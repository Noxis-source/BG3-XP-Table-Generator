using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using GeneratorData;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows;
using System.Windows.Resources;

namespace BG3_XP_Table_Generator {
    public class ViewModel : ViewModelBase {
        public XPData XPData { get => GetValue<XPData>(); set => SetValue(value); }
        IFolderBrowserDialogService FolderBrowserDialogService => GetService<IFolderBrowserDialogService>();
        IExportService ExportService => GetService<IExportService>();
        public ViewModel() {
            XPData = new XPData();
        }

        [Command]
        public void GenerateTable() {
            XPData.GenerateData();
        }

        [Command]
        public void Export() {
            if (FolderBrowserDialogService.ShowDialog()) {
                ExportService.Export(FolderBrowserDialogService.ResultPath, XPData);
            }
        }
    }
}
