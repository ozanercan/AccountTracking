using Autofac;
using Autofac.Extras.DynamicProxy;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using System.Reflection;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<AuthManager>().As<IAuthService>();

            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimDal>();
            builder.RegisterType<UserOperationClaimManager>().As<IUserOperationClaimService>();

            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();

            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<UserManager>().As<IUserService>();

            builder.RegisterType<EfCurrencyUnitDal>().As<ICurrencyUnitDal>();
            builder.RegisterType<CurrencyUnitManager>().As<ICurrencyUnitService>();

            builder.RegisterType<EfCorporateCurrentCardDal>().As<ICorporateCurrentCardDal>();
            builder.RegisterType<CorporateCurrentCardManager>().As<ICorporateCurrentCardService>();

            builder.RegisterType<EfIndividualCurrentCardDal>().As<IIndividualCurrentCardDal>();
            builder.RegisterType<IndividualCurrentCardManager>().As<IIndividualCurrentCardService>();

            builder.RegisterType<EfForeignIndividualCurrentCardDal>().As<IForeignIndividualCurrentCardDal>();
            builder.RegisterType<ForeignIndividualCurrentCardManager>().As<IForeignIndividualCurrentCardService>();

            builder.RegisterType<EfLocalIndividualCurrentCardDal>().As<ILocalIndividualCurrentCardDal>();
            builder.RegisterType<LocalIndividualCurrentCardManager>().As<ILocalIndividualCurrentCardService>();

            builder.RegisterType<EfCurrentCardDal>().As<ICurrentCardDal>();
            builder.RegisterType<CurrentCardManager>().As<ICurrentCardService>();

            builder.RegisterAutoMapper(Assembly.GetExecutingAssembly());

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
