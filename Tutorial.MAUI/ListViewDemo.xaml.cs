using Android.App;

namespace Tutorial.MAUI;

public partial class ListViewDemo : ContentPage
{
	public ListViewDemo()
	{
		InitializeComponent();
        BindingContext = new AnimalViewModel();
    }

    private void Animals_OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        string animal = "", animalData = "";
        switch (e.SelectedItem)
        {
            case ListModel m when m.Name == "Axolotl":
                animal = "axolotl";
                animalData = "Some random facts about axolotls.";
                break;
            case ListModel m when m.Name == "Beaver":
                animal = "beaver";
                animalData = "Some random facts about beavers.";
                break;
            case ListModel m when m.Name == "Capybara":
                animal = "capybara";
                animalData = "Some random facts about capybaras.";
                break;
            case ListModel m when m.Name == "Hedgehog":
                animal = "hedgehog";
                animalData = "Some random facts about hedgehogs.";
                break;
            case ListModel m when m.Name == "Stork":
                animal = "stork";
                animalData = "Some random facts about storks.";
                break;
            case ListModel { Name: "Toad" }:
                animal = "toad";
                animalData = "Some random facts about toads.";
                break;
            default:
                animal = "You wrote something wrong";
                break;

        }

        DisplayAlert($"{animal}", $"{animalData}", "OK");
    }
}