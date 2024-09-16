using Avalonia.Controls;
using MsBox.Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;

namespace shubenokAleks1
{
    public partial class MainWindow : Window
    {
        public List<Agent> allagent = new List<Agent>();
        public List<Agent> currAgents = new List<Agent> ();
        public MainWindow()
        {
         
            InitializeComponent();
            allagent = Info.agents;
            //  var m = new MessageBoxManager("");
            //  var m = MessageBoxManager.GetMessageBoxStandard("ghr", "tgert");
            //  OpenFileDialog dlg = new OpenFileDialog();
            //  typesCmb.ItemsSource = Info.typeAg.ToList();
            //  agentsList.ItemsSource = Info.agents.ToList();
            A();
        }

        public void A()
        {
            currAgents.Clear();
          //  currAgents = allagent;
          // currAgents = Info.agents;
            //  currAgents = Info.agents.Where(a => a.)
            foreach (Agent curr in Info.agents)
            {
                foreach (Prodazha prodazha in curr.prodazhi)
                {
                    curr.allprod += prodazha.kolvo;
                
                
                
                }



                if (curr.allprod >= 0 && curr.allprod <= 10000)
                {
                    curr.disc = "0%";

                }
                else if (curr.allprod > 10000 && curr.allprod <= 50000)
                {
                    curr.disc = "5%";
                }
                else if (curr.allprod > 50000 && curr.allprod <= 150000)
                {

                    curr.disc = "10%";
                }
                else if (curr.allprod > 150000 && curr.allprod <= 500000)
                {
                    curr.disc = "20%";

                }
                else
                {
                    curr.disc = "25%";
                
                }
            
            }

            switch (typesCmb.SelectedIndex)
            {

                case 0:
                    currAgents = Info.agents.Where(x => x.type == "Первый тип").ToList();
                    break;
                case 1:
                    currAgents = Info.agents.Where(x => x.type == "Второй тип").ToList();
                    break;
                case 2:
                    currAgents = Info.agents.Where(x => x.type =="Третий тип").ToList();
                    break;
                default:
                    currAgents = Info.agents.ToList();
                    break;

            }

            switch (sortsCmb.SelectedIndex)
            {
                case 0:
                    currAgents = Info.agents.OrderBy(x => x.namecomp).ToList();
                    break;
                    case 1:
                    currAgents = Info.agents.OrderByDescending(x => x.namecomp).ToList(); 
                    break;
                    case 2:
                    currAgents = Info.agents.OrderBy(x => x.disc).ToList();
                    break;
                case 3:
                    currAgents = Info.agents.OrderByDescending(x => x.disc).ToList();
                    break;






            }


            agentsList.ItemsSource = currAgents.ToList();
        
        
        
        
        
        }

        public void Sorts() 
        {

           // 
            currAgents = Info.agents;
            allagent = currAgents;
            currAgents.Clear();
            





            agentsList.ItemsSource = currAgents.ToList();
        }

        private void Add_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            Window1 addNew = new Window1(); 
            addNew.Show();
            this.Close();
        }

        private void Delete_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            int ind = Convert.ToInt32(this.Tag!.ToString());
            Info.agents.RemoveAt(ind);
        }
        private void prodazhi_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
          //  int ind =(int)(sender as Button)TagProperty.ToString();
                //Convert.ToInt32(this.Tag!.ToString());
           // Info.agentProd = Info.agents[ind];
            Window3 window  =   new Window3();
            window.Show();
            this.Close();
        }

        private void ListBox_SelectionChanged(object? sender, Avalonia.Controls.SelectionChangedEventArgs e)
        {



        }

        private void TextBox_KeyUp(object? sender, Avalonia.Input.KeyEventArgs e)
        {
        }

        private void ComboBox_SelectionChanged_1(object? sender, Avalonia.Controls.SelectionChangedEventArgs e)
        {
            A();
        }

        private void ComboBox_SelectionChanged_2(object? sender, Avalonia.Controls.SelectionChangedEventArgs e)
        {
            A();
        }
    }
}