﻿using Autofac;

namespace Nameless.Skeleton.Api {

    public partial class StartUp {

        #region Public Methods

        // ConfigureContainer is where you can register things directly
        // with Autofac. This runs after ConfigureServices so the things
        // here will override registrations made in ConfigureServices.
        // Don't build the container; that gets done for you by the factory.
        public void ConfigureContainer(ContainerBuilder builder) {
            //builder
            //    .RegisterModule(new CQRSModule(typeof(StartUp).Assembly))
            //    .RegisterModule(new EnvironmentModule())
            //    .RegisterModule(new FileStorageModule())
            //    .RegisterModule(new LocalizationModule())
            //    .RegisterModule(new LoggingModule())
            //    .RegisterModule(new PersistenceModule())
            //    .RegisterModule(new SerializationModule());
        }

        #endregion
    }
}
