using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Macro_Keyboard;
using Windows.UI.Xaml.Controls;

namespace Macro_Keyboard
{
    public class DeviceProperties
    {
        //public const String DeviceInstanceId = "System.Devices.DeviceInstanceId";
        public const String DeviceInstanceId = "System.ItemNameDisplay";
    }

    public class ArduinoDevice
    {
        public const UInt16 Vid = 0x2341;
        public const UInt16 Pid = 0x8036;
    }
}
