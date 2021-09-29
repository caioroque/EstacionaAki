using System;
using System.Collections.Generic;
using System.Linq;
using EstacionaAki.Data;
using EstacionaAki.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstacionaAki.Controllers
{
    [ApiController]
        
    [Route("ESTACIONAAKI/vaga")]
    public class VagaController : ControllerBase
    {
        private static List<VagaEstacionamento> estacionamento = new List<VagaEstacionamento>();

        public static List<VagaEstacionamento> getEstacionamento() {
		return estacionamento;
	    }

        private readonly DataContext _context;
        public VagaController(DataContext context)
        {
            _context = context;
        }

        //POST: ESTACIONAAKI/vaga/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]VagaEstacionamento vaga)
        {
            _context.Vagas.Add(vaga);
            _context.SaveChanges();
            return Created("", vaga);
        }

                //GET: ESTACIONAAKI/vagas/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Vagas.ToList());

        //GET: ESTACIONAAKI/vagas/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            VagaEstacionamento vaga = _context.Vagas.Find(id);
            if (vaga == null)
            {
                return NotFound();
            }
            return Ok(vaga);
        }

        //PUT: ESTACIONAAKI/vaga/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] VagaEstacionamento vaga)
        {
            _context.Vagas.Update(vaga);
            _context.SaveChanges();
            return Ok(vaga);
        }

        //DELETE: /ESTACIONAAKI/vaga/delete/id
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //Expressão lambda
            //Buscar um objeto na tabela de motoristas com base no nome
            VagaEstacionamento vaga = _context.Vagas.FirstOrDefault(vaga => vaga.Id == id);

            if (vaga == null)
            {
                return NotFound();
            }
            _context.Vagas.Remove(vaga);
            _context.SaveChanges();
            return Ok(_context.Vagas.ToList());
        }
        /*
        //NÃO ESTÁ FUNCIONANDO ESSE METODO
        //buscar veiculo pela placa
        //GET: ESTACIONAAKI/vagas/darEntrada
        [HttpGet]
        [Route("darEntrada/{id}")]
        public IActionResult darEntrada([FromRoute] int Id)
        {
            Motorista motorista = _context.Motoristas.Find(Id);
            Veiculo veiculo = _context.Veiculos.Find(Id);
            VagaEstacionamento vaga = _context.Vagas.Find(Id);

            vaga.setEntrada(new System.DateTime());
            return Ok(_context.Vagas.ToList());
        }

        //buscar veiculo pela placa
        //GET: ESTACIONAAKI/vagas/saida
       /* [HttpGet]
        [Route("saida")]
        public static ItemFaturamento saida(Veiculo veiculo)
		{
			foreach (VagaEstacionamento vagaExiste in estacionamento)
			{
				if (vagaExiste.getVeiculo().getPlaca().Equals(veiculo.getPlaca()))
				{
					vagaExiste.setSaida(DateTime.Now);
					ItemFaturamento fatura = FaturamentoController.calcular(vagaExiste);
					//vagaExiste.setEntrada(DateTime.Now); como setar a data em que foi feita a entrada
					vagaExiste.setMotorista(null);
					vagaExiste.setVeiculo(null);
					vagaExiste.setStatus(false);
					return fatura;
				}
			}
			return null;
		}

        [HttpGet]
        [Route("saida")]
        public static ItemFaturamento saida(string local)
		{
			VagaEstacionamento vaga = VagaController.(local);
			Console.WriteLine(local + "\n####\n" + vaga);
			if (vaga != null)
			{
				if (vaga.getStatus())
				{
					vaga.setSaida(DateTime.Now);
					ItemFaturamento fatura = FaturamentoController.calcular(vaga);
					//vagaExiste.setEntrada(DateTime.Now); como setar a data em que foi feita a entrada
					vaga.setMotorista(null);
					vaga.setVeiculo(null);
					vaga.setStatus(false);
					return fatura;
				}
			}
			return null;
		}
*/
        //buscar veiculo 
        //GET: ESTACIONAAKI/vagas/BuscarVeiculo/1
        [Route("getveiculo/{id}")]
        [HttpGet]
        public IActionResult GetVeiculo([FromRoute] int id)
        {
            Veiculo veiculo = _context.Veiculos.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }
            return Ok(veiculo);
        }
    }
}
