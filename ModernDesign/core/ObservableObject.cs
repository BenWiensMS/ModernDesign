using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ModernDesign.core
{
    class ObservableObject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)       
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }        
    }
}
