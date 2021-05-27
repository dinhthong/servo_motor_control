using DOTHI_HIENCLUBVN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MotorControl6h39;

namespace DOTHI_HIENCLUBVN
{
    
    class ControlSignals
    {
        public void sendspeedcontrol(bool pdir,double kP,double kI,double kD,double sPEED,out string truyendi)
        {

            truyendi = "";
            if (pdir)
            {
                //send speed control with + direction to COM
                //send[0] = 40; '@' character
                truyendi += "@P";

            }
            else
            {
                //send speed control with - direction to COM
                //send[0] = 21; //'!' character
                truyendi += "!P";
            }
            truyendi+=numberprocessor(kP);
            truyendi += "I";
            truyendi += numberprocessor(kI);
            truyendi += "D";
            truyendi += numberprocessor(kD);
            truyendi += "V";
            truyendi += numberprocessor(sPEED);
        }
        public void sendpositioncontrol(double kP, double kI, double kD, double pOSITION, out string truyendi)
        {
            truyendi = "@P";
            truyendi += numberprocessor(kP);
            truyendi += "I";
            truyendi += numberprocessor(kI);
            truyendi += "D";
            truyendi += numberprocessor(kD);
            truyendi += "X";
            truyendi += numberprocessor(pOSITION);
        }

        public string numberprocessor(double num)
        {
            if (num == 0)
                return "000.000";
            string vip="",returnstring="";
            string xtring;
            if (num >= 100 && num < 1000)
            {
                vip+= Convert.ToString(num);
            }
            else if (num>=10 && num<100)
            {
                vip+="0"+ Convert.ToString(num);
            }
            else
            {
                vip+= "00" + Convert.ToString(num);
            }
            returnstring += vip.Substring(0, 3) + ".";
            xtring = Convert.ToString(num * 100);
            returnstring += xtring.Substring(xtring.Length - 2, 2);
            return returnstring;
        }
    }
}
