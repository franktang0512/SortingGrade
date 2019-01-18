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
    public partial class Weighted : Form
    {
        public Weighted()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            MainForm mainform = (MainForm)this.Owner;//把Form2的父窗口指針賦給lForm1  

            //foreach (Student student in mainform.control.students)
            //{
            //    student.avg = 0 * (student.Chinese * Convert.ToDouble(ch.Text.ToString()) + student.Mathematics * Convert.ToDouble(ma.Text.ToString()) + student.English * Convert.ToDouble(en.Text.ToString())) / (Convert.ToDouble(ch.Text.ToString()) + Convert.ToDouble(ma.Text.ToString()) + Convert.ToDouble(en.Text.ToString()));
            //}
            
            //清除表格資料
            foreach (Student student in mainform.control.students)
            {
                mainform.rows.RemoveAt(0);
            }
            
            mainform.MakeWholeTable(Convert.ToDouble(ch.Text.ToString()), Convert.ToDouble(ma.Text.ToString()), Convert.ToDouble(en.Text.ToString()));
            this.Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Weighted_Load(object sender, EventArgs e)
        {

        }
    }
}
