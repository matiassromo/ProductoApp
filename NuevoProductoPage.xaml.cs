using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;

namespace ProductoAppMovil2;

public partial class NuevoProductoPage : ContentPage
{
	public NuevoProductoPage()
	{
		InitializeComponent();
	}

    private async void OnClickNuevoProducto(object sender, EventArgs e)
    {
        var toast = Toast.Make("Producto Creado", ToastDuration.Short, 10);

        await toast.Show();

        Producto producto = new Producto
        {
            IdProducto = 0,
            Nombre = Nombre.Text,
            Descripcion = Descripcion.Text,
            Cantidad = Int32.Parse(Cantidad.Text)
        };
        Utils.Utils.listaProductos.Add(producto);

        await Navigation.PopAsync();
    }
}