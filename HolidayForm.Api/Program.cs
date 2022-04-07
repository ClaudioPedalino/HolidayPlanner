using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace HolidayPlanner.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        /// COSTIAS PARA SEGUIR HACIENDO

        /// [Backend] "Eliminar" un formulario
        /// [Backend] Probar un poco m�s el funcionamiento de la api y detectar errores
        /// [Backend] Agregar l�gica de "not found" y "nulos" necesaria
        /// [Backend] Agregar validaciones faltantes
        /// [Backend] Permitir b�squeda por filtros (mail, posici�n, rango de fechas, estado de la petici�n)

        /// [Backend] Agregar tablas faltantes: "posiciones", "equipos", etc..
        /// [Backend] Agregar seguridad, puede ser un header custom o un token
        ///     https://www.youtube.com/watch?v=XhBil7d85fI
        ///     https://www.youtube.com/watch?v=jYwqwRsXLWc
        /// [Backend] Unificar objeto de respuestas de la api
        ///     https://alexdunn.org/2019/02/25/clean-up-your-client-to-business-logic-relationship-with-a-result-pattern-c/
        /// [Backend] Partir la api en un proyecto en capas
        /// [Backend] Agregar cache en memoria
        ///     https://www.youtube.com/watch?v=Y8Wd_4-s9hQ
        /// [Backend] Mejorar paginado y objeto resultante
        /// [Backend] Logging en base de datos
        ///     https://www.youtube.com/watch?v=HGXTv0_0NZQ
        ///     https://www.youtube.com/watch?v=LwgBWk48ywU
        /// [Backend] Agregar tabla de usuarios
        ///     Hacer Crud de usuarios
        ///     Autenticaci�n y autorizaci�n por usuario

        /// [Frontend] Pantalla de get-all (tabla con los datos)
        /// [Frontend] Posibilidad de cambiar el estado de una vacaci�n
        /// [Frontend] 



        /// Para el mi�rcoles que viene:
        /// > Usen el c�digo, levantenlo en local, entiendan c�mo funciona, debuggeenlo
        /// > Al hacerlo van a ir apareciendo errores, detectenlas y mencionenlas, ideal si las arreglan o proponen una mejora
        /// > 
    }
}
