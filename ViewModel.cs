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
        public XPData XPData { get => GetValue<XPData>(); set => SetValue(value); }
        public ObservableCollection<XPDataRecord> XPDataRecords { get; set; } = new ObservableCollection<XPDataRecord>();
        IFolderBrowserDialogService FolderBrowserDialogService => GetService<IFolderBrowserDialogService>();
        public ViewModel() {
            XPData = new XPData();
        }

        [Command]
        public void GenerateTable() {
            XPDataRecords.Clear();

            double limit = XPData.MaxLvl + 1;
            double sum = (limit - 1) * (limit / 2.0d);
            double root = XPData.MaxXP / sum;

            for (int i = 1; i < limit; i++)
                XPDataRecords.Add(new XPDataRecord(i, Convert.ToInt32(i * root)));
        }

        [Command]
        public void Export() {
            if (FolderBrowserDialogService.ShowDialog()) {
                using (var dataStream = File.Create(Path.Combine(FolderBrowserDialogService.ResultPath, DataPath))) {
                    var dataString = $"key \"MaximumXPCap\",\"{XPData.MaxXP}\"";
                    var info = new UTF8Encoding(true).GetBytes(dataString);
                    dataStream.Write(info, 0, info.Length);
                }

                using (var xpDataStream = File.Create(Path.Combine(FolderBrowserDialogService.ResultPath, XPDataPath))) {
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
