using System;
using System.Collections.Generic;
using System.Text;
namespace Treinamento_01
{
    public class ContaBancaria
    {
        public string NomeDoBanco { get; set; }
        public int Agencia { get; set; }
        public int NumeroDaConta { get; set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; set; }
        public void AbrirConta(){
            Console.WriteLine("Digite o nome do Banco...:");
            NomeDoBanco = Console.ReadLine();
            Console.WriteLine("Digite o numero da agencia...:");
            Agencia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o numero da conta...:");
            NumeroDaConta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular...:");
            NomeTitular = Console.ReadLine();
            Saldo = 1000;
        }
        public void ConsultaSaldo() {
            Console.WriteLine("Seu saldo é...:"+Saldo);
        }
        public void Depositar(double valor) {
            Saldo += valor;
        }     
        public void Transferir(double valor,ContaBancaria contadestino)
        {
            if(SaldoSuficiente(valor))
            {
                Saldo -= valor;
                contadestino.Saldo += valor;
            }
        }
        protected bool SaldoSuficiente(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine("Saldo Insuficiente...");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
