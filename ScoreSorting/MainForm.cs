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
        public string path;//../../TestResult.txt
        private ScoreSortingControll control = new ScoreSortingControll("../../TestResult.txt");
        private DataGridViewRowCollection rows;

        public MainForm()
        {
            InitializeComponent();
            MakeTable();
        }

        private void ClearTableData()
        {
            for (int i = 0; i < this.control.getStudentsCount(); i++)
            {
                this.rows.RemoveAt(0);
            }
        }
        //load the original data
        private void MakeTable()
        {
            rows = dataGridView1.Rows;
            for (int i = 0; i < this.control.getStudentsCount(); i++)
            {
                rows.Add(new Object[] { 
                    this.control.getStudent(i).getID(), 
                    this.control.getStudent(i).getName(), 
                    this.control.getStudent(i).getChinese(), 
                    this.control.getStudent(i).getMathematics(), 
                    this.control.getStudent(i).getEnglish() 
                });
            }
        }
        //complete the table with average and rank
        public void MakeWholeTable()
        {
            //rows = dataGridView1.Rows;
            this.ClearTableData();
            int rank = 0;
            
            for (int i = 0; i < this.control.getStudentsCount(); i++)
            {
                if (i == 0)
                {
                    rank += 1;
                    rows.Add(new Object[] { 
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
                        rows.Add(new Object[] { 
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
                        rows.Add(new Object[] { 
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
            this.control.SaveTxt();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.ClearTableData();
            this.control.Cleardata();
            this.control.Reload();
            this.MakeTable();

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

            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Score Sorter\nProgram Design: Frank Tang\nProgram Version:0.0.1", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void Open_Click(object sender, EventArgs e)
        {

        }
    }
}
