using GestaoAlunos.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using GestaoAlunos.API.Models;
using GestaoAlunos.Domain.Entidades;

namespace GestaoAlunos.API.Controllers
{
    [ApiController]
    [Route("API/CONTROLLER")]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        [HttpGet]
        [Route("getAlunos")]
        public IActionResult GetAlunos() 
        {
            return Ok(_alunoService.getTodos());
        }


        [HttpGet]
        [Route("getByID")]
        public IActionResult getByID(int id_aluno)
        {
            return Ok(_alunoService.getByID(id_aluno));
        }


        [HttpPost]
        [Route("addAlunos")]
        public IActionResult Adcionar(AlunoDTO alunoDTO)
        {
            // Conversao da classe AlunoDTO(classe anemica) para Aluno(que é o usado)
            
            //obs: confirmar com o humberto se entendi certo
           bool status = _alunoService.Adcionar(new Aluno
              (
                alunoDTO.nome,
                alunoDTO.email,
                alunoDTO.telefone,
                alunoDTO.cpf
              ));

            if (status is true)
                return Ok("Aluno inserido");

            return BadRequest("Erro ao inserir aluno");
        }
    }
}
