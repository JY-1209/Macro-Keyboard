using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization.Json;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
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
    /// 
    public sealed partial class Settings : Page
    {

        SavedSettingsItem newSettingItem = new SavedSettingsItem();
        private int SavedID = 0;
        private Boolean isModified = false;
        SavedSettingsItem ModifiedSettingItem;
        private const string JSONFILENAME = "data.json";

        public Settings()
        {
            this.InitializeComponent();
            //OpenFile();
            //OpenSettingsFile();
            createSavedSettingsItem();
            OpenTemporaryKeyFile();
            this.DataContext = this.newSettingItem;
        }

        public void createSavedSettingsItem()
        {
            newSettingItem = new SavedSettingsItem();

            newSettingItem.Title = "Setting " + SavedID ;
            newSettingItem.Setting1 = "Blank " + (SavedID);
            newSettingItem.Setting2 = "Blank " + (SavedID );
            newSettingItem.Setting3 = "Blank " + (SavedID);                                                   
            newSettingItem.Setting4 = "Blank " + (SavedID + 0);
            newSettingItem.Setting5 = "Blank " + (SavedID + 0);
            newSettingItem.Setting6 = "Blank " + (SavedID + 0);
            newSettingItem.Setting7 = "Blank " + (SavedID + 0);
            newSettingItem.Setting8 = "Blank " + (SavedID + 0);
            newSettingItem.Setting9 = "Blank " + (SavedID + 0);
            newSettingItem.Setting10 = "Blank " + (SavedID + 0);
        }

        private void ClosePopupClicked(object sender, RoutedEventArgs e)
        {
            // if the Popup is open, then close it 
            if (StandardPopup.IsOpen) { StandardPopup.IsOpen = false; }
        }

        // Handles the Click event on the Button on the page and opens the Popup. 
        private void ShowPopupOffsetClicked(object sender, RoutedEventArgs e)
        {
            // open the Popup if it isn't open already 
            if (!StandardPopup.IsOpen) { StandardPopup.IsOpen = true; }
        }

        //Mr. George's Code:
        //async private void OpenFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //            Windows.Storage.ApplicationData.Current.LocalFolder;
        //    try
        //    {
        //        Windows.Storage.StorageFile sampleFile =
        //                await storageFolder.GetFileAsync("sample.txt");
        //        tbData.Text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
        //    }
        //    catch
        //    {
        //        tbData.Text = "This is the default text";
        //    }
        //}

        //async private void SaveFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //Windows.Storage.ApplicationData.Current.LocalFolder;
        //    Windows.Storage.StorageFile sampleFile =
        //        await storageFolder.CreateFileAsync("sample.txt",
        //            Windows.Storage.CreationCollisionOption.ReplaceExisting);

        //    await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "This is a Save Test 2");
        //}

        //private void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    SaveFile();
        //}

        //private void SaveSettings_Click(object sender, RoutedEventArgs e)
        //{
        //    SaveSettingsFile();
        //}
        //async private void OpenSettingsFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //            Windows.Storage.ApplicationData.Current.LocalFolder;
        //    try
        //    {
        //        Windows.Storage.StorageFile SettingsFile =
        //                await storageFolder.GetFileAsync("SettingsFile.txt");
        //        tbData.Text = await Windows.Storage.FileIO.ReadTextAsync(SettingsFile);
        //    }
        //    catch
        //    {
        //        tbData.Text = "Insert";
        //    }
        //}

        //async private void SaveSettingsFile()
        //{
        //    Windows.Storage.StorageFolder storageFolder =
        //Windows.Storage.ApplicationData.Current.LocalFolder;
        //    Windows.Storage.StorageFile SettingsFile = 
        //        await storageFolder.CreateFileAsync("SettingsFile.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

        //    await Windows.Storage.FileIO.WriteTextAsync(SettingsFile, "This is a Save Test 2");
        //}

        //Saving the temporary settings of each block

        async private void OpenTemporaryKeyFile()
        {
            Windows.Storage.StorageFolder storageFolder =
                    Windows.Storage.ApplicationData.Current.LocalFolder;
            try
            {
                Windows.Storage.StorageFile TemporaryKeyFile =
                        await storageFolder.GetFileAsync("TemporaryKey.txt");
                String inputString = await Windows.Storage.FileIO.ReadTextAsync(TemporaryKeyFile);
            }

            catch
            {

            }

            //Block1.Text = newSettingItem.Setting1;
            //Block2.Text = newSettingItem.Setting2;
            //Block3.Text = newSettingItem.Setting3;
            //Block4.Text = newSettingItem.Setting4;
            //Block5.Text = newSettingItem.Setting5;
            //Block6.Text = newSettingItem.Setting6;
            //Block7.Text = newSettingItem.Setting7;
            //Block8.Text = newSettingItem.Setting8;
            //Block9.Text = newSettingItem.Setting9;
            //Block10.Text = newSettingItem.Setting10;
        }

        async private void SaveTemporaryKeyValueFile(int i)
        {
            Windows.Storage.StorageFolder storageFolder =
        Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile TemporaryKeyFile =
                await storageFolder.CreateFileAsync("TemporaryKey.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(TemporaryKeyFile, newSettingItem.Setting1);
        }
        private async void AllSave_Click(object sender, RoutedEventArgs e)
        {
            if (isModified)
            {
                ModifiedSettingItem.Setting1 = Block1.Text;
                ModifiedSettingItem.Setting2 = Block2.Text;
                ModifiedSettingItem.Setting3 = Block3.Text;
                ModifiedSettingItem.Setting4 = Block4.Text;
                ModifiedSettingItem.Setting5 = Block5.Text;
                ModifiedSettingItem.Setting6 = Block6.Text;
                ModifiedSettingItem.Setting7 = Block7.Text;
                ModifiedSettingItem.Setting8 = Block8.Text;
                ModifiedSettingItem.Setting9 = Block9.Text;
                ModifiedSettingItem.Setting10 = Block10.Text;
                ModifiedSettingItem.Title = TitleBlock.Text;
                isModified = false;
                this.Frame.Navigate(typeof(SettingsStoragePage), ModifiedSettingItem);
            }

            else
            {
                List<SavedSettingsItem> updatedList;

                var JsonSerializer = new DataContractJsonSerializer(typeof(List<SavedSettingsItem>));

                var myStream = await ApplicationData.Current.LocalFolder.OpenStreamForReadAsync(JSONFILENAME);

                updatedList = (List<SavedSettingsItem>)JsonSerializer.ReadObject(myStream);

                newSettingItem.SavedID = updatedList.Count;
                SavedIDText.Text = "" + newSettingItem.SavedID;
                // SavedID++;

                newSettingItem.Setting1 = Block1.Text;
                newSettingItem.Setting2 = Block2.Text;
                newSettingItem.Setting3 = Block3.Text;
                newSettingItem.Setting4 = Block4.Text;
                newSettingItem.Setting5 = Block5.Text;
                newSettingItem.Setting6 = Block6.Text;
                newSettingItem.Setting7 = Block7.Text;
                newSettingItem.Setting8 = Block8.Text;
                newSettingItem.Setting9 = Block9.Text;
                newSettingItem.Setting10 = Block10.Text;
                newSettingItem.Title = TitleBlock.Text;
                this.Frame.Navigate(typeof(SettingsStoragePage), newSettingItem);
            }
            
        }
   
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.Parameter is SavedSettingsItem)
            {
                isModified = true;
                ModifiedSettingItem = (SavedSettingsItem)e.Parameter;
                Block1.Text = ModifiedSettingItem.Setting1;
                Block2.Text = ModifiedSettingItem.Setting2;
                Block3.Text = ModifiedSettingItem.Setting3;
                Block4.Text = ModifiedSettingItem.Setting4;
                Block5.Text = ModifiedSettingItem.Setting5;
                Block6.Text = ModifiedSettingItem.Setting6;
                Block7.Text = ModifiedSettingItem.Setting7;
                Block8.Text = ModifiedSettingItem.Setting8;
                Block9.Text = ModifiedSettingItem.Setting9;
                Block10.Text = ModifiedSettingItem.Setting10;
                SavedIDText.Text = "SavedID is: " + ModifiedSettingItem.SavedID;
                TitleBlock.Text = ModifiedSettingItem.Title;
            }
        }
    }
}
