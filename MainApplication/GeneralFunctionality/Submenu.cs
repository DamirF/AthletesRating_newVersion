using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace MainApplication.GeneralFunctionality
{
    internal class Submenu
    {
        public static void customizeDesign(params Panel[] submenu)
        {
            foreach (var submenuItem in submenu)
                submenuItem.Visible = false;
        }

        public static void hideSubmenu(params Panel[] submenu)
        {
            foreach(var submenuItem in submenu)
            {
                if(submenuItem.Visible)
                    submenuItem.Visible=false;
            }
        }

        public static void showSubmenu(Panel submenu, Panel[] panelsSubmenu)
        {
            if (!submenu.Visible)
            {
                hideSubmenu(panelsSubmenu);
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }
    }
}
