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
        List<Student> students;
        
        //建構學生資料名單
        public ScoreSortingControll(string filepath)
        {
            //read data from../../TestResult.txt建構students
            this.filepath = filepath;
            students = new List<Student>();
            ContentTitle = null;
            ReadTxt(filepath);
        }
        private List<Student> getStudents() {
            return students;        
        }
        private void setStudent(List<Student> s) {
            this.students = s;        
        }
        public int getStudentsCount() {

            return getStudents().Count;
        }

        public void CalculateGrades(string ch,string ma,string en) {
            //calculate grades
            foreach (Student student in this.getStudents())
            {
                student.CalculateGrade(Convert.ToDouble(ch), Convert.ToDouble(ma), Convert.ToDouble(en));
            }
        }

        public void Sort() {
            /*Sort ordered by averages*/
            this.setStudent(this.getStudents().OrderByDescending(o => o.getAverage()).ThenBy(o => o.getID()).ToList());
        }

        void OpenFile() {
            //
            
            if (!File.Exists(filepath)) { 
            
            }
        }


        async void ReadTxt(string filepath)
        {
            if (File.Exists(filepath))
            {
                try
                {
                    using (StreamReader reader = File.OpenText(filepath))
                    {
                        string title = await reader.ReadLineAsync();
                        ContentTitle = title.Split(',');

                        while (!reader.EndOfStream)
                        {
                            string filecontent = reader.ReadLine();
                            string[] data = filecontent.Split(',');
                            students.Add(new Student(data[0], data[1], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4])));
                        }
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Fail to read the file:");
                    Console.WriteLine(e.Message);
                
                }
                
            }
            else {
                Console.WriteLine("File does not exist");
            
            }
        }
        //存檔
        public async void SaveTxt()
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

        public void Reload() {
            ReadTxt(this.filepath);        
        }

        public void Cleardata()
        {
            this.students.Clear();
        }

        public Student getStudent(int i){
            //return this.students.ElementAt(i);
            Student s = new Student(this.students.ElementAt(i).getID(), this.students.ElementAt(i).getName(), this.students.ElementAt(i).getChinese(), this.students.ElementAt(i).getMathematics(), this.students.ElementAt(i).getEnglish());
            s.CalculateGrade(0,0,0);
            return s;
        
        }
    }
}
