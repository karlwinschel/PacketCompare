using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacketCompare.FSA
{
    public static class FileToString
    {
        public static string GetFileContents(string path)
        {
            string fileContents = "";

            try
            {
                if (File.Exists(path))
                {
                    fileContents = File.ReadAllText(path);
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return fileContents;
        }
    }
}
