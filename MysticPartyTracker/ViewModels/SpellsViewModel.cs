using CommunityToolkit.Mvvm.ComponentModel;
using MysticPartyTracker.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MysticPartyTracker.ViewModels
{
    public partial class SpellsViewModel : ObservableObject
    {
            [ObservableProperty]
            private ObservableCollection<Spells> _magia = new ObservableCollection<Spells>();


            public SpellsViewModel()
            {
                _restService = new RestService();
                GetMagiaAsyncCommand = new Command(async () => await GetMagiaAsync());

            }

            private readonly RestService _restService;

            public ICommand GetMagiaAsyncCommand { get; }

            public async Task GetMagiaAsync()
            {
                Magia = await _restService.GetMagiaAsync();
            }

        
    }
}
