using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    public class ScoreSortingControll
    {
        //檔案路徑
        string filepath;
        //標頭
        string[] ContentTitle;
        //所有學生名單
        public List<Student> students;
        
        //建構學生資料名單
        public ScoreSortingControll(string filepath)
        {
            //read data from../../TestResult.txt建構students
            this.filepath = filepath;
            students = new List<Student>();
            ContentTitle = null;
            ReadTxt(filepath);
        }

        void ReadTxt(string filepath)
        {
            //只讀出 TestResult.txt全部的字

            StreamReader str = new StreamReader(filepath);

            ContentTitle = str.ReadLine().Split(',');
            //資料need to handle
            while (!str.EndOfStream)
            {
                string filecontent = str.ReadLine();
                string[] data = filecontent.Split(',');
                students.Add(new Student(data[0], data[1], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4])));

            }
            str.Close();
        }
        //存檔
        public void SaveTxt()
        {
            // 建立檔案串流
            StreamWriter sw = new StreamWriter(filepath);
            // 寫入標頭
            sw.WriteLine(string.Join(",", ContentTitle));			
            foreach(Student student in students){
                //寫入學生資料
                sw.WriteLine(string.Join(",",student.tostring()));            
            }
            // 關閉串流
            sw.Close();						
        }
        //argument 為加權國數英
        void Sorting(double ch,double ma,double en)
        {
            List<Student> weightedstudents= new List<Student>();
            foreach (Student student in this.students) {
                

            }
            this.students.ElementAt(1);
        }
        //讀取原檔案
        public void Reload() {
            ReadTxt(this.filepath);        
        }

        public void Cleardata(){
            this.students.Clear();
        }
    }
}
