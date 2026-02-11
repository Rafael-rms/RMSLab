// See https://aka.ms/new-console-template for more information

using RMSLab.Models;

List<Amostra> amostras = new List<Amostra>();


bool exibirMenu = true;
int idAmostras = 1;

while (exibirMenu)
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
            {
                Console.WriteLine("Digite o nome do paciente: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o documento do paciente: ");
                string documento = Console.ReadLine();

                Paciente paciente = new Paciente();
                paciente.Nome = nome;
                paciente.Documento = documento;

                Console.WriteLine($"Paciente criado: {nome} e {documento}");

                Console.WriteLine("Que exame deseja cadastrar: ");
                string exame = Console.ReadLine();
                Exame exame1 = new Exame();
                exame1.Tipo = exame;
                exame1.Status = StatusExame.Cadastrado;

                Amostra amostra = new Amostra();
                amostra.Codigo = $"RMS{idAmostras:D4}";
                amostra.Paciente = paciente;
                amostra.Exame = exame1;
                amostra.DataCadastro = DateTime.Now;

                amostras.Add(amostra);
                Console.WriteLine($"Temos a {amostras.Count}ª amostras cadastradas.");
                idAmostras++;
                Console.WriteLine($"O ID da sua amostra cadastrada é : {amostra.Codigo}");
                break;
            }
        case "2":
            {
                Console.WriteLine("Triagem");

                if (amostras.Count == 0)
                {
                    Console.WriteLine("Nenhuma amostra cadastrada");
                }
                else
                {
                    foreach (var amostra in amostras)
                    {
                        Console.WriteLine($"Código: {amostra.Codigo}, Paciente: {amostra.Paciente.Nome}, Status: {amostra.Exame.Status}");
                    }
                }

                break;
            }
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
