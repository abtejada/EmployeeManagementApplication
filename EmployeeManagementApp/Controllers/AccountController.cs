using EmployeeManagementApp.Models;
using EmployeeManagementApp.Models.Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace EmployeeManagementApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly PMMContext _context; // Adjust to your actual EF DbContext class name

        public AccountController(PMMContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login(string? returnUrl = null)
        {
            if (User.Identity != null && User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Employee");
            }
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string? returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Check credentials in database table
            var credential = await _context.PmsPersonnelLogincredentials
                .FirstOrDefaultAsync(c => c.EmployeeId == model.EmployeeId && c.Password == model.Password);

            if (credential == null)
            {
                ModelState.AddModelError(string.Empty, "Invalid Employee ID or Password.");
                return View(model);
            }

            // Fetch personnel info to get the full name for audit logs
            var personnel = await _context.PmsPersonnelInformations
                .FirstOrDefaultAsync(p => p.EmployeeId == credential.EmployeeId);

            string fullName = personnel != null
                ? $"{personnel.GivenName ?? ""} {personnel.Surname ?? ""}".Trim()
                : "Unknown User";

            // Format required for audit log: Full Name (Employee ID)
            string auditDisplayName = !string.IsNullOrEmpty(fullName)
                ? $"{fullName} ({credential.EmployeeId})"
                : credential.EmployeeId;

            // Create claims for cookie authentication
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, auditDisplayName),
                new Claim(ClaimTypes.Role, credential.UserType ?? "Emp"),
                new Claim("EmployeeId", credential.EmployeeId)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));

            if (!string.IsNullOrEmpty(returnUrl) && Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }

            return RedirectToAction("Index", "Employee");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }
    }
}