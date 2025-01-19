using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpEgitimKampi301.DataAccesLayer.Abstract;
using CSharpEgitimKampi301.DataAccesLayer.Repositories;
using CSharpEgitimKampi301.EntityLayer.Concrete;

namespace CSharpEgitimKampi301.DataAccesLayer.EntityFramework
{
    public class EfProductDal : GenericRepository <Product>, IProductDal
    {
    }
}
