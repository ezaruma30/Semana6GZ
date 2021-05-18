using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Semana6GZ.Droid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

[assembly: Xamarin.Forms.Dependency(typeof(Mensajes))]

namespace Semana6GZ.Droid
{
    class Mensajes : Mensaje
    {
        public void LongAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Long).Show();
        }

        public void ShortAlert(string mensaje)
        {
            Toast.MakeText(Application.Context, mensaje, ToastLength.Short).Show();

        }
    }
}