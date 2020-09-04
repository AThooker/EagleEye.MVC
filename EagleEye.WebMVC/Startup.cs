using EagleEye.Data;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EagleEye.WebMVC.Startup))]
namespace EagleEye.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }
        // In this method we will create default User roles and Admin user for login    
        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup create first Admin Role and create a default Admin User     
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin role    
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.UserName = "Austin";
                user.Email = "austintrent@icloud.com";

                string userPWD = "testing";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin    
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }
            // Creating User role     
            if (!roleManager.RoleExists("Contributor"))
            {
                var role = new IdentityRole();
                role.Name = "Contributor";
                roleManager.Create(role);

            }
            // Creating Employee role     
            if (!roleManager.RoleExists("Survivor"))
            {
                var role = new IdentityRole();
                role.Name = "Survivor";
                roleManager.Create(role);

            }
        }
    }
}
