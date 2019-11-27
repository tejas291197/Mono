﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MonoOvens.Models;

namespace MonoOvens.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly SignInManager<UserMaster> _signInManager;
        private readonly MonoContext _context;
        private readonly UserManager<UserMaster> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ILogger<RegisterModel> _logger;
     //   private readonly IEmailSender _emailSender;

        public RegisterModel(
            UserManager<UserMaster> userManager,
            RoleManager<IdentityRole> roleManager,
            SignInManager<UserMaster> signInManager,
            MonoContext context,
            ILogger<RegisterModel> logger )
       //     IEmailSender emailSender)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _context = context;
            _logger = logger;
      //      _emailSender = emailSender;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel:IdentityRole
        {
            [Required]
            [EmailAddress]
            [Display(Name = "Email")]
            public string Email { get; set; }

            [Required]
            [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            [Display(Name = "Password")]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirm password")]
            [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
            public string ConfirmPassword { get; set; }
            public string Role { get; set; }

        }

        public void OnGet(string returnUrl = null)
        {
            var roleList = _roleManager.Roles.ToList();
            roleList.Insert(0, new IdentityRole { Id = "0", Name = "---Select---" });
            ViewData["rolesOfUser"] = roleList;
            ReturnUrl = returnUrl;

        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
               
                var user = new UserMaster { UserName = Input.Email, Email = Input.Email ,AccessRole=Input.Role};
                var roleName = _context.Roles.SingleOrDefault(r => r.Id == user.AccessRole).Name;                
                var result = await _userManager.CreateAsync(user, Input.Password);
                var roleResult = await _userManager.AddToRoleAsync(user, roleName);
                if (result.Succeeded && roleResult.Succeeded)
                {
                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                   // await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                      //  $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return LocalRedirect(returnUrl);
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
