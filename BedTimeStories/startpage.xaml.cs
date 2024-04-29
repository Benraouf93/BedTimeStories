namespace BedTimeStories;

public partial class startpage : ContentPage
{
	public startpage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		this.Navigation.PushAsync(new Menu());
    }
}