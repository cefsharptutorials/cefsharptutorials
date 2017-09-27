using System;
using System.Collections.Generic;
using System.Linq;
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

namespace RemoteDebugging
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ChromiumWebBrowser leftBrowser;
        private ChromiumWebBrowser rightBrowser;

        public MainWindow()
        {
            InitializeComponent();

            CefSettings settings = new CefSettings() {RemoteDebuggingPort = 8088};
            Cef.Initialize(settings);

            leftBrowser = new ChromiumWebBrowser();
            RootGrid.Children.Add(leftBrowser);
            leftBrowser.SetValue(Grid.ColumnProperty, 0);

            rightBrowser = new ChromiumWebBrowser();
            RootGrid.Children.Add(rightBrowser);
            rightBrowser.SetValue(Grid.ColumnProperty, 1);

            leftBrowser.FrameLoadEnd += LeftBrowser_FrameLoadEnd;
            leftBrowser.Address = "github.com";
        }

        private void LeftBrowser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            Dispatcher.BeginInvoke((Action) (() =>
            {
                rightBrowser.Address = "localhost:8088";
            }));
        }
    }
}
