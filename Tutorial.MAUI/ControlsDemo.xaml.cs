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

    private void Slider_OnValueChanged(object sender, ValueChangedEventArgs e)
    {
        sliderLabel.Text = $"Slider: {Convert.ToInt32(e.NewValue)}";
    }

    private void Stepper_OnValueChanged(object sender, ValueChangedEventArgs e)
    {
        stepperLabel.Text = $"Stepper: {e.NewValue}";
    }
}