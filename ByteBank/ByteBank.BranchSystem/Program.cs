using System;
using System.Globalization;
using Humanizer;
using Humanizer.Localisation;

namespace ByteBank.BranchSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao ByteBank!");

            // chamando uma classe da dll
            Console.WriteLine("Chamando uma classe da nossa dll Bytebank.Models");
            CheckingAccount account = new CheckingAccount( 371, 3627362 );
            Console.WriteLine(account.Number);
            Console.WriteLine("----------------------------");

            // utilizando a dll humanizer
            Console.WriteLine("Utilizando a dll humanizer");
            // Dia 17 de Agosto de 2018
            DateTime DueDate = new DateTime(2018, 8, 17);
            // Data corrente no momento de execução do código
            DateTime CurrentDate = DateTime.Now;
            TimeSpan DateSpan = DueDate - CurrentDate;

            string message = "O vencimento ocrrerá em " + TimeSpanHumanizeExtensions.Humanize(DateSpan,culture: new CultureInfo("pt-BR"), maxUnit: TimeUnit.Month);

            Console.WriteLine(message);
            Console.WriteLine("----------------------------");

            Console.ReadLine();


        }
    }
}
