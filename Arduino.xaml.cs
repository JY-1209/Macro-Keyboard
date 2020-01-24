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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Macro_Keyboard
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Arduino : Page
    {
        public Arduino()
        {
            this.InitializeComponent();
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


        }
    }
}
