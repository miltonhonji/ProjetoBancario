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
            Model.CurrentAccount currentAccount = new Model.CurrentAccount();
            Model.CurrentAccount destinationAccount = new Model.CurrentAccount();

            currentAccount.Agency = 1207;
            currentAccount.AccountNumber = "180386-6";
            currentAccount.BankCode = 36;
            var nameCustomer = "Milton Honji";
            decimal balanceValue = 15000m;

            try
            {
                Console.Clear();

                Console.WriteLine($"Olá { nameCustomer } ");
                Console.WriteLine($"Número da Agência: { currentAccount.Agency }");
                Console.WriteLine($"Número da Conta: { currentAccount.AccountNumber }");
                Console.WriteLine($"Você está na agência com o código: { currentAccount.BankCode }");

                Console.WriteLine();
                Console.WriteLine("Conta Corrente - Opção Transferência");
                Console.WriteLine();

                Console.WriteLine("Digite o número da agência: ");
                destinationAccount.Agency = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o número da conta: ");
                destinationAccount.AccountNumber = Console.ReadLine();
                Console.WriteLine("Digite o valor que será transferido: ");
                decimal valueTransfer = decimal.Parse(Console.ReadLine());
                
                Console.Clear();
                Console.WriteLine("Dados para a transferência: ");
                
                Console.WriteLine();
                Console.WriteLine($"Número da Agência: { destinationAccount.Agency } ");
                Console.WriteLine($"Número da Conta: { destinationAccount.AccountNumber } ");
                Console.WriteLine($"Valor para a transferência: { valueTransfer.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))} ");
                
                Console.WriteLine();
                Console.WriteLine("Deseja efetuar a transferência?");
                Console.WriteLine("1 - Sim");
                Console.WriteLine("2 - Não");
                int transferOption = int.Parse(Console.ReadLine());

                switch (transferOption)
                {
                    case 1: 
                        if(valueTransfer <= balanceValue)
                        {
                            Console.Clear();
                            Console.WriteLine("Transferência efetuada com sucesso!");
                            Console.ReadKey();
                        }
                        else if(valueTransfer > balanceValue)
                        {
                            Console.Clear();
                            Console.WriteLine("Saldo para transferência indisponível!");
                            Console.ReadKey();
                        }
                    break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Operação não realizada!");
                        Console.ReadKey();
                    break;
                }

                Console.Clear();
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public void WithdrawOperation()
        {
            Model.CurrentAccount currentAccount = new Model.CurrentAccount();
            
            currentAccount.Agency = 1207;
            currentAccount.AccountNumber = "180386-6";
            currentAccount.BankCode = 36;
            var nameCustomer = "Milton Honji";
            decimal balanceValue = 15000m;

            try
            {
                Console.Clear();

                Console.WriteLine($"Olá { nameCustomer } ");
                Console.WriteLine($"Número da Agência: { currentAccount.Agency }");
                Console.WriteLine($"Número da Conta: { currentAccount.AccountNumber }");
                Console.WriteLine($"Você está na agência com o código: { currentAccount.BankCode }");
                
                Console.WriteLine();
                Console.WriteLine("Conta Corrente - Opção Saque");
                Console.WriteLine();
                Console.WriteLine("Digite o valor para o saque");
                decimal withDrawValue = decimal.Parse(Console.ReadLine());

                if(withDrawValue <= balanceValue)
                {
                    balanceValue -= withDrawValue;
                    Console.WriteLine("Aguarde conta as notas");
                    Thread.Sleep(2000);
                    
                    Console.Clear();
                    Console.WriteLine("Operação realizada com sucesso");
                    Console.ReadKey();
                    
                    Console.Clear();
                    Console.WriteLine("Deseja fazer uma outra operação: ");
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
                else if(withDrawValue > balanceValue)
                {
                    Console.WriteLine("Você não tem saldo suficiente para sacar. Verifique sua conta");
                }
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                 Console.WriteLine(ex.Message);
            }
        }
    }
}