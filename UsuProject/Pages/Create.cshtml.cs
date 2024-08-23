using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsuProject.Models;
using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;


namespace UsuProject.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Usuario Usuario { get; set; }

        public void OnGet()
        {
        }
        
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            


            string connectionString = "Server=.;Database=Gimnasio2;User Id=sa;Password=Emiliano25; TrustServerCertificate=True;";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("Ins_Usuarios2", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Email", Usuario.Email);
                    command.Parameters.AddWithValue("@Nombre", Usuario.Nombre);
                    command.Parameters.AddWithValue("@APaterno", Usuario.APaterno);
                    command.Parameters.AddWithValue("@AMaterno", Usuario.AMaterno ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@FechaNacimiento", Usuario.FechaNacimiento);
                    command.Parameters.AddWithValue("@Contraseña", Usuario.Contrasena);
                    command.Parameters.AddWithValue("@Celular", Usuario.Celular);
                    command.Parameters.AddWithValue("@Peso", Usuario.Peso ?? (object)DBNull.Value);
                    command.Parameters.AddWithValue("@Altura", Usuario.Altura ?? (object)DBNull.Value);
                    
                    command.ExecuteNonQuery();
                }
            }

            return RedirectToPage("/Index");
        }
    }
}
