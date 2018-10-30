using AutoMapper;
using Sgu.Entities;
using SGU.Epam.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SGU.Epam.App_Start
{
	public static class AutoMapperConfig
	{
		public static void Config()
		{
			Mapper.Initialize(cfg =>
			{
				cfg.CreateMap<UserCreateVM, User>()
				.ForMember(d => d.Age, opt => opt.Ignore())
				.ForMember(d => d.Name, opt => opt.Ignore());

				cfg.CreateMap<User, UserCreateVM>()
				.ForMember(d => d.ConfirmPassword, opt => opt.Ignore());
		


			});

			Mapper.Configuration.AssertConfigurationIsValid();
		}
	}
}