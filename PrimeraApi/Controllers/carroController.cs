using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc;
using PrimeraApi.Models;

namespace PrimeraApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class carroController : ControllerBase
    {
        private List<Carros> carros = new ()
        {
            new Carros { Color = "Azul", Placa = "TX15"},
            new Carros { Color = "Negro", Placa = "CA45"}
        };

        [HttpGet]
        public IEnumerable<Carros> GetCarros()
        {
            return carros;
        }

        [HttpPost]
        [Route("GetCarros")]

        public ActionResult<Carros> CreateCarro(Carros carro)
        {
            carros.Add(carro);
            return carro;
        }
    }
}
