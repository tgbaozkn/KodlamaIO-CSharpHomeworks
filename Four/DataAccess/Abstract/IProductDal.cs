using System;
using Entities.Concrete;

namespace DataAccess.Abstract
{
	//data access layer
	//DAO data access object

	public interface IProductDal:IEntityRepository<Product> //interfaces default internaldir.
	{

		
    }
}

