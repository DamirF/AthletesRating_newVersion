using System.Drawing;
using System.Windows.Forms;

namespace MainApplication.GeneralFunctionality
{
    internal class Submenu
    {
        public static void customizeDesign(ref Button[] buttons, params Panel[] submenu)
        {
            foreach (var submenuItem in submenu)
                submenuItem.Visible = false;

            foreach (var btn in buttons)
                btn.BackColor = Color.Black;
        }

        public static void hideSubmenu(ref Button[] buttons, params Panel[] submenu)
        {
            foreach(var submenuItem in submenu)
            {
                if(submenuItem.Visible)
                    submenuItem.Visible=false;
            }
            foreach (var btn in buttons)
                btn.BackColor = Color.Black;
        }

        public static void showSubmenu(Button btn, ref Button[] menuButtons, Panel submenu, Panel[] panelsSubmenu)
        {
            if (!submenu.Visible)
            {
                hideSubmenu(ref menuButtons, panelsSubmenu);
                submenu.Visible = true;
                btn.BackColor = Color.DarkGray;
            }
            else
            {
                submenu.Visible = false;
                btn.BackColor = Color.Black;
            }
        }
    }
}
