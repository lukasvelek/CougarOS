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
    public class System
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

        public string SystemVersion { get; private set; }
        public string SystemBuild { get; private set; }
        public string SystemVersionCodename { get; private set; }
        public string Language { get; private set; }
        public string Username { get; private set; }
        public string Permissions { get; private set; }

        public System()
        {
            // System Information
            SystemVersion = cfgapisys.SystemVersion;
            SystemBuild = cfgapisys.SystemBuild;
            SystemVersionCodename = cfgapisys.SystemVersionCodename;
            Language = cfgapisys.Language;

            // Current Session Information
            Username = cfgapiusr.CurrentUserUsername;
            Permissions = cfgapiusr.CurrentUserPermission;
        }

    }
}
