﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Excel : ILog
    {

        public void Log(string filePath, IList<string> history)
        {
            throw new NotImplementedException(filePath);
        }
    }
}
