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

            int n = 1;
            SavedSettingsCollection.Add(new SavedSettings { SavedID = 1, Title = n + "st Setting", Setting1 = "Note: ", CoverImage = "Image.jfif" });
            n++;

            return SavedSettingsCollection;
        }
    }
}
