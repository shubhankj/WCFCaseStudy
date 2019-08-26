using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCodeAnalyzer
{
    public class StaticCodeAnalyzer
    {
        internal static int Tool(string command)
        {
            try
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine(command);
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                //Process P = Process.Start("CMD.exe", cmd);
                // return 0;
                return cmd.ExitCode;
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("The tool cannot be run");
                return 1;
            }
        }

        internal static int MergeReports(string file1, string file2, string outfile)
        {

            int NoOfErrors = 0;
            try
            {
                System.IO.File.WriteAllText(outfile, string.Empty);
                NoOfErrors += Utility.WriteFileToCSV(file1, outfile);

                NoOfErrors += Utility.WriteFileToCSV(file2, outfile);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Cannot merge reports");
                return 1;
            }
            return NoOfErrors;
        }
    }
}
