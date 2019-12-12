using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.SerialCommunication;

namespace Macro_Keyboard
{
    class ConnectToArduino
    {
        public ConnectToArduino()
        {
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
    }
}
