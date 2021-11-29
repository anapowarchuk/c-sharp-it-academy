using Microsoft.AspNetCore.Mvc;

namespace DemoWebServiceAloMundo.Controllers;

//metadados -atributos - propriedades que ajudam a alterar
[ApiController] //pre configura varios pre req 
[Route("[controller]")] //
public class AloMundoController : ControllerBase
{
    private readonly ILogger<AloMundoController> _logger; 

    public AloMundoController(ILogger<AloMundoController> logger) //solicitar a injeção de dependências - injenção por contrutor
    {
        _logger = logger;
    }
    
    [HttpGet]
    public string Get(){
        _logger.LogInformation("AloMundoController.Get()");
        return "Alô Mundo!";
    }

    [HttpGet("{nome}")] //variavel de rota /api/alomundo/ana

    public string Get (string nome){
        _logger.LogInformation($"AloMundoController.Get({nome})");
        return $"Alô Mundo, {nome}!";
    }

    [HttpGet("query")]

        public string GetQuery (string nome) {
            _logger.LogInformation($"AloMundoController.GetQuery({nome})");
            return $"Alô Mundo, {nome}!";
        }

    [HttpPost("pessoa")]
    public string Post([FromBody] Pessoa pessoa) {
        _logger.LogInformation($"AloMundoController.Post({pessoa.Nome})");
        return $"Alô Mundo, {pessoa.Nome}!";
    }


    /*[HttpPost]
    public string Post([FromBody] string nome) {
        _logger.LogInformation($"AloMundoController.Post({nome})");
        return $"Alô Mundo, {nome}!";
    }*/
}
