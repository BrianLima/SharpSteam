using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpSteam
{
    public class SteamGame
    {
        public string AppName { get; set; }
        public string exe { get; set; }
        public string StartDir { get; set; }
        public string icon { get; set; }
        public string ShortcutPath { get; set; }
        public string IsHidden { get; set; }
        public string AllowDesktopConfig { get; set; }
        public string OpenVR { get; set; }
        public string tags { get; set; }
    }
}
