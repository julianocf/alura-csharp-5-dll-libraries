using ByteBank.Models;
using System;

namespace ByteBank.InternalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo ao Sistema Interno do ByteBank!");

            CheckingAccount account = new CheckingAccount(371, 3627362);
            Console.WriteLine(account.Number);

            Console.ReadLine();
        }
    }
}
