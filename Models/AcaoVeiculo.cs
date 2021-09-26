using System;

namespace EstacionaAki.Models
{
    public class AcaoVeiculo
    {
    private Motorista motorista;
    public Motorista getMotorista() {return motorista;}
	public void setMotorista(Motorista motorista)
    {this.motorista = motorista;}

    public string local { get; set;}
    //public DateTime entrada { get; set; }

    private DateTime Entrada;
	public DateTime getEntrada() {return Entrada;}
	public void setEntrada(DateTime Entrada) {this.Entrada = Entrada;	}

    private DateTime Saida;
    public DateTime getSaida(){ return Saida;}
    public void setSaida(DateTime Saida){ this.Saida = Saida;}

    private Veiculo veiculo;
	public Veiculo getVeiculo() {return veiculo;}
	public void setVeiculo(Veiculo veiculo)
     {this.veiculo = veiculo;}
    }
}