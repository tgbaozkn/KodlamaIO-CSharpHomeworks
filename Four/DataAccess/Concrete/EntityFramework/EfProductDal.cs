using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
namespace DataAccess.Concrete.EntityFramework
{
	public class EfProductDal:IProductDal

	{
		public EfProductDal()
		{
		}

        public void Add(Product product)
        {
            //IDisposable pattern implementation of c#
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(product);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();

            }
        }

        public void Delete(Product product)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(product);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();

            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {

            using (NorthwindContext context = new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            using(NorthwindContext context = new NorthwindContext())
            {
                //select from product table =>context.Set<Product>().ToList()
                return filter == null ? context.Set<Product>().ToList() : context.Set<Product>().Where(filter).ToList();    
            }
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
             using (NorthwindContext context = new NorthwindContext())
            {
                var updatedEntity = context.Entry(product);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();

            }
        }
    }
}

