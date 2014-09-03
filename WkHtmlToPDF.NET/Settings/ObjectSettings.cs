using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WkHtmlToPDF.NET.Settings
{
    public class ObjectSettings
    {
        public class HeaderOrFooterSettings
        {
            public string FontSize; // font size for the header in pt, e.g. "13"
            public string FontName; // font name for the header, e.g. "Courier New"

            /* following text fields can containt several macros which will be replaced with their respective values:
             * [page]       Replaced by the number of the pages currently being printed
             * [frompage]   Replaced by the number of the first page to be printed
             * [topage]     Replaced by the number of the last page to be printed
             * [webpage]    Replaced by the URL of the page being printed
             * [section]    Replaced by the name of the current section
             * [subsection] Replaced by the name of the current subsection
             * [date]       Replaced by the current date in system local format
             * [time]       Replaced by the current time in system local format
             * 
             * see http://madalgo.au.dk/~jakobt/wkhtmltoxdoc/wkhtmltopdf-0.9.9-doc.html
             */
            public string LeftText;
            public string CenterText;
            public string RightText;

            public string LineSeparator = "false"; // if "true", line is printed under the header (and on top of the footer) separating header from content
            public string Space; // space between the header and content in pt, e.g. "1.8"

            public string HtmlUrl; // URL for the HTML document to use as a header

            /// <summary>
            /// Sets up the supplied object config.
            /// </summary>
            /// <param name="config">config object pointer</param>
            /// <param name="prefix">property name prefix, must be either "header" or "footer"</param>
            internal IDictionary<string, object> GetObjectConfig(string prefix)
            {
                var dictionary = new Dictionary<string, object>();
                if (FontSize != null)
                {
                    dictionary.Add(prefix + "." + "fontSize", FontSize);
                }
                if (FontName != null)
                {
                    dictionary.Add(prefix + "." + "fontName", FontName);
                }
                if (LeftText != null)
                {
                    dictionary.Add(prefix + "." + "left", LeftText);
                }
                if (CenterText != null)
                {
                    dictionary.Add(prefix + "." + "center", CenterText);
                }
                if (RightText != null)
                {
                    dictionary.Add(prefix + "." + "right", RightText);
                }
                if (LineSeparator != null)
                {
                    dictionary.Add(prefix + "." + "line", LineSeparator);
                }
                if (Space != null)
                {
                    dictionary.Add(prefix + "." + "space", Space);
                }
                if (HtmlUrl != null)
                {
                    dictionary.Add(prefix + "." + "htmlUrl", HtmlUrl);
                }
                return dictionary;
            }
        }

        public string _includeInOutline; // include this document into outline and TOC generation
        public string _pagesCount; // count pages in this document for use in outline and TOC generation

        public string _tocXsl; // if it's not empty, this XSL stylesheet is used to convert XML outline into TOC, the page content is ignored

        public string _pageUri; // URL of filename of the page to convert, if "-" then input is read from stdin

        public string _useExternalLinks = "true"; // create external PDF links from external <a> tags in html
        public string _useLocalLinks = "true"; // create PDF links for local anchors in html
        public string _produceForms = "true"; // create PDF forms form html ones

        public string _loadUsername; // username to use in HTTPAuth
        public string _loadPassword; // password to use in HTTPAuth
        public string _loadJsDelay; // amount of time in ms to wait before printing the page
        public string _loadZoomFactor; // zoom factor, e.g. "2.2"
        public string _loadBlockLocalFileAccess = "false";
        public string _loadProxy; // string describing proxy in format http://username:password@host:port, http can be changed to socks5, see http://madalgo.au.dk/~jakobt/wkhtmltoxdoc/wkhtmltopdf-0.9.9-doc.html

        public string _webPrintBackground = "false"; // print background image
        public string _webLoadImages = "true"; // load images in the document
        public string _webRunJavascript = "true"; // run javascript
        public string _webIntelligentShrinking = "true"; // fits more content in one page
        public string _webMinFontSize; // minimum font size in pt, e.g. "9"
        public string _webPrintMediaType = "true"; // use "print" media instead of "screen" media
        public string _webDefaultEncoding = "utf-8"; // encoding to use, if it's not specified properly
        public string _webUserStylesheetUri; // URL or filename for the user stylesheet
        public string _webEnablePlugins = "false"; // enable some sort of plugins, er...

        public HeaderOrFooterSettings Header;
        public HeaderOrFooterSettings Footer;

        public IDictionary<string, object> GetObjectConfig(IDictionary<string, object> additionalSettings = null)
        {
            var dictionary = new Dictionary<string, object>();
            if (_includeInOutline != null)
            {
                dictionary.Add("includeInOutline", _includeInOutline);
            }
            if (_pagesCount != null)
            {
                dictionary.Add("pagesCount", _pagesCount);
            }
            if (_tocXsl != null)
            {
                dictionary.Add("tocXsl", _tocXsl);
            }
            if (_pageUri != null)
            {
                dictionary.Add("page", _pageUri);
            }
            if (_useExternalLinks != null)
            {
                dictionary.Add("useExternalLinks", _useExternalLinks);
            }
            if (_useLocalLinks != null)
            {
                dictionary.Add("useLocalLinks", _useLocalLinks);
            }
            if (_produceForms != null)
            {
                dictionary.Add("produceForms", _produceForms);
            }
            if (_loadUsername != null)
            {
                dictionary.Add("load.username", _loadUsername);
            }
            if (_loadPassword != null)
            {
                dictionary.Add("load.password", _loadPassword);
            }
            if (_loadJsDelay != null)
            {
                dictionary.Add("load.jsdelay", _loadJsDelay);
            }
            if (_loadZoomFactor != null)
            {
                dictionary.Add("load.zoomFactor", _loadZoomFactor);
            }
            if (_loadBlockLocalFileAccess != null)
            {
                dictionary.Add("load.blockLocalFileAccess", _loadBlockLocalFileAccess);
            }
            if (_loadProxy != null)
            {
                dictionary.Add("load.proxy", _loadProxy);
            }
            if (_webPrintBackground != null)
            {
                dictionary.Add("web.background", _webPrintBackground);
            }
            if (_webLoadImages != null)
            {
                dictionary.Add("web.loadImages", _webLoadImages);
            }
            if (_webRunJavascript != null)
            {
                dictionary.Add("web.enableJavascript", _webRunJavascript);
            }
            if (_webIntelligentShrinking != null)
            {
                dictionary.Add("web.enableIntelligentShrinking", _webIntelligentShrinking);
            }
            if (_webMinFontSize != null)
            {
                dictionary.Add("web.minimumFontSize", _webMinFontSize);
            }
            if (_webPrintMediaType != null)
            {
                dictionary.Add("web.printMediaType", _webPrintMediaType);
            }
            if (_webDefaultEncoding != null)
            {
                dictionary.Add("web.defaultEncoding", _webDefaultEncoding);
            }
            if (_webUserStylesheetUri != null)
            {
                dictionary.Add("web.userStyleSheet", _webUserStylesheetUri);
            }
            if (_webEnablePlugins != null)
            {
                dictionary.Add("web.enablePlugins", _webEnablePlugins);
            }

            if (Header != null)
            {
                dictionary.Concat(Header.GetObjectConfig("header").Where(kvp => !dictionary.ContainsKey(kvp.Key)));
            }

            if (Footer != null)
            {
                dictionary.Concat(Footer.GetObjectConfig("footer").Where(kvp => !dictionary.ContainsKey(kvp.Key)));
            }

            if (additionalSettings != null)
            {
                dictionary.Concat(additionalSettings.Where(kvp => !dictionary.ContainsKey(kvp.Key)));
            }

            return dictionary;
        }
    }
}
