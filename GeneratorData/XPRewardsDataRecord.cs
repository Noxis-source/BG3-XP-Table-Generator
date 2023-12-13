using DevExpress.Mvvm;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace GeneratorData {
    public class XPRewardsDataNode : BindableBase {
        public XPRewardsDataNode() {
            Factor = 1.0d;
        }

        public double Factor { get => GetValue<double>(); set => SetValue(value); }
        public string Name { get => GetValue<string>(); set => SetValue(value); }
        public ObservableCollection<XPRewardsDataRecord> Records { get; set; }
        public string UUID { get => GetValue<string>(); set => SetValue(value); }
    }

    public class XPRewardsDataRecord : BindableBase {
        public string Name { get => GetValue<string>(); set => SetValue(value); }
        public int Value { get => GetValue<int>(); set => SetValue(value); }
    }
}
