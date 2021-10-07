using System;
using Veterinaria.App.Dominio;
using Veterinaria.App.Persistencia;

namespace Veterinaria.App.Consola
{
    class Program
    {

        private static IRepositorioVeterinario repoVeterinario = new RepositorioVeterinario(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AgregarVeterinario();
        }

        private static void AgregarVeterinario(){

            EntidadVeterinario veterinario = new EntidadVeterinario {
                // Id = 10,
                Nombre = "Marlon",
                Telefono = "123456",
                Edad = 50,
                // Direccion= "",
                Correo = "marlon@marlon.com",
                Contrasenia = "marlon",
                FechaRegistro = new DateTime(2021, 09, 21),
                Especializacion = "test",
                TarjetaProfesional = "tarjetaprofesional"
            };

            repoVeterinario.AgregarVeterinario(veterinario);

        }
    }
}
