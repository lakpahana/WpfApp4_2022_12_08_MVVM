using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;

namespace WpfApp4_2022_12_08_MVVM
{
    public partial class MainWindowVM : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string? firstName;
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullName))]
        public string? lastName;
        [ObservableProperty]
        public int age;

        public MainWindowVM()
        {
            FirstName = "Tom";
            LastName = "Brown";
            Age = 25;
        }

        [RelayCommand]
        public void IncreaseAge()
        {
            Age += 5;
        }

        [RelayCommand]

        public void DecreaseAge()
        {
            Age -= 5;
        }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }  
        }
    }
}
