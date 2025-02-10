using System;
using System.Collections.Generic;
using System.IO;

// Интерфейс за логване
public interface ILog
{
    void Log(string filePath, IList<string> history);
}
