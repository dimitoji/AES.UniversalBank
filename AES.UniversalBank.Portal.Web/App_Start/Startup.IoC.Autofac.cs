using System.Web.Mvc;
using Owin;
using Autofac;
using Autofac.Integration.Mvc;

namespace AES.UniversalBank.Portal.Web
{
    public partial class Startup
    {
        // COnfiguracion de IoC usando Autofac.OWIN
        public void ConfigureIoC(IAppBuilder app)
        {
            var builder = new ContainerBuilder();

            //Services and dependencies
            builder.RegisterType<Authentication.Impl.DirectoryManager>()
                .As<Authentication.IDirectoryManager>();

            builder.RegisterType<Utils.MasterSlave.Impl.ParallelMasterSlave>()
                .As<Utils.MasterSlave.IMasterSlaveStrategy>();

            builder.RegisterType<Messaging.Broker.Impl.DebugAccountInfoBroker>()
                .As<Messaging.Broker.IAccountInfoBroker>();

            builder.RegisterType<BusinessLogic.Impl.AccountsManager>()
                .As<BusinessLogic.IAccountsManager>();

            // Controllers
            builder.RegisterControllers(typeof(Startup).Assembly);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            app.UseAutofacMiddleware(container);
            app.UseAutofacMvc();
        }
    }
}