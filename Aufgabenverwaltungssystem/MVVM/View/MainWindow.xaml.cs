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
using System.Xml.Serialization;

namespace Aufgabenverwaltungssystem
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            startApp(); 
        }

        private void startApp()
        {
            Console.WriteLine("getContent");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Clicked");
        }

        private void Close_Window(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Minimize_Window(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        
        private void RectangleDragWindow(object sender, MouseButtonEventArgs e) {
            DragMove();
        }

        private void HinzufuegenPageSelected(object sender, RoutedEventArgs e)
        {
            DisplayFrame.Source = new Uri("Hinzufuegen.xaml", UriKind.Relative);
            SortingStackPanel.Visibility = Visibility.Hidden;
        }

        private void ListePageSelected(object sender, RoutedEventArgs e)
        {
            DisplayFrame.Source = new Uri("Liste.xaml", UriKind.Relative);
            SortingStackPanel.Visibility = Visibility.Visible;
        }

        private void ErledigtPageSelected(object sender, RoutedEventArgs e) {
            DisplayFrame.Source = new Uri("Erledigt.xaml", UriKind.Relative);
            SortingStackPanel.Visibility = Visibility.Visible;
        }

    }
}
