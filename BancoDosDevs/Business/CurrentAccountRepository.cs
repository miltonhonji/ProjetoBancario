using System;
using System.Globalization;
using BancoDosDevs.Model;
using BancoDosDevs.Business.Contract;

namespace BancoDosDevs.Business
{
    public class CurrentAccountRepository : ICurrentAccountRepository
    {
        public void DepositOperation()
        { 
            try
            {
                Model.CurrentAccount currentAccount = new Model.CurrentAccount();
                Model.CurrentAccount destinationAccount = new Model.CurrentAccount();

                Console.Clear();
            
                Console.WriteLine("Conta Corrente - Opção Depósito");
                Console.WriteLine();

                Console.WriteLine("Digite o Número da Agência: ");
                destinationAccount.Agency = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o Número da Conta:");
                destinationAccount.AccountNumber = Console.ReadLine();

                Console.WriteLine("Digite o valor para depósito: ");
                var depositAmount = decimal.Parse(Console.ReadLine());

                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("Dados para o Depósito");
                Console.WriteLine();
                Console.WriteLine($"Número da Agência: { destinationAccount.Agency }");
                Console.WriteLine($"Número da Conta: { destinationAccount.AccountNumber }");
                Console.WriteLine($"Valor para Depósito: { depositAmount.ToString("C", CultureInfo.CreateSpecificCulture("pt-br")) }");
            
                Console.WriteLine("Deseja Confirmar o depósito: ");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int depositConfirm = int.Parse(Console.ReadLine());

                switch (depositConfirm)
                {
                    case 1: 
                        int initialDepositTime = 0;
                        int finalDepositTime = 10;
                        Console.Clear();
                        Console.WriteLine("Insira o seu envelope preenchido");

                        while(finalDepositTime >= initialDepositTime)
                        {
                            initialDepositTime += initialDepositTime + 1;
                            Console.WriteLine($"Depositando. Aguarde { initialDepositTime } segundos ");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Depósito realizado com sucesso!");
                            Console.WriteLine("Deseja fazer outra operação? ");
                            Console.WriteLine("1 - Sim");
                            Console.WriteLine("2 - Não");
                            int otherOperation = int.Parse(Console.ReadLine());
                        
                            switch (otherOperation)
                            {
                                case 1: 
                                    Console.Clear();
                                    Program.Menu(); 
                                break;
                                case 2: 
                                    Console.Clear();
                                    Console.WriteLine("Obrigado por usar os nossos Serviços");
                                    System.Environment.Exit(1);
                                break;
                            }
                            Console.ReadKey();
                        }

                    break;
                }
            
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }                
        }

        public List<CurrentAccount> GetExtract()
        {
            throw new NotImplementedException();
        }

        public void TakeOutInsurance(string bankCode)
        {
            throw new NotImplementedException();
        }

        public void TransferOperation()
        {
            throw new NotImplementedException();
        }

        public void WithdrawOperation()
        {
            //Model.
        }
    }
}