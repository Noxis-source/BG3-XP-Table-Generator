using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Mvvm.Native;
using DevExpress.Utils.About;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BG3_XP_Table_Generator {
    public class ViewModel : ViewModelBase {
        const string DataPath = @"Data.txt";
        const string XPDataPath = @"XPData.txt";
        const string TreasureTablePath = @"TreasureTable.txt";

        const string StatsFolderPath = @"Stats";
        const string GeneratedFolderPath = @"Generated";
        const string DataFolderPath = @"Data";

        public XPData XPData { get => GetValue<XPData>(); set => SetValue(value); }
        public ObservableCollection<XPDataRecord> XPDataRecords { get; set; } = new ObservableCollection<XPDataRecord>();
        IFolderBrowserDialogService FolderBrowserDialogService => GetService<IFolderBrowserDialogService>();
        public ViewModel() {
            XPData = new XPData();
        }

        [Command]
        public void GenerateTable() {
            XPDataRecords.Clear();
            XPData.GenerateData(XPDataRecords);
        }

        [Command]
        public void Export() {
            if (FolderBrowserDialogService.ShowDialog()) {
                if (!Directory.Exists(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath)))
                    Directory.CreateDirectory(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath));

                if (!Directory.Exists(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath)))
                    Directory.CreateDirectory(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath));

                if (!Directory.Exists(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath, GeneratedFolderPath)))
                    Directory.CreateDirectory(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath, GeneratedFolderPath));

                using (var treasureStream = File.Create(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath, TreasureTablePath))) {
                    var treasureString = File.ReadAllText("TreasureTable.txt").Replace("EndLevel \"\"", $"EndLevel \"{XPData.MaxLvl}\"");
                    var info = new UTF8Encoding(true).GetBytes(treasureString);
                    treasureStream.Write(info, 0, info.Length);
                }

                using (var dataStream = File.Create(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath, GeneratedFolderPath, DataPath))) {
                    var dataString = $"key \"MaximumXPCap\",\"{XPData.MaxXP}\"";
                    var info = new UTF8Encoding(true).GetBytes(dataString);
                    dataStream.Write(info, 0, info.Length);
                }

                using (var xpDataStream = File.Create(Path.Combine(FolderBrowserDialogService.ResultPath, StatsFolderPath, DataFolderPath, GeneratedFolderPath, XPDataPath))) {
                    foreach (var item in XPDataRecords) {
                        var xpDataString = $"key \"Level{item.Level}\",\"{item.XP}\"\r\n\r\n";
                        var info = new UTF8Encoding(true).GetBytes(xpDataString);
                        xpDataStream.Write(info, 0, info.Length);
                    }

                    var maxLevelString = $"key \"MaxXPLevel\",\"{XPData.MaxLvl}\"\r\n";
                    var maxLevelInfo = new UTF8Encoding(true).GetBytes(maxLevelString);
                    xpDataStream.Write(maxLevelInfo, 0, maxLevelInfo.Length);
                }
            }
        }
    }
}
