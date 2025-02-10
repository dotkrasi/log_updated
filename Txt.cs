using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Txt : ILog
    {
        public void Log(string filePath, IList<string> history)
        {
            using (StreamWriter stream = new StreamWriter(filePath))
            {
                foreach (string line in history)
                {
                    stream.WriteLine(line);
                }
            }


        }
    }

}

