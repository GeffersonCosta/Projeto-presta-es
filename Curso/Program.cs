using System;
using System.Globalization;
using Curso.Entities;
using Curso.Services;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/MM/yyyy): ");
            DateTime data = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double value = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Contract contract = new Contract(number,data,value);
            Console.Write("Enter number of installments: ");
            int numberInstallments = int.Parse(Console.ReadLine());
            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(contract,numberInstallments);
            Console.WriteLine("Installments:");
            Console.WriteLine(contract);


        }
    }
}
