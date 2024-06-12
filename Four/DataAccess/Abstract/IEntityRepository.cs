using System;
using System.Linq.Expressions;
using Entities.Abstract;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	public interface IEntityRepository<T> where T:class, IEntity, new()//generic constraint -tür kısıtı T:class demek referans tip olabilir demek
	{ //IEntity olabilir bu ya da IEntity implement eden bir nesne olabilir.
        //bu bir standart oluşturma idi.


        List<T> GetAll(Expression<Func<T,bool>> filter =null); //urunleri istege gore listeleme predicate delegate sistem
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);//default publictir.
        void Update(T entity);
        void Delete(T entity);
        
    }
}

