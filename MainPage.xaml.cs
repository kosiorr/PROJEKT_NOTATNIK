namespace notatnikpam;

public partial class MainPage : ContentPage
{
int nazwa = 0;
    
	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
        
		DateTime czas = DateTime.Now;
		string tekst = czas.ToString();
		Location location = await Geolocation.Default.GetLocationAsync();
		tekst = tekst + "\n lat:" +location.Latitude + "\n long:" +location.Longitude + "\n" + tresc.Text;
        string nazwaPliku = nazwa.ToString() + ".txt";
		string targetFile = Path.Combine(FileSystem.Current.AppDataDirectory, nazwaPliku);
		File.WriteAllText(targetFile, tekst);


		await DisplayAlert("Zapisano", tekst, "OK");
		

		nazwa++;
    }
}

