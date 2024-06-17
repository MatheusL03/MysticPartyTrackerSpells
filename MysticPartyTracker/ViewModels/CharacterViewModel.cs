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
     public partial class CharacterViewModel : ObservableObject
    {
        [ObservableProperty]
        public string _name;
        [ObservableProperty]
        public int _level;
        [ObservableProperty]
        public string _class;
        [ObservableProperty]
        public string _race;


        private ObservableCollection<Character> _characters = new ObservableCollection<Character>();
        public ObservableCollection<Character> Characters
        {
            get { return _characters; }
            set { _characters = value; }
        }


        public CharacterViewModel() 
        {
            CreateCharacterCommand = new Command(AdicionaPersonagem); //INSTÂNCIANDO 
        }

        public ICommand CreateCharacterCommand { get; } //COMANDO QUE CHAMA O MÉTODO

        public void AdicionaPersonagem() //MÉTODO
        {
            // INSTÂNCIA DE NOVO PERSONAGEM COM AS PROPRIEDADES OBSERVAVEIS LÁ DE CIMA
            Character character = new Character(Name, Level, Class, Race);

            Characters.Add(character);
        }


    }
}
