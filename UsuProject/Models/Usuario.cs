using System.ComponentModel.DataAnnotations;
namespace UsuProject.Models
{
    public class Usuario
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "El campo Email es obligatorio.")]
        [EmailAddress(ErrorMessage = "El email no es válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        [StringLength(30, ErrorMessage = "El nombre no puede tener más de 30 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Apellido Paterno es obligatorio.")]
        [StringLength(20, ErrorMessage = "El apellido paterno no puede tener más de 20 caracteres.")]
        public string APaterno { get; set; }

        [StringLength(20, ErrorMessage = "El apellido materno no puede tener más de 20 caracteres.")]
        public string AMaterno { get; set; }

        [Required(ErrorMessage = "El campo Fecha de Nacimiento es obligatorio.")]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "El campo Contraseña es obligatorio.")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        [Required(ErrorMessage = "El campo Celular es obligatorio.")]
        [Phone(ErrorMessage = "El número de celular no es válido.")]
        public string Celular { get; set; }

        public decimal? Peso { get; set; }
        public decimal? Altura { get; set; }
    }
}
