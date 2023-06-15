﻿using System.ComponentModel.DataAnnotations;

namespace eUseControl.Web.Models
{
	public class LoginForm
	{
		[Required]
		public string Email { get; set; }
		[Required]
		public string Password { get; set; }
	}
}