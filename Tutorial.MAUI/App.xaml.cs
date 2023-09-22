namespace Tutorial.MAUI;

public partial class App : Application
{
	public App()
	{
      //  try
        {
            InitializeComponent();

            var navPage = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Colors.Purple,
                BarTextColor = Colors.White
            };

            MainPage = navPage;
        }
      //  catch (Exception ex)
      //  {
      //      Console.WriteLine(ex.ToString());
      //  }



        //MainPage = new AppShell();
    }
}
