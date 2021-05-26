using System;
using System.Collections.Generic;

namespace tavares_filho.bank
{
        class Program
    {
        static List<Conta> ListContas = new List<Conta>();
                static void Main(string[] args) 
        
        {
           string opcaoUsuario=ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
                        
            {
              
           
            switch(opcaoUsuario)
            {
                case "1" :
                ListarContas();
                break;
                case "2":
                CadastrarContas();
                break;
                case "3" :
                transferencia();
                break;
                case "4" :
                Sacar();
                break;
                case "5" :
                Depositar();
                break;
            }
            opcaoUsuario=ObterOpcaoUsuario();
            
            }
        }

        private static void Depositar()
        {
           Console.Clear();
           Console.WriteLine 
           ("----------------------------");
           Console.WriteLine
           ("|           DEPÓSITO       |");
           Console.WriteLine 
           ("----------------------------");
           Console.Write("Digite o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o valor do depósito: ");
           double ValorDeposito = double.Parse(Console.ReadLine());

           ListContas[indiceConta].Depositar(ValorDeposito);
           
        }

        private static void Sacar()
        {
            Console.Clear();
            Console.WriteLine 
           ("----------------------------");
           Console.WriteLine
           ("|           SAQUE          |");
           Console.WriteLine 
           ("----------------------------");
           Console.Write("Digite o número da conta: ");
           int indiceConta = int.Parse(Console.ReadLine());

           Console.Write("Digite o valor: ");
           double valorSaque = double.Parse(Console.ReadLine());

           ListContas[indiceConta].Sacar(valorSaque);
        }

        private static void transferencia()
        {
            Console.Clear();
            Console.WriteLine 
           ("----------------------------");
           Console.WriteLine
           ("|        TRANSFERÊNCIA     |");
           Console.WriteLine 
           ("----------------------------");
           Console.Write("Digite o número da conta origem: ");
           int indiceContaOriogem = int.Parse(Console.ReadLine());

           Console.Write("Digite o número da conta origem: ");
           int indiceContaDestino = int.Parse(Console.ReadLine());

           Console.Write("Digite o valor da transferência: ");
           double ValorTransferencia = double.Parse(Console.ReadLine());

           ListContas[indiceContaOriogem].Transferir(ValorTransferencia, ListContas[indiceContaDestino]);


        }

        private static void CadastrarContas()
        {
           Console.Clear();
           Console.WriteLine 
           ("----------------------------");
           Console.WriteLine
           ("|      CADASTRAR CONTA     |");
           Console.WriteLine 
           ("----------------------------");
            Console.WriteLine();
             Console.Write("Tipo de conta: (1)Física  (2)Jurídica: " );
             int entradaTipoConta = int.Parse(Console.ReadLine());

            Console.WriteLine();
             Console.Write("Nome do Cliente: ");
             string entradaNome = Console.ReadLine();

            Console.WriteLine();
             Console.Write("Saldo Inicial: ");
             double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine();
             Console.Write("limite de Crédito: ");
             double entradaCredito = double.Parse(Console.ReadLine());

             Conta novaConta = new Conta(TipoConta:(TipoConta)entradaTipoConta,
             saldo: entradaSaldo, credito: entradaCredito, nome: entradaNome);
             ListContas.Add(novaConta);
             
        }

        private static void ListarContas()
        {  
            Console.Clear();
            Console.WriteLine 
           ("----------------------------");
           Console.WriteLine
           ("|      LISTAR  CONTAS      |");
           Console.WriteLine 
           ("----------------------------");

                 
          if(ListContas.Count ==0) {
              Console.WriteLine("Contas não cadastradas !!");
              Console.ReadLine();
              return;
          } else
          {
            Console.WriteLine("Total de Contas Cadastradas: {0}",ListContas.Count);
          for (int i = 0; i < ListContas.Count; i++) {
              Conta conta = ListContas[i];
              Console.Write("Numero da conta: {0} ",i );
              Console.WriteLine(conta);
          }
          Console.ReadLine();
          }
        }

        private static string ObterOpcaoUsuario()
        
        {
            Console.Clear();
            Console.WriteLine
            ("------------------------------------------");
            Console.WriteLine
            ("| Tavares Filho Bank - Sempre Com Você ! |");
            Console.WriteLine
            ("------------------------------------------");
            Console.WriteLine
            ("| listar Conta.........................1 |");
            Console.WriteLine
            ("| Cadastrar Conta......................2 |");
            Console.WriteLine
            ("| Realizar Transferência...............3 |");
            Console.WriteLine
            ("| Sacar................................4 |");
            Console.WriteLine
            ("| depósito.............................5 |");
            Console.WriteLine
            ("| Encerrar.............................X |");
            Console.WriteLine
            ("------------------------------------------");
            Console.Write
            (" Escolha sua Opção.....................");
            string opcaoUsuario = Console.ReadLine().ToUpper();
             return opcaoUsuario;
            
            }
        }    
    }
    