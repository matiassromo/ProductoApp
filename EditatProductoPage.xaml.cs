using Android.Net;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using ProductoAppMovil2.Models;
using ProductoAppMovil2.Services;

namespace ProductoAppMovil2;

public partial class EditatProductoPage : ContentPage
{
    private readonly APIService aPIService;
    private Producto _producto;
    public EditatProductoPage(APIService apiservice)
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

    private async void OnClickEditatProducto(object sender, EventArgs e)
    {
        if (_producto != null)
        {
            _producto.Nombre = Nombre.Text;
            _producto.Cantidad = Int32.Parse(Cantidad.Text);
            _producto.Descripcion = Descripcion.Text;
            await aPIService.PutProducto(_producto.IdProducto, _producto);

            var toast = Toast.Make("Producto Editado", ToastDuration.Short, 10);
            await toast.Show();
        }
        else
        {

            Producto producto = new Producto
            {
                IdProducto = 0,
                Nombre = Nombre.Text,
                Descripcion = Descripcion.Text,
                Cantidad = Int32.Parse(Cantidad.Text),
            };

            Utils.Utils.listaProductos.Add(producto);
        }
        await Navigation.PopAsync();

    }
}