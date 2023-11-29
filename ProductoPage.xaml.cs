using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;
using ProductoAppMovil2.Services;
using System.Collections.ObjectModel;

namespace ProductoAppMovil2;

public partial class ProductoPage : ContentPage
	
{

    private readonly APIService aPIService;
    public ProductoPage(APIService apiservice)
	{
		InitializeComponent();
		aPIService = apiservice;

	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
		List<Producto> ListaProducto = await aPIService.GetProductos();
		var productos = new ObservableCollection<Producto>(Utils.Utils.listaProductos);
		listaProductos.ItemsSource = productos;
        
    }

    private async void OnNuevoProducto(object sender, EventArgs e)
	{
		//var toast = Toast.Make("Click en nuevo producto", ToastDuration.Short, 10);
		//await toast.Show();

		await Navigation.PushAsync(new NuevoProductoPage(aPIService));
	}

    private async void OnClickDetalleProducto(object sender, SelectedItemChangedEventArgs e)
    {
		/*var toast = Toast.Make("CLICK", ToastDuration.Short);
		await toast.Show();*/
		Producto producto = e.SelectedItem as Producto;
		await Navigation.PushAsync(new DetalleProductoPage(aPIService){
			BindingContext = producto,
		});;
    }
}