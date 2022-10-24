using AutomotivePagingAPI.Data;
using AutomotivePagingAPI.DTO;
using AutomotivePagingAPI.Entities;
using AutomotivePagingAPI.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutomotivePagingAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ClientesController(ApplicationDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<List<Cliente>> Get([FromQuery]PaginacionDTO paginacionDTO)
        {
            //Aplicando paginación
            var queryable = context.Clientes.AsQueryable();
            await HttpContext.InsertPaginationHeader(queryable);

            var clientes = await queryable.OrderBy(x => x.Id).Paginate(paginacionDTO).ToListAsync();//es recomendable ordenar cuando se pagina
            return clientes;
        }
    }
}
