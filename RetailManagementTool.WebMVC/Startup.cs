﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using RetailManagementTool.Data;
using System.Data.Entity.Migrations;

[assembly: OwinStartupAttribute(typeof(RetailManagementTool.WebMVC.Startup))]
namespace RetailManagementTool.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
            Seed();
        }


        //Create default User roles and Admin user for login  
        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            //Creating first Admin Role and creating a default Admin User     
            if (!roleManager.RoleExists("Admin"))
            {

                //Create Admin role    
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Create an Admin super user who will maintain the website                   
                var user = new ApplicationUser();
                user.UserName = "Master";
                user.Email = "master@gmail.com";
                string userPWD = "Master1!";

                var chkUser = userManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = userManager.AddToRole(user.Id, "Admin");
                }
            }

            //Creating Employee role     
            if (!roleManager.RoleExists("Employee"))
            {
                var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
                role.Name = "Employee";
                roleManager.Create(role);

            }
        }
        private void Seed()
        {

            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

            context.Departments.AddOrUpdate
                (
                x => x.DepartmentName,
                new Department()
                {
                    DepartmentNumber = "94",
                    DepartmentName = "Dresses",
                },
                new Department()
                {
                    DepartmentNumber = "06",
                    DepartmentName = "Accessories"
                }
                );
            context.SaveChanges();

        }
    }
}
