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
        public ScoreSortingControll control = new ScoreSortingControll("../../TestResult.txt");
        public DataGridViewRowCollection rows;

        private double[] weightedvalues = new double[3];//[ch,ma,en]

        public string[] WeiVal
        {
            set
            {
                for (int i = 0; i < value.Length; i++)
                {
                    weightedvalues[i] = Convert.ToDouble(value[i]);

                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
            MakeTable();
        }

        //load the original data
        public void MakeTable()
        {
            rows = dataGridView1.Rows;
            foreach (Student s in control.getStudents())
            {
                rows.Add(new Object[] { s.ID, s.name, s.Chinese, s.Mathematics, s.English });
            }

        }
        //complete the table with average and rank
        public void MakeWholeTable()
        {
            rows = dataGridView1.Rows;
            int i = 0;

            //clear previous data in table
            foreach (Student s in this.control.getStudents())
            {
                this.rows.RemoveAt(0);
            }

            //Show all students in table
            foreach (Student s in this.control.getStudents())
            {
                rows.Add(new Object[] { s.ID, s.name, s.Chinese, s.Mathematics, s.English, s.avg, ++i });
            }

        }

        //private void openToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog dialog = new OpenFileDialog();
        //    dialog.Title = "Select file";
        //    dialog.InitialDirectory = ".\\";
        //    dialog.Filter = "";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        //this.path = dialog.FileName;
        //        //MessageBox.Show(dialog.FileName);
        //    }
        //}

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.control.SaveTxt();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Student student in control.getStudents())
            {
                rows.RemoveAt(0);
            }
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
            //Show WeightedForm and get weights
            Weighted WeightedForm = new Weighted();
            WeightedForm.Owner = this;
            WeightedForm.ShowDialog();

            if (weightedvalues[0] != 0 && weightedvalues[1] != 0 && weightedvalues[2] != 0)
            {
                //Clear previous data in table 
                foreach (Student student in this.control.getStudents())
                {
                    student.CalculateGrade(weightedvalues[0], weightedvalues[1], weightedvalues[2]);
                }

                /*Sort ordered by averages*/
                this.control.setStudent(this.control.getStudents().OrderByDescending(o => o.avg).ThenByDescending(o => o.ID).ToList());//.ThenBy(o => o.ID);

                //complete the table of all students with average and rank
                MakeWholeTable();
            
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Score Sorter\nProgram Design: Frank Tang\nProgram Version:0.0.1", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }
    }
}
