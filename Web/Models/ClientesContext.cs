using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Web.Models
{
    public class ClientesContext : DbContext
    {

        public ClientesContext(DbContextOptions<ClientesContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Documento> Documentos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

    }
}
