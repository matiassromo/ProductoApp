    using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;
using ProductoAppMovil2.Services;

namespace ProductoAppMovil2;

public partial class DetalleProductoPage : ContentPage
{
    private Producto _producto;
    private readonly APIService aPIService;
	public DetalleProductoPage(APIService apiservice)
	{

        InitializeComponent();
        aPIService = apiservice;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _producto = BindingContext as Producto;
        Nombre.Text = _producto.Nombre;
        Cantidad.Text = _producto.Cantidad.ToString();
        Descripcion.Text = _producto.Descripcion;   
    }


    private async void OnClickEditarProducto(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new EditatProductoPage(aPIService)
        {
            BindingContext = _producto,
        });
        
    }

    private async void OnClickEliminarProducto(object sender, EventArgs e)
    {
        var confirmEliminar = await DisplayAlert("Confirmar eliminacion", "Quieres borrar el producto?", "Si", "No");
        if (confirmEliminar)
        {
            await aPIService.DeleteProducto(_producto.IdProducto);
            // Utils.Utils.listaProductos.Remove(_producto);
            var toast = Toast.Make("Producto Eliminado", ToastDuration.Short, 10);
            await toast.Show();
            await Navigation.PopAsync();
        }    }

    /*private async void OnClickVolver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }*/


}