using System;

namespace EstacionaAki.Models
{
    public class ItemFaturamento
    {
        public ItemFaturamento() => Sdf = DateTime.Now;
        public int Id { get; set; }
        public double Periodo { get; set; }
        public double Valor { get; set; }
        public DateTime Sdf { get; set; }

        /*public override string ToString()
		{
			Locale.setDefault(new Locale("pt","Brazil"));
			return "Item | Estacionou em:" + Local + "\nPlaca:" + Veiculo.Placa + "\nValor cobrado:" + Valor + "\nMotorista:" + Motorista. + "\nTempo:" + Periodo + "\tEntrada:" + DateFormat.getDateTimeInstance(DateFormat.SHORT, DateFormat.MEDIUM).format(Entrada) + "\tSaida:" + DateFormat.getDateTimeInstance(DateFormat.SHORT, DateFormat.MEDIUM).format(Saida);
		}*/
    }
}