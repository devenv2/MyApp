using CommunityToolkit.Maui.Views;

namespace MyApp;

public partial class TestPage : ContentPage
{
    string time = DateTime.Now.ToShortDateString();
    public TestPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var popup = new TestPopup(time);

        await DisplayPopup();
    }

    public async Task DisplayPopup()
    {
        var popup = new TestPopup(time);

        var result = await this.ShowPopupAsync(popup);


        await DisplayAlert("", result.ToString(), "OK");


    }
}