using StaticCodeAnalyzer;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AnalyserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select AnalyserService.svc or AnalyserService.svc.cs at the Solution Explorer and start debugging.
    public class AnalyserService : IAnalyserService
    {
        int NoOfErrors;
        public string AnalyseCode(string threshold)
        {
            
            MainClass.SpotBugsTool();

            MainClass.PMDTool();

            NoOfErrors = MainClass.MergeReports();

            string filename = @"C:\Users\320052125\WCFCaseStudy\Errors.txt";
            var file = File.Open(filename, FileMode.OpenOrCreate);
            using (StreamWriter sw = new StreamWriter(file))
            {
                // int lastLine = Convert.ToInt32(File.ReadLines(filename).Last());

                file.Seek(file.Length, SeekOrigin.Begin);
                sw.WriteLine(NoOfErrors);

                if (NoOfErrors > Convert.ToInt32(threshold))
                    return "no";

                return "yes";
            }
        }

        public string AnalyseCodeAuto()
        {

            MainClass.SpotBugsTool();

            MainClass.PMDTool();

            NoOfErrors = MainClass.MergeReports();

            string filename = @"C:\Users\320052125\WCFCaseStudy\Errors.txt";
            int lastLine = Convert.ToInt32(File.ReadLines(filename).Last());

            var file = File.Open(filename, FileMode.OpenOrCreate);
            using (StreamWriter sw = new StreamWriter(file))
            {

                file.Seek(file.Length, SeekOrigin.Begin);
                sw.WriteLine(NoOfErrors);
                if (NoOfErrors <= lastLine)
                    return "Yes";
                return "No";
            }
        }
    }
}

