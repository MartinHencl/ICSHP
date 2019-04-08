using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DirectoryAnalysis
{
    class Program
    {
        internal void WriteFiles(DirectoryInfo[] directories, FileInfo[] files, string filePath, string info)
        {
            StringBuilder builder = new StringBuilder();

            if (!info.Equals(""))
            {
                foreach (var di in directories)
                {
                    builder.AppendFormat("/{0,-39}", di.Name);
                    builder.AppendFormat("{0,20} ", di.Attributes);
                    builder.AppendFormat("{0,15} ", di.CreationTime);
                    builder.AppendFormat("{0,10} ", "--");
                    builder.Append(" B");
                    builder.Append(Environment.NewLine);
                }
                foreach (FileInfo fi in files)
                {
                    builder.AppendFormat("{0,-40}", Path.GetFileName(fi.Name));
                    //builder.Append(";\t");
                    builder.AppendFormat("{0,20} ", fi.Extension);
                    //builder.Append(";\t");
                    builder.AppendFormat("{0,15} ", fi.CreationTime);
                    //builder.Append(";\t");
                    builder.AppendFormat("{0,10} ", fi.Length.ToString());
                    builder.Append(" B");
                    builder.Append(Environment.NewLine);
                }
            }
            builder.Append(SummaryOfDirectory(directories, files));

            if (filePath.Equals(""))
            {
                Console.WriteLine(builder);
            }
            else
            {
                File.WriteAllText(filePath, builder.ToString());
                Console.WriteLine("File {0} append", filePath);
            }
        }

        private string SummaryOfDirectory(DirectoryInfo[] dirs, FileInfo[] files)
        {
            StringBuilder summary = new StringBuilder();
            var extensionsWithNumbers = new Dictionary<string, int>();

            foreach (var di in dirs)
            {
                if (!extensionsWithNumbers.ContainsKey("dir"))
                {
                    extensionsWithNumbers["dir"] = new int();
                }
                extensionsWithNumbers["dir"]++;
            }
            foreach (var fi in files)
            {
                string extension = fi.Extension;
                if (!extensionsWithNumbers.ContainsKey(extension))
                {
                    extensionsWithNumbers[extension] = new int();
                }
                extensionsWithNumbers[extension]++;
            }

            foreach (var ext in extensionsWithNumbers)
            {
                summary.AppendFormat("{0,-10}:", ext.Key);
                summary.AppendFormat(" {0}", ext.Value);
                summary.Append(Environment.NewLine);
            }
            return summary.ToString();
        }

        internal void AnalyseDirictory(string filePath, string info)
        {
            string directoryPath = "./";
            AnalyseDirictory(directoryPath, filePath, info);
        }

        internal void AnalyseDirictory(string directoryPath, string filePath, string info)
        {
            if (directoryPath.Equals(""))
            {
                directoryPath = "./";
            }
            DirectoryInfo dirInfo = new DirectoryInfo(directoryPath);
            if (dirInfo.Exists)
            {
                DirectoryInfo[] directories = dirInfo.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
                FileInfo[] files = dirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                WriteFiles(directories, files, filePath, info);
            }
            else
            {
                throw new FileNotFoundException("Directory to analyse was not found!");
            }
        }

        static void Main(string[] args)
        {
            string directoryPath = @"D:\OneDrive\SKOLA\6. semestr\IBIS";  //   args[0]
            string filePath = "";   // "./textSlozky.txt";   //    args[1];
            string infoAboutDirectory = "jo"; //  args[2];

            Program newMain = new Program();
            try
            {
                newMain.AnalyseDirictory(directoryPath, filePath, infoAboutDirectory);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (UnauthorizedAccessException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Press Enter to exit:");
            Console.ReadLine();
        }
    }
}
