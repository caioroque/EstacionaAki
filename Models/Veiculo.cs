using System;

namespace EstacionaAki.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        //private ModeloVeiculo modelo;
        public string ModeloVeiculo { get; set; }
    }
}