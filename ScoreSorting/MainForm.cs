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
        Weighted WeightedForm;
        /// <summary>
        /// Initialize component and constructor MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            dataGridView1.Columns["平均"].ReadOnly = true;
            dataGridView1.Columns["名次"].ReadOnly = true;

            dataGridView1.Columns["國文"].ReadOnly = false;
            dataGridView1.Columns["數學"].ReadOnly = false;
            dataGridView1.Columns["英文"].ReadOnly = false;
            dataGridView1.Columns["姓名"].ReadOnly = false;
            dataGridView1.Columns["學號"].ReadOnly = false;
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
            int rank = 0, SameRankCount = 1;

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
                        SameRankCount += 1;
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
                        rank += SameRankCount;
                        SameRankCount = 1;
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
                }
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < this.control.getStudentsCount(); i++)
            {
                if (this.control.getStudent(i).getID().Equals(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()))
                {
                    Student s = this.control.getStudent(i);

                    try
                    {
                        if (e.ColumnIndex == 2 || e.ColumnIndex == 3 || e.ColumnIndex == 4)
                        {
                            try { double checkentry = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()); }
                            catch
                            {
                                MessageBox.Show("數值格式錯誤");
                                switch (e.ColumnIndex)
                                {
                                    case 2:
                                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s.getChinese();
                                        break;
                                    case 3:
                                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s.getMathematics();
                                        break;
                                    case 4:
                                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = s.getEnglish();
                                        break;
                                    default: break;
                                }
                            }
                        }
                        switch (e.ColumnIndex)
                        {
                            case 0:
                                s.setID(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                                break;
                            case 1:
                                s.setName(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());

                                break;
                            case 2:
                                s.setChinese(Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));

                                break;
                            case 3:
                                s.setMath(Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));

                                break;
                            case 4:
                                s.setEnglish(Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString()));

                                break;
                            default:
                                break;

                        }
                        this.control.ModifyStudent(i, s);
                        this.dataGridView1.Rows.Clear();
                        this.MakeTable();
                    }
                    catch { Console.WriteLine("Invalid operation expection"); }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.control = new ScoreSortingControll(@"" + openFileDialog1.FileName);
                MessageBox.Show("Open the file:" + openFileDialog1.FileName);
                MakeTable();
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.control.SaveTxt();
            }
            catch
            {
                MessageBox.Show("Sorry ! Can not save any file");

            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sortingWeightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Show WeightedForm and get weights
                WeightedForm = new Weighted();
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

        private void reloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataGridView1.Rows.Clear();
                this.control.Reload();
                MessageBox.Show("Reload the file");
                this.MakeTable();
            }
            catch
            {
                MessageBox.Show("No file has been loaded.Open a file first");
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Score Sorter\nProgram Design: Frank Tang\nProgram Version:0.0.1", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }
    }
}

