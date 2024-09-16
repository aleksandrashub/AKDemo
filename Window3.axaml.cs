using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Collections.Generic;
using System.Linq;

namespace shubenokAleks1;

public partial class Window3 : Window
{
    public List<Prodazha> Prodazhi = new List<Prodazha>();
    public Window3()
    {
        InitializeComponent();

       Prodazhi =  Info.agentProd.prodazhi;
        prodazhiList.ItemsSource = Prodazhi.ToList();
    }
}