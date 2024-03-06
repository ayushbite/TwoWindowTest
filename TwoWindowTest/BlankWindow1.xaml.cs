using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace TwoWindowTest
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankWindow1 : Window
    {
        private readonly BlankWindow1 _instance; 

        public BlankWindow1()
        {
            this.InitializeComponent();
            _instance = this;
            var th = new Thread(() => ThreadRun(_instance));
           
            th.Start();

        }

        public static void ThreadRun(BlankWindow1 instance)
        {
           
            instance.DispatcherQueue.TryEnqueue(() => { openwindow(); });
        }

        private static void openwindow()
        {
           
            App.blankWindow2 = new BlankWindow2();
            App.blankWindow2.Activate();
        }


    }
}
