using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace ProxyScraper
{
    public partial class frmMain : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption(IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        public frmMain()
        {
            InitializeComponent();
        }

        public string Get(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }

        public void ProxySifirla()
        {

            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings");
            regKey.SetValue("ProxyEnable", 0);
            regKey.SetValue("ProxyServer", listProxy.Text); //здесь менять прокси
            regKey.Close();
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            webBrowser1.Navigate("https://api.ipify.org");

        }
        private void btnGetProxy_Click(object sender, EventArgs e)
        {
            ProxySifirla();

            listProxy.Items.Clear();

            Regex reg = default(Regex);

            string webSource = Get("https://www.sslproxies.org/");
            Console.WriteLine(webSource);
            reg = new Regex("<tr><td>(.*?)</td><td>(.*?)</td><td>(.*?)</td><td class='hm'>");

            MatchCollection Matches = reg.Matches(webSource);
            foreach (Match ProxyString in Matches)
            {
                string ip = ProxyString.Value.Split('>')[2].Split('<')[0];
                string port = ProxyString.Value.Split('>')[4].Split('<')[0];

                listProxy.Items.Add(ip +":"+ port);

            }
        }

        private void btnProxyTest_Click(object sender, EventArgs e)
        {
            this.webBrowser1.Navigate("about:blank");
            this.webBrowser1.Document.OpenNew(true);
            this.webBrowser1.Document.Write("IP alınıyor.");

            RegistryKey regKey = Registry.CurrentUser;
            regKey = regKey.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Internet Settings");
            regKey.SetValue("ProxyEnable", 1);
            regKey.SetValue("ProxyServer", listProxy.Text); //здесь менять прокси
            regKey.Close();
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            InternetSetOption(IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
            webBrowser1.Navigate("https://api.ipify.org");
        }

        private void btnProxySifirla_Click(object sender, EventArgs e)
        {
            ProxySifirla();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           
            if (webBrowser1.Document.Body.OuterHtml.Contains("contentContainer"))
            {
                this.webBrowser1.Document.OpenNew(true);
                this.webBrowser1.Document.Write("ProxyHatali");
            }
           
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ProxySifirla();
        }
    }
}
