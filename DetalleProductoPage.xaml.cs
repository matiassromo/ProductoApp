using ProductoAppMovil2.Models;

namespace ProductoAppMovil2;

public partial class DetalleProductoPage : ContentPage
{
	public DetalleProductoPage(Producto producto)
	{

        InitializeComponent();
        if (producto != null)
        {
            Nombre.Text = producto.Nombre;
            Cantidad.Text = producto.Cantidad.ToString();
            Descripcion.Text = producto.Descripcion;
        }
    }

    private async void OnClickVolver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }
}