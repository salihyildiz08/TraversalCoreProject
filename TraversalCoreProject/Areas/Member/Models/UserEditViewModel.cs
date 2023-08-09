﻿using Microsoft.AspNetCore.Http;

namespace TraversalCoreProject.Areas.Member.Models
{
    public class UserEditViewModel
    {
        public string name { get; set; }
        public string surName { get; set; }
        public string password { get; set; }
        public string comfirmPassword { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
        public string imageUrl { get; set; }
        public IFormFile Image { get; set; }
    }
}
