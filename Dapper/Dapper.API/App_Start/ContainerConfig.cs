using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using Dapper.Business.Managers;
using Dapper.Dapper.Repositories;
using Dapper.Data.Repositories;

namespace Dapper.API.App_Start
{
    public class ContainerConfig
    {
        public static void Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(typeof(ContainerConfig).Assembly).InstancePerLifetimeScope();

            //This registers 'A'
            builder.RegisterAssemblyModules(typeof(ContainerConfig).Assembly);

            var container = builder.Build();

            GlobalConfiguration.Configuration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
        }
    }

    //This is 'A'
    public class RegisterServices : Module
    {
        protected override void Load(ContainerBuilder builder)
        {




            //Repositories
            builder.RegisterType<ArtistRepository>().As<IArtistRepository>();
            builder.RegisterType<WriterRepository>().As<IWriterRepository>();
            builder.RegisterType<WriterOriginalPublisherRepository>().As<IWriterOriginalPublisherRepository>();
            builder.RegisterType<LicenseProductProductRepository>().As<ILicenseProductProductRepository>();
            builder.RegisterType<LicenseStatusStatusRepository>().As<ILicenseStatusStatusRepository>();
            builder.RegisterType<LicenseRepository>().As<ILicenseRepository>();
            builder.RegisterType<TrackComposerRepository>().As<ITrackComposerRepository>();
            builder.RegisterType<TrackRepository>().As<ITrackRepository>();
            builder.RegisterType<ProductHeaderRepository>().As<IProductHeaderRepository>();
            builder.RegisterType<RecordingRepository>().As<IRecordingRepository>();
            builder.RegisterType<ProductConfigurationRepository>().As<IProductConfigurationRepository>();
            builder.RegisterType<LicenseDapperRepository>().As<ILicenseDapperRepository>();

            builder.RegisterType<LicenseManager>().As<ILicenseManager>();




            base.Load(builder);
        }
    }
}