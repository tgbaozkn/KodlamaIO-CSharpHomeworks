using System;
using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal

    {

        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> {

                new Product{CategoryId=1,ProductId=1,ProductName="Bardak",UnitPrice=15,UnitsInstock=2},
                new Product{CategoryId=1,ProductId=2,ProductName="Kamera",UnitPrice=300,UnitsInstock=2},
                new Product{CategoryId=1,ProductId=3,ProductName="Kalem",UnitPrice=100,UnitsInstock=2},
                new Product{CategoryId=1,ProductId=4,ProductName="Kitap",UnitPrice=20,UnitsInstock=2},
                new Product{CategoryId=1,ProductId=5,ProductName="Telefon",UnitPrice=30,UnitsInstock=2},
                new Product{CategoryId=1,ProductId=6,ProductName="Bilgisayar",UnitPrice=5,UnitsInstock=2},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //Language Integrated Query
            //=> işareti lambda
            //_products.Remove(product); delete içine gönderilen obje referans tipi ile çalıştığı için silinmek istenen listedeki referanstan farklı olabilir ve bu da silinmesini engeller.
            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategoryId(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            product.UnitsInstock = product.UnitsInstock;
        }
    }
}

