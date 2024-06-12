using System;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {

            //veri erişimi  çağırmak gerekiyor.
            //bir iş sınıfı başka sınıfları newlemez.
            //belli kurallar var sonra bu fonksiyon
            return _productDal.GetAll(); //dependency injection
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >=min && p.UnitPrice <=max);
        }
    }
}

