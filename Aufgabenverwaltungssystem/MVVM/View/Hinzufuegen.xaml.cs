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

namespace Aufgabenverwaltungssystem.MVVM.View
{
    /// <summary>
    /// Interaction logic for Hinzufuegen.xaml
    /// </summary>
    public partial class Hinzufuegen : Page
    {

        enum Priority
        {
            Low,
            Medium,
            High
        }

        Priority priority;

        public Hinzufuegen()
        {
            InitializeComponent();
        }

        public void HinzufuegenButtonPushed(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Titel: " + TitelTextFeld.Text);
            Console.WriteLine("Beschreibung: " + BeschreibungTextFeld.Text);
            Console.WriteLine("Datum: " + DatumPicker.Text);

            if (LowPriorityButton.IsChecked == true)
            {
                priority = Priority.Low;
            }
            else if (MediumPriorityButton.IsChecked == true)
            {
                priority = Priority.Medium;
            }
            else if (HighPriorityButton.IsChecked == true)
            {
                priority = Priority.High;
            }


            Console.WriteLine("Priorität: " + priority);
            Console.WriteLine("In Bearbeitung: " + InBearbeitungCheckbox.IsChecked);

        }

    }
}
