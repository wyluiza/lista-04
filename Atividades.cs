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
using System;

class Program
{
    static void Main()
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
}
    }
    public static void Atividade03()
    {

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