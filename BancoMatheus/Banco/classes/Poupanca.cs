using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{
    class Poupanca : Conta
    {
        public Poupanca(Cliente cliente, int numero, decimal saldo)
           : base( cliente,  numero,  saldo)
        {

        }    
        public override bool Depositar(decimal ValorDepositar)
        {
            if(ValorDepositar <= 0 )
            {
                Mensaguemtrans = $"O valor do deposito é invalido !";
                return false;
            }
            Saldo += (ValorDepositar + 0.5m);
            Mensaguemtrans = $"Depositado com sucesso";
            return true;
        }      

        public override bool Sacar(decimal ValorSaque)
        {

            var tirar = 0.10m;
            if(Saldo <= 0m)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Mensaguemtrans = $"Saldo da conta negativo ou zerado";
                throw new System.Exception("Saldo Insuficiente");
               
            }
            

            if (Saldo < ValorSaque)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Mensaguemtrans = $"Valor indisponivel para saque, valor na conta =R${Saldo}";
                throw new System.Exception("Saldo Insuficiente");
            }

            if (Saldo == ValorSaque)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Mensaguemtrans = $"Voce não pode retirar todo o saldo da sua conta";
                throw new System.Exception("Voce não pode retirar todo o saldo da sua conta já que tem uma tarifa a ser paga");
            }
            Saldo -= (ValorSaque + tirar);
            Console.WriteLine($"Saque de R${ValorSaque} realizado com sucesso para a conta de {Cliente.Nome}");
            Console.ForegroundColor = ConsoleColor.Green;
            Mensaguemtrans = "Saque realizado com sucesso";
                return true;
                
                
        }
    }
}
