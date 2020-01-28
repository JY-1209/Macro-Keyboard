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
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;
using Windows.Devices.Usb;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using Windows.UI.Input.Preview.Injection;
using Windows.System;
//using System.IO.ports;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Arduino : Page
    {
        ConnectToArduino connect = new ConnectToArduino();
        InjectedInputKeyboardInfo keyboard = new InjectedInputKeyboardInfo();

        public Arduino()
        {
            this.InitializeComponent();
            connect = new ConnectToArduino();
        }


        private async void Connect_Click(object sender, RoutedEventArgs e)
        {
            ToggleButton use = (ToggleButton)sender;
            ReadSerial.Content = "Stop Connecting";
            String input = "";

            if ((bool)use.IsChecked)
            {
                try
                {
                    await connect.initializeSerialAsync();
                }
                catch
                {
                    Connection.Text = "Connection Issue";
                }

                while (true)
                {
                    uint bufferCount = 1;
                    try
                    {
                       
                        Task<UInt32> loadAsyncTask = connect.getDataReader().LoadAsync(bufferCount).AsTask();
                        UInt32 numBytes = await loadAsyncTask;
                        if (numBytes > 0)
                        {
                            String value = connect.getDataReader().ReadString(numBytes);
                            Connection.Text = value;
                            input = value;
                            value = null;
                            connect.getDataWriter().DetachBuffer();
                            connect.getDataReader().DetachBuffer();
                        }

                        if(input.Equals('A'))
                        {
                            InputInjector inputInjector = InputInjector.TryCreate();
                            //for (int i = 0; i < 10; i++)
                            //{
                            //    var shift = new InjectedInputKeyboardInfo();
                            //    shift.VirtualKey = (ushort)(VirtualKey.Shift);
                            //    shift.KeyOptions = InjectedInputKeyOptions.None;


                            //    var tab = new InjectedInputKeyboardInfo();
                            //    tab.VirtualKey = (ushort)(VirtualKey.Tab);
                            //    tab.KeyOptions = InjectedInputKeyOptions.None;


                            //    inputInjector.InjectKeyboardInput(new[] { shift, tab });

                            //    await Task.Delay(1000);
                            //}

                            var A = new InjectedInputKeyboardInfo();
                            A.VirtualKey = (ushort)(VirtualKey.A);
                            A.KeyOptions = InjectedInputKeyOptions.None;
                            inputInjector.InjectKeyboardInput(new[] { A });

                            await Task.Delay(1000);
                        }
                    }
                    catch
                    {
                        
                    }

                    //if ()

                }
            }
            else
            {

                //onOffButton.Content = "Start Attendance";

                return;
            }
        }

        private void ArduinoButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
