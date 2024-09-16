using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using MsBox.Avalonia;
using System;

namespace shubenokAleks1;

public partial class Window2 : Window
{
    public bool ok;
    public Window2()
    {
        InitializeComponent();
       
        nameComp.Text =  Info.agentEdit.namecomp;
        fioDirComp.Text = Info.agentEdit.fioDir;
        phoneComp.Text = Info.agentEdit.phone;
        mailComp.Text = Info.agentEdit.mail;
        addressComp.Text = Info.agentEdit.address;
        amountComp.Text = Info.agentEdit.amount.ToString();
        innComp.Text =  Info.agentEdit.INN;
        kppComp.Text = Info.agentEdit.Kpp;


        switch (Info.agentEdit.type)
        {
            case "������ ���":
                typeAgCmb.SelectedIndex = 0;
                break;
            case "������ ���":
                typeAgCmb.SelectedIndex = 1;
                break;
            case "������ ���":
                typeAgCmb.SelectedIndex = 2;
                break;
        }


        switch (Info.agentEdit.prior)
        {

            case "������ ���������":
                priorAgCmb.SelectedIndex = 0;
                break;

            case "������ ���������":
                priorAgCmb.SelectedIndex = 1;
                break;
            case "������ ���������":
                priorAgCmb.SelectedIndex= 2;
                break;
        
        }

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

    private void Ok_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
    {
        ok = true;

        Agent agent = new Agent();
        agent.id = Info.agents.Count;
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
}