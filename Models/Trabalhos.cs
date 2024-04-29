using Eletricista.Models.Enuns;

namespace Eletricista.models
{

    public class Trabalho
    {

        public int Id { get; set; }

        public string NomeCliente { get; set;}

        public string Rua { get; set;}

        public int Endereço { get; set;}

        public double ValorTrabalho { get; set;}

        public ClasseEnum Classe{ get; set; }

    }
}