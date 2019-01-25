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
    /// <summary>
    /// The form is for user to set the wighte of each subject
    /// </summary>
    public partial class Weighted : Form
    {
        /// <summary>
        /// Construct Weighted 
        /// </summary>
        public Weighted()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Chinese Weight from ch textbox
        /// </summary>
        /// <returns>Chinese Weight</returns>
        public string getChineseWeight()
        {
            return this.ch.Text.ToString();
        }
        /// <summary>
        /// Math Weight from ma textbox
        /// </summary>
        /// <returns>Math Weight</returns>
        public string getMathWeight()
        {
            return this.ma.Text.ToString();
        }
        /// <summary>
        /// English Weight from en textbox
        /// </summary>
        /// <returns>English Weight</returns>
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
