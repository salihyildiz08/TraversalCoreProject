﻿using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using TraversalCoreProject.Areas.Member.Models;

namespace TraversalCoreProject.Areas.Member.Controllers
{
    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    [AllowAnonymous]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var value = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();

            userEditViewModel.name = value.Name;
            userEditViewModel.surName = value.SurName;
            userEditViewModel.phoneNumber = value.PhoneNumber;
            userEditViewModel.mail = value.Email;


            return View(userEditViewModel);
        }


        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user=await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream=new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }

            user.Name = p.name;
            user.PhoneNumber = p.phoneNumber;
            user.SurName = p.surName;
            if (p.password!=null)
            {
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            }
           

            var result=await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("SignIn","Login");
            }

            return View();
        }
    }
}
