﻿namespace Box.Properties {
    
    
    // This class allows you to handle specific events on the settings class:
    //  The SettingChanging event is raised before a setting's value is changed.
    //  The PropertyChanged event is raised after a setting's value is changed.
    //  The SettingsLoaded event is raised after the setting values are loaded.
    //  The SettingsSaving event is raised before the setting values are saved.
    public sealed partial class Settings {
        
        public Settings() {
            PropertyChanged += PropertyChangedEventHandler;
        }

        private void PropertyChangedEventHandler(object sender, System.ComponentModel.PropertyChangedEventArgs e) {
            Default.Save();
        }
     
    }
}