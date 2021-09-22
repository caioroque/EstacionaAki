using System;

namespace EstacionaAki.Models
{
    public class ItemFaturamento
    {
        public ItemFaturamento() => Sdf = DateTime.Now;
        private double Periodo { get; set; }
        private double Valor { get; set; }
        private DateTime Sdf { get; set; }
    }
}