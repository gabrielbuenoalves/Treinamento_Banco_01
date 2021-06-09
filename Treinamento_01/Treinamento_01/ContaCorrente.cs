using System;
using System.Collections.Generic;
using System.Text;

namespace Treinamento_01
{
    class ContaCorrente:ContaBancaria
    {
        public void Sacar(double valor)
        {
            if (SaldoSuficiente(valor))
            {             
                Saldo -= valor;
            }
        }
    }
}
