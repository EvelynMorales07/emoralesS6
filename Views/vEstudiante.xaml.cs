using emoralesS6.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace emoralesS6.Views;

public partial class vEstudiante : ContentPage
{
	private const string Url = "http://192.168.17.33/moviles/post.php";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Models.Estudiante> est;

	public vEstudiante()
	{
		InitializeComponent();
	}

	public async void mostrar()
	{
		var content = await cliente.GetStringAsync(Url);
		List<Models.Estudiante> mostrar = new JsonConvert.DeserializeObject<List<Models.Estudiante>>(content);
        est =new ObservableCollection<Models.Estudiante>(mostrar);
		listaEstudiates.ItemsSource = est;
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {

    }
}