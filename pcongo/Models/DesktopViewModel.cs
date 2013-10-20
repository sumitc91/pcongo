using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace pcongo.Models
{
    public class DesktopViewModel
    {
        public List<UserFolder> userfolder { get; set; }
        public UserBackgroundImage userbackgroundimage { get; set; }
        public user user { get; set; }
    }
}