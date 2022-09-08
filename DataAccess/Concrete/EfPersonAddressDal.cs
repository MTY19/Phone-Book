using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entitities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EfPersonAddressDal : EfEntityRepositoryBase<PersonAddress, PhoneBookContext>, IPersonAddressDal
    {

    }
}
