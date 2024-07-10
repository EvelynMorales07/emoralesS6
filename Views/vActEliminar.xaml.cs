using emoralesS6.Models;

namespace emoralesS6.Views;

public partial class vActEliminar : ContentPage
{
	public vActEliminar(Estudiante datos)
	{
		InitializeComponent();
        txtCodigo.Text=datos.codigo.ToString();
        txtNombre.Text=datos.nombre;
        txtApellido.Text=datos.apellido;
        txtEdad.Text=datos.edad.ToString();
	}

    private void btnActualizar_Clicked(object sender, EventArgs e)
    {

    }

    private void btnEliminar_Clicked(object sender, EventArgs e)
    {

    }
}