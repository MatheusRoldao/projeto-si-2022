using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.classes
{
    public abstract class Conta
    {


        public Conta(Cliente cliente, int numero , decimal saldo)
        {
           
            {
                if (!cliente.ValidarIdade())
                    throw new Exception("Cliente menor de 18 anos");

                if (numero.ToString().Length < 5)
                    throw new Exception("Numero da conta invalido");
                Cliente = cliente;
                Numero = numero;
                Saldo = saldo;
            }
        }

        private decimal _saldo;
        public int Numero { get; private set; }

        public Cliente Cliente { get; private set; }
        public string Mensaguemtrans { get; set; }

        
        public decimal Saldo
        {
            get { return _saldo; }
            protected set
            {
                if (value >= 0)
                {
                    _saldo = value;
                }
                else
                {
                    _saldo = 0;
                }
            }
        }
        public abstract bool Sacar(decimal ValorSaque);
        public abstract bool Depositar(decimal ValorDepositar);

      
        public  void Trasferir (decimal valor, Conta destino)
        {
           var controle = 0;
            var SucessoTrasacaoSaque = Sacar(valor);
            var SucessoTransacaoDeposito = destino.Depositar(valor);
            Console.WriteLine($"Transferindo da conta {Cliente.Nome} para {destino.Cliente.Nome} o valor R${valor} ");       
                    
           
            if(SucessoTrasacaoSaque && SucessoTransacaoDeposito)
            {
                Mensaguemtrans = "Transferencia Realizada com sucesso";
            }
            Mensaguemtrans = "Transacao nao realizada";



        }


    }
}