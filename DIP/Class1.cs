using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP
{
    // not implement DIP

    //internal class VoiceAnalyzer
    //{
    //    public bool Analyzer(string info)
    //    {
    //        return info.Contains("lie");
    //    }
    //}

    //internal class TerroristInterrogationUnit()
    //{
    //    private VoiceAnalyzer voiceCheck = new VoiceAnalyzer();

    //    public void StartInvestigate(string info)
    //    {
    //        if (voiceCheck.Analyzer(info))
    //        {
    //            Console.WriteLine("He is lie.");
    //        }
    //        else
    //        {
    //            Console.WriteLine("He is tell the truth.");
    //        }
    //    }
    //}



    //implement DIP
    internal interface ILieDetector
    {
        public bool Analyzer(string info);
    }
    internal class VoiceAnalyzer : ILieDetector
    {
        public bool Analyzer(string info)
        {
            return info.Contains("lie");
        }
    }

    internal class ThermalScanner : ILieDetector
    {
        public bool Analyzer(string info)
        {
            return info.Contains("pressure");
        }
    }

    internal class TerroristInterrogationUnit()
    {
        private ILieDetector analyze;

        public void StartInvestigate(string info)
        {
            if (analyze.Analyzer(info))
            {
                Console.WriteLine("He is lie.");
            }
            else
            {
                Console.WriteLine("He is not lie.");
            }
        }
    }

}
