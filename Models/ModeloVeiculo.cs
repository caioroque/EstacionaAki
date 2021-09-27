namespace EstacionaAki.Models
{
    public class ModeloVeiculo
    {
       // public ModeloVeiculo(){}
        public int Id { get; set; }
        public string Nome { get; set; }
        public string getNome(){ return Nome;}
        public void setNome(string Nome){ this.Nome = Nome;}
    }
}