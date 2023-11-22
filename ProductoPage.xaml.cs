using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;
using System.Collections.ObjectModel;

namespace ProductoAppMovil2;

public partial class ProductoPage : ContentPage
{
	public ProductoPage()
	{
		InitializeComponent();

	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
		var productos = new ObservableCollection<Producto>(Utils.Utils.listaProductos);
		listaProductos.ItemsSource = productos;
        
    }

    private async void OnNuevoProducto(object sender, EventArgs e)
	{
		//var toast = Toast.Make("Click en nuevo producto", ToastDuration.Short, 10);
		//await toast.Show();

		await Navigation.PushAsync(new NuevoProductoPage());
	}

    private async void OnClickDetalleProducto(object sender, SelectedItemChangedEventArgs e)
    {
		var toast = Toast.Make("CLICK", ToastDuration.Short);
		await toast.Show();
		Producto producto = e.SelectedItem as Producto;
		await Navigation.PushAsync(new DetalleProductoPage(producto));
    }
}