using SoapBox.FluentDwelling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeControl.Modem
{
    public static class ModemManager
    {
        public static Plm modem = new Plm("COM6");
    }
}