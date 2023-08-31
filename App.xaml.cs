using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace BG3_XP_Table_Generator {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        static App() {
            AppDomain.CurrentDomain.UnhandledException += (_, __) => MessageBox.Show(__.ExceptionObject?.ToString());

            ApplicationThemeHelper.ApplicationThemeName = Theme.Win11DarkName;
        }
    }
}
