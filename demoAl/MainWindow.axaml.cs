using Avalonia.Controls;
using Avalonia.Media.Imaging;
using demoAl.Models;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace demoAl
{
    public class Cheliki
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Phone { get; set; }

        public string AgentType {  get; set; }

        public int ProductCount { get; set; }

        public int Discount {  get; set; }

        public required string Logo { get; set; }
    }

    public partial class MainWindow : Window
    {
        ObservableCollection<Cheliki> images;
        public MainWindow()
        {
            InitializeComponent();
            using var context = new User20Context();
            var dataSource = context.Agents.Select(Agent => new Cheliki
            {
                Id = Agent.Id,
                Phone = Agent.Phone,
                Logo = Agent.Logo,
                
            });
            images = new ObservableCollection<Cheliki>(dataSource);
            AgentBox.ItemsSource = images;
        }
    }

    public class AgentPresenter(): Agent{
        Bitmap? LogoAgent { get
            {
                try
                {
                    /*доделать*/
                    return new Bitmap(Logo);
                }
                catch
                {
                    return null;
                }

             }
        }
    } 
}