using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreSorting
{
    /// <summary>
    /// Expand the formate of files
    /// </summary>
    public class FileIOBuilder
    {
        public FileIO CreateFileIO(string filetype) {
            FileIO fileio = null;
            if (filetype.Equals(".txt")) {
                fileio = new TxtFileIO();
                return fileio;
            }
            else if (filetype.Equals(".csv"))
            {
                fileio = new CSVFileIO();
                return fileio;
            }
            else if (filetype.Equals(".xml"))
            {
                fileio = new XMLFileIO();
                return fileio;
            }
            else {
                //副檔名無符合格式
                return null;           
            }

        }
    }
}
