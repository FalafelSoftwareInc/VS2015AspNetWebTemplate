using System.Collections.Generic;
using Microsoft.AspNet.Mvc.Rendering;

namespace WebApplication5.Models
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }

        public ICollection<SelectListItem> Providers { get; set; }
    }
}
