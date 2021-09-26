using System;
using System.Collections.Generic;
using EstacionaAki.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstacionaAki.Controllers
{
    using ItemFaturamento = Models.ItemFaturamento;
	using VagaEstacionamento = Models.VagaEstacionamento;

    [ApiController]
        
    [Route("ESTACIONAAKI/fatura")]
    public class FaturamentoController : ControllerBase
    {

		public static double taxaHr = 1.0;
		private static List<ItemFaturamento> faturas = new List<ItemFaturamento>();

		public static List<ItemFaturamento> Faturas
		{
			get
			{
				return faturas;
			}
		}
/*
		public static List<ItemFaturamento> verFatMes(int mes, int ano)
		{
			List<ItemFaturamento> faturasMes = new List<ItemFaturamento>(), faturasAtual = Faturas;
				foreach (ItemFaturamento fat in faturasAtual)
				{
					if (ano == fat.().getYear() && mes == fat.getEntrada().getMonth())
					{
						faturasMes.Add(fat);
					}
				}
			return faturasMes;
		}


		public static ItemFaturamento calcular(VagaEstacionamento vaga)
		{
			ItemFaturamento item = new ItemFaturamento();
			long tempo = vaga.getSaida().getTime() - vaga.getEntrada().getTime();
			Console.WriteLine("Tempo long: " + tempo);
			tempo = TimeUnit.HOURS.convert(tempo, TimeUnit.MILLISECONDS);
			double periodo = (double) tempo;
			Console.WriteLine("periodo Double: " + periodo);
			item.setEntrada(vaga.getEntrada());
			item.setSaida(vaga.getSaida());
			item.setPeriodo(periodo);
			item.setLocal(vaga.getLocal());
			item.setMotorista(vaga.getMotorista());
			item.setVeiculo(vaga.getVeiculo());
			item.setValor(periodo * taxaHr);
			faturas.Add(item);
			return item;
		}*/

		public static void definirTaxa(double taxa)
		{
			taxaHr = taxa;
		}
	}
    }
