using System.Collections.Generic;

namespace EstacionaAki.Models
{
    public class MarcaVeiculo
    {
      /*  public MarcaVeiculo() {
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

		public int Id { get; set; }

		public MarcaVeiculo()
		{
			Modeloveiculo = new List<ModeloVeiculo>();
		}

		private string nome;
			public virtual string Nome
			{
				get
				{
					return nome;
				}
				set
				{
					this.nome = value;
				}
			}

			//private ModeloVeiculo modelos;
			private List<ModeloVeiculo> modelos;
			public virtual List<ModeloVeiculo> Modelos
			{
				get{return modelos;}
			}

			public virtual List<ModeloVeiculo> Modeloveiculo
			{
				set
				{
					this.modelos = value;
				}
			}

			public override string ToString()
			{
				return "Marca:" + nome + "\nModelos:" + modelos + "\n------";
			}
    }
}