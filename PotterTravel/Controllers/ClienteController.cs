using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PotterTravel.Data;
using PotterTravel.Model;

namespace PotterTravel.Controllers
{
    [ApiController]
    [Route("api")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetClientes()
        {
            return await _dataContext.Clientes.ToListAsync();
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Cliente>> GetClienteById(int id)
        {
            var cliente = await _dataContext.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

    }
}
