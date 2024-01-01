namespace JCD1._3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas para a árvore: ");
            int numeroDeLinhas = Convert.ToInt32(Console.ReadLine());

            // Loop para percorrer cada linha da árvore
            for (int linha = 1; linha <= numeroDeLinhas; linha++)
            {
                // Calcular a quantidade de espaços em branco antes dos números ímpares
                int espacosEmBranco = numeroDeLinhas - linha;

                // Imprimir espaços em branco
                for (int i = 0; i < espacosEmBranco; i++)
                {
                    Console.Write(" ");
                }

                // Calcular e imprimir os números ímpares com o caractere '*'
                for (int numeroImpar = 1; numeroImpar <= (2 * linha - 1); numeroImpar += 2)
                {
                    Console.Write(numeroImpar);
                }

                // Ir para a próxima linha após imprimir a linha atual
                Console.WriteLine();
            }

            // Aguardar a entrada do usuário antes de fechar o console
            Console.ReadLine();
        }
    }
}