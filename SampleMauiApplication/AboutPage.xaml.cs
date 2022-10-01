namespace SampleMauiApplication;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void AccessGit_Clicked(object sender, EventArgs e)
	{
        await Launcher.Default.OpenAsync("https://github.com/manussss");
    }
}