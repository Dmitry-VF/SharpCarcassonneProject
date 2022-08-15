using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpCarcassonneProject.Models
{
    internal static class RCRF
    {
        public static string Image = "/Assets/Tiles/RCRF";

        public static bool IsArmed = false;

        public static SideNames Left = SideNames.Road;
        public static SideNames Top = SideNames.City;
        public static SideNames Right = SideNames.Road;
        public static SideNames Bottom = SideNames.Field;
        
    }
}
