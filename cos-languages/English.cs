using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_languages
{
    public class English
    {

        // ERRORS

        public string err_cannotLogin = "Sorry, but we can't log you in. Please press enter to try again.";
        public string err_cannotconnecttopinghost = "There was an error while processing your request!";

        public string err_alreadyadministrator = "You already are an administrator!";
        public string err_badpassword = "Entered password isn't right. Please try again!";
        public string err_rootcannotlosepermissions = "User 'root' can't lose their permissions! Please log in as different user!";
        public string err_isnotadministrator = "You are not an administrator!";

        // END OF ERRORS


        // CONFIG MENU DESCRIPTION

        public string cfgmenu_title = "Config";
        public string cfgmenu_users = "Users";
        public string cfgmenu_personalization = "Personalization";
        public string cfgmenu_language = "Language";
        public string cfgmenu_back = "Back";


        public string cfgmenu_users_title = "Users";
        public string cfgmenu_users_listallusers = "List all users";
        public string cfgmenu_users_addauser = "Add a user";

        public string cfgmenu_users_listallusers_title = "List all users";
        public string cfgmenu_users_listallusers_selectauser = "Select a user";
        public string cfgmenu_users_listallusers_enterusername = "Enter the username";
        public string cfgmenu_users_listallusers_username = "Username";


        public string cfgmenu_personalization_title = "Personalization";
        public string cfgmenu_personalization_colors = "Colors";
        public string cfgmenu_personalization_titles = "Titles";

        public string cfgmenu_personalization_colors_title = "Colors";
        public string cfgmenu_personalization_colors_textcolor = "Text color";
        public string cfgmenu_personalization_colors_backgroundcolor = "Background color";

        public string cfgmenu_personalization_colors_textcolor_title = "Text color";
        public string cfgmenu_personalization_colors_textcolor_chooseacolor = "Choose a color";

        public string cfgmenu_personalization_colors_backgroundcolor_title = "Background color";
        public string cfgmenu_personalization_colors_backgroundcolor_chooseacolor = "Choose a color";

        // END OF CONFIG MENU DESCRIPTION


        // COLOR DECLARATION

        public string color_red = "Red";
        public string color_green = "Green";
        public string color_blue = "Blue";
        public string color_black = "Black";
        public string color_white = "White";
        public string color_yellow = "Yellow";
        public string color_magenta = "Magenta";

        // END OF COLOR DECLARATION


        // COMMAND DESCRIPTIONS

        public string cmd_ping_destinationip = "Destination IP: ";

        // END OF COMMAND DESCRIPTIONS


        // HELP DESCRIPTION

        // END OF HELP DESCRIPTION

    }
}
