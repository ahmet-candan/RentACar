using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityRepository
{
    public class EfColorDal :EfEntityRepositoryBase<Color,RentACarContext>, IColorDal
    {

    }
}
