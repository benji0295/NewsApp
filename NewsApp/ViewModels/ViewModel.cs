using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace NewsApp.ViewModels
{
    [ObservableObject]
    public abstract partial class ViewModel
    {
        public INavigate Navigation { get; init; }

        internal ViewModel(INavigate navigation) => Navigation = navigation;
    }
}
