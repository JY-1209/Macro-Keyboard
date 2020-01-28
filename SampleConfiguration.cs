using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Macro_Keyboard;

namespace Macro_Keyboard
{
    public partial class ExampleMainPage : Page
    {
        public const string FEATURE_NAME = "SerialArduino";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="Connect/Disconnect", ClassType=typeof(Scenario1_ConnectDisconnect)},
            new Scenario() { Title="LED/Temperature", ClassType=typeof(Scenario2_LEDTemp)}
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
