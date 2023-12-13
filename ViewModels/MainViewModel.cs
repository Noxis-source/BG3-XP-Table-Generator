using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.UI;
using GeneratorData;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace BG3_XP_Table_Generator.ViewModels {
    public class MainViewModel : ViewModelBase {
        public MainViewModel() {
            XPData = new XPData();
            XPRewardsData = new XPRewardsData();
        }

        IDialogService DialogService => GetService<IDialogService>();
        IExportService ExportService => GetService<IExportService>();
        IFolderBrowserDialogService FolderBrowserDialogService => GetService<IFolderBrowserDialogService>();
        IOpenFileDialogService OpenFileDialogService => GetService<IOpenFileDialogService>();

        [Command]
        public void Export() {
            if (FolderBrowserDialogService.ShowDialog()) {
                ExportService.ExportPath = FolderBrowserDialogService.ResultPath;
                ExportService.ExportXPData(XPData);
                ExportService.ExportXPRewardsData(XPRewardsData);
                ExportService.ExportTreasureTable(XPData);
                ExportService.ExportMeta();
            }
        }

        [Command]
        public void GenerateTable() {
            XPData.GenerateData(App.AppSettings.SkipEmptyLevels);
        }

        [Command]
        public void LoadTreasureTable() {
            OpenFileDialogService.Filter = null;
            ((FileDialogServiceBase)OpenFileDialogService).DefaultFileName = null;
            if (OpenFileDialogService.ShowDialog())
                XPData.LoadTreasureTable(OpenFileDialogService.File);
        }

        [Command]
        public void Pack() {
            if (FolderBrowserDialogService.ShowDialog())
                Process.Start(App.AppSettings.LSLibPath, $"-g \"bg3\" --action \"create-package\" --source \"{FolderBrowserDialogService.ResultPath}\" --destination \"{FolderBrowserDialogService.ResultPath}.pak\" -l \"all\"");
        }

        [Command]
        public void ResetTreasureTable() {
            XPData.ResetTreasureTable();
        }

        [Command]
        public void SelectLSLib() {
            OpenFileDialogService.Filter = "Executable (.exe)|*.exe";
            ((FileDialogServiceBase)OpenFileDialogService).DefaultFileName = "divine.exe";
            if (OpenFileDialogService.ShowDialog() && OpenFileDialogService.File.Name == "divine.exe")
                App.AppSettings.LSLibPath = Path.Combine(OpenFileDialogService.File.DirectoryName, OpenFileDialogService.File.Name);
        }

        [Command]
        public void ShowSettings() {
            if (DialogService.ShowDialog(MessageButton.OKCancel, "Settings", "SettingsView", this) == MessageResult.OK)
                App.SaveSettings();
            else
                App.LoadSettings();
        }

        public XPData XPData { get => GetValue<XPData>(); set => SetValue(value); }
        public XPRewardsData XPRewardsData { get => GetValue<XPRewardsData>(); set => SetValue(value); }
    }
}
