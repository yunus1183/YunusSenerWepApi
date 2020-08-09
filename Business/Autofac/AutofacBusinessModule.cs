using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfProductDal>().As<IProductDal>();
            builder.RegisterType<ProductManager>().As<IProductService>();
        }
    }
}
