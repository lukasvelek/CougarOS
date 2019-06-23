using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cos_languages
{
    public class Translator
    {

        English l_english = new English();
        Czech l_czech = new Czech();

        public string Translate(string language, string text)
        {
            switch (language)
            {
                case "English":
                    switch (text)
                    {
                        // Login Form
                        case "login_yourusername":
                            return l_english.login_yourusername;
                        case "login_yourpassword":
                            return l_english.login_yourpassword;

                        // Calculator App
                        case "app_calculator_number1":
                            return l_english.app_calculator_number1;
                        case "app_calculator_number2":
                            return l_english.app_calculator_number2;
                        case "app_calculator_function":
                            return l_english.app_calculator_function;

                        // Errors
                        case "err_cannotLogin":
                            return l_english.err_cannotLogin;
                        case "err_cannotconnecttopinghost":
                            return l_english.err_cannotconnecttopinghost;
                        case "err_alreadyadministrator":
                            return l_english.err_alreadyadministrator;
                        case "err_badpassword":
                            return l_english.err_badpassword;
                        case "err_rootcannotlosepermissions":
                            return l_english.err_rootcannotlosepermissions;
                        case "err_isnotadministrator":
                            return l_english.err_isnotadministrator;

                        // Config Menu
                        case "cfgmenu_title":
                            return l_english.cfgmenu_title;
                        case "cfgmenu_users":
                            return l_english.cfgmenu_users;
                        case "cfgmenu_personalization":
                            return l_english.cfgmenu_personalization;
                        case "cfgmenu_language":
                            return l_english.cfgmenu_language;
                        case "cfgmenu_back":
                            return l_english.cfgmenu_back;

                        case "cfgmenu_users_title":
                            return l_english.cfgmenu_users_title;
                        case "cfgmenu_users_listallusers":
                            return l_english.cfgmenu_users_listallusers;
                        case "cfgmenu_users_addauser":
                            return l_english.cfgmenu_users_addauser;
                        case "cfgmenu_users_listallusers_title":
                            return l_english.cfgmenu_users_listallusers_title;
                        case "cfgmenu_users_listallusers_selectauser":
                            return l_english.cfgmenu_users_listallusers_selectauser;
                        case "cfgmenu_users_listallusers_enterusername":
                            return l_english.cfgmenu_users_listallusers_enterusername;
                        case "cfgmenu_users_listallusers_username":
                            return l_english.cfgmenu_users_listallusers_username;

                        case "cfgmenu_personalization_title":
                            return l_english.cfgmenu_personalization_title;
                        case "cfgmenu_personalization_colors":
                            return l_english.cfgmenu_personalization_colors;
                        case "cfgmenu_personalization_titles":
                            return l_english.cfgmenu_personalization_titles;

                        case "cfgmenu_personalization_colors_title":
                            return l_english.cfgmenu_personalization_colors_title;
                        case "cfgmenu_personalization_colors_textcolor":
                            return l_english.cfgmenu_personalization_colors_textcolor;
                        case "cfgmenu_personalization_colors_backgroundcolor":
                            return l_english.cfgmenu_personalization_colors_backgroundcolor;

                        case "cfgmenu_personalization_colors_textcolor_title":
                            return l_english.cfgmenu_personalization_colors_textcolor_title;
                        case "cfgmenu_personalization_colors_textcolor_chooseacolor":
                            return l_english.cfgmenu_personalization_colors_textcolor_chooseacolor;

                        case "cfgmenu_personalization_colors_backgroundcolor_title":
                            return l_english.cfgmenu_personalization_colors_backgroundcolor_title;
                        case "cfgmenu_personalization_colors_backgroundcolor_chooseacolor":
                            return l_english.cfgmenu_personalization_colors_backgroundcolor_chooseacolor;

                        case "cfgmenu_language_title":
                            return l_english.cfgmenu_language_title;
                        case "cfgmenu_language_choosealanguage":
                            return l_english.cfgmenu_language_choosealanguage;
                        case "cfgmenu_language_english":
                            return l_english.cfgmenu_language_english;
                        case "cfgmenu_language_czech":
                            return l_english.cfgmenu_language_czech;

                        // Colors
                        case "color_red":
                            return l_english.color_red;
                        case "color_green":
                            return l_english.color_green;
                        case "color_blue":
                            return l_english.color_blue;
                        case "color_black":
                            return l_english.color_black;
                        case "color_white":
                            return l_english.color_white;
                        case "color_yellow":
                            return l_english.color_yellow;
                        case "color_magenta":
                            return l_english.color_magenta;

                        // Commands
                        case "cmd_ping_destinationip":
                            return l_english.cmd_ping_destinationip;

                        default:
                            return null;
                    }

                case "Czech":
                    switch (text)
                    {
                        // Login Form
                        case "login_yourusername":
                            return l_czech.login_yourusername;
                        case "login_yourpassword":
                            return l_czech.login_yourpassword;

                        // Calculator App
                        case "app_calculator_number1":
                            return l_czech.app_calculator_number1;
                        case "app_calculator_number2":
                            return l_czech.app_calculator_number2;
                        case "app_calculator_function":
                            return l_czech.app_calculator_function;

                        // Errors
                        case "err_cannotLogin":
                            return l_czech.err_cannotLogin;
                        case "err_cannotconnecttopinghost":
                            return l_czech.err_cannotconnecttopinghost;
                        case "err_alreadyadministrator":
                            return l_czech.err_alreadyadministrator;
                        case "err_badpassword":
                            return l_czech.err_badpassword;
                        case "err_rootcannotlosepermissions":
                            return l_czech.err_rootcannotlosepermissions;
                        case "err_isnotadministrator":
                            return l_czech.err_isnotadministrator;

                        // Config Menu
                        case "cfgmenu_title":
                            return l_czech.cfgmenu_title;
                        case "cfgmenu_users":
                            return l_czech.cfgmenu_users;
                        case "cfgmenu_personalization":
                            return l_czech.cfgmenu_personalization;
                        case "cfgmenu_language":
                            return l_czech.cfgmenu_language;
                        case "cfgmenu_back":
                            return l_czech.cfgmenu_back;

                        case "cfgmenu_users_title":
                            return l_czech.cfgmenu_users_title;
                        case "cfgmenu_users_listallusers":
                            return l_czech.cfgmenu_users_listallusers;
                        case "cfgmenu_users_addauser":
                            return l_czech.cfgmenu_users_addauser;
                        case "cfgmenu_users_listallusers_title":
                            return l_czech.cfgmenu_users_listallusers_title;
                        case "cfgmenu_users_listallusers_selectauser":
                            return l_czech.cfgmenu_users_listallusers_selectauser;
                        case "cfgmenu_users_listallusers_enterusername":
                            return l_czech.cfgmenu_users_listallusers_enterusername;
                        case "cfgmenu_users_listallusers_username":
                            return l_czech.cfgmenu_users_listallusers_username;

                        case "cfgmenu_personalization_title":
                            return l_czech.cfgmenu_personalization_title;
                        case "cfgmenu_personalization_colors":
                            return l_czech.cfgmenu_personalization_colors;
                        case "cfgmenu_personalization_titles":
                            return l_czech.cfgmenu_personalization_titles;

                        case "cfgmenu_personalization_colors_title":
                            return l_czech.cfgmenu_personalization_colors_title;
                        case "cfgmenu_personalization_colors_textcolor":
                            return l_czech.cfgmenu_personalization_colors_textcolor;
                        case "cfgmenu_personalization_colors_backgroundcolor":
                            return l_czech.cfgmenu_personalization_colors_backgroundcolor;

                        case "cfgmenu_personalization_colors_textcolor_title":
                            return l_czech.cfgmenu_personalization_colors_textcolor_title;
                        case "cfgmenu_personalization_colors_textcolor_chooseacolor":
                            return l_czech.cfgmenu_personalization_colors_textcolor_chooseacolor;

                        case "cfgmenu_personalization_colors_backgroundcolor_title":
                            return l_czech.cfgmenu_personalization_colors_backgroundcolor_title;
                        case "cfgmenu_personalization_colors_backgroundcolor_chooseacolor":
                            return l_czech.cfgmenu_personalization_colors_backgroundcolor_chooseacolor;

                        case "cfgmenu_language_title":
                            return l_czech.cfgmenu_language_title;
                        case "cfgmenu_language_choosealanguage":
                            return l_czech.cfgmenu_language_choosealanguage;
                        case "cfgmenu_language_english":
                            return l_czech.cfgmenu_language_english;
                        case "cfgmenu_language_czech":
                            return l_czech.cfgmenu_language_czech;

                        // Colors
                        case "color_red":
                            return l_czech.color_red;
                        case "color_green":
                            return l_czech.color_green;
                        case "color_blue":
                            return l_czech.color_blue;
                        case "color_black":
                            return l_czech.color_black;
                        case "color_white":
                            return l_czech.color_white;
                        case "color_yellow":
                            return l_czech.color_yellow;
                        case "color_magenta":
                            return l_czech.color_magenta;

                        // Commands
                        case "cmd_ping_destinationip":
                            return l_czech.cmd_ping_destinationip;

                        default:
                            return null;
                    }

                default:
                    return null;
            }
        }

    }
}
