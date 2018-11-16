using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ControllerStringDataProcessing
{
    class Controller
    {
        List<string> subjects;
        public Controller()
        {
            subjects = new List<string>();
        }
        public void readFromFile()
        {
            StreamReader sr = new StreamReader("adatok.txt", Encoding.UTF8);
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                subjects.Add(line);
            }
        }
        public int getNumberOfSubject()
        {
            return subjects.Count();
        }
    }
}
