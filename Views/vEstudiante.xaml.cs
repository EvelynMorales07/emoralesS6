using emoralesS6.Models;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace emoralesS6.Views;

public partial class vEstudiante : ContentPage
{
	private const string Url = "http://192.168.17.30/semana6/post.php";
	private readonly HttpClient cliente = new HttpClient();
	private ObservableCollection<Estudiante> est;

	public vEstudiante()
	{
		InitializeComponent();
	}

	public async void mostrar()
	{
		var content = await cliente.GetStringAsync(Url);
		List<Estudiante> mostrar = new JsonConvert.DeserializeObject<List<Estudiante>>(content);
		est=new ObservableCollection<Estudiante>(mostrar);
		listaEstudiates.ItemsSource = est;
	}
}