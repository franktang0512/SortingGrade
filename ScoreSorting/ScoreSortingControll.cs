using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    /// <summary>
    /// For the functions which will be used in the Grade Sorting system
    /// </summary>
    public class ScoreSortingControll
    {
        /// <summary>
        /// Where the file is
        /// </summary>
        string filepath;

        FileIOBuilder fileIObuilder;

        /// <summary>
        /// All students in list
        /// </summary>
        List<Student> students;

        /// <summary>
        /// Constructor for building students's data in the filepath
        /// </summary>
        /// <param name="filepath">Where the file going to be opened is</param>
        public ScoreSortingControll(string filepath)
        {
            //read data from../../TestResult.txt建構students
            this.filepath = filepath;
            students = new List<Student>();
            fileIObuilder = new FileIOBuilder();
            ReadFile(this.filepath);
            /*盡量使用簡單工廠建立檔案至資料結構中
              ReadTxt(filepath);             
             */


        }

        public void ReadFile(string filepath)
        {
            //todo: 阻止使用者輸入表格以外的檔案
            FileIO fio;
            try
            {
                fio = fileIObuilder.CreateFileIO(Path.GetExtension(filepath));
                fio.setFilePath(filepath);
                this.students = fio.getFileToList();
            }
            catch {
                System.Windows.Forms.MessageBox.Show("Choose a right file");
            
            }

        }

        public void Save() {
            FileIO fio;
            fio = fileIObuilder.CreateFileIO(Path.GetExtension(this.filepath));
            fio.setFilePath(filepath);  
            fio.SaveListToFile(this.students);
        }

        /// <summary>
        /// Get students in list
        /// </summary>
        /// <returns>students</returns>
        private List<Student> getStudents()
        {
            return students;
        }
        /// <summary>
        /// Set the students' data if there's any change on them
        /// </summary>
        /// <param name="s">Students which has changed to the list</param>
        private void setStudent(List<Student> s)
        {
            this.students = s;
        }
        /// <summary>
        /// Get total count of sutdents
        /// </summary>
        /// <returns></returns>
        public int getStudentsCount()
        {
            return getStudents().Count;
        }
        /// <summary>
        /// Calculate students' average with the weights
        /// </summary>
        /// <param name="ch">Chinese weights</param>
        /// <param name="ma">Math weights</param>
        /// <param name="en">English weights</param>
        public void CalculateGrades(string ch, string ma, string en)
        {
            //calculate grades
            try
            {
                foreach (Student student in this.getStudents())
                {
                    student.CalculateGrade(Convert.ToDouble(ch), Convert.ToDouble(ma), Convert.ToDouble(en));
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.WriteLine("Probably the weight can't be converted to double");
            }

        }
        /// <summary>
        /// Sort the data with students' average and their ID
        /// </summary>
        public void Sort()
        {
            /*Sort ordered by averages*/
            this.setStudent(this.getStudents().OrderByDescending(o => o.getAverage()).ThenBy(o => o.getID()).ToList());
        }
        /// <summary>
        /// Read the file in the filepath
        /// </summary>
        /// <param name="filepath">Filepath where the file's going to use</param>
        //public async void ReadTxt(string filepath)
        //{
        //    if (File.Exists(filepath))
        //    {
        //        try
        //        {
        //            using (StreamReader reader = File.OpenText(filepath))
        //            {
        //                string title = await reader.ReadLineAsync();
        //                ContentTitle = title.Split(',');

        //                while (!reader.EndOfStream)
        //                {
        //                    string filecontent = reader.ReadLine();
        //                    string[] data = filecontent.Split(',');
        //                    try
        //                    {
        //                        students.Add(new Student(data[0], data[1], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4])));
        //                    }
        //                    catch (Exception e)
        //                    {
        //                        Console.WriteLine(e.Message);
        //                        Console.WriteLine("Check if the string can be converted to double");
        //                        break;

        //                    }

        //                }
        //            }
        //        }
        //        catch (Exception e)
        //        {
        //            Console.WriteLine("Fail to read the file:");
        //            Console.WriteLine(e.Message);

        //        }

        //    }
        //    else
        //    {
        //        Console.WriteLine("File does not exist");

        //    }
        //}
        /// <summary>
        /// Save data of stuents if there's any change
        /// </summary>
        //public async void SaveTxt()
        //{
        //    try
        //    {
        //        // 建立檔案串流
        //        using (StreamWriter writer = File.CreateText(filepath))
        //        {
        //            // 寫入標頭
        //            writer.WriteLine(string.Join(",", ContentTitle));
        //            foreach (Student student in students)
        //            {
        //                try
        //                {   //寫入學生資料
        //                    await writer.WriteLineAsync(string.Join(",", student.tostring()));
        //                }
        //                catch (Exception e)
        //                {
        //                    Console.WriteLine("Fail to read the file:");
        //                    Console.WriteLine(e.Message);

        //                }

        //            }
        //        }
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine("Fail to write the file:");
        //        Console.WriteLine(e.Message);
        //    }

        //}
        /// <summary>
        /// Reload data from the file
        /// </summary>
        public void Reload()
        {
            this.Cleardata();
            ReadFile(this.filepath);
        }
        /// <summary>
        /// Clear data in students
        /// </summary>
        private void Cleardata()
        {
            this.students.Clear();
        }
        /// <summary>
        /// Get student's data
        /// </summary>
        /// <param name="i">Student index in students list</param>
        /// <returns>The copy of one of students instead of the real student itself</returns>
        public Student getStudent(int i)
        {
            //return this.students.ElementAt(i);
            Student s = new Student(this.students.ElementAt(i).getID(), this.students.ElementAt(i).getName(), this.students.ElementAt(i).getChinese(), this.students.ElementAt(i).getMathematics(), this.students.ElementAt(i).getEnglish());
            /*需要改掉*/
            s.setAverage(this.students.ElementAt(i).getAverage());
            return s;

        }
        /// <summary>
        /// Modify Student
        /// </summary>
        /// <param name="index">Student index in students</param>
        /// <param name="s"> Student object for modifing students' </param>
        public void ModifyStudent(int index, Student s)
        {
            this.students.ElementAt(index).setID(s.getID());
            this.students.ElementAt(index).setName(s.getName());
            this.students.ElementAt(index).setChinese(s.getChinese());
            this.students.ElementAt(index).setMath(s.getMathematics());
            this.students.ElementAt(index).setEnglish(s.getEnglish());


        }
    }
}
