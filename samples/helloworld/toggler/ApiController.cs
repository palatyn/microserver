﻿using GHIElectronics.TinyCLR.Pins;
using GHIElectronics.TinyCLR.Devices.Gpio;

using Bytewizer.TinyCLR.Http.Mvc;

namespace Bytewizer.Toggler
{    
    public class ApiController : Controller
    {
        private static GpioPin led;

        public ApiController()
        {
            if (led == null)
            {           
                var gpioController = GpioController.GetDefault();
                led = gpioController.OpenPin(SC20100.GpioPin.PE11);
                led.SetDriveMode(GpioPinDriveMode.Output);
            }
        }

        public IActionResult ToggleLed(string webname)
        {   
            led.Write(led.Read() == GpioPinValue.High ? GpioPinValue.Low : GpioPinValue.High);

            return Ok();
        }
    }
}