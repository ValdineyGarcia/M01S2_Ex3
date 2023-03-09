using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2Exercicio3
{
    public class MensagemCelular
    { 
        public int Telefone { get; set; }
        public string Mensagem { get; set; }

       
        public MensagemCelular(int telefone, string mensagem) 
        {
        Telefone = telefone;
        Mensagem = mensagem;

        }
        public void Executar()
        {
            Console.WriteLine("Método Executado pelo console.");
            EnviarMensagemAoTelefone();
        }
        private void EnviarMensagemAoTelefone()
        {
            Console.WriteLine("Método privado executado na classe.");
            Console.WriteLine($"Telefone: {Telefone}, Mensagem: {Mensagem}.");
        }
    }
}

