using MediatR;
using Microsoft.AspNetCore.Mvc;
using Web.Commands;
using Web.Handlers;
using Web.Models;
using Web.Queries;

namespace Web.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ClientesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<ActionResult<List<Cliente>>> ObterTodos()
        {
            var query = new ObterTodosClientesQuery();
            var resultado = await _mediator.Send(query);
            return Ok(resultado);
        }
        [HttpPost]
        public async Task<ActionResult<int>> CriarCliente(CreateClientesCommands command)
        {
            var clienteId = await _mediator.Send(command);

            return Ok(clienteId);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> ObterClientePorId(int id)
        {
            var query = new ObterClientePorIdQuery { Id = id };
            var cliente = await _mediator.Send(query);

            return Ok(cliente);
        }
        [HttpGet("{id}/documentos")]
        public async Task<ActionResult<Cliente>> ObterDocumentosPorId(int id)
        {
            var query = new ObterDocumentosPorIdQuery { Id = id };
            var cliente = await _mediator.Send(query);

            return Ok(cliente);
        }
        [HttpGet("{id}/enderecos")]
        public async Task<ActionResult<Cliente>> ObterEnderecoPorId(int id)
        {
            var query = new ObterEnderecoPorIdQuery { Id = id };
            var cliente = await _mediator.Send(query);

            return Ok(cliente);
        }
        [HttpPut("{id}")]
        public async Task<ActionResult<Cliente>> Atualizar(int id, [FromBody] UpdateClientesCommands command)
        {
            if (id != command.Id)
            {
                return BadRequest();
            }

            var resultado = await _mediator.Send(command);
            return Ok(resultado);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletarCliente(int id)
        {
            await _mediator.Send(new DeleteClientesCommands { Id = id });

            return NoContent();
        }
    }
}
