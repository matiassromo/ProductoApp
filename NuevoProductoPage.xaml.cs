using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;
using ProductoAppMovil2.Services;

namespace ProductoAppMovil2;

public partial class NuevoProductoPage : ContentPage
    
{
    private Producto _producto;
    private readonly APIService aPIService;
    public NuevoProductoPage(APIService apiservice)
    {
		InitializeComponent();
        aPIService = apiservice;
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
        await aPIService.PostProducto(producto);

        await Navigation.PopAsync();
    }
}