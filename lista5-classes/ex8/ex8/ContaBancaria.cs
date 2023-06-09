﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ex8
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) : this(numero, titular) 
        {
            Depositar(depositoInicial);
        }

        public void Depositar(double quantia)
        {
            Saldo += quantia;
        }

        public void Sacar(double quantia)
        {
            Saldo -= quantia;
            Saldo -= 5;
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular: "
            + Titular 
            + ", Saldo: R$" 
            + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
