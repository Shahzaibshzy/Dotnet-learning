using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/character")]
    public class CharachterController : ControllerBase
    {
        private static List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{ Id = 1,Name = "sam" },

        };

        [HttpGet("GetAll")]
        public ActionResult<List<Character>> get()
        {
            return Ok(characters);
        }

        [HttpGet("{id}")]

        public ActionResult<Character> getsingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpPost]
        public ActionResult<List<Character>> Addcharacter(Character newcharacter)
        {
            characters.Add(newcharacter);
            return Ok(characters);
        }
    }
}