using System.Linq;
using EstacionaAki.Data;
using EstacionaAki.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstacionaAki.Controllers
{
    [ApiController]
        
    [Route("ESTACIONAAKI/veiculo")]
    public class VeiculoController : ControllerBase
    {
        private readonly DataContext _context;
        public VeiculoController(DataContext context)
        {
            _context = context;
        }

        //POST: ESTACIONAAKI/veiculo/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            _context.SaveChanges();
            return Created("", veiculo);
        }

        //GET: ESTACIONAAKI/veiculo/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Veiculos.ToList());

        //GET: ESTACIONAAKI/veiculo/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Veiculo veiculo = _context.Veiculos.Find(id);
            if (veiculo == null)
            {
                return NotFound();
            }
            return Ok(veiculo);
        }

        //DELETE: /ESTACIONAAKI/veiculo/delete/bolacha
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            //Expressão lambda
            //Buscar um objeto na tabela de motoristas com base no nome
            Veiculo veiculo = _context.Veiculos.FirstOrDefault(veiculo => veiculo.Placa == name);

            if (veiculo == null)
            {
                return NotFound();
            }
            _context.Veiculos.Remove(veiculo);
            _context.SaveChanges();
            return Ok(_context.Veiculos.ToList());
        }

        //PUT: ESTACIONAAKI/motorista/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
            return Ok(veiculo);
        }
    }
}