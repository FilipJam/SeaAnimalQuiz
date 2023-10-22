using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SeaAnimalsQuiz
{
    public static class PathManager 
    {
        public static string GetMyDirectory() // maintains file management
        {
            string path = Directory.GetCurrentDirectory();
            // path backs from current directory untill it reaches SeaAnimalsQuiz directory
            while (!path.EndsWith("SeaAnimalsQuiz"))
                path = Directory.GetParent(path).FullName;
            return path;
        }

    }
}
