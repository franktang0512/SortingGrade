using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    public class Student
    {
        string ID, name;
        double Chinese, Mathematics, English, avg;
        /// <summary>
        /// Constuctor student's data 
        /// </summary>
        /// <param name="ID">Student's ID number</param>
        /// <param name="name">Student's name</param>
        /// <param name="Chinese">Student's Chinese grade</param>
        /// <param name="Mathematics">Student's Mathematics grade</param>
        /// <param name="English">Student's English grade</param>
        public Student(string ID, string name, double Chinese, double Mathematics, double English)
        {
            this.ID = ID;
            this.name = name;
            this.Chinese = Chinese;
            this.Mathematics = Mathematics;
            this.English = English;
        }
        public string getID() { return this.ID; }
        public string getName() { return this.name; }
        public double getChinese() { return this.Chinese; }
        public double getMathematics() { return this.Mathematics; }
        public double getEnglish() { return this.English; }
        public double getAverage() { return this.avg; }

        public void setID(string id) { this.ID = id; }
        public void setName(string name) { this.name = name; }
        public void setChinese(double ch) { this.Chinese = ch; }
        public void setMath(double ma) { this.Mathematics = ma; }
        public void setEnglish(double en) { this.English = en; }
        public void setAverage(double average) { this.avg = average; }

        /// <summary>
        /// Calculate Student's average if it doesn't have the value
        /// </summary>
        /// <param name="ch">Chinese Weight</param>
        /// <param name="ma">Mathematics Weight</param>
        /// <param name="en">English Weight</param>
        public void CalculateGrade(double ch, double ma, double en)
        {
            
            this.avg = Math.Round((this.Chinese * ch + this.Mathematics * ma + this.English * en) / ((ch + ma + en) == 0 ? 3 : (ch + ma + en)), 2, MidpointRounding.AwayFromZero);
            //Math.Round(value, round to 2, MidpointRounding.AwayFromZero)
        }
        /// <summary>
        /// Make student's data in to string 
        /// </summary>
        /// <returns>Studeunt's data string</returns>
        public string tostring()
        {
            return ID + ',' + name + ',' + Chinese + ',' + Mathematics + ',' + English;
        }
    }
}
