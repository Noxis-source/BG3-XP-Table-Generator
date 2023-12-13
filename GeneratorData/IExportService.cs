using BG3_XP_Table_Generator;
using System;
using System.Linq;

namespace GeneratorData {
    public interface IExportService {
        void ExportMeta();
        void ExportTreasureTable(XPData data);
        void ExportXPData(XPData data);
        void ExportXPRewardsData(XPRewardsData data);

        string ExportPath { get; set; }
    }
}
