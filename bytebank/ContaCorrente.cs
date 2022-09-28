using bytebank.Titular;
using System.Globalization;

namespace bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }     
        
        public string Conta
        {
            get { return _conta; }
            set { if (value == null) { return; } else { _conta = value; } }
        }        
        public int NumAgencia { 
        get { return _numAgencia; }
            set { if(value<= 0) { } _numAgencia = value; }
        }
        public string NomeAgencia { get; set; }
        private double Saldo;



        private string _conta;
        private int _numAgencia;



        public ContaCorrente(int numAgencia, string conta)
        {
            NumAgencia = numAgencia;
            Conta = conta;
            TotalDeContasCriadas++;
        }

        public ContaCorrente(Cliente titular, string conta, int numAgencia, string nomeAgencia, double saldo)
        {
            Titular = titular;
            Conta = conta;        
            NumAgencia = numAgencia;           
            NomeAgencia = nomeAgencia;
            Saldo = saldo;
            TotalDeContasCriadas++;
            
        }

        public static int TotalDeContasCriadas { get; set; }
        public double saldo
        {
            get
            {
                return Saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    Saldo += value;
                }
            }
        }       

        public bool Sacar(double valor)
        {
            if (valor < 0)
            {
                return false;
            }
            else if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {

            }
            else
            {
                saldo += valor;

            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else if (valor < 0)
            {
                return false;

            }
            else
            {
                saldo -= valor;
                destino.saldo += valor;
                return true;
            }
        }

        public void ExibirDadosDaConta()
        {
            Console.WriteLine("Titular :" + Titular);
            Console.WriteLine("Conta :" + Conta);
            Console.WriteLine("Número Agência :" + NumAgencia);
            Console.WriteLine("Nome Agência :" + NomeAgencia);
            Console.WriteLine("Saldo: " + saldo);
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + ", Titular:"
                + Titular.Nome
                + ", CPF:"
                + Titular.Cpf
                + ", Profissão:"
                + Titular.Profissao
                + ", Saldo: R$"
                + saldo.ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}