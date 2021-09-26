using System;

namespace EstacionaAki.Models
{
    public class VagaEstacionamento : AcaoVeiculo
    {

	public int Id { get; set;}
    public VagaEstacionamento() {
		setStatus(false);
	}
	
	private Boolean status;
		public Boolean getStatus() {
			return status;
		}
		public void setStatus(Boolean status) {
			this.status = status;
		}
		

		/*
        @Override
        public String toString() {
			return "VAGA | Local: " + getLocal() + "; Status: " + getStatus() + "; Ocupante: " + getVeiculo();
		}*/
    }
}