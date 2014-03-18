using System.ComponentModel;
using Endurance.Re.ReSolver.Infrastructure.Interfaces;

namespace Endurance.Re.ReSolver.Infrastructure.Concrete
{
    public class ViewModelBase : IViewModel, INotifyPropertyChanged
    {

        public ViewModelBase()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

        }
    }
}
