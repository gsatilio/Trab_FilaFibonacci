using Trab_FilaFibonacci;

internal class Program
{
    private static void Main(string[] args)
    {
        int opc, anterior, atual, valorfibonacci;
        FilaFibonacci fila = new FilaFibonacci();
        do
        {
            anterior = -1; atual = 1; valorfibonacci = 0;
            Console.WriteLine("Informe a quantidade de números Fibonacci que deseja inserir na fila, ou digite 0 para sair.");
            opc = int.Parse(Console.ReadLine());
            for (int i = 0; i <= opc; i++)
            {
                valorfibonacci = anterior + atual;

                if (valorfibonacci > 0)
                {
                    fila.push(new Fibonacci(valorfibonacci));
                }
                anterior = atual;
                atual = valorfibonacci;
            }
            Console.WriteLine(fila.print());
            for (int i = 0; i <= opc; i++)
            {
                fila.pop();
            }
            if (opc > 0)
            {
                opc = -1;
            }
        } while (opc != 0);
    }
}