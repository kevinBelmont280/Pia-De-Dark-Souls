using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace login2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VerEquipos : ContentPage
    {
        public VerEquipos()
        {
            InitializeComponent();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}