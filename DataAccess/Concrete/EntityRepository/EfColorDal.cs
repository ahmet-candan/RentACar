﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityRepository
{
    public class EfColorDal : IColorDal
    {
        public void Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Add(Entities.Concrete.Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Concrete.Color entity)
        {
            throw new NotImplementedException();
        }

        public Color Get()
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Entities.Concrete.Color> GetAll(Expression<Func<Entities.Concrete.Color, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Color entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Entities.Concrete.Color entity)
        {
            throw new NotImplementedException();
        }

        Entities.Concrete.Color IEntityRepository<Entities.Concrete.Color>.Get()
        {
            throw new NotImplementedException();
        }
    }
}
