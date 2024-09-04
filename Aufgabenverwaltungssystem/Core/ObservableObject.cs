using System;
using System.ComponentModel;

namespace Aufgabenverwaltungssystem.Core
{
    internal class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
