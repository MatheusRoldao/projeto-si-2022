using System;
using Banco.classes;


namespace Banco
{
    class Program
    {
        static void Main(string[] args)
        {
           try
            {
                string linha = "----------------------------------------------------------------------------------------";
                var s = new Spinning("teweststtststs");
                int i = 0;
                do
                {
                    
                    System.Threading.Thread.Sleep(100); // simulate some work being done
                    s.UpdateProgress();
                    i++;
                }
                while (i <= 15);
                

                int mydelay = 4000;
                int mydelayfast = 1000;
                Cliente kaique = new Cliente();

                System.Console.WriteLine($"Criando Clientes...");               
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                do
                {

                    System.Threading.Thread.Sleep(100); // simulate some work being done
                    s.UpdateProgress();
                    i++;
                }
                while (i <= 15);


                var ClienteMatheus = Cliente.CreateCliente("Matheus", "Av Lucrecia ranalli corsi nº20", 19997301673, "123.453.548-56", new DateTime(2003, 03, 23));
                Console.WriteLine(ClienteMatheus.ToString());
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();
                System.Console.WriteLine("Estamos trabalhando nisso...");
                System.Threading.Thread.Sleep(mydelay);


                
                var ClienteIsabela = Cliente.CreateCliente("Isabela", "rua Ernesto loreto", 19997301673, "123.453.548-56", new DateTime(200, 03, 23));
                Console.WriteLine(ClienteIsabela.ToString());
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();
                Console.WriteLine("");

                System.Console.WriteLine($" Criando Poupança...");
                System.Threading.Thread.Sleep(mydelayfast);
                System.Console.Clear();
                System.Console.WriteLine("Realizando Transferencia...");
                System.Threading.Thread.Sleep(mydelay);
                System.Console.Clear();

                Conta ContaPoupancaMatheus = new Poupanca(ClienteMatheus, 12297, 1000);
                Console.WriteLine($" Saldo de Matheus = {ContaPoupancaMatheus.Saldo}");
                Conta ContaCorrenteIsabela = new Corrente(ClienteIsabela, 12297, 100);
                Console.WriteLine($"Saldo de Isabela = {ContaCorrenteIsabela.Saldo}");
                Console.WriteLine(linha);
              

                ContaPoupancaMatheus.Trasferir(1000, ContaCorrenteIsabela);
               
                System.Threading.Thread.Sleep(mydelay);


                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Isabela = {ContaCorrenteIsabela.Saldo}");
                Console.WriteLine($"Matheus = {ContaPoupancaMatheus.Saldo}");




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
               
            }
        }
    }
}
