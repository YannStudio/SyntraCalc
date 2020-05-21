﻿using Autofac;
using SyntraCalc.Services.Infrastructure;

namespace SyntraCalc.UI.WPF.ViewModels
{
    public class ViewModelLocator
    {
        private readonly IContainer container;

        public ViewModelLocator()
        {
            // Autofac dependency injection, register all viewmodels amd service module

            var builder = new ContainerBuilder();
            builder.RegisterModule<ServicesModule>();
            builder.RegisterType<MainViewModel>().SingleInstance();
            builder.RegisterType<DashboardViewModel>().SingleInstance();

            container = builder.Build();
            container.Resolve<MainViewModel>();
            container.Resolve<DashboardViewModel>();
                
        }

        public MainViewModel Main => container.Resolve<MainViewModel>();
        public DashboardViewModel Dasboard => container.Resolve<DashboardViewModel>();
           

    }
}
