using Calc.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Calc.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged([CallerMemberName] string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        private double number1;
        public double Number1
        {
            get => number1;
            set
            {
                number1 = value;
                OnPropertyChanged();
            }
        }

        private double number2;
        public double Number2
        {
            get => number2;
            set
            {
                number2 = value;
                OnPropertyChanged();
            }
        }

        private double number3;
        public double Number3
        {
            get => number3;
            set
            {
                number3 = value;
                OnPropertyChanged();
            }
        }

        public ICommand AddCommand1 { get; }
        private void OnAddCommandExecute1(object p)
        {
            Number3 = Class1.Add(Number1,Number2);
        }

        public ICommand AddCommand2 { get; }
        private void OnAddCommandExecute2(object p)
        {
            Number3 = Class2.Add(Number1, Number2);
        }

        public ICommand AddCommand3 { get; }
        private void OnAddCommandExecute3(object p)
        {
            Number3 = Class3.Add(Number1, Number2);
        }

        public ICommand AddCommand4 { get; }
        private void OnAddCommandExecute4(object p)
        {
            Number3 = Class4.Add(Number1, Number2);
        }

        private bool CanAddCommandExecuted(object p)
        {
            return true;
        }

        public MainWindowViewModel()
        {
            AddCommand1 = new RelayCommand(OnAddCommandExecute1, CanAddCommandExecuted);
            AddCommand2 = new RelayCommand(OnAddCommandExecute2, CanAddCommandExecuted);
            AddCommand3 = new RelayCommand(OnAddCommandExecute3, CanAddCommandExecuted);
            AddCommand4 = new RelayCommand(OnAddCommandExecute4, CanAddCommandExecuted);
        }
    }
}
