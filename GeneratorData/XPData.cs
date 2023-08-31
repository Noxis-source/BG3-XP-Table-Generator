using DevExpress.Mvvm;
using GeneratorData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BG3_XP_Table_Generator {
    public class XPData : BindableBase {
        const int DEFAULT_MaxXP = 100000;
        const int DEFAULT_MinLvl = 1;
        const int DEFAULT_MaxLvl = 12;

        public double MaxXP { get => GetValue<double>(); set => SetValue(value); }
        public int MinLvl { get => GetValue<int>(); set => SetValue(value); }
        public int MaxLvl { get => GetValue<int>(); set => SetValue(value); }
        public ProgressionType Progression { get => GetValue<ProgressionType>(); set => SetValue(value); }

        public XPData() {
            MaxXP = DEFAULT_MaxXP;
            MinLvl = DEFAULT_MinLvl;
            MaxLvl = DEFAULT_MaxLvl;
            Progression = ProgressionType.Linear;
        }

        public void GenerateData(ICollection<XPDataRecord> source) {
            if (Progression == ProgressionType.Linear) {
                double limit = MaxLvl + 1;
                double sum = (limit - 1) * (limit / 2.0d);
                double root = MaxXP / sum;

                for (int i = MinLvl; i < limit; i++)
                    source.Add(new XPDataRecord(i, Convert.ToInt32(i * root)));
            }
        }
    }
}
