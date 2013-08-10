using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SoapBox.FluentDwelling;
using SoapBox.FluentDwelling.Devices;
using HomeControl.Modem;
namespace HomeControl.Controllers
{
    public class ControlController : Controller
    {
        //
        // GET: /Control/
        public string AcAddress = "22.C0.EC";
        //public Plm modem = new Plm("COM6");
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DeviceList()
        {
            var database = ModemManager.modem.GetAllLinkDatabase();
            foreach (var record in database.Records)
            {
                DeviceBase device;
            }
        }

        // GET: /TurnOff/

        public ActionResult TurnOff()
        {
            DeviceBase device;
            if (ModemManager.modem.Network.TryConnectToDevice(AcAddress, out device))
            {
                var ac = device as LightingControl;
                ac.TurnOff();
            }

            return new EmptyResult();
        }
        public ActionResult TurnOn()
        {
            DeviceBase device;
            if (ModemManager.modem.Network.TryConnectToDevice(AcAddress, out device))
            {
                var ac = device as LightingControl;
                ac.TurnOn();
            }

            return new EmptyResult();
        }

    }
}
