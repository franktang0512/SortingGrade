using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    /// <summary>
    /// For Student's data
    /// </summary>
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
        /// <summary>
        /// Get student's ID
        /// </summary>
        /// <returns>Student's ID</returns>
        public string getID() { return this.ID; }
        /// <summary>
        /// Get student's name
        /// </summary>
        /// <returns>Student's name</returns>
        public string getName() { return this.name; }
        /// <summary>
        /// Get student's Chinese grade
        /// </summary>
        /// <returns>Student's Chinese grade</returns>
        public double getChinese() { return this.Chinese; }
        /// <summary>
        /// Get student's math grade
        /// </summary>
        /// <returns>Student's math grade</returns>
        public double getMathematics() { return this.Mathematics; }
        /// <summary>
        /// Get student's English grade
        /// </summary>
        /// <returns>Student's English grade</returns>
        public double getEnglish() { return this.English; }
        /// <summary>
        /// Get student's ID
        /// </summary>
        /// <returns>Student's ID</returns>
        public double getAverage() { return this.avg; }


        /// <summary>
        /// Set student's ID if there's any change
        /// </summary>
        /// <param name="id">Changed ID</param> 
        public void setID(string id) { this.ID = id; }
        /// <summary>
        /// Set student's name if there's any change
        /// </summary>
        /// <param name="name">Changed name</param>
        public void setName(string name) { this.name = name; }
        /// <summary>
        /// Set student's Chinese grade if there's any change
        /// </summary>
        /// <param name="ch">Changed Chinese grade</param>
        public void setChinese(double ch) { this.Chinese = ch; }
        /// <summary>
        /// Set student's math grade if there's any change
        /// </summary>
        /// <param name="ma">Changed math grade</param>
        public void setMath(double ma) { this.Mathematics = ma; }
        /// <summary>
        /// Set student's English grade if there's any change
        /// </summary>
        /// <param name="en">Changed English grade</param>
        public void setEnglish(double en) { this.English = en; }
        /// <summary>
        /// Set student's average if there's any change
        /// </summary>
        /// <param name="average">Changed average</param>
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
