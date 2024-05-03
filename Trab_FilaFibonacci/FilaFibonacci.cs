using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trab_FilaFibonacci
{
    internal class FilaFibonacci
    {
        Fibonacci? inicio;
        Fibonacci? fim;

        public FilaFibonacci()
        {
            this.inicio = null;
            this.fim = null;
        }
        public void push(Fibonacci aux)
        {
            if (vazia())
            {
                this.inicio = this.fim = aux;
            }
            else
            {
                this.fim.setProximo(aux);
                this.fim = aux;
            }
        }
        internal bool vazia()
        {
            return inicio == null && fim == null;
        }
        public int pop()
        {
            int valor = 0;
            if (!vazia())
            {
                if (fim == inicio) // se cabeca = cauda entao so tem 1 elemento na fila
                {
                    valor = this.inicio.getNumero();
                    inicio = fim = null;
                }
                else
                {
                    valor = this.inicio.getNumero();
                    this.inicio = this.inicio.getProximo();
                }
            }
            return valor;
        }
        public string print()
        {
            Fibonacci aux = inicio;
            string texto = "";
            if (!vazia())
            {
                texto = "Inicio => ";
                do
                {
                    texto += $"{aux.ToString()} ";
                    aux = aux.getProximo();
                } while (aux != null);
                texto += "<= Fim";
            }
            return texto;
        }
    }
}
