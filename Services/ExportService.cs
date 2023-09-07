using DevExpress.Data.Browsing;
using DevExpress.Mvvm.UI;
using GeneratorData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG3_XP_Table_Generator.Services
{
    public class ExportService : ServiceBase, IExportService {
        const string DataPath = @"Data.txt";
        const string XPDataPath = @"XPData.txt";
        const string TreasureTablePath = @"TreasureTable.txt";

        const string StatsFolderPath = @"Stats";
        const string GeneratedFolderPath = @"Generated";
        const string DataFolderPath = @"Data";
        public void Export(string path, XPData data) {
            var statsPath = Path.Combine(path, StatsFolderPath);
            if (!Directory.Exists(statsPath))
                Directory.CreateDirectory(statsPath);

            var generatedPath = Path.Combine(statsPath, GeneratedFolderPath);
            if (!Directory.Exists(generatedPath))
                Directory.CreateDirectory(generatedPath);

            var dataPath = Path.Combine(generatedPath, DataFolderPath);
            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);

            using (var treasureStream = File.Create(Path.Combine(generatedPath, TreasureTablePath))) {
                var treasureString = XPData.TREASURE_TABLE.Replace("EndLevel \"\"", $"EndLevel \"{data.MaxLvl}\"");
                var info = new UTF8Encoding(true).GetBytes(treasureString);
                treasureStream.Write(info, 0, info.Length);
            }

            using (var dataStream = File.Create(Path.Combine(dataPath, DataPath))) {
                var dataString = $"key \"MaximumXPCap\",\"{data.MaxXP}\"";
                var info = new UTF8Encoding(true).GetBytes(dataString);
                dataStream.Write(info, 0, info.Length);
            }

            using (var xpDataStream = File.Create(Path.Combine(dataPath, XPDataPath))) {
                foreach (var item in data.XPDataRecords) {
                    var xpDataString = $"key \"Level{item.Level}\",\"{item.XP}\"\r\n\r\n";
                    var info = new UTF8Encoding(true).GetBytes(xpDataString);
                    xpDataStream.Write(info, 0, info.Length);
                }

                var maxLevelString = $"key \"MaxXPLevel\",\"{data.MaxLvl}\"\r\n";
                var maxLevelInfo = new UTF8Encoding(true).GetBytes(maxLevelString);
                xpDataStream.Write(maxLevelInfo, 0, maxLevelInfo.Length);
            }
        }
    }
}
