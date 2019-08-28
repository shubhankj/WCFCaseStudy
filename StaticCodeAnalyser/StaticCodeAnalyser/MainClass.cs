using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticCodeAnalyzer
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //SpotBugsTool();

            PMDTool();

            //int status = MergeReports();


            
        }

        public static int PMDTool()
        {
            int status=StaticCodeAnalyzer.Tool(@"(C:\Users\320052123\WCFCaseStudy\pmd-bin-6.16.0\bin\pmd.bat -d C:\Users\320052123\WCFCaseStudy\feereport -f text -R C:\Users\320052123\WCFCaseStudy\pmd-bin-6.16.0\bin\rulesets\java\quickstart.xml -r C:\Users\320052123\WCFCaseStudy\PMDReport.txt)");
            int NoOfErrors = StaticCodeAnalyzer.GetNoOfErrors(@"C:\Users\320052123\WCFCaseStudy\PMDReport.txt");
            return NoOfErrors;
        }

        /*public static void SpotBugsTool()
        {
            StaticCodeAnalyzer.Tool(@"(C:\Users\320052123\WCFCaseStudy\spotbugs-3.1.12\bin\spotbugs.bat -textui -maxHeap 1500 -nested:false -output C:\Users\320052123\WCFCaseStudy\SpotBugsReport.emacs -effort:max -low -sortByClass -emacs sourcepath C:\Users\320052123\WCFCaseStudy\feereport)");
        }*/

        /*public static int MergeReports()
        {
            return StaticCodeAnalyzer.MergeReports(@"C:\Users\320052123\WCFCaseStudy\SpotBugsReport.emacs", @"C:\Users\320052123\WCFCaseStudy\PMDReport.txt", @"C:\Users\320052123\WCFCaseStudy\FinalReport.csv");
        }*/

    }
}
