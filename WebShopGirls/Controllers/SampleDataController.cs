using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebShopGirls.Models;

namespace WebShopGirls.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
    //    [HttpPost]
    //    public async void Post([FromBody]Registration reg)
    //    {

    //        var oktaClient = new OktaClient();
    //        var user = await oktaClient.Users.CreateUserAsync(
    //            new CreateUserWithPasswordOptions
    //            {
    //                Profile = new UserProfile
    //                {
    //                    FirstName = reg.FirstName,
    //                    LastName = reg.LastName,
    //                    Email = reg.Email,
    //                    Login = reg.Email
    //                },
    //                Password = reg.Password,
    //                Activate = true
    //            }
    //        );
    //    }
    }
}
