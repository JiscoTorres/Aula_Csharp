public class ContaCorrente // Classe sempre tem "Modificador de acesso" "class" "Nome"
{
            public string Titular; //Atributos sempre vem logo após que as chaves foram abertas
            public  int Agencia; // Atributos tem "modificador de acesso" "tipo" "nome"
            public int Numero;
            public double Saldo;         


public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo){ // Construtor
            this.Titular = Titular;
            this.Agencia = Agencia;
            this.Numero =  Numero; 
            this.Saldo =  Saldo;
}

      public bool Sacar(double ValorSaque){ // É um método!
                if (this.Saldo >= ValorSaque){
                    this.Saldo = this.Saldo - ValorSaque;
                    return true;
                }
                return false;
              }
}
// int, string, double, float são "atributos"!


// CLasse seria a "forma" do bolo.

// C# oferece a possibilidade de termos classes públicas e privadas.
    //Classes Públicas (public class): 
    //Classes Privadas (private class): 