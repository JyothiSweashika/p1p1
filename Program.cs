using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace phase1project1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\91849\OneDrive\Desktop\student_text.txt";
           try
            {

                Console.WriteLine("Student Data:");
                Console.WriteLine("-------------");
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine(fileContent);
            }

            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.ReadKey();


            }

        }
    }
}

    

