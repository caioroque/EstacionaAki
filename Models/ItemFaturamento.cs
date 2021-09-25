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
    }
}