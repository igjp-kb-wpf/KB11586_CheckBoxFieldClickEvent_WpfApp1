using Infragistics.Windows.Editors;
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

namespace KB11586_CheckBoxFieldClickEvent_WpfApp1;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void XamCheckEditor_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
    {
        var xamCheckEditor = (XamCheckEditor)sender;
        var isChecked = (bool)xamCheckEditor.Value;
        this.textBlock1.Text = $"({DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.fff")}) XamCheckEditor_ValueChanged: New Value={isChecked}";
    }
}
