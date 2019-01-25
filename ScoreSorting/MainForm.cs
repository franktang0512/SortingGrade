using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreSorting
{
    public partial class MainForm : Form
    {
        private ScoreSortingControll control;
        /// <summary>
        /// Initialize component and constructor MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load data in the table
        /// </summary>
        private void MakeTable()
        {
            for (int i = 0; i < this.control.getStudentsCount(); i++)
            {
                this.dataGridView1.Rows.Add(new Object[] { 
                    this.control.getStudent(i).getID(), 
                    this.control.getStudent(i).getName(), 
                    this.control.getStudent(i).getChinese(), 
                    this.control.getStudent(i).getMathematics(), 
                    this.control.getStudent(i).getEnglish() 
                });
            }
        }
        /// <summary>
        /// Complete the table with average and rank
        /// </summary>
        public void MakeWholeTable()
        {
            this.dataGridView1.Rows.Clear();
            int rank = 0;
            
            for (int i = 0; i < this.control.getStudentsCount(); i++)
            {
                if (i == 0)
                {
                    rank += 1;
                    this.dataGridView1.Rows.Add(new Object[] { 
                        this.control.getStudent(i).getID(), 
                        this.control.getStudent(i).getName(), 
                        this.control.getStudent(i).getChinese(), 
                        this.control.getStudent(i).getMathematics(), 
                        this.control.getStudent(i).getEnglish(),
                        this.control.getStudent(i).getAverage(),
                        rank
                    });

                }
                else
                {
                    if (this.control.getStudent(i).getAverage() == this.control.getStudent(i - 1).getAverage())
                    {
                        this.dataGridView1.Rows.Add(new Object[] { 
                            this.control.getStudent(i).getID(), 
                            this.control.getStudent(i).getName(), 
                            this.control.getStudent(i).getChinese(), 
                            this.control.getStudent(i).getMathematics(), 
                            this.control.getStudent(i).getEnglish(),
                            this.control.getStudent(i).getAverage(),
                            rank
                        });

                    }
                    else {
                        this.dataGridView1.Rows.Add(new Object[] { 
                            this.control.getStudent(i).getID(), 
                            this.control.getStudent(i).getName(), 
                            this.control.getStudent(i).getChinese(), 
                            this.control.getStudent(i).getMathematics(), 
                            this.control.getStudent(i).getEnglish(),
                            this.control.getStudent(i).getAverage(),
                            ++rank
                        });
                    
                    }


                }

            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                this.control.SaveTxt();
            }
            catch {
                MessageBox.Show("Sorry ! Can not save any file");
            
            }

        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Rows.Clear();
                this.control.Reload();
                MessageBox.Show("Reload the file");
                this.MakeTable();
            }
            catch {
                MessageBox.Show("No file has been loaded.Open a file first");
            
            }


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sortToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Show WeightedForm and get weights
                Weighted WeightedForm = new Weighted();
                WeightedForm.ShowDialog();

                this.control.CalculateGrades(WeightedForm.getChineseWeight(), WeightedForm.getMathWeight(), WeightedForm.getEnglishWeight());
                this.control.Sort();
                //complete the table of all students with average and rank
                MakeWholeTable();
            }
            catch
            {
                MessageBox.Show("Can't sort any data. Recommend opening a file first");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Score Sorter\nProgram Design: Frank Tang\nProgram Version:0.0.1", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1= new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.control = new ScoreSortingControll(@"" + openFileDialog1.FileName);
                MessageBox.Show("Open the file:"+openFileDialog1.FileName);
                MakeTable();
            }  
        }
    }
}
