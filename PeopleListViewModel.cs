using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WpfPractices.Data;

namespace WpfPractices
{
    public class PeopleListViewModel: ViewModelBase
    {

        public PeopleListViewModel()
        {

            this.InitializeCommands();
            
        }

        private void InitializeCommands()
        {

            this.InitializeCommand = new RelayCommand(this.Initialize);
            this.ShowPersonCommand = new RelayCommand<Person>(this.ShowPersonDetail);

        }


        public RelayCommand InitializeCommand { get; private set; }

        public RelayCommand<Person> ShowPersonCommand { get; private set; }


        private ObservableCollection<Person> _peopleList;

        public ObservableCollection<Person> PeopleList
        {
            get => _peopleList;
            private set
            {
                _peopleList = value;
                RaisePropertyChanged();
            }
        }

        private void ShowPersonDetail(Person p)
        {
            var log = $"Phone: {p.PhoneNumber} , Id: {p.PersonId}";
            MessageBox.Show(log, "Info", MessageBoxButton.OK, MessageBoxImage.Information);
        }



        public void Initialize()
        {

            var collection = Person.GetPeopleData();
            this.PeopleList = new ObservableCollection<Person>(collection);


        }








    }
}
