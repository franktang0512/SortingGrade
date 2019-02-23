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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="chWeight"></param>
        /// <param name="mathWeight"></param>
        /// <param name="enWeight"></param>
        /// <returns></returns>
        public bool SetWeight(out double chWeight,out double mathWeight, out double enWeight)
        {
            Console.WriteLine(ch.Text);
            chWeight = Convert.ToDouble(ch.Text);
            mathWeight = Convert.ToDouble(ma.Text.ToString());
            enWeight = Convert.ToDouble(en.Text.ToString());

            return true;
            //try
            //{
            //    //check if users' input is numeric
            //    chWeight = Convert.ToDouble(ch.Text.ToString());
            //    mathWeight = Convert.ToDouble(ma.Text.ToString());
            //    enWeight = Convert.ToDouble(en.Text.ToString());

            //    return true;
            //}
            //catch
            //{
            //    //Remind users to type in numeric
            //    MessageBox.Show("Tired? Please enter numeric things and try again thanks");
            //    chWeight =1;
            //    mathWeight = 1;
            //    enWeight = 1;
            //    return false;
            //}




            
        }

        public void aa(){
            //this.ch.Width = Convert.ToInt32(x * ch.Width);
            //this.ch.Height = Convert.ToInt32(y * ch.Height);

            //this.Chinese.Width = Convert.ToInt32(x * Chinese.Width);
            //this.Chinese.Height = Convert.ToInt32(y * Chinese.Height);


            //this.ma.Height = Convert.ToInt32(y * ma.Height);
            //this.ma.Width = Convert.ToInt32(x * ma.Width);

            //this.Math.Height = Convert.ToInt32(y * Math.Height);
            //this.Math.Width = Convert.ToInt32(x * Math.Width);

            //this.en.Height = Convert.ToInt32(y * en.Height);
            //this.en.Width = Convert.ToInt32(x * en.Width);

            //this.English.Width = Convert.ToInt32(x * English.Width);
            //this.English.Height = Convert.ToInt32(y * English.Height);
        }

        private void sort_Click(object sender, EventArgs e)
        {            
            try
            {
                //check if users' input is numeric
                Convert.ToDouble(ch.Text.ToString());
                Convert.ToDouble(ma.Text.ToString());
                Convert.ToDouble(en.Text.ToString());
                this.Close();
            }
            catch(Exception eee)
            {
                //Remind users to type in numeric
                MessageBox.Show("Tired? Please enter numeric things and try again thanks");
            }

        }

    }
}
