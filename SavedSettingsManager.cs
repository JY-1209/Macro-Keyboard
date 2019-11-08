using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Macro_Keyboard
{
    class SavedSettingsManager
    {
        public static ObservableCollection<SavedSettings> getSettings()
        {
            var SavedSettingsCollection = new ObservableCollection<SavedSettings>();

            SavedSettingsCollection.Add(new SavedSettings { SavedID = 1, Title = "1st Setting", Setting1 = "Futurum", CoverImage = "Image.jfif" });

            return SavedSettingsCollection;
        }
    }
}
