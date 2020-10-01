using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Contcrete.EntityFramework.Contexts;
using Entities.Concrete;

namespace DataAccess.Contcrete.EntitiyFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product,NorthwindContext>,IProductDal
    {
         
    }
}
