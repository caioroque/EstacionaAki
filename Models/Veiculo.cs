using System;

namespace EstacionaAki.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa;
        public string getPlaca(){ return Placa;}
        public void setPlaca(string Placa){ this.Placa = Placa;}
        public string Cor { get; set; }
        //private ModeloVeiculo modelo;
        public string ModeloVeiculo { get; set; }
    }
}