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
        double Chinese, Mathematics, English,avg;

        public Student(string ID, string name, double Chinese, double Mathematics, double English)
        {
            this.ID = ID;
            this.name = name;
            this.Chinese = Chinese;
            this.Mathematics = Mathematics;
            this.English = English;
        }
        public void CalculateGrade(double ch, double ma, double en)
        {
            this.avg = Math.Round((this.Chinese * ch + this.Mathematics * ma + this.English * en) / ((ch + ma + en) == 0 ? 3 : (ch + ma + en)), 2,MidpointRounding.AwayFromZero);
            //Math.Round(value, round to 2, MidpointRounding.AwayFromZero)
        }
        public string getID() { return this.ID; }
        public string getName() { return this.name; }
        public double getChinese() { return this.Chinese; }
        public double getMathematics() { return this.Mathematics; }
        public double getEnglish() { return this.English; }
        public double getAverage() { return this.avg; }

        public string tostring()
        {
            return ID + ',' + name + ',' + Chinese + ',' + Mathematics + ',' + English;
        }
    }
}
