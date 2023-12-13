using BG3_XP_Table_Generator.Helpers;
using DevExpress.Xpf.Core;
using GeneratorData;
using System;
using System.Linq;
using System.Windows;

namespace BG3_XP_Table_Generator {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        const string settingsFileName = "BG3XPTableGenerator.json";

        static SettingsManager<AppSettings> settingsMan = new SettingsManager<AppSettings>(settingsFileName);

        static App() {
            AppDomain.CurrentDomain.UnhandledException += (_, __) => MessageBox.Show(__.ExceptionObject?.ToString());

            CompatibilitySettings.UseLightweightThemes = true;
            ApplicationThemeHelper.ApplicationThemeName = LightweightTheme.Win11Dark.Name;

            AppSettings = settingsMan.LoadSettings(new AppSettings() { SkipEmptyLevels = true });
        }

        public static void LoadSettings() {
            AppSettings = settingsMan.LoadSettings();
        }

        public static void SaveSettings() {
            settingsMan.SaveSettings(AppSettings);
        }

        public static AppSettings AppSettings { get; set; }
    }
}
