public static class Atividades
{
    public static void Atividade01()
    {
        string[] alunos = new string[5];
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.Write("Informe o nome do aluno: ");
            alunos[i] = Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Alunos cadastrados:");
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine(alunos[i]);
        }
    }
    public static void Atividade02()
    {

        double[] notas = new double[5];

        double soma = 0;

        for (int i = 0; i < notas.Length; i++)
        {
            Console.Write($"Informe a nota do aluno {i + 1}: ");
            notas[i] = double.Parse(Console.ReadLine());
        }
        for (int i = 0; i < notas.Length; i++)
        {
            soma += notas[i];
        }
        double media = soma / notas.Length;

        Console.WriteLine();
        Console.WriteLine($"Média da turma: {media:F2}");
    }
    public static void Atividade03()
    {
        int[,] numeros = new int[2, 3];
        for (int linha = 0; linha < numeros.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < numeros.GetLength(1); coluna++)
            {
                Console.Write($"Informe o valor da posição [{linha},{coluna}]: ");
                numeros[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        for (int linha = 0; linha < numeros.GetLength(0); linha++)
        {
            for (int coluna = 0; coluna < numeros.GetLength(1); coluna++)
            {
                Console.Write(numeros[linha, coluna] + "\t");
            }
            Console.WriteLine();
        }
    }
    public static void Atividade04()
    {

    }
    public static void Atividade05()
    {

    }
    public static void Atividade06()
    {

    }
    public static void Atividade07()
    {

    }
    public static void Atividade08()
    {

    }
    public static void Atividade09()
    {

    }
    public static void Atividade10()
    {

    }
}