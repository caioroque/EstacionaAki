using System.Linq;
using EstacionaAki.Data;
using EstacionaAki.Models;
using Microsoft.AspNetCore.Mvc;

namespace EstacionaAki.Controllers
{
    [ApiController]
        
    [Route("ESTACIONAAKI/modelo")]
    public class ModeloVeiculoController : ControllerBase
    {
        private readonly DataContext _context;
        public ModeloVeiculoController(DataContext context)
        {
            _context = context;
        }
    
        //POST: ESTACIONAAKI/modelo/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]ModeloVeiculo modelo)
        {
            _context.Modelos.Add(modelo);
            _context.SaveChanges();
            return Created("", modelo);
        }

        //GET: ESTACIONAAKI/marca/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Modelos.ToList());

        //GET: ESTACIONAAKI/modelo/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            ModeloVeiculo modelo = _context.Modelos.Find(id);
            if (modelo == null)
            {
                return NotFound();
            }
            return Ok(modelo);
        }

        //DELETE: /ESTACIONAAKI/motorista/delete/
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            //Expressão lambda
            //Buscar um objeto na tabela de motoristas com base no nome
            ModeloVeiculo modelo = _context.Modelos.FirstOrDefault(modelo => modelo.Id == id);

            if (modelo == null)
            {
                return NotFound();
            }
            _context.Modelos.Remove(modelo);
            _context.SaveChanges();
            return Ok(_context.Modelos.ToList());
        }

        //PUT: ESTACIONAAKI/modelo/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] ModeloVeiculo modelo)
        {
            _context.Modelos.Update(modelo);
            _context.SaveChanges();
            return Ok(modelo);
        }
    }
}