namespace BedTimeStories;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();
	}

    private void btntortue_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new tortuePage());
    }

    private void btngold_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new goldPage());
    }

    private void btnloup_Clicked(object sender, EventArgs e)
    {
        this.Navigation.PushAsync(new loupPage());
    }
}