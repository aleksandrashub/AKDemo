using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;
using MsBox.Avalonia;
using System;
using System.IO;

namespace shubenokAleks1;

public partial class Window1 : Window
{
    public Bitmap bitmap;
    public string path;
    public bool ok;
    public Window1()
    {
        InitializeComponent();

        //typesCmb.ItemsSource = Info.typeAg;
        //var Path = AppDomain.CurrentDomain.BaseDirectory;
        
    }

    private void Ok_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ok = true;
        
        Agent agent = new Agent();
        agent.id = Info.agents.Count ;
        agent.fioDir = fioDirComp.Text;
        agent.Kpp = kppComp.Text;
        agent.phone = phoneComp.Text;
        agent.INN = innComp.Text;
        agent.address = addressComp.Text;
        // ��������� �� int  agent.amount = amountComp.Text;
        agent.amount = Convert.ToInt32(amountComp.Text);
       
       
        agent.phone = phoneComp.Text;
        agent.mail = mailComp.Text;
        switch (typeAgCmb.SelectedIndex)
        {
            case 0:
                agent.type = "������ ���";
                break;
            case 1:
                agent.type = "������ ���";
                break;
            case 2:
                agent.type = "������ ���";
                break;
                default:
                var msgBox = MessageBoxManager.GetMessageBoxStandard("������", "��� ������ �� ������");
                break;
        }
        switch (priorAgCmb.SelectedIndex)
        {
            case 0:
                agent.type = "������ ���������";
                break;
            case 1:
                agent.type = "������ ���������";
                break;
            case 2:
                agent.type = "������ ���������";
                break;
            default:
                var msgBox = MessageBoxManager.GetMessageBoxStandard("������", "��������� ������ �� ������");
                break;
        }


        Info.agents.Add(agent);
        MainWindow main = new MainWindow();
        main.Show();
        this.Close();



    }



    private async void Img_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
       /* OpenFileDialog openFileDialog = new OpenFileDialog();
       var res =  openFileDialog.ShowAsync(this).Result;
        //  path = res.
        res.ToString();
        if (res != null)
        {
          path =  openFileDialog.InitialFileName;
        
        }*/

    }
}