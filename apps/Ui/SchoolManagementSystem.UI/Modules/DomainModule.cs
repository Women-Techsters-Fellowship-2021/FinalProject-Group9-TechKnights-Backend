﻿using Autofac;
using SchoolManagementSystem.Domain.Services;


namespace SchoolManagementSystem.UI.Modules
{
    public class DomainModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentService>().As<IStudentService>();
            builder.RegisterType<GradeService>().As<IGradeService>();
            builder.RegisterType<ModuleService>().As<IModuleService>();
            base.Load(builder);
        }
    }
}