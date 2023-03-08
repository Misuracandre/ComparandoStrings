internal class Program
{
    private static void Main(string[] args)
    {    // Declaraçao de váriaveis
        string nome1, nome2;

        nome1 = Console.ReadLine();
        nome2 = Console.ReadLine();

        // nome1 é chamado no metodo equals, usando nome2 como argumento
        bool saoIguais = nome1.Equals(nome2, StringComparison.OrdinalIgnoreCase);

        if (saoIguais)
        {
            Console.WriteLine("As strings são iguais.");
        }
        else
        {
            Console.WriteLine("As strings são diferentes.");
        }
    }
}