using System.Collections.Generic;
using System.Linq;
using EstacionaAki.Data;
using EstacionaAki.Models;
using Microsoft.AspNetCore.Mvc;


namespace EstacionaAki.Controllers
{
    using Marca = Models.MarcaVeiculo;
    using ModeloVeiculo = Models.ModeloVeiculo;

    [ApiController]
        
    [Route("ESTACIONAAKI/marca")]
    public class MarcaController : ControllerBase
    {
        private readonly DataContext _context;
        public MarcaController(DataContext context)
        {
            _context = context;
        }

        private static List<Marca> marcas = new List<Marca>();

        public static List<Marca> Marcas
		{
			get {return marcas;}
		}

    
        //POST: ESTACIONAAKI/marca/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Marca marca)
        {
            _context.Marcas.Add(marca);
            _context.SaveChanges();
            return Created("", marca);
        }

        //GET: ESTACIONAAKI/marca/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Marcas.ToList());

        //GET: ESTACIONAAKI/marca/getbyid/id
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            MarcaVeiculo marca = _context.Marcas.Find(id);
            if (marca == null)
            {
                return NotFound();
            }
            return Ok(marca);
        }

        //DELETE: /ESTACIONAAKI/marca/delete/nome da marca
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            //Expressão lambda
            //Buscar um objeto na tabela de motoristas com base no nome
            MarcaVeiculo marca = _context.Marcas.FirstOrDefault(marca => marca.Nome == name);

            if (marca == null)
            {
                return NotFound();
            }
            _context.Marcas.Remove(marca);
            _context.SaveChanges();
            return Ok(_context.Marcas.ToList());
        }

        
        //tras o modelo do carro pelo Id
        //GET: ESTACIONAAKI/marca/getbyid/1
        [HttpGet]
        [Route("getmodeloid/{id}")]
        public IActionResult Getmodelobyid([FromRoute] int id)
        {
            ModeloVeiculo modelo = _context.Modelos.Find(id);
            if (modelo == null)
            {
                return NotFound();
            }
            return Ok(modelo);
        }
    }
}