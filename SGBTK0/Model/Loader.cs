using System;
using System.Collections.Generic;
using System.IO;

namespace SGBTK0.Model
{
    class Loader<T>
    {
        public List<T> LoadFromFile(string FileName, Func<string[], T> parser)
        {
            List<T> list = new List<T>();

            StreamReader reader = new StreamReader(FileName);

            while (!reader.EndOfStream)
            {
                list.Add(parser(reader.ReadLine().Split(';')));
            }

            reader.Close();
            return list;
        }
    }
}
