using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.IO.Ports;
using Windows.Storage.Streams;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Arduino : Page
    {
        bool isConnected = false;
        String[] ports;
        SerialPort port; 
        public Arduino()
        {
            this.InitializeComponent();
            ports = SerialPort.GetPortNames();
            // Jeffrey gave this to me:
            //string aqs = SerialDevice.GetDeviceSelectorFromUsbVidPid(vid, pid);
            //var infoCollection = await DeviceInformation.FindAllAsync(aqs);
            //var deviceInformation = infoCollection[0];
            //string deviceId = deviceInformation.Id;

            //var device = await SerialDevice.FromIdAsync(deviceId);

            //var inputStream = device.InputStream;
            //inReader = new DataReader(inputStream);
            ////If we ever need to write anything to the arduino
            //var outputStream = device.OutputStream;
            //outWriter = new DataWriter(outputStream);
        }

        void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
        }

        //public void button1_Click(object sender, EventArgs e)
        //{
        //    if (!isConnected)
        //    {
        //        ConnectToArduino();
        //    }

        //    else
        //    {
        //        disconnectfromArduino();
        //    }
        //}

        //private void connectToArduino()
        //{
        //    isConnected = true;
        //    port = new SerialPort("10", 9600, Parity.None, 8, StopBits.One);
        //    port.Open();
        //    port.Write("#STAR\n");
        //    button1.text = "Disconnect";
        //    enableControls();
        //}

        private async void ConnectToSerialPort()
        {
            string selector = SerialDevice.GetDeviceSelector("COM7");
            DeviceInformationCollection devices = await DeviceInformation.FindAllAsync(selector);
            if (devices.Count > 0)
            {
                DeviceInformation deviceInfo = devices[0];
                SerialDevice serialDevice = await SerialDevice.FromIdAsync(deviceInfo.Id);
                serialDevice.BaudRate = 9600;
                serialDevice.DataBits = 8;
                serialDevice.StopBits = SerialStopBitCount.Two;
                serialDevice.Parity = SerialParity.None;

                DataWriter dataWriter = new DataWriter(serialDevice.OutputStream);
                dataWriter.WriteString("your message here");
                await dataWriter.StoreAsync();
                dataWriter.DetachStream();
                dataWriter = null;
            }
            else
            {
                MessageDialog popup = new MessageDialog("Sorry, no device found.");
                await popup.ShowAsync();
            }
        }

        private void newbut_Click(object sender, RoutedEventArgs e)
        {
            ConnectToSerialPort();
        }
    }
}
