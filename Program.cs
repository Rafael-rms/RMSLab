// See https://aka.ms/new-console-template for more information

using System.Reflection.Metadata;
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
    Console.WriteLine("2 - Recebimento de Amostras");
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


                bool exibirNovoMenu = true;
                while (exibirNovoMenu)
                {
                    Console.Clear();
                    Console.WriteLine("Recebimento de Amostras");
                    Console.WriteLine("1 - Consultar Amostra");
                    Console.WriteLine("2 - Triagem");
                    Console.WriteLine("3 - Voltar");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                Console.WriteLine("Consultar Amostra");


                                Console.WriteLine($"Digite o código da amostra: ");
                                string codigoAmostraDigitado = Console.ReadLine();

                                Amostra amostraEncontrada = null;

                                foreach (var amostra in amostras)
                                {
                                    if (amostra.Codigo == codigoAmostraDigitado)
                                    {
                                        amostraEncontrada = amostra;
                                        break;
                                    }
                                }

                                if (amostraEncontrada != null)
                                    {
                                        Console.WriteLine("Codigo encontrado com sucesso!!");

                                        Console.WriteLine($"Codigo: {amostraEncontrada.Codigo}");
                                        Console.WriteLine($"Paciente: {amostraEncontrada.Paciente.Nome}");
                                        Console.WriteLine($"Exame: {amostraEncontrada.Exame.Tipo}");
                                        Console.WriteLine($"Exame: {amostraEncontrada.Exame.Status}");
                                        Console.WriteLine($"Data: {amostraEncontrada.DataCadastro}");

                                    }
                                    else
                                    {
                                        Console.WriteLine("Codigo não encontrado.");
                                    }
                                

                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Triagem");
                                Console.WriteLine($"Digite o código da amostra: ");
                                string codigoAmostraDigitado = Console.ReadLine();

                                Amostra amostraEncontrada = null;
                                foreach (var amostra in amostras)
                                {
                                    if (amostra.Codigo == codigoAmostraDigitado)
                                    {
                                        amostraEncontrada = amostra;
                                        break;
                                    }
                                }

                                if (amostraEncontrada != null)
                                    {
                                        Console.WriteLine("Codigo encontrado com sucesso!!");

                                        Console.WriteLine($"Codigo: {amostraEncontrada.Codigo}");
                                        Console.WriteLine($"Paciente: {amostraEncontrada.Paciente.Nome}");
                                        Console.WriteLine($"Exame: {amostraEncontrada.Exame.Tipo}");
                                        Console.WriteLine($"Exame: {amostraEncontrada.Exame.Status}");
                                        Console.WriteLine($"Data: {amostraEncontrada.DataCadastro}");

                                        if (amostraEncontrada.Exame.Status == StatusExame.Cadastrado)
                                        {
                                            amostraEncontrada.Exame.Status = StatusExame.PreTriado;
                                            Console.WriteLine("Exame pre triado com sucesso!!");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Amostra ja se encontra pré-traida.");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Codigo não encontrado.");
                                    }

                                break;
                            }
                        case "3":
                            {
                                exibirNovoMenu = false;
                                break;
                            }
                        default:
                            Console.WriteLine("Opção inválida");
                            break;
                    }

                    Console.WriteLine("Pressione uma tecla para continuar");
                    Console.ReadLine();
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
