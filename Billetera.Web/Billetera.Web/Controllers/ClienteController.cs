
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Billetera.Models;
using Billetera.Web.Models;
using System.Web.Routing;
namespace Billetera.Web.Controllers
{
    
    [RoutePrefix("api/Cliente")]
    public class ClienteController : ApiController
    {
        // GET: api/Cliente
        public IEnumerable<Cliente> Get()
        {
            GestorCliente gCliente = new GestorCliente();
            return gCliente.obtenerClientes();
        }

        // GET: api/Cliente/"número de id"
        public Cliente Get(int id)
        {
            GestorCliente gCliente = new GestorCliente();
            return gCliente.obtenerPorId(id);
        }

        // POST: api/Cliente
        public void Post([FromBody] Cliente nuevo)
        {
            GestorCliente gCliente = new GestorCliente();
            //return gCliente.nuevoCliente(nuevo);
        }

        // PUT: api/Cliente/"número de id"
        public void Put(int id, [FromBody] Cliente cli)
        {
            GestorCliente gCliente = new GestorCliente();
            //return gCliente.modificarCliente(id);
        }

        // DELETE: api/Cliente/"número de id"
        public void Delete(int id)
        {
            GestorCliente gCliente = new GestorCliente();
            //return gCliente.eliminarCliente(id);
        }
    }
}