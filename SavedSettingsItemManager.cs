using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro_Keyboard
{
    class SavedSettingsItemManager
    {
        public static ObservableCollection<SavedSettingsItem> getSettings()
        {
            var SavedSettingsCollection = new ObservableCollection<SavedSettingsItem>();

            int n = 1;
            SavedSettingsCollection.Add(new SavedSettingsItem { SavedID = 1, Title = n + "st Setting", Setting1 = "Note: " });
            n++;

            return SavedSettingsCollection;
        }
    }
}
