using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {           
            double dUsd, dEur;
            string sUsd, sEur;
            do
            {
                Console.WriteLine("введите курсы валют, сначала доллар/гривна, потом евро/гривна ");
                sUsd = Console.ReadLine();
                sEur = Console.ReadLine();
            }
            while (!(double.TryParse(sUsd, out dUsd) && double.TryParse(sEur, out dEur) && dEur > 0 && dUsd > 0));

            Converter convert = new(dUsd, dEur);

            Console.WriteLine("что бы конвертировать валюту в гривны- введите 1, конвертировать гривны в валюту- что угодно кроме 1");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine(convert.ConvertToHRN().ToString());
            }
            else
            {
                Console.WriteLine(convert.ConvertToCur().ToString());
            }
        }
    }

    class Converter 
    {
        double usd, eur;
        
        public Converter(double _usd, double _eur)
        {
            usd = _usd;
            eur = _eur;
        }

        public double ConvertToHRN( )
        {
            Console.WriteLine("какую валюту конвертировать в гривны? 1- евро, иначе- доллар");
            double HRN;
            if (Console.ReadLine() == "1")
            {
                do
                {
                    Console.WriteLine("введите кол-во евро которое нужно конвертировать в гривны");
                    
                } while (!(double.TryParse(Console.ReadLine(), out HRN) && HRN > 0));
                return HRN*eur;
            }
            else
            {
                do
                {
                    Console.WriteLine("введите кол-во долларов которое нужно конвертировать в гривны");

                } while (!(double.TryParse(Console.ReadLine(), out HRN) && HRN > 0));
                return HRN *usd;
            }
        }


        public double ConvertToCur()
        {
            Console.WriteLine("в какую валюту конвертировать гривны? 1- в евро, иначе- в доллар");
            double HRN;
            if (Console.ReadLine() == "1")
            {
                do
                {
                    Console.WriteLine("введите кол-во гривен которое нужно конвертировать в евро");

                } while (!(double.TryParse(Console.ReadLine(), out HRN) && HRN > 0));
                return HRN / eur;
            }
            else
            {
                do
                {
                    Console.WriteLine("введите кол-во гривен которое нужно конвертировать в доллары");

                } 
                while (!(double.TryParse(Console.ReadLine(), out HRN) && HRN > 0));
                return HRN /usd;
            }
        }
    }


}