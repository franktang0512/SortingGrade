using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    public abstract class FileIO
    {
        public string filepath;
        public string[] ContentTitle = { "學號", "姓名", "國文分數", "數學分數", "英文分數" };
        public List<Student> students = new List<Student>();

        //public abstract void ReadFile(string filepath);
        //public abstract void WriteFile(string filepath);

        public abstract List<Student> getFileToList();
        public abstract void SaveListToFile(List<Student> s);
        public void setFilePath(string fp)
        {
            filepath = fp;
        }
    }

    /***************************
     *                          *
     *Can create different type *
     *of files below to use many*
     *forms of data easily      *
     *                          *
     ****************************/

    public class TxtFileIO : FileIO
    {

        public TxtFileIO() { }
        async void ReadFile(string filepath)
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
                            try
                            {
                                this.students.Add(new Student(data[0], data[1], Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4])));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Console.WriteLine("Check if the string can be converted to double");
                                break;

                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Fail to read the file:");
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("File does not exist");
            }

        }

        async void WriteFile(string filepath)
        {

            try
            {
                // 建立檔案串流
                using (StreamWriter writer = File.CreateText(filepath))
                {
                    // 寫入標頭
                    writer.WriteLine(string.Join(",", ContentTitle));

                    foreach (Student student in students)
                    {
                        try
                        {   //寫入學生資料
                            await writer.WriteLineAsync(string.Join(",", student.tostring()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Fail to read the file:");
                            Console.WriteLine(e.Message);

                        }

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Fail to write the file:");
                Console.WriteLine(e.Message);
            }

        }
        public override List<Student> getFileToList()
        {
            ReadFile(this.filepath);
            System.Windows.Forms.MessageBox.Show("Open the file" + this.filepath);
            return this.students;
        }
        public override void SaveListToFile(List<Student> s)
        {
            students = s;
            WriteFile(this.filepath);
        }
    }

    public class CSVFileIO : FileIO
    {

        public CSVFileIO() { }
        public void ReadFile(string filepath) { }
        public void WriteFile(string filepath) { }
        public override List<Student> getFileToList() { return null; }
        public override void SaveListToFile(List<Student> s) { }

    }
    public class XMLFileIO : FileIO
    {
        public XMLFileIO() { }
        public void ReadFile(string filepath) { }
        public void WriteFile(string filepath) { }
        public override List<Student> getFileToList() { return null; }
        public override void SaveListToFile(List<Student> s) { }

    }

}
