using DataAccess.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    interface IUserDal:IEntityRepository<User>
    {

    }
}
