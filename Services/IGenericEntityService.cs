using breath_app_core.Model.BaseEntities;
using Microsoft.EntityFrameworkCore;

namespace breath_app_core.Services {
    public interface IGenericEntityService<TEntity> {
        public TEntity? GetById(long id);
        public List<TEntity> GetAll();
        public void Add(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(long id);

    }
}
