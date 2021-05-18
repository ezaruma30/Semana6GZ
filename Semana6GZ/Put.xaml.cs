using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana6GZ
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Put : ContentPage
    {
        public Put()
        {
            InitializeComponent();
        }

        private void btnModificar_Clicked(object sender, EventArgs e)
        {
            try
            {
                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
                cliente.UploadValues("http://192.168.0.185/moviles/post.php", "PUT", parametros);

                var mensaje = "Dato Actualizado";
                DependencyService.Get<Mensaje>().LongAlert(mensaje);
                txtCodigo.Text = "";
                txtNombre.Text = "";
                txtApellido.Text = "";
                txtEdad.Text = "";
            }
            catch (Exception ex)
            {
                DependencyService.Get<Mensaje>().ShortAlert(ex.Message);
            }
        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MainPage());
        }
    }
}