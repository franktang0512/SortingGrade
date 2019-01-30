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
        int savefile = 0;

        String ch_weight = "", ma_weight = "", en_weight = "";

        double oldWidth, oldHeight;
        /// <summary>
        /// Initialize component and constructor MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            oldWidth = this.Width;
            oldHeight = this.Height; 
            dataGridView1.Columns["平均"].ReadOnly = true;
            dataGridView1.Columns["名次"].ReadOnly = true;

            dataGridView1.Columns["國文"].ReadOnly = false;
            dataGridView1.Columns["數學"].ReadOnly = false;
            dataGridView1.Columns["英文"].ReadOnly = false;
            dataGridView1.Columns["姓名"].ReadOnly = false;
            dataGridView1.Columns["學號"].ReadOnly = false;
            this.panel3.Dock = DockStyle.Right;
            this.panel2.Dock = DockStyle.Fill;
            this.panel1.Dock = DockStyle.Left;
            //this.WeightGroupBox.Dock = DockStyle.Right;
            //this.dataGridView1.Dock = DockStyle.Fill;
                        
            //this.dataGridView1.Dock = DockStyle.None;
            this.menuStrip1.Dock = DockStyle.Top;
        }

        /// <summary>
        /// Load data in the table
        /// </summary>
        private void MakeTable()
        {
            this.dataGridView1.Rows.Clear();
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
            this.control.CalculateGrades(this.ch_weight, this.ma_weight, this.en_weight);

            this.control.Sort();

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

       

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.savefile == 1)
            {
                if (this.IsSavingFile())
                {
                    
                    this.SaveFile();
                }
            }
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.control = new ScoreSortingControll(@"" + openFileDialog1.FileName);
                MakeTable();
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            double x = (this.Width / oldWidth);
            double y = (this.Height / oldHeight);

            this.panel3.Height = Convert.ToInt32(y * panel3.Height);
            this.panel3.Width = Convert.ToInt32(x * panel3.Width);
            this.panel2.Height = Convert.ToInt32(y * panel2.Height);
            this.panel2.Width = Convert.ToInt32(x * panel2.Width);
            this.panel1.Height = Convert.ToInt32(y * menuStrip1.Height);
            this.panel1.Width = Convert.ToInt32(x * menuStrip1.Width);

            this.dataGridView1.Width = Convert.ToInt32(x * dataGridView1.Width);
            this.dataGridView1.Height = Convert.ToInt32(y * dataGridView1.Height);

            this.WeightGroupBox.Width = Convert.ToInt32(x * WeightGroupBox.Width);
            this.WeightGroupBox.Height = Convert.ToInt32(y * WeightGroupBox.Height);


            this.ch.Width = Convert.ToInt32(x * ch.Width);
            this.ch.Height = Convert.ToInt32(y * ch.Height);

            this.Chinese.Width = Convert.ToInt32(x * Chinese.Width);
            this.Chinese.Height = Convert.ToInt32(y * Chinese.Height);
            
            
            this.ma.Height = Convert.ToInt32(y * ma.Height);
            this.ma.Width = Convert.ToInt32(x * ma.Width);
            
            this.Math.Height = Convert.ToInt32(y * Math.Height);
            this.Math.Width = Convert.ToInt32(x * Math.Width);
            
            this.en.Height = Convert.ToInt32(y * en.Height);
            this.en.Width = Convert.ToInt32(x * en.Width);

            this.English.Width = Convert.ToInt32(x * English.Width);
            this.English.Height = Convert.ToInt32(y * English.Height);

            oldWidth = this.Width;
            oldHeight = this.Height;
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.savefile == 1)
            {
                if (this.IsSavingFile())
                {
                    
                    this.SaveFile();
                }
            }
            this.Dispose();
        }

        /*can delete the function*/
        private void sortingWeightsToolStripMenuItem_Click(object sender, EventArgs e) { }

        private void reloadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.savefile == 1)
            {
                if(this.IsSavingFile()){
                    this.SaveFile();
                }
            }
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

        private void Sort_Click(object sender, EventArgs e)
        {
            if (this.savefile == 1)
            {
                if (this.IsSavingFile())
                {
                    this.SaveFile();
                }
            }
            if (this.control != null)
            {
                try
                {
                    //check if users' input is numeric
                    double dtest = Convert.ToDouble(ch.Text.ToString());
                    dtest = Convert.ToDouble(ma.Text.ToString());
                    dtest = Convert.ToDouble(en.Text.ToString());

                    this.ch_weight = ch.Text.ToString();
                    this.ma_weight = ma.Text.ToString();
                    this.en_weight = en.Text.ToString();

                    //complete the table of all students with average and rank
                    MakeWholeTable();

                    //TODO: sort here
                }
                catch
                {
                    //Remind users to type in numeric
                    MessageBox.Show("Tired? Please enter numeric things and try again thanks", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
                }
            }
            else {
                MessageBox.Show("Open a file first thanks.");
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

                        
                        if ((this.ch_weight != "") && (this.ma_weight != "") && (this.en_weight != ""))
                        {
                            this.MakeWholeTable();
                        }

                        this.savefile = 1;
                    }
                    catch { Console.WriteLine("Invalid operation expection"); }
                }
            }
        }

        private void SaveFile() {
            try
            {
                this.control.Save();
                this.savefile = 0;
            }
            catch
            {
                MessageBox.Show("Sorry ! Can not save any file");
            }
        }

        private bool IsSavingFile() {

            Console.WriteLine("{0}",savefile);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Title = "Save the Current File?";
            saveFileDialog1.ShowDialog();

            
            return false; }
    }
}