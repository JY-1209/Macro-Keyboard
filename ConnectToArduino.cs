using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;

namespace Macro_Keyboard
{
    class ConnectToArduino
    {
        public ConnectToArduino()
        {
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

        //private async void loginContinueClick(object sender, RoutedEventArgs e)
        //{

        //    var filter = SerialDevice.GetDeviceSelector("COM10");
        //    var devices = await DeviceInformation.FindAllAsync(filter);
        //    if (devices.Any())
        //    {
        //        var deviceId = devices.First().Id;
        //        this.device = await SerialDevice.FromIdAsync(deviceId);

        //        if (this.device != null)
        //        {
        //            this.device.BaudRate = 9600;
        //            this.device.StopBits = SerialStopBitCount.One;
        //            this.device.DataBits = 8;
        //            this.device.Parity = SerialParity.None;
        //            this.device.Handshake = SerialHandshake.None;

        //            this.dataReader = new DataReader(this.device.InputStream);

        //            Speak("Device found");

        //            while (true)
        //            {
        //                var bytesRecieved = await this.dataReader.LoadAsync(128);
        //                if (bytesRecieved > 0)
        //                {

        //                    ElementsRead.Text = this.dataReader.ReadString(bytesRecieved).Trim();
        //                }
        //            }

        //        }
        //    }


        //}
    }
}
