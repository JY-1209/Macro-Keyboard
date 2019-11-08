using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SavedPreferences : Page
    {

        private ObservableCollection<SavedSettings> SavedSettingsCollection;

        public SavedPreferences()
        {
            this.InitializeComponent();
            SavedSettingsCollection = SavedSettingsManager.getSettings();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var SavedSetting = (SavedSettings)e.ClickedItem;
            ResultTextBlock.Text = "Yoiu selected " + SavedSetting.Title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SavedSettingsCollection.Add(new SavedSettings { SavedID = 1, Title = "Vulpate", Setting1 = "Futurum", CoverImage = "Assets/1.jpg" });
        }
    }
}
