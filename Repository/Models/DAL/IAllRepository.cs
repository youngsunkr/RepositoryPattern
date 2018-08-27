using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Models.DAL
{
    public interface IAllRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetModel();

        TEntity GetModelByID(int modelId);

        void InsertModel(TEntity model);

        void DeleteModel(int modelId);

        void UpdateModel(TEntity model);

        void Save();

    }
}