using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WkHtmlToPDF.NET.Settings
{
    public class GlobalSettings
    {
        // paper sizes from http://msdn.microsoft.com/en-us/library/system.drawing.printing.paperkind.aspx
        public string PaperSize;
        public string PaperWidth; // for example "4cm"
        public string PaperHeight; // or "12in"
        public string PaperOrientation = "Portrait"; // must be either "Landscape" or "Portrait"

        public string ColorMode = "Color"; // must be either "Color" or "Grayscale"
        public string Dpi; // DPI used when printing, like "80"

        public string PageOffset; // start page number (used in headers, footers and TOC)
        public string Copies; // number of copies to include into the document =)
        public string Collate = "false"; // collate copies or not, must be either "true" or "false"

        public string Outline = "false"; // generate table of contents, must be either "true" or "false"
        public string OutlineDepth; // outline depth
        public string DumpOutline = ""; // filename to dump outline in XML format

        public string Output = ""; // filename to dump PDF into, if "-", then it's dumped into stdout
        public string DocumentTitle; // title for the PDF document

        public string UseCompression = "true"; // turns on lossless compression of the PDF file

        public string MarginTop; // size of the top margin (ex. "2cm)
        public string MarginRight;
        public string MarginBottom;
        public string MarginLeft;

        public string OutputFormat = "pdf"; // can be "ps" or "pdf"

        public string ImageDpi; // maximum DPI for the images in document
        public string ImageQuality; // specifies JPEG compression factor for the (reencoded) images in pdf, from "0" to "100"

        public string CookieJar; // path to (text) file used to load and store cookies



        public IDictionary<string, object> GetGlobalConfig(IDictionary<string, object> additionalSettings = null)
        {
            var dictionary = new Dictionary<string, object>();
            if (PaperSize != null)
            {
                dictionary.Add("size.paperSize", PaperSize);
            }
            if (PaperWidth != null)
            {
                dictionary.Add("size.width", PaperWidth);
            }
            if (PaperHeight != null)
            {
                dictionary.Add("size.height", PaperHeight);
            }
            if (PaperOrientation != null)
            {
                dictionary.Add("orientation", PaperOrientation);
            }
            if (ColorMode != null)
            {
                dictionary.Add("colorMode", ColorMode);
            }
            if (Dpi != null)
            {
                dictionary.Add("dpi", Dpi);
            }
            if (PageOffset != null)
            {
                dictionary.Add("pageOffset", PageOffset);
            }
            if (Copies != null)
            {
                dictionary.Add("copies", Copies);
            }
            if (Collate != null)
            {
                dictionary.Add("collate", Collate);
            }
            if (Outline != null)
            {
                dictionary.Add("outline", Outline);
            }
            if (OutlineDepth != null)
            {
                dictionary.Add("outlineDepth", OutlineDepth);
            }
            if (DumpOutline != null)
            {
                dictionary.Add("dumpOutline", DumpOutline);
            }
            if (Output != null)
            {
                dictionary.Add("out", Output);
            }
            if (DocumentTitle != null)
            {
                dictionary.Add("documentTitle", DocumentTitle);
            }
            if (UseCompression != null)
            {
                dictionary.Add("useCompression", UseCompression);
            }
            if (MarginTop != null)
            {
                dictionary.Add("margin.top", MarginTop);
            }
            if (MarginRight != null)
            {
                dictionary.Add("margin.right", MarginRight);
            }
            if (MarginBottom != null)
            {
                dictionary.Add("margin.bottom", MarginBottom);
            }
            if (MarginLeft != null)
            {
                dictionary.Add("margin.left", MarginLeft);
            }
            if (OutputFormat != null)
            {
                dictionary.Add("outputFormat", OutputFormat);
            }
            if (ImageDpi != null)
            {
                dictionary.Add("imageDPI", ImageDpi);
            }
            if (ImageQuality != null)
            {
                dictionary.Add("imageQuality", ImageQuality);
            }
            if (CookieJar != null)
            {
                dictionary.Add("load.cookieJar", CookieJar);
            }

            if (additionalSettings != null)
            {
                dictionary.Concat(additionalSettings.Where(kvp => !dictionary.ContainsKey(kvp.Key)));
            }
            return dictionary;
        }
    }
}
