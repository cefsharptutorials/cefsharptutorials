using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CefSharp;
using CefSharp.Wpf;

namespace InjectDotNetToJavaScript
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChromiumWebBrowser Browser;

        public MainWindow()
        {
            InitializeComponent();

            Browser = new ChromiumWebBrowser();
            Browser.RegisterJsObject("dotNetMessage", new DotNetMessage());

            Browser.IsBrowserInitializedChanged += (sender, args) =>
            {
                if (Browser.IsBrowserInitialized)
                {
                    Browser.LoadHtml(File.ReadAllText("index.html"));
                }
            };

            MainGrid.Children.Add(Browser);
        }
    }

    public class DotNetMessage
    {
        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }
}
