// See https://aka.ms/new-console-template for more information
using System;


namespace MeuPrimeiroProjeto
{
    class Program
    {
     static void Main(string[] args)
        {
         //    string Titular1 = "Sabruxa";
         //    int Agencia1 = 666;
         //    int Numero1 = 666;
         //    double Saldo1 = 311;

         //    string Titular2 = "Naiga";
         //    int Agencia2 = 636;
         //    int Numero2 = 663;
         //    double Saldo2 = 611;

         // // 1° Modo de fazer:
         //    Console.WriteLine("Titular: " + Titular1);
         //    Console.WriteLine("Agencia: " + Agencia1);
         //    Console.WriteLine("Numero: " + Numero1);
         //    Console.WriteLine("Saldo: " + Saldo1);

         // // 2° Modo de fazer:
         //    Console.WriteLine("Conta: " + Titular1 + " " + Numero1);
         //    Console.WriteLine("Conta: " + Titular2 + " " + Numero2);




         // // 3° Modo de fazer:
         //    ContaCorrente conta_do_Joao = new ContaCorrente (); // Variável(conta_do_Joao) do tipo conta corrente
         //       conta_do_Joao.Titular= "João Francisco";
         //       conta_do_Joao.Agencia= 123434;
         //       conta_do_Joao.Numero=0909;
         //       conta_do_Joao.Saldo=66602323;
         //       Console.WriteLine("A conta é do (a) " + conta_do_Joao.Titular + ", sua agência é a " + conta_do_Joao.Agencia + " e seu número é " 
         //       + conta_do_Joao.Numero + ".");
         //       //A conta é do (a) João Francisco, sua agência é a 123434 e seu número é 0909.


         //    ContaCorrente conta_da_Isado = new ContaCorrente (); 
         //       conta_da_Isado.Titular= "Isado Rafaela";
         //       conta_da_Isado.Agencia= 66666;
         //       conta_da_Isado.Numero=1610;
         //       conta_da_Isado.Saldo=0;
         //       Console.WriteLine("A conta é do (a) " + conta_da_Isado.Titular + ", sua agência é a " + conta_da_Isado.Agencia + " e seu número é " 
         //       + conta_da_Isado.Numero + ".");


         //    ContaCorrente conta_da_Yasmin = new ContaCorrente ();
         //       conta_da_Yasmin.Titular= "Yasmona Leite";
         //       conta_da_Yasmin.Agencia= 000001;
         //       conta_da_Yasmin.Numero=1211231;
         //       conta_da_Yasmin.Saldo=0;
         //       Console.WriteLine("A conta é do (a) " + conta_da_Yasmin.Titular + ", sua agência é a " + conta_da_Yasmin.Agencia + " e seu número é " 
         //       + conta_da_Yasmin.Numero + ".");

               ContaCorrente conta_da_Barbie = new ContaCorrente ("Barbie", 12321312, 212122, 98765);
               ContaCorrente conta_da_Lupita = new ContaCorrente ("Lupita DeLayla", 654323, 123456, 09874);
               ContaCorrente conta_da_Greiba = new ContaCorrente ("Greiba Keka", 4322235, 6543234, 345678);
                     
                     Console.WriteLine("A conta é do (a) " + conta_da_Barbie.Titular + ", sua agência é a " + conta_da_Barbie.Agencia + " e seu número é " 
                     + conta_da_Barbie.Numero + ".");
                     
                     Console.WriteLine("A conta é do (a) " + conta_da_Lupita.Titular + ", sua agência é a " + conta_da_Lupita.Agencia + " e seu número é " 
                     + conta_da_Lupita.Numero + ".");

                     Console.WriteLine("A conta é do (a) " + conta_da_Greiba.Titular + ", sua agência é a " + conta_da_Greiba.Agencia + " e seu número é " 
                     + conta_da_Greiba.Numero + ".");
              
        }
    }
}


