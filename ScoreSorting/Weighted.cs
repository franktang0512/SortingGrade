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

        public string getChineseWeight()
        {
            return this.ch.Text.ToString();
        }
        public string getMathWeight()
        {
            return this.ma.Text.ToString();
        }
        public string getEnglishWeight()
        {
            return this.en.Text.ToString();
        }
        private void OK_Click(object sender, EventArgs e)
        {

            try
            {
                //check if users' input is numeric
                double dtest = Convert.ToDouble(ch.Text.ToString());
                dtest = Convert.ToDouble(ma.Text.ToString());
                dtest = Convert.ToDouble(en.Text.ToString());
            }
            catch
            {
                //Remind users to type in numeric
                MessageBox.Show("Tired? Please enter numeric things and try again thanks", "", MessageBoxButtons.OKCancel, MessageBoxIcon.None);
            }
            this.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
