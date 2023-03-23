
using ByteBank.Portal.Infraestrutura;

var prefixos = new string[] { "http://localhost:5341/" };
var webApplication = new WebApplication(prefixos);
webApplication.Iniciar();
