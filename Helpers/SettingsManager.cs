using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace BG3_XP_Table_Generator.Helpers {
    public class SettingsManager<T> where T : class {
        private readonly string _filePath;

        public SettingsManager(string fileName) {
            _filePath = GetLocalFilePath(fileName);
        }

        protected string GetLocalFilePath(string fileName) {
            string appData = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            return Path.Combine(appData, fileName);
        }

        public T LoadSettings(T defaultSettings = null) {
            if (!File.Exists(_filePath) && defaultSettings != null)
                SaveSettings(defaultSettings);
            return JsonConvert.DeserializeObject<T>(File.ReadAllText(_filePath));
        }

        public void SaveSettings(T settings) {
            string json = JsonConvert.SerializeObject(settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
