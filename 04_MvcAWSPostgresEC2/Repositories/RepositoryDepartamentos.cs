using _04_MvcAWSPostgresEC2.Data;
using _04_MvcAWSPostgresEC2.Models;
using Microsoft.EntityFrameworkCore;

namespace _04_MvcAWSPostgresEC2.Repositories
{
	public class RepositoryDepartamentos
	{
		private DepartamentosContext context;

		public RepositoryDepartamentos(DepartamentosContext context)
		{
			this.context = context;
		}

		public async Task<List<Departamento>> GetDepartamentosAsync()
		{
			return await this.context.Departamentos.ToListAsync();
		}

		public async Task<Departamento> FindDepartamentoAsync(int id)
		{
			return await this.context.Departamentos.FirstOrDefaultAsync(x => x.IdDepartemento == id);
		}

		public async Task InsertDepartamentosAsync(int id, string nombre, string localidad)
		{
			Departamento departamento = new Departamento
			{
				IdDepartemento = id,
				Nombre = nombre,
				Localidad = localidad
			};

			this.context.Departamentos.Add(departamento);

			await this.context.SaveChangesAsync();
		}
	}
}
