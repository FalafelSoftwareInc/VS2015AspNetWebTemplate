﻿using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace WebApplication5.ViewModels.Account
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }

        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}
