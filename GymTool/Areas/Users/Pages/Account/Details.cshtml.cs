using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymTool.Areas.Users.Models;
using GymTool.Data;
using GymTool.Library;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GymTool.Areas.Users.Pages.Account
{
    public class DetailsModel : PageModel
    {
        private SignInManager<IdentityUser> _signInManager;
        private LUser _user;
        private String roleAdmin = "Administrador";

        public DetailsModel(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            _signInManager = signInManager;
            _user = new LUser(userManager, signInManager, roleManager, context);
        }
        public void OnGet(int id)
        {
            if (_signInManager.IsSignedIn(User) && User.IsInRole(roleAdmin))
            {
                var data = _user.getTUsuariosAsync(null, id, "");
                if (0 < data.Result.Count)
                {
                    Input = new InputModel
                    {
                        DataUser = data.Result.ToList().Last(),
                    };
                }
                else
                {
                    Response.Redirect("/Users/Users?area=Users");
                    Input = new InputModel
                    {
                        DataUser = null,
                    };
                }
            }
            else
            {
                Response.Redirect("https://localhost:44312/");
                Input = new InputModel
                {
                    DataUser = null,
                };
            }
        }
        [BindProperty]
        public InputModel Input { get; set; }
        public class InputModel
        {
            public InputModelRegister DataUser { get; set; }
        }
    }
}
