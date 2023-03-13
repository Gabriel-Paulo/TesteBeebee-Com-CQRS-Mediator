using MediatR;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Queries;

namespace Web.Handlers
{
    public class ObterTodosClientesQueryHandler : IRequestHandler<ObterTodosClientesQuery, List<Cliente>>
    {
        private readonly ClientesContext _context;

        public ObterTodosClientesQueryHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<List<Cliente>> Handle(ObterTodosClientesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Clientes
                 .Include(c => c.Documentos)
                 .Include(c => c.Enderecos)
                 .ToListAsync(); ;
        }
    }
}
