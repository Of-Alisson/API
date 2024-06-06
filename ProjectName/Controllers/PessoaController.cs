using System.Threading.Tasks; //Tasks = programação Assincronas
using ProjectName.Data;
using Microsoft.AspNetCore.Mvc; //Responsavel pela criação das rotas
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class Controllers
    {
        [HttpGet("oi")]
        public string oi()
        {
            return "Hello World!!";
        }


    }
}
