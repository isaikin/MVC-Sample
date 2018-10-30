﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SGU.Epam.ViewModel
{
	public class UserCreateVM
	{
		[Required]
		public string Login { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Display(Name = "Пароль")]
		public string Password { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[Compare("Password")]
		[Display(Name = "Подтверждение Пароль")]
		public string ConfirmPassword { get; set; }
	}
}