using MediatR;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Queries;

namespace Web.Handlers
{
    public class ObterEnderecoPorIdQueryHandler : IRequestHandler<ObterEnderecoPorIdQuery, List<Endereco>>
    {
        private readonly ClientesContext _context;

        public ObterEnderecoPorIdQueryHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<List<Endereco>> Handle(ObterEnderecoPorIdQuery request, CancellationToken cancellationToken)
        {
            var cliente =  await _context.Enderecos.Where(e => e.ClienteId == request.Id).ToListAsync();

            return cliente;
        }
    }
}
