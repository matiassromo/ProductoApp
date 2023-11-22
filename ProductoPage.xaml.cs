using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;

namespace ProductoAppMovil2;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();
		listaProductos.ItemsSource = Utils.Utils.listaProductos;
	}

    private async void OnNuevoProducto(object sender, EventArgs e)
	{
		var toast = Toast.Make("Producto Creado", ToastDuration.Short, 10);

		await toast.Show();

		

	}
}