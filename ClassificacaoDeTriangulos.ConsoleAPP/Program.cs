namespace ClassificacaoDeTriangulos
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                ExibirCabecalho();

                int ladoX = LerLado("X");
                int ladoY = LerLado("Y");
                int ladoZ = LerLado("Z");

                ExibirValoresInformados(ladoX, ladoY, ladoZ);

                if (ClassificadorDeTriangulos.FormamTrianguloValido(ladoX, ladoY, ladoZ))
                {
                    string classificacao = ClassificadorDeTriangulos.Classificar(ladoX, ladoY, ladoZ);
                    Console.WriteLine($"O triângulo é {classificacao}.");
                }
                else
                {
                    Console.WriteLine("Os valores informados não formam um triângulo válido.");
                }

                Console.WriteLine("-------------------------------------------------");
                Console.Write("Deseja continuar? (s/N) ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
        static void ExibirCabecalho()
        {
            Console.Clear();
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Classificador de Triângulos");
            Console.WriteLine("-------------------------------");
        }

        static int LerLado(string nomeLado)
        {
            while (true)
            {
                Console.Write($"Informe o lado {nomeLado}: ");
                bool conseguiuConverter = int.TryParse(Console.ReadLine(), out int valor);
                if (conseguiuConverter && valor > 0)
                    return valor;

                Console.WriteLine("Entrada inválida! Informe apenas números inteiros positivos.");
            }
        }

        static void ExibirValoresInformados(int ladoX, int ladoY, int ladoZ)
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Valores informados:");
            Console.WriteLine($"Lado X: {ladoX}");
            Console.WriteLine($"Lado Y: {ladoY}");
            Console.WriteLine($"Lado Z: {ladoZ}");
            Console.WriteLine("-------------------------------------------------");
        }
    }
    public static class ClassificadorDeTriangulos
    {
        public static bool FormamTrianguloValido(int x, int y, int z)
        {
            return x + y > z && x + z > y && y + z > x;
        }
        public static string Classificar(int x, int y, int z)
        {
            if (x == y && y == z)
                return "Equilátero";
            else if (x != y && y != z && x != z)
                return "Escaleno";
            else
                return "Isósceles";
        }
    }
}
