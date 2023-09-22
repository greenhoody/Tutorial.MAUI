namespace Tutorial.MAUI;

public partial class ControlsDemo : ContentPage
{
	public ControlsDemo()
	{
		InitializeComponent();
	}

    private void imgBtn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "You clicked the image (ImageButton)", "Ok");
    }

    private void btn_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Alert", "You clicked the button", "Ok");
    }

    private void SearchBar_OnSearchButtonPressed(object sender, EventArgs e)
    {
        infoLabel.Text = $"Searching for {searchBar.Text}";
    }

    private void RadioButton_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        RadioButton sexBtn = sender as RadioButton;
        infoLabel.Text = $"I see are a {sexBtn.Content}";
    }

    private void CheckBox_OnCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        infoLabel.Text = $"Thank you {e.Value}";
    }

    private void Switch_OnToggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            infoLabel.Text = $"You are wonderful person";
        }
        else
        {
            infoLabel.Text = $"I don't like you any more";
        }
    }

    private void SwipeItem_OnInvoked(object sender, EventArgs e)
    {
        infoLabel.Text = $"Marked as Favorite";
    }

    private void SwipeItem_OnInvoked_1(object sender, EventArgs e)
    {
        infoLabel.Text = $"Marked as Friend";
    }
}