using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
        private int count = 0;

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

            newSettingItem.Title = "Setting " + count + 1;
            newSettingItem.Setting1 = "Testing " + (count + 1);
            newSettingItem.Setting2 = "Testing " + (count + 1);
            newSettingItem.Setting3 = "Testing " + (count + 1);                                                   
            newSettingItem.Setting4 = "Testing " + (count + 1);
            newSettingItem.Setting5 = "Testing " + (count + 1);
            newSettingItem.Setting6 = "Testing " + (count + 1);
            newSettingItem.Setting7 = "Testing " + (count + 1);
            newSettingItem.Setting8 = "Testing " + (count + 1);
            newSettingItem.Setting9 = "Testing " + (count + 1);
            newSettingItem.Setting10 = "Testing " + (count + 1);
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

                // display text in txtfile
                // tbData.Text = "input string is: " + inputString;
            }

            catch
            {

            }

            Block1.Text = newSettingItem.Setting1;
            Block2.Text = newSettingItem.Setting2;
            Block3.Text = newSettingItem.Setting3;
            Block4.Text = newSettingItem.Setting4;
            Block5.Text = newSettingItem.Setting5;
            Block6.Text = newSettingItem.Setting6;
            Block7.Text = newSettingItem.Setting7;
            Block8.Text = newSettingItem.Setting8;
            Block9.Text = newSettingItem.Setting9;
            Block10.Text = newSettingItem.Setting10;
        }

        async private void SaveTemporaryKeyValueFile(int i)
        {
            Windows.Storage.StorageFolder storageFolder =
        Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile TemporaryKeyFile =
                await storageFolder.CreateFileAsync("TemporaryKey.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(TemporaryKeyFile, newSettingItem.Setting1);
        }
        private void AllSave_Click(object sender, RoutedEventArgs e)
        {
            count++;
            this.Frame.Navigate(typeof(SettingsStoragePage), newSettingItem);

        }
        private void Setting1Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting1 = Block1.Text;
            SaveTemporaryKeyValueFile(1);
        }

        private void Setting2Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting2 = Block2.Text;
            SaveTemporaryKeyValueFile(2);
        }

        private void Setting3Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting3 = Block3.Text;
            SaveTemporaryKeyValueFile(3);
        }

        private void Setting4Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting4 = Block4.Text;
            SaveTemporaryKeyValueFile(4);
        }

        private void Setting5Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting5 = Block5.Text;
            SaveTemporaryKeyValueFile(5);
        }

        private void Setting6Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting6 = Block6.Text;
            SaveTemporaryKeyValueFile(6);
        }

        private void Setting7Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting7 = Block7.Text;
            SaveTemporaryKeyValueFile(7);
        }

        private void Setting8Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting8 = Block8.Text;
            SaveTemporaryKeyValueFile(8);
        }

        private void Setting9Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting9 = Block9.Text;
            SaveTemporaryKeyValueFile(9);
        }

        private void TextBox10Save_Click(object sender, RoutedEventArgs e)
        {
            newSettingItem.Setting10 = Block10.Text;
            SaveTemporaryKeyValueFile(10);
        }
    }
}
