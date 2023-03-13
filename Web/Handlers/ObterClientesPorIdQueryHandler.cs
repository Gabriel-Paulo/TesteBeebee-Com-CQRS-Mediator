using MediatR;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Queries;

namespace Web.Handlers
{
    public class ObterClientePorIdQueryHandler : IRequestHandler<ObterClientePorIdQuery, Cliente>
    {
        private readonly ClientesContext _context;

        public ObterClientePorIdQueryHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<Cliente> Handle(ObterClientePorIdQuery request, CancellationToken cancellationToken)
        {
            var cliente = await _context.Clientes.Include(c => c.Documentos).Include(c => c.Enderecos).FirstOrDefaultAsync(c => c.Id == request.Id);

            return cliente;
        }
    }
}
