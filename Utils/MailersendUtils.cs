using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Simulacro3.Models;

namespace Simulacro3.Utils  
{
    public class MailersendUtils
    {
         public async void EnviarCorreo(string email, string Descripcion, string Nombre)
        {
            //URL de detino para solicitud POST de la API Mailersend:
            string url = "https://api.mailersend.com/v1/email";

            //Token de autorizacion para la solicitud :
            string tokenEmail = "mlsn.12ae0cd4991d7a91a3e3240b11b7908b6485016c1169f53d1c2091aa3af6cbfc";

            //se crea una instancia de la clase email para contener el mensaje :
            var emailMessage = new Email{
            
                from = new From {email = "MS_8FGLaW@trial-z86org8od2z4ew13.mlsender.net"},
                to = [
                    new To {email = email}
                ],
                subject = "Tarea asignada",
                text = $"¡Hola {Nombre} tu Tarea asignada es :{Descripcion}"
               
                //JsonSerializer.Serialize() => este combierte datos a tipo json
            };
            //serializar el objeto emailMessge en formato JSON:
            string jsonBody = JsonSerializer.Serialize(emailMessage);

            //se crea un objeto HttpClient para realizar la solicitud http:
            using(HttpClient client = new HttpClient())
            {
            //configurar el encabezado de Authorization para indicar el token de autorizacion :
            client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.
            AuthenticationHeaderValue("Bearer", tokenEmail);

            // crear el contenido de la solicitud POST como stringContent :  Encoding.UTF8 esto encripta
            StringContent content= new StringContent(jsonBody, Encoding.UTF8, "application/json");

            //realizar la solicitud POST a la URL indicada:
            HttpResponseMessage response = await client.PostAsync(url, content);

            //verificar si la solicitud fue exitosa (codigo de estado: 200 - 209):
            if(response.IsSuccessStatusCode)
            {
                //se muestra el estado de la solicitud :
                 Console.WriteLine($"Estado de la solicitud :{response.StatusCode}");
            }
            else
            {
                // si la solicitud no fue exitosa, se muestra el estado de la solicitud :
                Console.WriteLine($"correo no enviado : {response.StatusCode}");
            }
            }
        }
    }
}