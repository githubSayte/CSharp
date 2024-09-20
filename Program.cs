using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace CSharp

{
    // Começo class Program
    class Program
    {
        #region Região 0: as Listas e os IDs e Caminhos dos arquivos (usando caminhos relativos)
        // Listas e IDs
        static List<Computador> computadores = new List<Computador>();
        static List<Cliente> clientes = new List<Cliente>();
        static List<Venda> vendas = new List<Venda>();
        static int proximoIdComputador = 1;
        static int proximoIdCliente = 1;
        static int proximoIdVenda = 1;

        // Caminhos dos arquivos (usando caminhos relativos)
        static string caminhoComputadores = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "computadores.json");
        static string caminhoClientes = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "clientes.json");
        static string caminhoVendas = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "vendas.json");
        static string caminhoConfig = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");
        #endregion

        #region Região 1: Métodos Principais (Main, ExibirCabecalho, ExibirOpcoesMenu, ExibirInformacoesExtras, ExecutarOpcaoMenu, CarregarConfig, CarregarDados, SalvarDados)

        // Método principal da aplicação, responsável por gerenciar o fluxo do programa.
        static void Main(string[] args)
        {
            Config config = CarregarConfig(caminhoConfig);
            CarregarDados(caminhoComputadores, caminhoClientes, caminhoVendas);

            int opcao;
            do
            {
                Console.Clear();
                ExibirCabecalho("SISTEMA DE GERENCIAMENTO DE VENDAS DE COMPUTADORES E CADASTRO DE CLIENTES");
                ExibirOpcoesMenu();
                ExibirInformacoesExtras(config);

                Console.Write("Escolha uma opção: ");
                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    Thread.Sleep(1000);
                    continue;
                }

                ExecutarOpcaoMenu(opcao, caminhoComputadores, caminhoClientes, caminhoVendas);
            }
            while (opcao != 0);
        }


        static void ExecutarOpcaoMenu(int opcao, string caminhoComputadores, string caminhoClientes, string caminhoVendas)
        {
            switch (opcao)
            {
                case 1:
                    MenuComputadores();
                    break;
                case 2:
                    MenuClientes();
                    break;
                case 3:
                    MenuVendas();
                    break;
                case 0:
                    SalvarDados(caminhoComputadores, caminhoClientes, caminhoVendas);
                    Console.WriteLine("\nSaindo do programa...");
                    break;
                default:
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    Thread.Sleep(1000);
                    break;
            }
        }

        // Método para exibir o cabeçalho do sistema.
        static void ExibirCabecalho(string titulo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║ {titulo.PadRight(87)} ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Método para exibir o menu de opções.
        static void ExibirOpcoesMenu()
        {
            Console.WriteLine("║ 1. Gerenciar Estoque de Computadores                                                           ║");
            Console.WriteLine("║ 2. Gerenciar Cadastro de Clientes                                                              ║");
            Console.WriteLine("║ 3. Gerenciar Relatório de Vendas                                                               ║");
            Console.WriteLine("║ 0. Sair                                                                                        ║");
        }

        // Método para exibir informações adicionais no rodapé.
        static void ExibirInformacoesExtras(Config config)
        {
            Console.WriteLine($"║ Autor: Renato Resende Monteiro                                                                 ║");
            Console.WriteLine($"║ Data da Última Atualização: {config.DataUltimaAtualizacao,-30}                                     ║");
            Console.WriteLine($"║ Versão do Sistema: {config.Versao,-42}                                  ║");
            Console.WriteLine($"║ Data e Hora de Acesso: {DateTime.Now:dd/MM/yyyy HH:mm}                                                        ║");
        }

        // Método responsável por carregar a configuração do sistema.
        static Config CarregarConfig(string caminho)
        {
            if (File.Exists(caminho))
            {
                try
                {
                    string json = File.ReadAllText(caminho);
                    return JsonConvert.DeserializeObject<Config>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar o arquivo de configuração: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Arquivo de configuração não encontrado: {caminho}");
            }
            return null;
        }

        // Método responsável por carregar dados de computadores, clientes e vendas.
        static void CarregarDados(string caminhoComputadores, string caminhoClientes, string caminhoVendas)
        {
            CarregarDadosArquivo<Computador>(caminhoComputadores, "computadores");
            CarregarDadosArquivo<Cliente>(caminhoClientes, "clientes");
            CarregarDadosArquivo<Venda>(caminhoVendas, "vendas");
        }

        // Método genérico para carregar dados de arquivos JSON.
        static void CarregarDadosArquivo<T>(string caminho, string tipoDado)
        {
            if (File.Exists(caminho))
            {
                try
                {
                    string json = File.ReadAllText(caminho);
                    var dados = JsonConvert.DeserializeObject<List<T>>(json);
                    Console.WriteLine($"Dados de {tipoDado} carregados com sucesso.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao carregar os dados de {tipoDado}: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine($"Arquivo de {tipoDado} não encontrado: {caminho}");
            }
        }

        // Método responsável por salvar os dados nos arquivos.
        static void SalvarDados(string caminhoComputadores, string caminhoClientes, string caminhoVendas)
        {
            SalvarDadosArquivo(caminhoComputadores, new List<Computador> { new Computador { Id = 1, Marca = "Dell", Modelo = "XPS 15" } });
            SalvarDadosArquivo(caminhoClientes, new List<Cliente> { new Cliente { Id = 1, Nome = "João Silva", Email = "joao.silva@example.com" } });
            SalvarDadosArquivo(caminhoVendas, new List<Venda> { new Venda { Id = 1, ComputadorId = 1, ClienteId = 1, DataVenda = DateTime.Now } });

            Console.WriteLine("Dados salvos com sucesso.");
        }

        // Método genérico para salvar dados em arquivos JSON.
        static void SalvarDadosArquivo<T>(string caminho, List<T> dados)
        {
            try
            {
                File.WriteAllText(caminho, JsonConvert.SerializeObject(dados, Formatting.Indented));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar os dados: {ex.Message}");
            }
        }

        #endregion
        
        #region Região 2: Seleção de Menus (MenuComputadores, MenuClientes, MenuVendas)

        // Menu de Computadores
        static void MenuComputadores()
        {
            int opcao;
            do
            {
                Console.Clear();
                ExibirCabecalho("SISTEMA DE GERENCIAMENTO DE VENDAS DE COMPUTADORES E CLIENTES", "GERENCIAR ESTOQUE DE COMPUTADORES");

                // Exibe as opções do menu
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Adicionar Computador                                                                       ║");
                Console.WriteLine("║2. Listar Computadores                                                                        ║");
                Console.WriteLine("║3. Atualizar Computador                                                                       ║");
                Console.WriteLine("║4. Excluir Computador                                                                         ║");
                Console.WriteLine("║0. Voltar                                                                                     ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    Thread.Sleep(1000);
                    continue;
                }

                // Executa a ação correspondente com base na opção
                switch (opcao)
                {
                    case 1: AdicionarComputador(); break;
                    case 2: ListarComputadores(); break;
                    case 3: AtualizarComputador(); break;
                    case 4: ExcluirComputador(); break;
                    case 0: Console.WriteLine("\nVoltando ao menu principal..."); break;
                    default: Console.WriteLine("\nOpção inválida, tente novamente."); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        // Menu de Clientes
        static void MenuClientes()
        {
            int opcao;
            do
            {
                Console.Clear();
                ExibirCabecalho("SISTEMA DE GERENCIAMENTO DE VENDAS DE COMPUTADORES E CLIENTES", "GERENCIAR CADASTRO DE CLIENTES");

                // Exibe as opções do menu
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Adicionar Cliente                                                                          ║");
                Console.WriteLine("║2. Listar Clientes                                                                           ║");
                Console.WriteLine("║3. Atualizar Cliente                                                                         ║");
                Console.WriteLine("║4. Excluir Cliente                                                                           ║");
                Console.WriteLine("║0. Voltar                                                                                     ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    Thread.Sleep(1000);
                    continue;
                }

                // Executa a ação correspondente com base na opção
                switch (opcao)
                {
                    case 1: AdicionarCliente(); break;
                    case 2: ListarClientes(); break;
                    case 3: AtualizarCliente(); break;
                    case 4: ExcluirCliente(); break;
                    case 0: Console.WriteLine("\nVoltando ao menu principal..."); break;
                    default: Console.WriteLine("\nOpção inválida, tente novamente."); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        // Menu de Vendas
        static void MenuVendas()
        {
            int opcao;
            do
            {
                Console.Clear();
                ExibirCabecalho("SISTEMA DE GERENCIAMENTO DE VENDAS DE COMPUTADORES E CLIENTES", "GERENCIAR RELATÓRIO DE VENDAS");

                // Exibe as opções do menu
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("║1. Adicionar Venda                                                                            ║");
                Console.WriteLine("║2. Listar Vendas                                                                              ║");
                Console.WriteLine("║3. Atualizar Venda                                                                            ║");
                Console.WriteLine("║4. Excluir Venda                                                                              ║");
                Console.WriteLine("║0. Voltar                                                                                     ║");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Escolha uma opção: ");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("\nOpção inválida, tente novamente.");
                    Thread.Sleep(1000);
                    continue;
                }

                // Executa a ação correspondente com base na opção
                switch (opcao)
                {
                    case 1: AdicionarVenda(); break;
                    case 2: ListarVendas(); break;
                    case 3: AtualizarVenda(); break;
                    case 4: ExcluirVenda(); break;
                    case 0: Console.WriteLine("\nVoltando ao menu principal..."); break;
                    default: Console.WriteLine("\nOpção inválida, tente novamente."); break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        // Método para exibir o cabeçalho com informações gerais e específicas
        static void ExibirCabecalho(string sistemaTitulo, string menuTitulo)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine($"║            {sistemaTitulo,-86} ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"║                        {menuTitulo,-86} ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

            // Exibe informações sobre o desenvolvedor, data e hora
            Console.WriteLine($"║ Desenvolvedor Responsável: Renato Resende Monteiro                                           ║");
            Console.WriteLine($"║ Data da Última Atualização: 18/09/2024                                                       ║");
            Console.WriteLine($"║ Versão do Sistema: 1.00                                                                      ║");
            Console.WriteLine($"║ Hora e Data de Acesso: {DateTime.Now:HH:mm} de {DateTime.Now:dd/MM/yyyy}                                           ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");
        }

        #endregion

        #region Região 3: Métodos de gerenciamento do estoque dos Computadores

        // Métodos de gerenciamento do estoque dos Computadores
        static void AdicionarComputador()
        {
            Console.Clear();
            ExibirCabecalho("ADICIONAR NOVO COMPUTADOR");

            // Solicita as informações do computador
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o modelo do computador: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite a marca do computador: ");
            string marca = Console.ReadLine();
            Console.Write("Digite o preço do computador: ");
            decimal preco = decimal.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade em estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Adiciona o computador à lista
            var computador = new Computador
            {
                Id = proximoIdComputador++,
                Modelo = modelo,
                Marca = marca,
                Preco = preco,
                Quantidade = quantidade
            };

            computadores.Add(computador);

            // Mensagem de sucesso
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n╔════════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║ Computador adicionado com sucesso!                                                             ║");
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════╝");

            // Restaura a cor do texto para branco
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarComputadores()
        {
            Console.Clear();
            ExibirCabecalho("LISTA DE COMPUTADORES");

            // Exibe os computadores cadastrados ou uma mensagem informando que não há nenhum computador
            Console.ForegroundColor = ConsoleColor.White;
            if (computadores.Count == 0)
            {
                Console.WriteLine("\nNenhum computador cadastrado.");
            }
            else
            {
                foreach (var computador in computadores)
                {
                    Console.WriteLine($"ID: {computador.Id} - Modelo: {computador.Modelo} - Marca: {computador.Marca} - Preço: {computador.Preco:C} - Quantidade: {computador.Quantidade}");
                }
            }

            // Restaura a cor do texto para branco
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void AtualizarComputador()
        {
            Console.Clear();
            ExibirCabecalho("ATUALIZAR DADOS DO COMPUTADOR");

            // Define a cor do texto como branco para a entrada de dados
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o ID do computador a ser atualizado: ");
            int id = int.Parse(Console.ReadLine());

            var computador = computadores.Find(c => c.Id == id);

            if (computador != null)
            {
                Console.Write("Digite o novo modelo (deixe em branco para manter o atual): ");
                string modelo = Console.ReadLine();
                if (!string.IsNullOrEmpty(modelo)) computador.Modelo = modelo;

                Console.Write("Digite a nova marca (deixe em branco para manter a atual): ");
                string marca = Console.ReadLine();
                if (!string.IsNullOrEmpty(marca)) computador.Marca = marca;

                Console.Write("Digite o novo preço (deixe em branco para manter o atual): ");
                string precoStr = Console.ReadLine();
                if (decimal.TryParse(precoStr, out decimal preco)) computador.Preco = preco;

                Console.Write("Digite a nova quantidade (deixe em branco para manter a atual): ");
                string quantidadeStr = Console.ReadLine();
                if (int.TryParse(quantidadeStr, out int quantidade)) computador.Quantidade = quantidade;

                Console.WriteLine("\nComputador atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nID de computador não encontrado.");
            }

            // Restaura a cor do texto para branco
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        static void ExcluirComputador()
        {
            Console.Clear();
            ExibirCabecalho("EXCLUIR COMPUTADOR");

            // Define a cor do texto como branco para a entrada de dados
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o ID do computador a ser excluído: ");
            int id = int.Parse(Console.ReadLine());

            var computador = computadores.Find(c => c.Id == id);

            if (computador != null)
            {
                computadores.Remove(computador);
                Console.WriteLine("\nComputador excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("\nID de computador não encontrado.");
            }

            // Restaura a cor do texto para branco
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }
        #endregion

        #region Região 4: Métodos de gerenciamento do cadastro de Clientes

        // Métodos de gerenciamento do cadastro de Clientes
        static void AdicionarCliente()
        {
            Console.Clear();
            ExibirCabecalho("ADICIONAR NOVO CLIENTE");

            // Coleta informações do cliente
            var cliente = new Cliente
            {
                Id = proximoIdCliente++,
                Nome = SolicitarEntrada("Digite o nome do cliente: "),
                Email = SolicitarEntrada("Digite o e-mail do cliente: "),
                Telefone = SolicitarEntrada("Digite o telefone do cliente: ")
            };

            clientes.Add(cliente);
            Console.WriteLine("\nCliente adicionado com sucesso!");
            PausarExecucao();
        }

        static void ListarClientes()
        {
            Console.Clear();
            ExibirCabecalho("LISTA DE CLIENTES");

            // Exibe os clientes cadastrados
            Console.ForegroundColor = ConsoleColor.White;
            if (clientes.Count == 0)
            {
                Console.WriteLine("\nNenhum cliente cadastrado.");
            }
            else
            {
                foreach (var cliente in clientes)
                {
                    Console.WriteLine($"ID: {cliente.Id} - Nome: {cliente.Nome} - E-mail: {cliente.Email} - Telefone: {cliente.Telefone}");
                }
            }

            PausarExecucao();
        }

        static void AtualizarCliente()
        {
            Console.Clear();
            ExibirCabecalho("ATUALIZAR DADOS DO CLIENTE");

            Console.ForegroundColor = ConsoleColor.White;
            int id = int.Parse(SolicitarEntrada("Digite o ID do cliente a ser atualizado: "));
            var cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                cliente.Nome = SolicitarEntrada($"Digite o novo nome (atual: {cliente.Nome}): ", cliente.Nome);
                cliente.Email = SolicitarEntrada($"Digite o novo e-mail (atual: {cliente.Email}): ", cliente.Email);
                cliente.Telefone = SolicitarEntrada($"Digite o novo telefone (atual: {cliente.Telefone}): ", cliente.Telefone);
                Console.WriteLine("\nCliente atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("\nID de cliente não encontrado.");
            }

            PausarExecucao();
        }

        static void ExcluirCliente()
        {
            Console.Clear();
            ExibirCabecalho("EXCLUIR CLIENTE");

            Console.ForegroundColor = ConsoleColor.White;
            int id = int.Parse(SolicitarEntrada("Digite o ID do cliente a ser excluído: "));
            var cliente = clientes.Find(c => c.Id == id);

            if (cliente != null)
            {
                clientes.Remove(cliente);
                Console.WriteLine("\nCliente excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("\nID de cliente não encontrado.");
            }

            PausarExecucao();
        }

        // Método auxiliar para solicitar entradas e manter a cor do texto
        static string SolicitarEntrada(string mensagem, string valorAtual = "")
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine();
            return string.IsNullOrEmpty(entrada) ? valorAtual : entrada;
        }

        // Método para pausar a execução
        static void PausarExecucao()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
        }

        #endregion

        #region Região 5: Métodos de gerenciamento do controle das Vendas

        // Métodos de gerenciamento do controle das Vendas
        static void AdicionarVenda()
        {
            Console.Clear();
            ExibirCabecalho("ADICIONAR NOVA VENDA");

            // Coleta informações da venda
            if (!ObterCliente(out var cliente)) return;
            if (!ObterComputador(out var computador)) return;

            int quantidade = SolicitarQuantidade(computador);
            if (quantidade < 0) return;

            // Atualiza o estoque
            computador.Quantidade -= quantidade;

            // Registra a venda
            var venda = new Venda
            {
                Id = proximoIdVenda++,
                ClienteId = cliente.Id,
                ComputadorId = computador.Id,
                Quantidade = quantidade,
                DataVenda = DateTime.Now
            };

            vendas.Add(venda);
            Console.WriteLine("\nVenda registrada com sucesso!");
            PausarExecucao();
        }

        static void ListarVendas()
        {
            Console.Clear();
            ExibirCabecalho("LISTA DE VENDAS");

            // Exibe as vendas registradas
            if (vendas.Count == 0)
            {
                Console.WriteLine("\nNenhuma venda registrada.");
            }
            else
            {
                foreach (var venda in vendas)
                {
                    var cliente = clientes.Find(c => c.Id == venda.ClienteId);
                    var computador = computadores.Find(c => c.Id == venda.ComputadorId);
                    Console.WriteLine($"ID: {venda.Id} - Cliente: {cliente?.Nome ?? "Desconhecido"} - Computador: {computador?.Modelo ?? "Desconhecido"} - Quantidade: {venda.Quantidade} - Data: {venda.DataVenda}");
                }
            }

            PausarExecucao();
        }

        static void AtualizarVenda()
        {
            Console.Clear();
            ExibirCabecalho("ATUALIZAR DADOS DA VENDA");

            Console.Write("Digite o ID da venda a ser atualizada: ");
            if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("\nID inválido."); return; }

            var venda = vendas.Find(v => v.Id == id);
            if (venda == null) { Console.WriteLine("\nID de venda não encontrado."); return; }

            // Atualiza informações da venda
            if (ObterNovoClienteId(out var novoClienteId)) venda.ClienteId = novoClienteId;
            if (ObterNovoComputadorId(out var novoComputadorId, venda)) venda.ComputadorId = novoComputadorId;
            if (ObterNovaQuantidade(venda)) { /* lógica de atualização da quantidade */ }

            Console.WriteLine("\nVenda atualizada com sucesso!");
            PausarExecucao();
        }

        static void ExcluirVenda()
        {
            Console.Clear();
            ExibirCabecalho("EXCLUIR VENDA");

            Console.Write("Digite o ID da venda a ser excluída: ");
            if (!int.TryParse(Console.ReadLine(), out int id)) { Console.WriteLine("\nID inválido."); return; }

            var venda = vendas.Find(v => v.Id == id);
            if (venda != null)
            {
                var computador = computadores.Find(c => c.Id == venda.ComputadorId);
                if (computador != null) computador.Quantidade += venda.Quantidade; // Restaura o estoque

                vendas.Remove(venda);
                Console.WriteLine("\nVenda excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("\nID de venda não encontrado.");
            }

            PausarExecucao();
        }

        static bool ObterCliente(out Cliente cliente)
        {
            Console.Write("Digite o ID do cliente: ");
            if (int.TryParse(Console.ReadLine(), out int clienteId))
            {
                cliente = clientes.Find(c => c.Id == clienteId);
                if (cliente != null) return true;
                Console.WriteLine("\nCliente não encontrado.");
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
            cliente = null;
            return false;
        }

        static bool ObterComputador(out Computador computador)
        {
            Console.Write("Digite o ID do computador: ");
            if (int.TryParse(Console.ReadLine(), out int computadorId))
            {
                computador = computadores.Find(c => c.Id == computadorId);
                if (computador != null) return true;
                Console.WriteLine("\nComputador não encontrado.");
            }
            else
            {
                Console.WriteLine("\nID inválido.");
            }
            computador = null;
            return false;
        }

        static int SolicitarQuantidade(Computador computador)
        {
            Console.Write("Digite a quantidade vendida: ");
            if (int.TryParse(Console.ReadLine(), out int quantidade))
            {
                if (quantidade <= computador.Quantidade) return quantidade;
                Console.WriteLine("\nQuantidade vendida não disponível em estoque.");
            }
            else
            {
                Console.WriteLine("\nQuantidade inválida.");
            }
            return -1;
        }

        static bool ObterNovoClienteId(out int clienteId)
        {
            Console.Write("Digite o novo ID do cliente (deixe em branco para manter o atual): ");
            string clienteIdStr = Console.ReadLine();
            if (int.TryParse(clienteIdStr, out clienteId)) return true;
            clienteId = -1; // Valor inválido
            return false;
        }

        static bool ObterNovoComputadorId(out int computadorId, Venda venda)
        {
            Console.Write("Digite o novo ID do computador (deixe em branco para manter o atual): ");
            string computadorIdStr = Console.ReadLine();
            if (int.TryParse(computadorIdStr, out computadorId)) return true;
            computadorId = -1; // Valor inválido
            return false;
        }

        static bool ObterNovaQuantidade(Venda venda)
        {
            Console.Write("Digite a nova quantidade (deixe em branco para manter a atual): ");
            string quantidadeStr = Console.ReadLine();
            if (int.TryParse(quantidadeStr, out int novaQuantidade))
            {
                var computador = computadores.Find(c => c.Id == venda.ComputadorId);
                if (computador != null && novaQuantidade <= computador.Quantidade + venda.Quantidade)
                {
                    computador.Quantidade += venda.Quantidade - novaQuantidade; // Atualiza o estoque
                    venda.Quantidade = novaQuantidade;
                    return true;
                }
                Console.WriteLine("\nQuantidade não disponível em estoque.");
            }
            return false;
        }
        #endregion


    }//Fim class Program

    #region Região 6: Classes públicas do sistema


    public class Config
    {
        public string Versao { get; set; } // Versão do sistema.
        public DateTime DataUltimaAtualizacao { get; set; } // Data da última atualização.
    }

    public class Computador
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public decimal Preco { get; set; }
        public int Quantidade { get; set; }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
    }

    public class Venda
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int ComputadorId { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
#endregion

