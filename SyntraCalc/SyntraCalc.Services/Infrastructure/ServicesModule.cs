using Autofac;
using SyntraCalc.Repositories.Infrastructure;

namespace SyntraCalc.Services.Infrastructure
{
    public class ServicesModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterModule<RepositoriesModule>();
            builder.RegisterType<GeometricShapesService>().AsImplementedInterfaces();
        }
    }
}
