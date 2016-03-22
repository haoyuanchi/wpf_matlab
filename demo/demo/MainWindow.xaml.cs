using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Interop;

namespace demo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        bool langChoose = true; //true为中文 false为英文
        paraSetWin parasetwin;

        win2D3D temp2D;

        public MainWindow()
        {
            InitializeComponent();

            
            
            
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            parasetwin = new paraSetWin();
            parasetwin.Show();
        }

        private void lanChanButt_Click(object sender, RoutedEventArgs e)
        {
            if (langChoose == true)
            {
                langChoose = false;
                aboutUs.Header = "About Us";
                paraSet.Header = "Param Set";
                runButton.Content = "Run";
                lanChanButt.Header = " 中文 ";
            }

            else
            {
                langChoose = true;
                aboutUs.Header = "关于我们";
                paraSet.Header = "参数设置";
                runButton.Content = "开始";
                lanChanButt.Header = "English";
            }
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked == true)
            {
                temp2D = new win2D3D();
                temp2D.Show();

                WindowInteropHelper parentHelper = new WindowInteropHelper(this);
                WindowInteropHelper childHelper = new WindowInteropHelper(temp2D);

                Win32Native.SetParent(childHelper.Handle, parentHelper.Handle);
            }
            else
            {
                temp2D.Close();
            }
        }

        private void runButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    
}
