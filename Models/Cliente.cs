using System.ComponentModel.DataAnnotations;

namespace MockPruebaTecnica.Models
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [EmailAddress(ErrorMessage = "Correo electronico Inválido")]
        public string CorreoElectronico { get; set; }
    }
}
