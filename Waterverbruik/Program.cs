using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Waterverbruik
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            • tarief 1: vastrecht € 100,= per jaar • tarief 1: verbruikskosten € 0,25 per m3 
            • tarief 2: vastrecht € 75,= per jaar • tarief 2: verbruikskosten € 0,38 per m3 • 
            tarief 0: Voor de betreffende verbruiker wordt de voordeligste mogelijkheid(tarief 1 of tarief 2) gekozen.
            */
            double tarief, verbruik, tariefKosten1, tariefKosten2, kosten;
            double tariefVast1 = 100;
            double tariefVast2 = 75;
            double tariefVerbruik1 = 0.25;
            double tariefVerbruik2 = 0.38;

            Console.WriteLine("Gelieve het tarief in te voeren:");
            tarief = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Gelieve het verbruik in kubieke meters in te voeren:");
            verbruik = Convert.ToDouble(Console.ReadLine());

            tariefKosten1 = tariefVast1 + verbruik * tariefVerbruik1;
            tariefKosten2 = tariefVast2 + verbruik * tariefVerbruik2;

            if (tarief == 1)
            {
                kosten = tariefKosten1;
            } else if (tarief == 2) {
                kosten = tariefKosten2;
            } else {
                kosten = (tariefKosten1 < tariefKosten2) ? tariefKosten1 : tariefKosten2 ;
            }

            Console.WriteLine("De kosten zijn {0:0.00}euro.", kosten);

            Console.ReadLine();
        }
    }
}