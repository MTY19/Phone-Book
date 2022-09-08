using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete;
using DataAccess.Abstract;
using Business.Concrete;
using Business.Abstract;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region person
            builder.RegisterType<PersonManager>().As<IPersonService>();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>();
            #endregion

            #region personaddress
            builder.RegisterType<PersonAddressManager>().As<IPersonAddressService>();
            builder.RegisterType<EfPersonAddressDal>().As<IPersonAddressDal>();
            #endregion
        }
    }
}
