using System;

namespace Sexta
{
    class Program
    {
        static void Main(string[] args)
        {
            Operacao objAula = new Operacao(); 

            Console.WriteLine("1 - Fazer operação");
            int opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1:
                    Operacao objOper = new Operacao();
                    
                    Console.WriteLine("Informar o valor um: ");
                    int n1 = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Informar o valor dois: ");
                    int n2 = int.Parse(Console.ReadLine());

                    string resultado = objOper.Soma(n1, n2);
                    Console.WriteLine(resultado);
                    break;

                case 2:
                    Operacao objOpera = new Operacao();

                    Console.WriteLine("Informar o valor um: ");
                    int num1 = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Informar o valor dois: ");
                    int num2 = int.Parse(Console.ReadLine());

                    string result = objOpera.Sub(num1, num2);
                    Console.WriteLine(result);
                    break;

                case 3:
                    Operacao objOperac = new Operacao();

                    Console.WriteLine("Informar o valor um: ");
                    int nume1 = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Informar o valor dois: ");
                    int nume2 = int.Parse(Console.ReadLine());

                    string resulta = objOperac.Mult(nume1, nume2);
                    Console.WriteLine(resulta);
                    break;
                
                case 4:
                    Operacao objOperaca = new Operacao();

                    Console.WriteLine("Informar o valor um: ");
                    int numer1 = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Informar o valor dois: ");
                    int numer2 = int.Parse(Console.ReadLine());

                    string resultad = objOperaca.Div(numer1, numer2);
                    Console.WriteLine(resultad);
                    break;

            }

            Console.WriteLine("Fim da operação");
            Console.ReadKey();
        }
    }
}

