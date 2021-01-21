using System;

namespace PegarDataUtc
{
    class Program
    {
        static void Main(string[] args)
        {
            ExibirData();
        }

        private static void ExibirData()
        {
            DateTime timeUtc = DateTime.UtcNow;

            var cuiaba = TimeZoneInfo.FindSystemTimeZoneById("Central Brazilian Standard Time");
            Console.WriteLine("===============================================================================");
            Console.WriteLine("Data: {0}", TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cuiaba).ToString("dd/MM/yyyy"));
            Console.WriteLine("Dia: {0}", TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cuiaba).Day.ToString());
            Console.WriteLine("Mês: {0}", TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cuiaba).Month.ToString());
            Console.WriteLine("Ano: {0}", TimeZoneInfo.ConvertTimeFromUtc(timeUtc, cuiaba).Year.ToString());
            Console.WriteLine(cuiaba);
            Console.WriteLine("===============================================================================");
        }
    }
}
