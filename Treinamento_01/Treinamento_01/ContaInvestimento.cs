using System;
using System.Collections.Generic;
using System.Text;
namespace Treinamento_01
{
    public class ContaInvestimento : ContaBancaria
    {
        public bool Aplicar(double valor, int tempo, double juros)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                Saldo += valor * (tempo * juros);
                return true;
            }
        }

    }
}