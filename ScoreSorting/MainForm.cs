using System;
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

        public ScoreSortingControll control = new ScoreSortingControll("../../TestResult.txt");
        public DataGridViewRowCollection rows;

        public MainForm()
        {
            InitializeComponent();
            MakeTable();
        }
        public void MakeTable()
        {
            rows = dataGridView1.Rows;
            foreach (Student s in control.students)
            {
                rows.Add(new Object[] { s.ID, s.name, s.Chinese, s.Mathematics, s.English });
            }

        }
        public void MakeWholeTable(double ch, double ma, double en)
        {
            rows = dataGridView1.Rows;
            int i = 0;
            foreach (Student s in control.students)
            {
                //計算平均
                s.CalculateGrade(ch, ma, en);

                //rows.Add(new Object[] { s.ID, s.name, s.Chinese, s.Mathematics, s.English,s.avg,++i});
            }

            /*用平均來排序*/
            control.students.Sort((delegate(Student x, Student y)
            {
                if (x.avg == null && y.avg == null) return 0;
                else if (x.avg == null) return -1;
                else if (y.avg == null) return 1;
                else return x.avg.CompareTo(y.avg);

            })); control.students.Reverse();

            //顯示在表格中
            foreach (Student s in control.students)
            {
                rows.Add(new Object[] { s.ID, s.name, s.Chinese, s.Mathematics, s.English, s.avg, ++i });
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void File_ButtonClick(object sender, EventArgs e)
        {

        }

        private void Help_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program Name: Score Sorter\nProgram Design: Frank Tang\nProgram Version:0.0.1", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.control.SaveTxt();
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {

            foreach (Student student in control.students)
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

            Weighted WeightedForm = new Weighted();
            WeightedForm.Owner = this;
            WeightedForm.Show();

        }


    }
}
