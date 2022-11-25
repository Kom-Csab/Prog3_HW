using System;

namespace SGBTK0.Model
{
    class Parser
    {
        public static Work Parse(string[] columns)
        {
            return new Work(columns[0], Convert.ToInt32(columns[1]), Convert.ToInt32(columns[2]));
        }
    }
}
