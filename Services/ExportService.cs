using DevExpress.Mvvm.Native;
using DevExpress.Mvvm.UI;
using GeneratorData;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace BG3_XP_Table_Generator.Services {
    public class ExportService : ServiceBase, IExportService {

        const string BaseFolderPath = @"XP Mod";
        const string DataFolderPath = @"Data";
        const string DataPath = @"Data.txt";
        const string GeneratedFolderPath = @"Generated";
        const string LevelmapsPath = @"Levelmaps";
        const string MetaPath = @"meta.lsx";
        const string ModsPath = @"Mods";
        const string PublicPath = @"Public";
        const string StatsFolderPath = @"Stats";
        const string TreasureTablePath = @"TreasureTable.txt";
        const string XPDataPath = @"XPData.txt";
        const string XPRewardsDataPath = @"ExperienceRewards.lsx";

        string basePath;
        string contentPath;
        string dataPath;
        string exportPath;
        string generatedPath;
        string levelmapsPath;
        string metaPath;
        string modsPath;
        string publicPath;
        string statsPath;

        void InitFolders() {
            basePath = Path.Combine(ExportPath, BaseFolderPath);
            if (!Directory.Exists(basePath))
                Directory.CreateDirectory(basePath);

            modsPath = Path.Combine(basePath, ModsPath);
            if (!Directory.Exists(modsPath))
                Directory.CreateDirectory(modsPath);

            metaPath = Path.Combine(modsPath, BaseFolderPath);
            if (!Directory.Exists(metaPath))
                Directory.CreateDirectory(metaPath);

            publicPath = Path.Combine(basePath, PublicPath);
            if (!Directory.Exists(publicPath))
                Directory.CreateDirectory(publicPath);

            contentPath = Path.Combine(publicPath, BaseFolderPath);
            if (!Directory.Exists(contentPath))
                Directory.CreateDirectory(contentPath);

            levelmapsPath = Path.Combine(contentPath, LevelmapsPath);
            if (!Directory.Exists(levelmapsPath))
                Directory.CreateDirectory(levelmapsPath);

            statsPath = Path.Combine(contentPath, StatsFolderPath);
            if (!Directory.Exists(statsPath))
                Directory.CreateDirectory(statsPath);

            generatedPath = Path.Combine(statsPath, GeneratedFolderPath);
            if (!Directory.Exists(generatedPath))
                Directory.CreateDirectory(generatedPath);

            dataPath = Path.Combine(generatedPath, DataFolderPath);
            if (!Directory.Exists(dataPath))
                Directory.CreateDirectory(dataPath);
        }

        public void ExportMeta() {
            using (var metaStream = File.Create(Path.Combine(metaPath, MetaPath))) {
                var info = new UTF8Encoding(true).GetBytes(XPData.META_BASE);
                metaStream.Write(info, 0, info.Length);
            }
        }

        public void ExportTreasureTable(XPData data) {
            using (var treasureStream = File.Create(Path.Combine(generatedPath, TreasureTablePath))) {
                var treasureString = data.ActualTreasureTable == XPData.TREASURE_TABLE_BASE ?
                    XPData.TREASURE_TABLE_BASE.Replace("EndLevel \"\"", $"EndLevel \"{data.MaxLvl}\"") :
                    data.ActualTreasureTable;
                var info = new UTF8Encoding(true).GetBytes(treasureString);
                treasureStream.Write(info, 0, info.Length);
            }
        }

        public void ExportXPData(XPData data) {
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

        public void ExportXPRewardsData(XPRewardsData data) {
            var nodes = data.XDocument
                .Element("save")
                .Element("region")
                .Element("node")
                .Element("children")
                .Elements("node");

            data.XPRewardsDataRecords.ForEach(x => x.Records.ForEach(y => {
                var node = nodes.Where(z => z.Elements().Any(a => a.Attribute("id").Value == "UUID" && a.Attribute("value").Value == x.UUID));
                node.Elements().Where(z => z.Attribute("id").Value == y.Name).First().Attribute("value").Value = (y.Value * x.Factor).ToString();
            }));

            using (var xpRewardsStream = File.Create(Path.Combine(levelmapsPath, XPRewardsDataPath)))
                data.XDocument.Save(xpRewardsStream);
        }

        public string ExportPath {
            get => exportPath;
            set {
                exportPath = value;
                InitFolders();
            }
        }
    }
}
