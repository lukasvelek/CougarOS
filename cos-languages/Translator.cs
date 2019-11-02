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
                        // Basic
                        case "yes":
                            return l_english.yes;
                        case "no":
                            return l_english.no;

                        // Terminal
                        case "terminal_yourpassword":
                            return l_english.terminal_yourpassword;

                        // Login Form
                        case "login_yourusername":
                            return l_english.login_yourusername;
                        case "login_yourpassword":
                            return l_english.login_yourpassword;

                        /*// Calculator App
                        case "app_calculator_number1":
                            return l_english.app_calculator_number1;
                        case "app_calculator_number2":
                            return l_english.app_calculator_number2;
                        case "app_calculator_function":
                            return l_english.app_calculator_function;*/

                        // Calculator App
                        case "app_calculator_number":
                            return l_english.app_calculator_number;
                        case "app_calculator_operation":
                            return l_english.app_calculator_operation;
                        case "app_calculator_continue":
                            return l_english.app_calculator_continue;
                        case "app_calculator_yes":
                            return l_english.app_calculator_yes;
                        case "app_calculator_no":
                            return l_english.app_calculator_no;
                        case "app_calculator_theresultis":
                            return l_english.app_calculator_theresultis;
                        case "app_calculator_pressentertogoback":
                            return l_english.app_calculator_pressentertogoback;

                        // About App
                        case "app_about_system_name":
                            return l_english.app_about_system_name;
                        case "app_about_system_build":
                            return l_english.app_about_system_build;
                        case "app_about_system_version":
                            return l_english.app_about_system_version;
                        case "app_about_system_codename":
                            return l_english.app_about_system_codename;

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
                        case "err_nocommandfoundfor":
                            return l_english.err_nocommandfoundfor;

                        // Config Menu
                        case "cfgmenu_title":
                            return l_english.cfgmenu_title;
                        case "cfgmenu_users":
                            return l_english.cfgmenu_users;
                        case "cfgmenu_personalization":
                            return l_english.cfgmenu_personalization;
                        case "cfgmenu_language":
                            return l_english.cfgmenu_language;
                        case "cfgmenu_system":
                            return l_english.cfgmenu_system;
                        case "cfgmenu_back":
                            return l_english.cfgmenu_back;


                        case "cfgmenu_system_title":
                            return l_english.cfgmenu_system_title;
                        case "cfgmenu_system_about":
                            return l_english.cfgmenu_system_about;
                        case "cfgmenu_system_factoryreset":
                            return l_english.cfgmenu_system_factoryreset;

                        case "cfgmenu_system_factoryreset_title":
                            return l_english.cfgmenu_system_factoryreset_title;
                        case "cfgmenu_system_factoryreset_message":
                            return l_english.cfgmenu_system_factoryreset_message;

                        case "cfgmenu_system_about_title":
                            return l_english.cfgmenu_system_about_title;
                        case "cfgmenu_system_about_systemversion":
                            return l_english.cfgmenu_system_about_systemversion;
                        case "cfgmenu_system_about_versioncodename":
                            return l_english.cfgmenu_system_about_versioncodename;
                        case "cfgmenu_system_about_systembuild":
                            return l_english.cfgmenu_system_about_systembuild;


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
                        case "cfgmenu_users_listallusers_enternumber":
                            return l_english.cfgmenu_users_listallusers_enternumber;
                        case "cfgmenu_users_listallusers_password":
                            return l_english.cfgmenu_users_listallusers_password;
                        case "cfgmenu_users_listallusers_permissions":
                            return l_english.cfgmenu_users_listallusers_permissions;
                        case "cfgmenu_users_listallusers_changepermissions":
                            return l_english.cfgmenu_users_listallusers_changepermissions;
                        case "cfgmenu_users_listallusers_deleteuser":
                            return l_english.cfgmenu_users_listallusers_deleteuser;
                        case "cfgmenu_users_listallusers_deleteuser_message":
                            return l_english.cfgmenu_users_listallusers_deleteuser_message;


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

                        // Types of users
                        case "usr_normal":
                            return l_english.usr_normal;
                        case "usr_admin":
                            return l_english.usr_admin;

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

                        // Clock App
                        case "app_clock_currenttime":
                            return l_english.app_clock_currenttime;
                        case "app_clock_setalarm":
                            return l_english.app_clock_setalarm;
                        case "app_clock_back":
                            return l_english.app_clock_back;

                        // -- Sudo commands --

                        // ## Sudo Update
                        case "su_sudo_update_checkingforupdates":
                            return l_english.su_sudo_update_checkingforupdates;
                        case "su_sudo_update_fetchingupdates":
                            return l_english.su_sudo_update_fetchingupdates;
                        case "su_sudo_update_pleasewait":
                            return l_english.su_sudo_update_pleasewait;
                        case "su_sudo_update_noupdatesfound":
                            return l_english.su_sudo_update_noupdatesfound;
                        case "su_sudo_update_possibleserveroutage":
                            return l_english.su_sudo_update_possibleserveroutage;
                        case "su_sudo_update_checkingserver":
                            return l_english.su_sudo_update_checkingserver;

                        // -- End of Sudo commands -- 

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

                        /*// Calculator App
                        case "app_calculator_number1":
                            return l_czech.app_calculator_number1;
                        case "app_calculator_number2":
                            return l_czech.app_calculator_number2;
                        case "app_calculator_function":
                            return l_czech.app_calculator_function;*/

                        // Calculator App
                        case "app_calculator_number":
                            return l_czech.app_calculator_number;
                        case "app_calculator_operation":
                            return l_czech.app_calculator_operation;
                        case "app_calculator_continue":
                            return l_czech.app_calculator_continue;
                        case "app_calculator_yes":
                            return l_czech.app_calculator_yes;
                        case "app_calculator_no":
                            return l_czech.app_calculator_no;
                        case "app_calculator_theresultis":
                            return l_czech.app_calculator_theresultis;
                        case "app_calculator_pressentertogoback":
                            return l_czech.app_calculator_pressentertogoback;

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

                        // Clock App
                        case "app_clock_currenttime":
                            return l_czech.app_clock_currenttime;
                        case "app_clock_setalarm":
                            return l_czech.app_clock_setalarm;
                        case "app_clock_back":
                            return l_czech.app_clock_back;

                        default:
                            return null;
                    }

                default:
                    return null;
            }
        }

    }
}
