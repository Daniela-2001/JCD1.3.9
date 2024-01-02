namespace JCD1._3._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o número de linhas para a metade da árvore: ");

            // Obter o número de linhas a partir da entrada do usuário
            int numeroDeLinhas = Convert.ToInt32(Console.ReadLine());

            // Loop para desenhar a metade da árvore
            for (int i = 1; i <= numeroDeLinhas; i++)
            {
                // Números de '*' por linha
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }

                // Mover para a próxima linha após desenhar uma linha completa
                Console.WriteLine();
            }

            Console.ReadLine(); // Manter o console aberto após a execução
        }
    }
   
}