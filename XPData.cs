using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG3_XP_Table_Generator {
    public class XPData : BindableBase {
        const int DEFAULT_MaxXP = 420000;
        const int DEFAULT_MaxLvl = 12;

        public double MaxXP { get => GetValue<double>(); set => SetValue(value); }
        public int MaxLvl { get => GetValue<int>(); set => SetValue(value); }

        public XPData() {
            MaxXP = DEFAULT_MaxXP;
            MaxLvl = DEFAULT_MaxLvl;
        }
    }
}
