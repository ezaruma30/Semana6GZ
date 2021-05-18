using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Semana6GZ
{
    public partial class MainPage : ContentPage
    {
        private const string Url = "http://192.168.100.17/moviles/post.php";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<Semana6GZ.Ws.Datos> _post;
        public MainPage()
        {
            InitializeComponent();
            get();
        }

        public async void get()
        {
            try
            {
                var content = await client.GetStringAsync(Url);
                List<Semana6GZ.Ws.Datos> posts = JsonConvert.DeserializeObject<List<Semana6GZ.Ws.Datos>>(content);
                _post = new ObservableCollection<Semana6GZ.Ws.Datos>(posts);


            }
            catch (Exception ex)
            {
                DisplayAlert("error", "error" + ex.Message, "ok");

            }

        }

        private async void btnGet_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new InsertPost());
        }

        private async void btnPost_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Put());
        }

        private async void btnEliminar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Eliminar());
        }
    }
}
