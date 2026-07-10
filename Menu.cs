public class Menu
{
    public static void Exibir()
    {
        int opcao;

        do
        {
            Console.Clear();

            Console.WriteLine("======== Menu Principal ========");
            Console.WriteLine("1 - Cadastro de Alunos");
            Console.WriteLine("2 - Média da Turma");
            Console.WriteLine("3 - Tabela de Valores");
            Console.WriteLine("4 - Soma dos Valores");
            Console.WriteLine("5 - Maior Valor");
            Console.WriteLine("6 - Boletim da Turma");
            Console.WriteLine("7 - Controle de Presença");
            Console.WriteLine("8 - Somatório Recursivo");
            Console.WriteLine("9 - Contagem Regressiva");
            Console.WriteLine("10 - Sequência de Fibonacci");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.Parse(Console.ReadLine()!);
Console.Clear();
            switch (opcao)
            {
                case 1:
                    Atividades.Atividade01();
                    break;
                case 2:
                    Atividades.Atividade02();
                    break;
                case 3:
                    Atividades.Atividade03();
                    break;
                case 4:
                    Atividades.Atividade04();
                    break;
                case 5:
                    Atividades.Atividade05();
                    break;
                case 6:
                    Atividades.Atividade06();
                    break;
                case 7:
                    Atividades.Atividade07();
                    break;
                case 8:
                    Atividades.Atividade08();
                    break;
                case 9:
                    Atividades.Atividade09();
                    break;
                case 10:
                    Atividades.Atividade10();
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Pressione Enter e tente novamente.");
                    Console.ReadKey();
                    break;
                    {
                      
            
                    }
            }
                Console.WriteLine("Pressione qualquer tecla para sair.");
            Console.ReadKey();
        } while (opcao != 0);   
    }
}
