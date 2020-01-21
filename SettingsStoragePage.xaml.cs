using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsStoragePage : Page
    {
        private ObservableCollection<SavedSettingsItem> SavedSettingsCollection;
        // int n = 2;
        SavedSettingsItem newSavedItem;
        List<SavedSettingsItem> StoredSettings;

        private const string fileName = "data.xml";

        private const string JSONFILENAME = "data.json";
        // This is for storing and serializing the SavedSettingItems
        List<string> JSONFILES;


        public SettingsStoragePage()
        {
            this.InitializeComponent();
            JSONFILES = new List<string>();
            SavedSettingsCollection = SavedSettingsItemManager.getSettings();
            StoredSettings = new List<SavedSettingsItem>();
            OpenFile();
            CountTextBlock.Text = "Number of Saved Items: " + StoredSettings.Count;
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var SavedSetting = (SavedSettingsItem) e.ClickedItem;
            this.Frame.Navigate(typeof(Settings), SavedSetting);
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is SavedSettingsItem)
            {
                newSavedItem = (SavedSettingsItem) e.Parameter;
                await deserializeToStoredSettings();

                if (newSavedItem.SavedID < StoredSettings.Count)
                {
                    StoredSettings.Insert(newSavedItem.SavedID, newSavedItem);
                    StoredSettings.RemoveAt(newSavedItem.SavedID + 1);
                    SavedSettingsCollection.Clear();
                    foreach (SavedSettingsItem i in StoredSettings)
                    {
                        SavedSettingsCollection.Add(i);
                    }
                }

                else
                {
                    StoredSettings.Add(newSavedItem);
                    SavedSettingsCollection.Add(newSavedItem);

                    ResultTextBlock.Text = "There are: " + StoredSettings.Count;
                }

                await writeJsonAsync();
            }

            CountTextBlock.Text = "Number of Saved Items: " + StoredSettings.Count;
        }

        private async Task deserializeToStoredSettings()
        {
            //List<SavedSettingsItem> updatedList;
            var JsonSerializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));

            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

            StoredSettings = (List<SavedSettingsItem>)JsonSerializer.ReadObject(myStream);
        }


        // Code for serializing SavedSettingsItem 

        private async Task writeJsonAsync()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));
            using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(JSONFILENAME, CreationCollisionOption.ReplaceExisting))
            {
                // actual code for serializing the class
                serializer.WriteObject(stream, StoredSettings);
            }
        }

        private async Task deserializeJsonAsync()
        {
            string content = String.Empty;

            List<SavedSettingsItem> updatedList;
            var JsonSerializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));

            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

            updatedList = (List<SavedSettingsItem>)JsonSerializer.ReadObject(myStream);

            foreach (var SavedItem in updatedList)
            {
                content += String.Format("ID: {0}, Setting1: {1}, Setting2: {2} ... ", SavedItem.SavedID, SavedItem.Setting1, SavedItem.Setting2);
            }

            ResultTextBlock.Text = content;
        }

        async private void OpenFile()
        {
            List<SavedSettingsItem> updatedList;

            var JsonSerializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));

            var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

            updatedList = (List<SavedSettingsItem>)JsonSerializer.ReadObject(myStream);

            foreach (var SavedItem in updatedList)
            {
                StoredSettings.Add(SavedItem);
                SavedSettingsCollection.Add(SavedItem);
            }
        }

        private void StoredSettingRemove_Click(object sender, RoutedEventArgs e)
        {
            ResultTextBlock.Text = "There are: " + StoredSettings.Count + " items";
        }

        private async void Deserialize_Click(object sender, RoutedEventArgs e)
        {
            await deserializeJsonAsync();
        }   

        private async void DeleteAll_Click(object sender, RoutedEventArgs e)
        {
            StoredSettings.Clear();
            SavedSettingsCollection.Clear();
            var serializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));
            using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(JSONFILENAME, CreationCollisionOption.ReplaceExisting))
            {
                // actual code for serializing the class
                serializer.WriteObject(stream, StoredSettings);
            }
        }
    }
}
