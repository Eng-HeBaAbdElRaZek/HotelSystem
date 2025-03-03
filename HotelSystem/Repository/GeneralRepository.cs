using HotelSystem.Data;
using HotelSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;

namespace HotelSystem.Repository
{
	public class GeneralRepository<T> where T : BaseModel
	{

		Context _context;
		DbSet<T> _dbSet;
		public GeneralRepository()
		{
			_context = new Context();
			_dbSet = _context.Set<T>();



		}

		public IQueryable<T> GetAll()
		{
			return _dbSet.Where(c => !c.IsDeleted);


		}

		public IQueryable<T> Get()
		{
			return GetAll();


		}

		//If I Need To Filter By Any Thing
		public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
		{
			return GetAll().Where(predicate);


		}
		//Filter By Id
		public async Task<T> GetById(int id)
		{
			return await _dbSet
				.Where(c => !c.IsDeleted && c.Id == id)
				.FirstOrDefaultAsync();
		}

		public async Task<T> GetByIdWithRracking(int id)
		{
			return await _dbSet
				.Where(c => !c.IsDeleted && c.Id == id)
				.AsTracking()
				.FirstOrDefaultAsync();
		}
		public void Add(T entity)
		{
			_dbSet.Add(entity);
			_context.SaveChanges();

		}
		public void Update(T entity)
		{
			_dbSet.Update(entity);
			_context.SaveChanges();
		}

		public async void Delete(int id)
		{
			var entity = await GetByIdWithRracking(id);
			entity.IsDeleted = true;
			_context.SaveChanges();
		}

		public void UpdateInclude(T entity, params string[] modifiedProperties)
		{
			var local = _dbSet.Local.FirstOrDefault(x => x.Id == entity.Id);
			EntityEntry entityEntry;
			if (local == null)
			{
				entityEntry = _context.Entry(entity);

			}
			else
			{
				entityEntry = _context.ChangeTracker
					.Entries<T>().FirstOrDefault(x => x.Entity.Id == entity.Id);
			}
			foreach (var prop in entityEntry.Properties)
			{
				if (modifiedProperties.Contains(prop.Metadata.Name))
				{
					prop.CurrentValue = entity.GetType().GetProperty(prop.Metadata.Name).GetValue(entity);
					prop.IsModified = true;
				}


			}
			_context.SaveChanges();


		}

		//Update Exclude
		public void UpdateExclude(T entity, params string[] excludedProperties)
		{
			var local = _dbSet.Local.FirstOrDefault(x => x.Id == entity.Id);
			EntityEntry entityEntry;
			if (local == null)
			{
				entityEntry = _context.Entry(entity);
			}
			else
			{
				entityEntry = _context.ChangeTracker
					.Entries<T>().FirstOrDefault(x => x.Entity.Id == entity.Id);
			}

			foreach (var prop in entityEntry.Properties)
			{
				if (!excludedProperties.Contains(prop.Metadata.Name))
				{
					prop.CurrentValue = entity.GetType().GetProperty(prop.Metadata.Name).GetValue(entity);
					prop.IsModified = true;
				}
			}

			_context.SaveChanges();
		}
	}
}
