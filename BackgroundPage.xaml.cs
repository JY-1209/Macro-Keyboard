using System;
using System.Collections.Generic;
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
using System.Threading.Tasks;
using Windows.UI.Core;
using Windows.UI.Xaml.Automation.Peers;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
    {
        public static MainPage Current;

        public MainPage()
        {
            this.InitializeComponent();
            Current = this;
            HomePageListBoxItem.IsSelected = true;
            InnerFrame.Navigate(typeof(HomePage));
            IconsListBox.SelectedItem = HomePageListBoxItem;
            BackButton.IsEnabled = false;
        }

        public void NotifyUser(string strMessage, NotifyType type)
        {
            // If called from the UI thread, then update immediately.
            // Otherwise, schedule a task on the UI thread to perform the update.
            if (Dispatcher.HasThreadAccess)
            {
                UpdateStatus(strMessage, type);
            }
            else
            {
                var task = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () => UpdateStatus(strMessage, type));
            }
        }

        private void UpdateStatus(string strMessage, NotifyType type)
        {
        }

        private void Hamburger_Click(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void IconsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            if (HomePageListBoxItem.IsSelected)
            {
                InnerFrame.Navigate(typeof(HomePage));
                Header.Text = "HomePage";
            }
            
            else if (SettingsListBoxItem.IsSelected) {
                InnerFrame.Navigate(typeof(Settings));
                Header.Text = "Settings";
            }

            else if (SavedListBoxItem.IsSelected) {
                InnerFrame.Navigate(typeof(SettingsStoragePage));
                Header.Text = "Saved";
            }

            else if (ArduinoListBoxItem.IsSelected)
            {
                InnerFrame.Navigate(typeof(Arduino));
                Header.Text = "Arduino";
            }

            else if (ScenarioListBoxItem.IsSelected)
            {
                InnerFrame.Navigate(typeof(Scenario1_ConnectDisconnect));
                Header.Text = "Scenario";
            }

            else if (Scenario2ListBoxItem.IsSelected)
            {
                InnerFrame.Navigate(typeof(Scenario2_LEDTemp));
                Header.Text = "Scenario2";
            }

            BackButton.IsEnabled = true;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            if (InnerFrame.CanGoBack) 
            {
                InnerFrame.GoBack();
                if (InnerFrame.Content.GetType() == typeof(HomePage))
                {
                    Header.Text = "HomePage";
                    IconsListBox.SelectedItem = HomePageListBoxItem;
                    if(InnerFrame.BackStack.Count > 0)
                    {
                        InnerFrame.GoBack();
                    }
                }

                else if (InnerFrame.Content.GetType() == typeof(Settings))
                {
                    Header.Text = "Settings";
                    IconsListBox.SelectedItem = SettingsListBoxItem;
                    if (InnerFrame.BackStack.Count > 0)
                    {
                        InnerFrame.GoBack();
                    }
                }

                else if (InnerFrame.Content.GetType() == typeof(SettingsStoragePage))
                {
                    Header.Text = "Saved";
                    IconsListBox.SelectedItem = SavedListBoxItem;
                    if (InnerFrame.BackStack.Count > 0)
                    {
                        InnerFrame.GoBack();
                    }
                }

                else if (InnerFrame.Content.GetType() == typeof(Arduino))
                {
                    Header.Text = "Arduino";
                    IconsListBox.SelectedItem = ArduinoListBoxItem;
                    if (InnerFrame.BackStack.Count > 0)
                    {
                        InnerFrame.GoBack();
                    }
                }

                else if (InnerFrame.Content.GetType() == typeof(Scenario1_ConnectDisconnect))
                {
                    Header.Text = "Scenario";
                    IconsListBox.SelectedItem = ScenarioListBoxItem;
                    if (InnerFrame.BackStack.Count > 0)
                    {
                        InnerFrame.GoBack();
                    }
                }

                else if (InnerFrame.Content.GetType() == typeof(Scenario2_LEDTemp))
                {
                    Header.Text = "Scenario2";
                    IconsListBox.SelectedItem = ScenarioListBoxItem;
                    if (InnerFrame.BackStack.Count > 0)
                    {
                        InnerFrame.GoBack();
                    }
                }

                BackButton.IsEnabled = InnerFrame.CanGoBack;
            }
        }
    }
}