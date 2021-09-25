using System.Linq;
using EstacionaAki.Data;
using EstacionaAki.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace EstacionaAki.Controllers
{
    [ApiController]
        
    [Route("ESTACIONAAKI/motorista")]
    public class MotoristaController : ControllerBase
    {
        
        private readonly DataContext _context;
        public MotoristaController(DataContext context)
        {
            _context = context;
        }

        //POST: ESTACIONAAKI/motorista/create
        [HttpPost]
        [Route("create")]
        public IActionResult Create([FromBody]Motorista motorista)
        {
            _context.Motoristas.Add(motorista);
            _context.SaveChanges();
            return Created("", motorista);
        }

        //GET: ESTACIONAAKI/motorista/list
        [HttpGet]
        [Route("list")]
        public IActionResult List() => Ok(_context.Motoristas.ToList());

        //GET: ESTACIONAAKI/motorista/getbyid/1
        [HttpGet]
        [Route("getbyid/{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            Motorista motorista = _context.Motoristas.Find(id);
            if (motorista == null)
            {
                return NotFound();
            }
            return Ok(motorista);
        }

        //DELETE: /ESTACIONAAKI/motorista/delete/bolacha
        [HttpDelete]
        [Route("delete/{name}")]
        public IActionResult Delete([FromRoute] string name)
        {
            //Expressão lambda
            //Buscar um objeto na tabela de motoristas com base no nome
            Motorista motorista = _context.Motoristas.FirstOrDefault(motorista => motorista.NomeMotorista == name);

            if (motorista == null)
            {
                return NotFound();
            }
            _context.Motoristas.Remove(motorista);
            _context.SaveChanges();
            return Ok(_context.Motoristas.ToList());
        }


        //PUT: ESTACIONAAKI/motorista/update
        [HttpPut]
        [Route("update")]
        public IActionResult Update([FromBody] Motorista motorista)
        {
            _context.Motoristas.Update(motorista);
            _context.SaveChanges();
            return Ok(motorista);
        }
    }
    }
