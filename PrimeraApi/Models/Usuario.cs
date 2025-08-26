using System.Text.Json.Serialization;

namespace PrimeraApi.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Categoria { get; set; }
    }
}
