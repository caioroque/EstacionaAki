using System.Collections.Generic;

namespace EstacionaAki.Models
{
    public class MarcaVeiculo
    {
        public MarcaVeiculo() {
		setModeloveiculo(new List<ModeloVeiculo>());
	}

    public string NomeMarca { get; set;}
    private List<ModeloVeiculo> modelos;

    public void setModeloveiculo(List<ModeloVeiculo> modelos) {
			this.modelos = modelos;
		}
        		/*@Override
		public String toString() {
			return "Marca:" + nome + "\nModelos:" + modelos + "\n------";
		}*/
    }
}