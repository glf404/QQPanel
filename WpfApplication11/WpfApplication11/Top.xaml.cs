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

namespace WpfApplication11
{
    /// <summary>
    /// Top.xaml 的交互逻辑
    /// </summary>
    public partial class Top : UserControl
    {
        public Top()
        {
            InitializeComponent(); 

        }

        public delegate void DelegateWindowMin();
        public event DelegateWindowMin windowMin;
        void lbMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (windowMin!=null)
            {
                windowMin();
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WpfApplication11.Controls.ucList uc = new Controls.ucList();
            uc.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            uc.Topmost = true;
            uc.ListItemSelected += uc_ListItemSelected;
            uc.Show();
        }

        void uc_ListItemSelected(string text)
        {
            MessageBox.Show(text);
        }




        
    }
}
