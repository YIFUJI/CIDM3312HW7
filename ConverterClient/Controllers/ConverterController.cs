using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConverterClient.Models;
using ConverterLib;
using ConverterLib.TemperatureConvert;
using ConverterLib.LengthConvert;
using ConverterLib.MassConvert;

namespace ConverterClient.Controllers
{
    public class ConverterController : Controller
    {
        // Default View for the Controller
        public IActionResult Index()
        {
            return View();
        }
        // View for Length.cshtml
        public IActionResult Length()
        {
            return View();
        }
        // View for Mass.cshtml
        public IActionResult Mass()
        {
            return View();
        }
        // View for Temp.cshtml
        public IActionResult Temp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ConvertTemp(ConverterViewModel model)
        {    
            // Establish those objects which will be converted to

            ITemperatureConverter CtoF = new CelsiusToFahrenheit();
            ITemperatureConverter CtoK = new CelsiusToKelvin();
            ITemperatureConverter FtoC = new FahrenheitToCelsius();
            ITemperatureConverter FtoK = new FahrenheitToKelvin();
            ITemperatureConverter KtoC = new KelvinToCelsius();
            ITemperatureConverter KtoF = new KelvinToFahrenheit();

            switch(model.ConversionType)
            {
                case "CtoF":
                    model.ConvertedValue = Math.Round(CtoF.getTemperature(model.ValueToConvert), 2);
                    return View(model);
                case "CtoK":
                    model.ConvertedValue = Math.Round(CtoK.getTemperature(model.ValueToConvert), 2);
                    return View(model);
                case "FtoC":
                    model.ConvertedValue = Math.Round(FtoC.getTemperature(model.ValueToConvert), 2);
                    return View(model);
                case "FtoK":
                    model.ConvertedValue = Math.Round(FtoK.getTemperature(model.ValueToConvert), 2);
                    return View(model);
                case "KtoC":
                    model.ConvertedValue = Math.Round(KtoC.getTemperature(model.ValueToConvert), 2);
                    return View(model);
                case "KtoF":
                    model.ConvertedValue = Math.Round(KtoF.getTemperature(model.ValueToConvert), 2);
                    return View(model);
                default:
                    return View();
            }
        }
        [HttpPost]
        public IActionResult ConvertLength(ConverterViewModel model)
        {
            // Establish those objects which will be converted to

            ILengthConverter FtoM = new FeetToMeters();
            ILengthConverter FtoY = new FeetToYards();
            ILengthConverter MtoF = new MetersToFeet();
            ILengthConverter MtoY = new MetersToYards();
            ILengthConverter YtoF = new YardsToFeet();
            ILengthConverter YtoM = new YardsToMeters();

            switch(model.ConversionType)
            {
                case "FtoM":
                    model.ConvertedValue = Math.Round(FtoM.getLength(model.ValueToConvert), 2);
                    return View(model);
                case "FtoY":
                    model.ConvertedValue = Math.Round(FtoY.getLength(model.ValueToConvert), 2);
                    return View(model);
                case "MtoF":
                    model.ConvertedValue = Math.Round(MtoF.getLength(model.ValueToConvert), 2);
                    return View(model);
                case "MtoY":
                    model.ConvertedValue = Math.Round(MtoY.getLength(model.ValueToConvert), 2);
                    return View(model);
                case "YtoF":
                    model.ConvertedValue = Math.Round(YtoF.getLength(model.ValueToConvert), 2);
                    return View(model);
                case "YtoM":
                    model.ConvertedValue = Math.Round(YtoM.getLength(model.ValueToConvert), 2);
                    return View(model);
                default:
                    return View();
            }
        }
        [HttpPost]
        public IActionResult ConvertMass(ConverterViewModel model)
        {
            // Establish those objects which will be converted to

            IMassConverter GtoK = new GramsToKilos();
            IMassConverter GtoO = new GramsToOunces();
            IMassConverter GtoP = new GramsToPounds();
            IMassConverter KtoG = new KilosToGrams();
            IMassConverter KtoO = new KilosToOunces();
            IMassConverter KtoP = new KilosToPounds();
            IMassConverter OtoG = new OuncesToGrams();
            IMassConverter OtoK = new OuncesToKilos();
            IMassConverter OtoP = new OuncesToPounds();
            IMassConverter PtoG = new PoundsToGrams();
            IMassConverter PtoK = new PoundsToKilos();
            IMassConverter PtoO = new PoundsToOunces();

            switch(model.ConversionType)
            {
                case "GtoK":
                    model.ConvertedValue = Math.Round(GtoK.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "GtoO":
                    model.ConvertedValue = Math.Round(GtoO.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "GtoP":
                    model.ConvertedValue = Math.Round(GtoP.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "KtoG":
                    model.ConvertedValue = Math.Round(KtoG.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "KtoO":
                    model.ConvertedValue = Math.Round(KtoO.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "KtoP":
                    model.ConvertedValue = Math.Round(KtoP.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "OtoG":
                    model.ConvertedValue = Math.Round(OtoG.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "OtoK":
                    model.ConvertedValue = Math.Round(OtoK.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "OtoP":
                    model.ConvertedValue = Math.Round(OtoP.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "PtoG":
                    model.ConvertedValue = Math.Round(PtoG.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "PtoK":
                    model.ConvertedValue = Math.Round(PtoK.getMass(model.ValueToConvert), 2);
                    return View(model);
                case "PtoO":
                    model.ConvertedValue = Math.Round(PtoO.getMass(model.ValueToConvert), 2);
                    return View(model);
                default:
                    return View();
            }
        }
    }
}