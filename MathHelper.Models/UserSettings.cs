using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelper.Models
{
    public class UserSettings
    {
        public int Id { get; set; }

        public ApplicationUser User { get; set; }

        public string PhotoPath { get; set; }

        public RolesType Role { get; set; }

        public SiteTheme Theme { get; set; }

        public UserLanguage Language { get; set; }
    }
}
