using System;
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
        int n = 2;
        SavedSettingsItem newSavedItem;
        List<SavedSettingsItem> StoredSettings;

        private const string fileName = "data.xml";
        private const string JSONFILENAME = "data.json";

        // This is for storing and serializing the SavedSettingItems
        List<string> JSONFILES;

        // This is the text that goes inside the JSONFILES field
        // string SerializedText = "";


        public SettingsStoragePage()
        {
            this.InitializeComponent();
            JSONFILES = new List<string>();
            SavedSettingsCollection = SavedSettingsItemManager.getSettings();
            StoredSettings = new List<SavedSettingsItem>();
            // OpenFile();
        }

        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var SavedSetting = (SavedSettingsItem)e.ClickedItem;
            ResultTextBlock.Text = "You selected " + SavedSetting.Title;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SavedSettingsCollection.Add(new SavedSettingsItem { SavedID = 1, Title = n + "st Setting", Setting1 = "Note: " });
            n++;
        }

        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is SavedSettingsItem)
            {
                newSavedItem = (SavedSettingsItem) e.Parameter;

                StoredSettings.Add(newSavedItem);
                //await deserializeJsonAsyncInLocalFile();
                //foreach (SavedSettingsItem item in StoredSettings)
                //{
                //    SavedSettingsCollection.Add(newSavedItem);
                //}
                await writeJsonAsync();
            }

        }


        // Code for serializing SavedSettingsItem 

        private async Task writeJsonAsync()
        {
            var serializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));
            using (var stream = await ApplicationData.Current.LocalFolder.OpenStreamForWriteAsync(JSONFILENAME, CreationCollisionOption.ReplaceExisting))
            {
                serializer.WriteObject(stream, StoredSettings);
            }

            ResultTextBlock.Text = "succeeded";
        }

        //private async Task readJsonAsync()
        //{
        //    string content = String.Empty;

        //    var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

        //    using (StreamReader reader = new StreamReader(myStream))
        //    {
        //        content = await reader.ReadToEndAsync();
        //    }

        //    ResultTextBlock.Text = content;
        //}

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

        //private async void deserializeToStoredSettings()
        //{
        //    List<SavedSettingsItem> updatedList;
        //    var JsonSerializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));

        //    var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

        //    updatedList = (List<SavedSettingsItem>)JsonSerializer.ReadObject(myStream);

        //    foreach (var SavedItem in updatedList)
        //    {
        //        StoredSettings.Add(SavedItem);
        //    }
        //}

        //private async Task deserializeJsonAsyncInLocalFile()
        //{
        //    string content = String.Empty;

        //    List<SavedSettingsItem> updatedList;
        //    var JsonSerializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));

        //    var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

        //    updatedList = (List<SavedSettingsItem>)JsonSerializer.ReadObject(myStream);

        //    foreach (var SavedItem in updatedList)
        //    {
        //        content += String.Format("ID: {0}, Setting1: {1}, Setting2: {2} ... ", SavedItem.SavedID, SavedItem.Setting1, SavedItem.Setting2);
        //    }

        //    ResultTextBlock.Text = content;
        //}

        //async private void OpenFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //            Windows.Storage.ApplicationData.Current.LocalFolder;
        //    try
        //    {
        //        foreach (string Filename in JSONFILENAME)
        //        {
        //            Windows.Storage.StorageFile sampleFile =
        //                await storageFolder.GetFileAsync(Filename);

        //        }

        //    }
        //    catch
        //    {
        //        TextinFile.Text = "Default Text";
        //    }
        //}

        private void StoredSettingRemove_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Deserialize_Click(object sender, RoutedEventArgs e)
        {
            await deserializeJsonAsync();
        }



        // delete the rest of this section later:
        //async private void SaveFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //Windows.Storage.ApplicationData.Current.LocalFolder;
        //    Windows.Storage.StorageFile sampleFile =
        //        await storageFolder.CreateFileAsync("StoredSettingsFile.txt",
        //            Windows.Storage.CreationCollisionOption.ReplaceExisting);

        //    await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "This is a Save Test 2");
        //}

        //async private void OpenSettingsFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //            Windows.Storage.ApplicationData.Current.LocalFolder;
        //    try
        //    {
        //        Windows.Storage.StorageFile SettingsFile =
        //                await storageFolder.GetFileAsync("StoredSettingsFile.txt");
        //        tbData.Text = await Windows.Storage.FileIO.ReadTextAsync(SettingsFile);
        //    }
        //    catch
        //    {
        //        tbData.Text = "Insert";
        //    }
        //}
    }
}
