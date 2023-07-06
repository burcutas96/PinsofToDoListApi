using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TodoManager>().As<ITodoService>().SingleInstance();
            builder.RegisterType<EfTodoDal>().As<ITodoDal>().SingleInstance();

            builder.RegisterType<DoingManager>().As<IDoingService>().SingleInstance();
            builder.RegisterType<EfDoingDal>().As<IDoingDal>().SingleInstance();

            builder.RegisterType<DoneManager>().As<IDoneService>().SingleInstance();
            builder.RegisterType<EfDoneDal>().As<IDoneDal>().SingleInstance();
        }
    }
}
