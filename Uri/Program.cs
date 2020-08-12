using System;
using System.Globalization;
using System.Text;

namespace Uri
{
    public class Program
    {
        static void Main(string[] args)
        {
            double cem = 0;
            double cinquenta = 0;
            double vinte = 0;
            double dez = 0;
            double cinco = 0;
            double dois = 0;
            double um = 0;
            double cinquentaCentavos = 0;
            double vinteCinco = 0;
            double dezCentavos = 0;
            double cincoCentavos = 0;
            double umCentavo = 0;
            double resto = 0;


            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resto = valor;

            if (resto >= 100)
            {
                cem = Math.Truncate((resto / 100));
                resto = Math.Round(resto - (cem * 100), 2);

            }

            if (resto >= 50)
            {
                cinquenta = Math.Truncate(resto / 50);
                resto = Math.Round(resto - (cinquenta * 50), 2);

            }

            if (resto >= 20)
            {
                vinte = Math.Truncate(resto / 20);
                resto = resto - Math.Round((vinte * 20), 2);

            }

            if (resto >= 10)
            {
                dez = Math.Truncate(resto / 10);
                resto = Math.Round(resto - (dez * 10), 2);
            }

            if (resto >= 5)
            {
                cinco = Math.Truncate(resto / 5);
                resto = Math.Round(resto - (cinco * 5), 2);
            }

            if (resto >= 2)
            {
                dois = Math.Truncate(resto / 2);
                resto = Math.Round(resto - (dois * 2), 2);
            }

            if (resto >= 1)
            {
                um = Math.Truncate(resto / 1);
                resto = Math.Round(resto - (um * 1), 2);
            }

            if (resto >= 0.50)
            {
                cinquentaCentavos = Math.Truncate(resto / 0.50);
                resto = Math.Round(resto - (cinquentaCentavos * 0.50), 2);
            }

            if (resto >= 0.25)
            {
                vinteCinco = Math.Truncate(resto / 0.25);
                resto = Math.Round(resto - (vinteCinco * 0.25), 2);

            }

            if (resto >= 0.10)
            {
                dezCentavos = Math.Truncate(resto / 0.10);
                resto = Math.Round(resto - (dezCentavos * 0.10), 2);
            }

            if (resto >= 0.05)
            {
                cincoCentavos = Math.Truncate(resto / 0.05);
                resto = Math.Round(resto - (cincoCentavos * 0.05), 2);
            }

            if (resto >= 0.01)
            {
                umCentavo = Math.Truncate(resto / 0.01);
                resto = Math.Round(resto - (umCentavo * 0.01), 2);
            }


            StringBuilder sb = new StringBuilder();

            sb.AppendLine("NOTAS:");
            sb.AppendLine(cem + " nota(s) de R$ 100.00");
            sb.AppendLine(cinquenta + " nota(s) de R$ 50.00");
            sb.AppendLine(vinte + " nota(s) de R$ 20.00");
            sb.AppendLine(dez + " nota(s) de R$ 10.00");
            sb.AppendLine(cinco + " nota(s) de R$ 5.00");
            sb.AppendLine(dois + " nota(s) de R$ 2.00");
            sb.AppendLine("MOEDAS:");
            sb.AppendLine(um + " moeda(s) de R$ 1.00");
            sb.AppendLine(cinquentaCentavos + " moeda(s) de R$ 0.50");
            sb.AppendLine(vinteCinco + " moeda(s) de R$ 0.25");
            sb.AppendLine(dezCentavos + " moeda(s) de R$ 0.10");
            sb.AppendLine(cincoCentavos + " moeda(s) de R$ 0.05");
            sb.AppendLine(umCentavo + " moeda(s) de R$ 0.01");


            Console.WriteLine(sb.ToString());




        }
    }
}
