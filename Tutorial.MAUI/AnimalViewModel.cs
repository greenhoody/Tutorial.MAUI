using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;

namespace Tutorial.MAUI
{
    internal class AnimalViewModel
    {
        public ObservableCollection<ListModel> MyAnimals { get; set; } = new ObservableCollection<ListModel>()
        {
            new ListModel { Name = "Axolotl", Image = "axolotl.png" },
            new ListModel { Name = "Beaver", Image = "beaver.png" },
            new ListModel { Name = "Capybara", Image = "capybara.png" },
            new ListModel { Name = "Hedgehog", Image = "hedgehog.png" },
            new ListModel { Name = "Stork", Image = "stork.png" },
            new ListModel { Name = "Toad", Image = "toad.png" },
        };

        public Command<ListModel> DeletePlayer { get; private set; }

        public AnimalViewModel()
        {
            DeletePlayer = new Command<ListModel>(model => { MyAnimals.Remove(model); });
        }
    }
}
