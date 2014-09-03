using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using WkHtmlToPDF.NET;
using WkHtmlToPDF.NET.Settings;

namespace WkHtmlToPDF.NET.Tests
{
    [TestClass]
    public class WkHtmlToPDFTest
    {
        [TestMethod]
        public void TestConversion()
        {
            for (int i = 0; i < 10; i++)
            {
                RunConverter();
            }
        }

        public void RunConverter()
        {
            var objectSettings = new ObjectSettings() { _pageUri = "https://www.google.com/" }.GetObjectConfig();
            var globalSettings = new GlobalSettings().GetGlobalConfig();
            using (var converter = new WkHtmlToPdfConverter(globalSettings, objectSettings))
            {
                try
                {
                    var file = converter.Convert();
                    File.WriteAllBytes("C:\\temp\\" + Guid.NewGuid() + ".pdf", file);
                }
                catch { };

            }
        }
    }
}
