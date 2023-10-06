using AkademiPlusMicroservice.Services.Order.Core.Application.Mapping;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AkademiPlusMicroservice.Services.Order.Core.Application.Services
{
    public static class ServiceRegistration 
    {
        public static void AddApplicationServices(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
            services.AddAutoMapper(opt =>
            {
                opt.AddProfiles(new List<Profile>
                {
                    new AddressProfile(),
                    new OrderingProfile(),
                    new OrderDetailProfile()
                });
            });
        }

    }
}
