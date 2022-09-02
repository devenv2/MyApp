using CommunityToolkit.Maui.Views;

namespace MyApp;

public partial class TestPopup : Popup
{
	string time;
	public TestPopup(string time)
	{
		this.time = time;
		InitializeComponent();
		label.Text = time;
 

    }

	void OnYesButtonClicked(object sender, EventArgs e)
	{
		Close(true);
	}

	void OnNoButtonClicked(object sender, EventArgs e)
	{
		Close(false);
	}
}