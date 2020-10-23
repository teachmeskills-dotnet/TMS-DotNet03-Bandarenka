using Filmary.BLL.Interfaces;
using Filmary.BLL.Models;
using Filmary.DAL.Models;
using Filmary.Web.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Filmary.Web.Controllers
{
   
        public class ProfileController : Controller
        {
            private readonly UserManager<User> _userManager;
            private readonly IProfileService _profileService;

            /// <summary>
            /// Constructor
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="signInManager"></param>
            /// <param name="profileService"></param>
            public ProfileController(UserManager<User> userManager, SignInManager<User> signInManager, IProfileService profileService)
            {
                _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
                _profileService = profileService ?? throw new ArgumentNullException(nameof(profileService));
            }

            /// <summary>
            /// Get profile
            /// </summary>
            /// <returns>Profile model</returns>
            [Authorize]
            [HttpGet]
            public async Task<IActionResult> Profile()
            {
                var username = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(username);
                var profile = await _profileService.GetProfileByUserId(user.Id);
                var model = new ProfileViewModel { FullName = profile.FullName };
                return View(model);
            }

            /// <summary>
            /// Change password model
            /// </summary>
            /// <returns>User model</returns>
            public async Task<IActionResult> EditProfile()
            {
                var username = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(username);
                var profile = await _profileService.GetProfileByUserId(user.Id);
                var model = new ProfileViewModel { FullName = profile.FullName};
                return View(model);
            }

            /// <summary>
            /// Edit user profile
            /// </summary>
            /// <param name="editProfile"></param>
            /// <returns>Result edit profile</returns>
            [Authorize]
            [HttpPost]
            public async Task<IActionResult> EditProfile(ProfileViewModel editProfile)
            {
                var username = User.Identity.Name;
                var user = await _userManager.FindByNameAsync(username);
                var getProfile = await _profileService.GetProfileByUserId(user.Id);

                var profile = new Profiledto
                {
                    Id = getProfile.Id,
                    FullName = editProfile.FullName,
                    
                };

                await _profileService.Edit(profile);
                return RedirectToAction("Profile");
            }

            
           
            }
        }
    
