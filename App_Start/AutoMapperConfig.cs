using KnockoutMVCFinal.Models;
using KnockoutMVCFinal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KnockoutMVCFinal.App_Start
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {
            AutoMapper.Mapper.Initialize(cfg => {
                cfg.CreateMap<Author, AuthorViewModel>();
                //cfg.CreateMap<Customer, RegisterViewModel>();
            });
        }
    }
}