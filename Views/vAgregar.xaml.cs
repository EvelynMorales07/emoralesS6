using System.Net;

namespace emoralesS6.Views;

public partial class vAgregar : ContentPage
{
	public vAgregar()
	{
		InitializeComponent();
	}

    private void btnAgregar_Clicked(object sender, EventArgs e)
    {
		try
		{
			WebClient cliente = new WebClient();
			var parametros = new System.Collections.Specialized.NameValueCollection();
			parametros.Add("nombre", txtNombre.Text);
			parametros.Add("apellido",txtApellido.Text);
			parametros.Add("edad",txtEdad.Text);

			cliente.UploadValues("http://192.168.17.33/moviles/post.php", "POST", parametros);
			Navigation.PushAsync(new vEstudiante());
			
		
		}
		catch (Exception ex)
		{

			DisplayAlert("Alerta", ex.Message, "OK");
		}
    }
}