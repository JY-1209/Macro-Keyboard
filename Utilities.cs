using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Macro_Keyboard;

namespace Macro_Keyboard
{
    class Utilities
    {
        /// <summary>
        /// Prints an error message stating that device is not connected
        /// </summary>
        public static void NotifyDeviceNotConnected()
        {
            ExampleMainPage.Current.NotifyUser("Device is not connected, please select a plugged in device to try the scenario again", NotifyType.ErrorMessage);
        }
    }
}
