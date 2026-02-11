// See https://aka.ms/new-console-template for more information

using RMSLab.Models;

List<Amostra> amostras = new List<Amostra>();


bool exibirMenu = true;

while(exibirMenu)
{
    
    Console.Clear();
    Console.WriteLine("Seja bem vindo ao seu laboratório de microbiologia");
    Console.WriteLine("Digite a opção desejada");
    Console.WriteLine("1 - Cadastro");
    Console.WriteLine("2 - Triagem");
    Console.WriteLine("3 - Inserir resultado");
    Console.WriteLine("4 - Gerenciamento de lote");
    Console.WriteLine("5 - Sair");

    switch (Console.ReadLine())
    {
        case "1":
        Console.WriteLine("Digite o nome do paciente: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite o documento do paciente: ");
        string documento = Console.ReadLine();

        Paciente paciente = new Paciente();
        paciente.Nome = nome;
        paciente.Documento = documento;

        Console.WriteLine($"Paciente criado: {nome} e {documento}");

        break;
        case "2":
        Console.WriteLine("Triagem");
        break;
        case "3":
        Console.WriteLine("Inserir resultado (Individual)");
        break;
        case "4":
        Console.WriteLine("Gerenciamento de lote (Liberação)");
        break;
        case "5":
        exibirMenu = false;
        break;
        default:
        Console.WriteLine("Opção inválida");
        break;
    }
    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
