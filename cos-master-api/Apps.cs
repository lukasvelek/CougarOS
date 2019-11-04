using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cfg = cos_api_config;
using dis = cos_api_display;
using io = cos_api_io;
using lng = cos_languages;
using math = cos_api_math;
using file = cos_api_files;
using sys = cos_api_system;
using usr = cos_api_user;
using apps = cos_apps;

namespace cos_master_api
{
    public class Apps
    {
        cfg.System cfgapisys = new cfg.System();
        cfg.User cfgapiusr = new cfg.User();

        dis.Boot disboot = new dis.Boot();
        dis.InstallationScreen disdis = new dis.InstallationScreen();
        dis.Login dislog = new dis.Login();

        io.File iofile = new io.File();

        lng.Translator translator = new lng.Translator();

        math.SimpleMath msm = new math.SimpleMath();

        file.Browser fb = new file.Browser();

        sys.Boot sysboot = new sys.Boot();
        sys.FactoryReset sysfr = new sys.FactoryReset();
        sys.Installation sysins = new sys.Installation();
        sys.InstallationSubPrograms sysisp = new sys.InstallationSubPrograms();
        sys.Register sysreg = new sys.Register();
        sys.Terminal systerm = new sys.Terminal();
        sys.Thread systhread = new sys.Thread();

        usr.NormalUser usrnu = new usr.NormalUser();
        usr.SuperUser usrsu = new usr.SuperUser();
        usr.SuperUserCommands usrsuc = new usr.SuperUserCommands();

        apps.About app_about = new apps.About();
        apps.Calculator app_calculator = new apps.Calculator();
        apps.Cat app_cat = new apps.Cat();
        apps.Clock app_clock = new apps.Clock();
        apps.Help app_help = new apps.Help();
        apps.Notepad app_notepad = new apps.Notepad();
        apps.TextBrowser app_textbrowser = new apps.TextBrowser();
        apps.Yes app_yes = new apps.Yes();

        public string App_AboutVersion { get; private set; }
        public string App_CalculatorVersion { get; private set; }
        public string App_CatVersion { get; private set; }
        public string App_ClockVersion { get; private set; }
        public string App_HelpVersion { get; private set; }
        public string App_NotepadVersion { get; private set; }
        public string App_TextBrowserVersion { get; private set; }
        public string App_YesVersion { get; private set; }

        public Apps()
        {
            // App Versions
            App_AboutVersion = app_about.AppVersion;
            App_CalculatorVersion = app_calculator.AppVersion;
            App_CatVersion = app_cat.AppVersion;
            App_ClockVersion = app_clock.AppVersion;
            App_HelpVersion = app_help.AppVersion;
            App_NotepadVersion = app_notepad.AppVersion;
            App_TextBrowserVersion = app_textbrowser.AppVersion;
            App_YesVersion = app_yes.AppVersion;
        }
    }
}
