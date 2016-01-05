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

namespace WpfApplication11.Controls
{
    /// <summary>
    /// ucList.xaml 的交互逻辑
    /// </summary>
    public partial class ucList : Window
    {
        public ucList()
        {
            InitializeComponent();
            DataContext = QQDATA.dat;
        }



        

        

        public delegate void DelegateItemSelected(string text);
        public event DelegateItemSelected ListItemSelected;
        private void ListBox_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var item = ItemsControl.ContainerFromElement(sender as ListBox, e.OriginalSource as DependencyObject) as ListBoxItem;
            if (item != null)//e.OriginalSource--指示由哪个对象引发了事件
            {
                if ((item.Content as QQDATA).txt is string)
                {
                    switch ((item.Content as QQDATA).txt)
                    {
                        case "在线":
                            if (ListItemSelected!=null)
                            {
                                ListItemSelected("在线");
                            }
                            
                            break;
                        case "离线":
                            if (ListItemSelected != null)
                            {
                                ListItemSelected("离线");
                            }
                           
                            break;
                        case "离开":
                            if (ListItemSelected != null)
                            {
                                ListItemSelected("离开");
                            }
                            
                            break;
                            
                        default:
                            break;
                    }

                }
                
                
            }
        }
    }


    public class QQDATA
    {
       
        private string _imagepath;
        public string imagepath 
        { 
            get{return _imagepath; }
            set{_imagepath=value;}
        }

        private string _txt;
        public string txt
        {
            get { return _txt; }
            set { _txt = value; }
        }
        public QQDATA(string _ip1 ,string _txt1)
        {
            _imagepath = _ip1;
            _txt = _txt1;
        }

        public static QQDATA []dat=
        {
            new QQDATA("/WpfApplication11;component/images/在线.png","离线"),
            new QQDATA("/WpfApplication11;component/images/离线.png","在线"),
            new QQDATA("/WpfApplication11;component/images/离线.png","离开")
        };
    }

}
