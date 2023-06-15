using eUseControl.Domain.Entities;
using eUseControl.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace eUseControl.BusinessLogic.Database
{
    public class BlogDbInitializer : DropCreateDatabaseIfModelChanges<BlogDbContext>
	{
		protected override void Seed(BlogDbContext context)
		{
            var user = context.Users.Add(new User()
            {
                Name = "Евгений Бондарчук",
                PasswordHash = AuthHelper.GeneratePasswordHash("123"),
                Email = "evghenii.bondarciuc@isa.utm.md",
                Role = UserRole.Admin
            });

            context.Users.Add(new User()
            {
                Name = "Никита Максимчук",
                PasswordHash = AuthHelper.GeneratePasswordHash("123"),
                Email = "nichita.maximciuc@isa.utm.md",
            });

			context.Users.Add(new User() 
            { 
                Name = "Виталий Димов", 
                PasswordHash = AuthHelper.GeneratePasswordHash("123"), 
                Email = "vitali.dimov@isa.utm.md", 
            });

            context.Users.Add(new User()
            {
                Name = "Вадим Адвахов",
                PasswordHash = AuthHelper.GeneratePasswordHash("123"),
                Email = "vadim.advahov@isa.utm.md",
                Role = UserRole.Admin
            });

            context.Users.Add(new User()
            {
                Name = "Евстафий Бугай",
                PasswordHash = AuthHelper.GeneratePasswordHash("123"),
                Email = "evstafii.bugai@isa.utm.md",
            });

            //---------------------------------------------------//
            base.Seed(context);
		}
	}
}