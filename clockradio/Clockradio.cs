using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class clockradio
    {
        string isType;
        String isColor;
        int speedPercentageofMax;
        bool isOn;
        public clockradio(string istype, string iscolor, int speedpercentageofmax, bool ison)
        {
            isType = istype;
            isColor = iscolor;
            speedPercentageofMax = speedpercentageofmax;
            isOn = ison;
        }
        public void TurnOn()
        {
            isOn = true;
        }
        public void TurnOff()
        {
            isOn = false;
        }
        public void SwitchToLow()
        {
            speedPercentageofMax = 33;
        }
        public void SwitchToMed()
        {
            speedPercentageofMax = 66;
        }
        public void SwitchToHigh()
        {
            speedPercentageofMax = 100;
        }
    }
}