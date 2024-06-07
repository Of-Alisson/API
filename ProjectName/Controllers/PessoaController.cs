using System.Threading.Tasks; //Tasks = programação Assincronas
using ProjectName.Data;
using Microsoft.AspNetCore.Mvc; //Responsavel pela criação das rotas
using Microsoft.EntityFrameworkCore;
using ProjectName.Models;


namespace ProjectName.Controllers
{
    [Controller]
    [Route("[controller]")]


    public class PessoaController : ControllerBase
    {

        private DataContext dc;

        public PessoaController(DataContext context) 
        {
            this.dc = context;
        }

        [HttpPost("api")]
        public async Task<ActionResult> Cadastrar([FromBody] Pessoa p)
        {

            dc.pessoa.Add(p);
            await dc.SaveChangesAsync();

            return Created("Objeto Pessoa", p);

        }

        [HttpGet("oi")]
        public string oi()
        {
            return "Hello World!!";
        }


    }
}
