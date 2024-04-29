using Eletricista.models;
using Eletricista.Models.Enuns;
using Microsoft.AspNetCore.Mvc;

namespace Eletricista.Controllers
{

    [ApiController]
    [Route("[Controller]")]

    public class PersonagensExemploController : ControllerBase
    {
      
      private static List<Trabalho> trabalhos = new List<Trabalho>()
      {
       
       new Trabalho() { Id = 1, NomeCliente = "Gustavo", Rua="italia", Endereço=793,  ValorTrabalho=640, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 2, NomeCliente = "Alberto", Rua="Londres", Endereço=203, ValorTrabalho=80, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 3, NomeCliente = "Carlos", Rua="Japão", Endereço=399, ValorTrabalho=350, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 4, NomeCliente = "Nicolas", Rua="Almirante Abreu", Endereço=81, ValorTrabalho=2200, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 5, NomeCliente = "Julia", Rua="Hungria", Endereço=507, ValorTrabalho=200, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 6, NomeCliente = "Henrique", Rua="Getulio", Endereço=153, ValorTrabalho=3000, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 7, NomeCliente = "Daniel", Rua="Castelo Branco", Endereço=41, ValorTrabalho=400, Classe=ClasseEnum.Cliente},
       new Trabalho() { Id = 8, NomeCliente = "Maria", Rua="Império", Endereço=906, ValorTrabalho=1000, Classe=ClasseEnum.Cliente},
 
      };

      public IActionResult GetFirst()
      {
        return Ok(trabalhos);
      }


      [HttpGet("GetAll")]
      public IActionResult Get()
      {
        return Ok(trabalhos);
      }

      [HttpGet("{id}")]

      public IActionResult GetSingle(int id)
      {
        return Ok(trabalhos.FirstOrDefault(pe => pe.Id ==id));
      }

      [HttpPost]
      public IActionResult AddTrabalho(Trabalho novoTrabalho)
      {
        trabalhos.Add(novoTrabalho);
        return Ok(trabalhos);
      }

      [HttpPut]public IActionResult UpdateTrabalho(Trabalho p)
      {
        Trabalho trabalhoAlternado = trabalhos.Find(pers => pers.Id == p.Id);
        trabalhoAlternado.NomeCliente = p.NomeCliente;
        trabalhoAlternado.Rua = p.Rua;
        trabalhoAlternado.Endereço = p.Endereço;
        trabalhoAlternado.ValorTrabalho = p.ValorTrabalho;

        return Ok(trabalhos);

      }

      [HttpDelete("{id}")]

      public IActionResult Delete(int id)
      {
        trabalhos.RemoveAll(pers => pers.Id == id);

        return Ok(trabalhos);
      }


    }
}