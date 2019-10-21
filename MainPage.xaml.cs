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



// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 

    public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            HomePageListBoxItem.IsSelected = true;
            InnerFrame.Navigate(typeof(HomePage));
            IconsListBox.SelectedItem = HomePageListBoxItem;
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
                InnerFrame.Navigate(typeof(Saved));
                Header.Text = "Saved";
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e) {
            if (InnerFrame.CanGoBack) 
            {

                //if (InnerFrame.BackStack.Last().GetType() == typeof(HomePage))
                //{
                //    Header.Text = "HomePage";
                //    IconsListBox.SelectedItem = HomePageListBoxItem;
                //}

                //if (InnerFrame.BackStack.Last().GetType() == typeof(Settings))
                //{
                //    Header.Text = "Settings";
                //    IconsListBox.SelectedItem = SettingsListBoxItem;
                //}

                //if (InnerFrame.BackStack.Last().GetType() == typeof(Saved))
                //{
                //    Header.Text = "Saved";
                //    IconsListBox.SelectedItem = SavedListBoxItem;
                //}

                InnerFrame.GoBack();
                if (InnerFrame.Content.GetType() == typeof(HomePage))
                {
                    Header.Text = "HomePage";
                    IconsListBox.SelectedItem = HomePageListBoxItem;
                }

                else if (InnerFrame.Content.GetType() == typeof(Settings))
                {
                    Header.Text = "Settings";
                    IconsListBox.SelectedItem = SettingsListBoxItem;
                }

                else if (InnerFrame.Content.GetType() == typeof(Saved))
                {
                    Header.Text = "Saved";
                    IconsListBox.SelectedItem = SavedListBoxItem;
                }
            }
        }
    }
}