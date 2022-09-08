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
            builder.RegisterType<PhoneBookManager>().As<IPhoneBookService>();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>();
       
        }
    }
}
