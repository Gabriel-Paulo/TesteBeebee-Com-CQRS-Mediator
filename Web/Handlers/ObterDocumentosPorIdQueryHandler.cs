using MediatR;
using Microsoft.EntityFrameworkCore;
using Web.Models;
using Web.Queries;

namespace Web.Handlers
{
    public class ObterDocumentosPorIdQueryHandler : IRequestHandler<ObterDocumentosPorIdQuery, List<Documento>>
    {
        private readonly ClientesContext _context;

        public ObterDocumentosPorIdQueryHandler(ClientesContext context)
        {
            _context = context;
        }

        public async Task<List<Documento>> Handle(ObterDocumentosPorIdQuery request, CancellationToken cancellationToken)
        {
            var cliente = await _context.Documentos.Where(d => d.ClienteId == request.Id).ToListAsync();

            return cliente;
        }
    }
}
