using StaticCodeAnalyzer;
using System;
using System.Collections.Generic;
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
        public string AnalyseCode(string threshold)
        {
            
            MainClass.SpotBugsTool();

            MainClass.PMDTool();

            if (MainClass.MergeReports() > Convert.ToInt32(threshold))
                return "no";

            return "yes";

            
        }
    }
}
