using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfPractices
{
    public class AnimeMenuTestViewModel:ViewModelBase
    {

        public AnimeMenuTestViewModel()
        {
            
        }


        private bool _openMenu = false;

        public bool OpenMenu
        {
            get => _openMenu;
            private set
            {
                _openMenu = value;
                RaisePropertyChanged();
            }
        }


        public void ToggleMenu()
        {
            OpenMenu = !OpenMenu;
        }




    }
}
