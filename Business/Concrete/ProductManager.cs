using Business.Abstract;
using Business.Constants;
using Core.Uthilities.Results;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal productDal;
        public ProductManager(IProductDal productDal)
        {
            this.productDal = productDal;
        }
        public IResult Add(Product product)
        {
            productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(productDal.Get(p => p.Id == id));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(productDal.GetList().ToList());
        }

        public IResult Update(Product product)
        {
            productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
