using MarcelStudy.Application;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcelStudy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContatoController : ControllerBase
    {
        private ContatoApplication _contatoApplication;
        public ContatoController(ContatoApplication contatoApplication)
        {
            _contatoApplication = contatoApplication;
        }

        [HttpGet("Listar")]
        public async Task<IActionResult> Listar()
        {
            try
            {
                var contatos = _contatoApplication.Listar();
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet("BuscarPorNome")]
        public async Task<IActionResult> BuscarPorNome(string nome)
        {
            try
            {
                var contatos = _contatoApplication.BuscarPorNome(nome);
                return Ok(contatos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        //Marcel - Lição de casa

        // Exercicio 1
        //[HttpGet("BuscarPorId")]
        //public async Task<IActionResult> BuscarPorCodigo(int id)
        //{
        //    try
        //    {
        //        return Ok();
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}

        // Exercicio 2
        //[HttpGet("BuscarPorDDD")]


        // Exercicio 3
        //[HttpPost("Adicionar")]
        // Um contato precisa ter nome, idade, ddd e telefone
        // Quando chegar na etapa de REPOSITORY: https://www.devmedia.com.br/entity-framework-como-fazer-seu-primeiro-mapeamento-objeto-relacional/38756
        // Olhar etapa no site: Passo 5: Gravar dados no banco


    }
}
