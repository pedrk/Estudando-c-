using System;

namespace Sexta
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno objAula = new Aluno(); 
            
            Console.WriteLine("Insira o primeiro numero: ");
            int n1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            int n2 = Int32.Parse(Console.ReadLine());

            string result = objAula.Soma(n1, n2);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
