namespace MyApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

             MainPage = new NavigationPage(new TestPage());

    }
}
