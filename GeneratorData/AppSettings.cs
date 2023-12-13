using System;
using System.ComponentModel;
using System.Linq;

namespace GeneratorData {
    public class AppSettings : INotifyPropertyChanged {
        string lSLibPath;
        bool skipEmptyLevels;

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged(object? sender, PropertyChangedEventArgs e) {
            PropertyChanged?.Invoke(sender, e);
        }

        public string LSLibPath {
            get => lSLibPath;
            set {
                if (lSLibPath == value) {
                    return;
                }

                lSLibPath = value;
                OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(LSLibPath)));
            }
        }
        public bool SkipEmptyLevels {
            get => skipEmptyLevels;
            set {
                if (skipEmptyLevels == value) {
                    return;
                }

                skipEmptyLevels = value;
                OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(SkipEmptyLevels)));
            }
        }
    }
}
