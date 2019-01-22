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
            WeightedForm.ShowDialog();

            this.control.CalculateGrades(WeightedForm.getChineseWeight(), WeightedForm.getMathWeight(), WeightedForm.getEnglishWeight());
            this.control.Sort();
            //complete the table of all students with average and rank
            MakeWholeTable();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Score Sorter\nProgram Design: Frank Tang\nProgram Version:0.0.1", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }
    }
}
