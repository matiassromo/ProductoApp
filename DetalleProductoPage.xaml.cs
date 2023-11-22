using ProductoAppMovil2.Models;

namespace ProductoAppMovil2;

public partial class DetalleProductoPage : ContentPage
{
    private Producto _producto;
	public DetalleProductoPage()
	{

        InitializeComponent();
        
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
        await Navigation.PushAsync(new EditatProductoPage()
        {
            BindingContext = _producto,
        });
        
    }

    private async void OnClickEliminarProducto(object sender, EventArgs e)
    {
        var confirmEliminar = await DisplayAlert("Confirmar eliminacion", "Quieres borrar el producto?", "Si", "No");
        if (confirmEliminar)
        {
            Utils.Utils.listaProductos.Remove(_producto);
            await Navigation.PopAsync();
        }    }

    /*private async void OnClickVolver(object sender, EventArgs e)
    {
        await Navigation.PopAsync();

    }*/


}