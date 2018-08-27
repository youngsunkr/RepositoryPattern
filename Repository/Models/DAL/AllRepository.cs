using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Repository.Models.DAL
{
    public class AllRepository<TEntity> : IAllRepository<TEntity> where TEntity : class
    {
        private DataContext _context;
        private IDbSet<TEntity> dbEntity;

        public AllRepository()
        {
            _context = new DataContext();
            dbEntity = _context.Set<TEntity>();
        }

        //public AllRepository(DataContext context)
        //{
        //    this._context = context;
        //}

        public void DeleteModel(int modelId)
        {
            TEntity model = dbEntity.Find(modelId);

            dbEntity.Remove(model);
        }

        public IEnumerable<TEntity> GetModel()
        {
            return dbEntity.ToList();
        }

        public TEntity GetModelByID(int modelId)
        {
            return dbEntity.Find(modelId);
        }

        public void InsertModel(TEntity model)
        {
            dbEntity.Add(model);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void UpdateModel(TEntity model)
        {
            _context.Entry(model).State = System.Data.Entity.EntityState.Modified;
        }
    }
}