using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata;

namespace Proyecto2
{
    public class fileHelper
    {
        static public void savInfo(string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("output.txt"))
                {
                    writer.Write(content);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to file: " + ex.Message);
            }
        }

    }
}
