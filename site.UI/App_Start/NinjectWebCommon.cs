[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(site.UI.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(site.UI.NinjectWebCommon), "Stop")]

namespace site.UI
{
	using System;
	using System.Web;

	using Microsoft.Web.Infrastructure.DynamicModuleHelper;

	using Ninject;
	using Ninject.Web.Common;
	using Data;
	using Domain;
	using Service;

	public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();
		private static readonly string _path = @"/App_Data/data.xml";

		/// <summary>
		/// Starts the application
		/// </summary>
		public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            try
            {
                kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernel);
                return kernel;
            }
            catch
            {
                kernel.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
			var filepath = System.Configuration.ConfigurationManager.AppSettings["datafile"];

			kernel.Bind<IDataContext>().To<DataContext>().InRequestScope()
				.WithConstructorArgument("path", string.Format(@"{0}", filepath));

			kernel.Bind<IArticleService>().To<ArticleService>();

			kernel.Bind<IRepo<ArticleData>>().To<Repo<ArticleData>>();

			kernel.Bind<IManagerFactory<ArticleData>>().To<ManagerFactory<ArticleData>>();

			kernel.Bind<IManager<ArticleData>>().To<ArticleManager>();
		}        
    }
}
