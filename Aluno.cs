using System;

namespace Sexta
{
    public class Operacao
    {
        
        public string Soma(int n1, int n2) 
        {
            int somar = n1 + n2;
            return $"O seu resultado é: {somar}" ;
            //return $"Seja bem vindo, {nome}";
        }

        public string Sub(int n1, int n2)
        {
            int subtracao = n1 - n2;
            return $"O seu resultado é: {subtracao}" ;
        }

        public string Mult(int n1, int n2)
        {
            int mult = n1 * n2;
            return $"O seu resultado é: {mult}" ;
        }

        public string Div(int n1, int n2)
        {
            int divisao = n1 - n2;
            return $"O seu resultado é: {divisao}" ;
        }

        

        
    }
}