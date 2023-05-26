using System.Net;

namespace ScriptApp.Client.Repositorios
{
    public class HttpResponseWrapper<T>
    {
        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMessage)
        {
            Response = response;
            Error = error;
            HttpResponseMessage = httpResponseMessage;
        }

        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string?> ObtenerMensajeError()
        {
            if (!Error)
            {
                return null;
            }
            var codigoEstatus = HttpResponseMessage.StatusCode;

            if (codigoEstatus == HttpStatusCode.NotFound)
            {
                return "Recurso no encontrado";
            }
            else if (codigoEstatus == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }
            else if (codigoEstatus == HttpStatusCode.Unauthorized)
            {
                return "Debe estar registrado para acceder a esta opción";
            }
            else if (codigoEstatus == HttpStatusCode.Forbidden)
            {
                return "No tiene suficientes permisos para realizar esta opción";
            }
            else if (codigoEstatus == HttpStatusCode.NoContent)
            {
                return "Ok";
            }
            else
            {
                return "Ha ocurrido un error inesperado";
            }
        }
    }
}
