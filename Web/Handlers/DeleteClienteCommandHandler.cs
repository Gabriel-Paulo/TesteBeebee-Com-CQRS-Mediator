using MediatR;
using Web.Commands;
using Web.Models;

namespace Web.Handlers
{
    public class DeleteClienteCommandHandler : IRequestHandler<DeleteClientesCommands, Cliente>
    {
        private readonly ClientesContext _context;

        public DeleteClienteCommandHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(DeleteClientesCommands request, CancellationToken cancellationToken)
        {
            var cliente = await _context.Clientes.FindAsync(request.Id);

            if (cliente == null)
            {
                throw new NotFoundException(nameof(Cliente), request.Id);
            }

            _context.Clientes.Remove(cliente);
            await _context.SaveChangesAsync();

            return cliente;
        }
    }
}
