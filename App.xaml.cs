using ProductoAppMovil2.Services;

namespace ProductoAppMovil2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            APIService apiservice = new APIService();
            MainPage = new NavigationPage(new ProductoPage(apiservice));
            //MainPage = new EditatProductoPage();
        }
    }
}