using HotelSystem.Data;
using HotelSystem.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace HotelSystem.Repository
{
    public class GeneralRepository<T> where T : BaseModel
    {
        Context _context;

        
        DbSet<T> _dbSet { get; set; }
        public GeneralRepository(Context context)
        {    
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public GeneralRepository()
        {
        }

        public IQueryable<T> GetAll()
        {
            return _dbSet.Where(c => !c.Deleted);
        }

        public async Task<T> GetByID(int id)
        {
            return await _dbSet
                .Where(c => !c.Deleted && c.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task<T> GetByIDWithTracking(int id)
        {
            return await _dbSet
                .Where(c =>  !c.Deleted && c.Id == id)
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
            var crs = await GetByIDWithTracking(id);
            crs.Deleted = true;
            _context.SaveChanges();
        }

        public void UpdateInclude(T entity, params string[] modifiedProperties)
        {
            if (!_dbSet.Any(x => x.Id == entity.Id && !x.Deleted))
                return;

            var local = _dbSet.Local.FirstOrDefault(x => x.Id == entity.Id);
            EntityEntry entityEntry;

            if (local is null)
                entityEntry = _context.Entry(entity);
            else
                entityEntry = _context.ChangeTracker.Entries<T>().FirstOrDefault(x => x.Entity.Id == entity.Id);


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

        internal void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
