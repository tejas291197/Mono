﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MonoOvens.Models;
using Microsoft.Extensions.Configuration;

namespace MonoOvens.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly SignInManager<UserMaster> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly IConfiguration _config;

        public LoginModel(SignInManager<UserMaster> signInManager, ILogger<LoginModel> logger    , IConfiguration config)
        {
            _signInManager = signInManager;
            _logger = logger;
            _config = config;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        // public async Task OnGetAsync(string returnUrl = null)
        public async Task<IActionResult> OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }
                     

            if (_signInManager.IsSignedIn(User))
            {
                returnUrl = "/Home/Index";
                return LocalRedirect(returnUrl);
            }
            else
            {
                returnUrl = returnUrl ?? Url.Content("~/");

                // Clear the existing external cookie to ensure a clean login process
                await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

                ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

                ReturnUrl = returnUrl;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            // returnUrl = returnUrl ?? Url.Content("~/");
            if (returnUrl == null)
            {
                returnUrl = "/Home/Index";          // this is used to redirect to dash board page after the login into the system. 
            }
            else
            {
                returnUrl = returnUrl ?? Url.Content("~/");
            }

            if (ModelState.IsValid)
            {

                if (!await GoogleRecaptchaHelper.IsReCaptchaPassedAsync(Request.Form["g-recaptcha-response"],
                _config["GoogleReCaptcha:secret"]))
                {
                    ModelState.AddModelError(string.Empty, "You failed the CAPTCHA");
                    return Page();
                }
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    return LocalRedirect("/Home/Index");
                }
                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
