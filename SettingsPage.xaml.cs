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
        public ObservableCollection<Settings> UpcomingSettings { get; private set; }
        public ObservableCollection<Settings> MasterList { get; private set; }

        private String block1Shortcut;
        //private String block2Shortcut;
        //private String block3Shortcut;
        //private String block4Shortcut;
        //private String block5Shortcut;
        //private String block6Shortcut;
        //private String block7Shortcut;
        //private String block8TShortcut;
        //private String block9TShortcut;
        //private String block10TShortcut;

        public Settings()
        {
            this.InitializeComponent();
            OpenFile();
            //OpenSettingsFile();
            OpenTemporaryKeyFile();
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

        async private void OpenFile()
        {
            Windows.Storage.StorageFolder storageFolder =
                    Windows.Storage.ApplicationData.Current.LocalFolder;
            try
            {
                Windows.Storage.StorageFile sampleFile =
                        await storageFolder.GetFileAsync("sample.txt");
                tbData.Text = await Windows.Storage.FileIO.ReadTextAsync(sampleFile);
            }
            catch
            {
                tbData.Text = "This is the default text";
            }
        }

        async private void SaveFile()
        {
            Windows.Storage.StorageFolder storageFolder =
        Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile sampleFile =
                await storageFolder.CreateFileAsync("sample.txt",
                    Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "This is a Save Test 2");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }

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
        private void Block1Setting_Click(object sender, RoutedEventArgs e)
        {
            block1Shortcut = Block1.Text;
            SaveTemporaryKeyValueFile();
        }

        async private void OpenTemporaryKeyFile()
        {
            Windows.Storage.StorageFolder storageFolder =
                    Windows.Storage.ApplicationData.Current.LocalFolder;
            try
            {
                Windows.Storage.StorageFile TemporaryKeyFile =
                        await storageFolder.GetFileAsync("TemporaryKey.txt");
                Block1.Text = await Windows.Storage.FileIO.ReadTextAsync(TemporaryKeyFile);
            }
            catch
            {
                Block1.PlaceholderText = "Enter Command 1000000";
            }
        }

        async private void SaveTemporaryKeyValueFile()
        {
            Windows.Storage.StorageFolder storageFolder =
        Windows.Storage.ApplicationData.Current.LocalFolder;
            Windows.Storage.StorageFile TemporaryKeyFile =
                await storageFolder.CreateFileAsync("TemporaryKey.txt", Windows.Storage.CreationCollisionOption.ReplaceExisting);

            await Windows.Storage.FileIO.WriteTextAsync(TemporaryKeyFile, Block1.Text);
        }

        private void SaveSettings_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
