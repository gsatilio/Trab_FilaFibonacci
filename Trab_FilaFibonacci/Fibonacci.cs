using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_FilaFibonacci
{
    internal class Fibonacci
    {
        int valor;
        Fibonacci proximo;
        public Fibonacci(int numero)
        {
            this.valor = numero;
        }
        public void setProximo(Fibonacci num)
        {
            this.proximo = num;
        }
        public Fibonacci getProximo()
        {
            return this.proximo;
        }
        public int getNumero()
        {
            return this.valor;
        }
        public override string? ToString()
        {
            return "" + valor;
        }
    }
}
