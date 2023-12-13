using DevExpress.Mvvm;
using System;
using System.Linq;

namespace BG3_XP_Table_Generator {
    public class XPDataRecord : BindableBase {
        public XPDataRecord(int level, int xp) {
            Level = level;
            XP = xp;
        }

        public int Level { get => GetValue<int>(); set => SetValue(value); }
        public int XP { get => GetValue<int>(); set => SetValue(value); }
    }
}
