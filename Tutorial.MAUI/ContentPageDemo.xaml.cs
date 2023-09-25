namespace Tutorial.MAUI;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void Button_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }

    private void Button_Flyout(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlyoutDemo());

    }

    private void Button_Tabbed(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TabbedDemo());
    }

    private void Button_Stack(object sender, EventArgs e)
    {
        Navigation.PushAsync(new StackDemo());
    }

    private void Button_Horizontal(object sender, EventArgs e)
    {
        Navigation.PushAsync(new HorizontalDemo());
    }

    private void Button_Grid(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GridDemo());
    }

    private void Button_Calc(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CalcDemo());
    }

    private void Button_Flex(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlexDemo());
    }

    private void Button_Absolute(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteDemo());
    }

    private void Button_Controls(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ControlsDemo());
    }

    private void Button_ListView(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListViewDemo());
    }
}