using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Enumeration;
using Windows.Devices.SerialCommunication;
using Windows.Storage.Streams;
using System.IO;
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
using Windows.Devices.Usb;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;

namespace Macro_Keyboard
{
    class ConnectToArduino
    {
        private DataReader inReader;
        private DataWriter outWriter;
        static bool setup = false;

        public ConnectToArduino()
        {
            
        }

        public async Task initializeSerialAsync()
        {
            try
            {
                inReader.Dispose();
                outWriter.Dispose();
            }
            catch
            {

            }
            string aqs = SerialDevice.GetDeviceSelectorFromUsbVidPid(ArduinoDevice.Vid, ArduinoDevice.Pid);
            var infoCollection = await DeviceInformation.FindAllAsync(aqs);
            var deviceInformation = infoCollection[0];
            string deviceId = deviceInformation.Id;

            var device = await SerialDevice.FromIdAsync(deviceId);

            var inputStream = device.InputStream;
            inReader = new DataReader(inputStream);
            //If we ever need to write anything to the arduino
            var outputStream = device.OutputStream;
            outWriter = new DataWriter(outputStream);
            setup = true;

        }

        public DataReader getDataReader()
        {
            return inReader;
        }

        public DataWriter getDataWriter()
        {
            return outWriter;
        }
    }
}
