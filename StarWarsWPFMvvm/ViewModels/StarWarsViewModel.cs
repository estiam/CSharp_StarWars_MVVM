using StarWarsWPFMvvm.DAL;
using StarWarsWPFMvvm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarWarsWPFMvvm.ViewModels
{
    public class StarWarsViewModel : INotifyPropertyChanged
    {
        public StarWarsViewModel()
        {
            LoadCharacters();
        }

        public async void LoadCharacters()
        {
            Characters = await StarWarsAPIDAL.LoadCharacters();
        }
        

        private List<Character> characters;

        public List<Character> Characters
        {
            get
            {
                return characters;
            }
            set
            {
                characters = value;
                OnPropertyChange("Characters");
            }
        }

        private Character selectedCharacter;

        public Character SelectedCharacter
        {
            get
            {
                return selectedCharacter;
            }
            set
            {
                selectedCharacter = value;
                OnPropertyChange("SelectedCharacter");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
