using System;
namespace Treinamento_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            double valor;
            Console.WriteLine("Qual tipo de conta deseja instanciar...:");
            Console.WriteLine("1-Conta Corrente, 2-Conta Poupança, 3-Conta Investimento");
            entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada == 1)
            {
                ContaCorrente conta01 = new ContaCorrente();
                conta01.AbrirConta();
                while (entrada != 0)
                {
                    Console.WriteLine("Qual operacao deseja realizar");
                    Console.WriteLine("1-Consultar Saldo, 2-Depositar, 3-Sacar, 4-Transferir, 0-Sair");
                    entrada = Convert.ToInt32(Console.ReadLine());
                    if (entrada == 1)
                    {
                        conta01.ConsultaSaldo();
                    }
                    else if (entrada == 2)
                    {
                        Depositar(conta01);
                    }
                    else if (entrada == 3)
                    {
                        Console.WriteLine("Digite o valor que deseja sacar...:");
                        valor = Convert.ToDouble(Console.ReadLine());
                        conta01.Sacar(valor);
                    }
                    else if (entrada == 4)
                    {
                        Transferir(conta01);
                    }
                }
            }
            else if (entrada == 2) {
                
                ContaPoupanca conta02 = new ContaPoupanca();
                conta02.AbrirConta();
                while (entrada != 0)
                {
                    Console.WriteLine("Qual operacao deseja realizar");
                    Console.WriteLine("1-Consultar Saldo, 2-Depositar, 3-Transferir, 4-Aplicar, 0-Sair");
                    entrada = Convert.ToInt32(Console.ReadLine());
                    if (entrada == 1)
                    {
                        conta02.ConsultaSaldo();
                    }
                    else if (entrada == 2)
                    {
                        Depositar(conta02);
                    }
                    else if (entrada == 3)
                    {
                        Transferir(conta02);
                        
                    }
                    else if (entrada == 4)
                    {
                        int tempo;
                        double juros;

                        Console.WriteLine("Valor a ser Aplicado...:");
                        valor  = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Tempo a ser Aplicado...:");
                        tempo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Juros a serem Aplicado...:");
                        juros = Convert.ToDouble(Console.ReadLine());
                        conta02.Aplicar(valor,tempo,juros);
                    }
                }
            }
            else if (entrada == 3)
            {

                ContaInvestimento conta03 = new ContaInvestimento();
                conta03.AbrirConta();
                while (entrada != 0)
                {
                    Console.WriteLine("Qual operacao deseja realizar");
                    Console.WriteLine("1-Consultar Saldo, 2-Depositar, 3-Transferir, 4-Aplicar, 0-Sair");
                    entrada = Convert.ToInt32(Console.ReadLine());
                    if (entrada == 1)
                    {
                        conta03.ConsultaSaldo();
                    }
                    else if (entrada == 2)
                    {
                        Depositar(conta03);
                    }
                    else if (entrada == 3)
                    {
                        Transferir(conta03);


                    }
                    else if (entrada == 4)
                    {
                        int tempo;
                        double juros;

                        Console.WriteLine("Valor a ser Aplicado...:");
                        valor = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Tempo a ser Aplicado...:");
                        tempo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Juros a serem Aplicado...:");
                        juros = Convert.ToDouble(Console.ReadLine());
                        conta03.Aplicar(valor, tempo, juros);


                    }
                }
            }
        }
        public static void Depositar(ContaBancaria conta)
        {
            Console.WriteLine("Digite o valor a ser depositado...:");
            double valor = Convert.ToDouble(Console.ReadLine());
            conta.Depositar(valor);
        }
        public static void Transferir(ContaBancaria conta)
        {
            Console.WriteLine("Digite o valor e a conta para qual deseja transferir...:");
            double valor = Convert.ToDouble(Console.ReadLine());
            ContaBancaria contaTransferencia = null;
            Console.WriteLine("infome o tipo da conta para qual deseja transferir");
            Console.WriteLine("1-Conta Corrente, 2-Conta Poupança, 3-Conta Investimento");

            int entrada = Convert.ToInt32(Console.ReadLine());
            if (entrada == 1)
            {
                contaTransferencia = new ContaCorrente();
                contaTransferencia.AbrirConta();
            }
            if (entrada == 2)
            {
                contaTransferencia = new ContaPoupanca();
                contaTransferencia.AbrirConta();
            }
            if (entrada == 3)
            {
                contaTransferencia = new ContaInvestimento();
                contaTransferencia.AbrirConta();
            }
            conta.Transferir(valor, contaTransferencia);
        }
    }
}