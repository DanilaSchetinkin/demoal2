using Avalonia.Controls;
using Avalonia.Media.Imaging;
using demoAl.Models;
using System;
using System.Collections.ObjectModel;

namespace demoAl
{
    public partial class MainWindow : Window
    {
        ObservableCollection<AgentPresenter> images;
        public MainWindow()
        {
            InitializeComponent();
            using var context = new ;
        }
    }

    public class AgentPresenter(): Agent{
        Bitmap? LogoAgent { get
            {
                try
                {
                    /*доделать*/
                    return new Bitmap(AppDomain.CurrentDomain.BaseDirectory + Logo);
                }
                catch
                {
                    return null;
                }

             }
        }
    } 
}