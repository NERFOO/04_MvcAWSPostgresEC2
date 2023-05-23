using _04_MvcAWSPostgresEC2.Models;
using Microsoft.EntityFrameworkCore;

namespace _04_MvcAWSPostgresEC2.Data
{
	public class DepartamentosContext : DbContext
	{
		public DepartamentosContext(DbContextOptions<DepartamentosContext> options) : base(options) { } 
		public DbSet<Departamento> Departamentos { get; set; }
	}
}
