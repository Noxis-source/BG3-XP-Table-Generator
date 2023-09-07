using BG3_XP_Table_Generator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorData {
    public interface IExportService {
        void Export(string path, XPData data);
    }
}
