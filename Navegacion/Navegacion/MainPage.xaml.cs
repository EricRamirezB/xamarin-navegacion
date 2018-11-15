using Navegacion.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Navegacion
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Inicio_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
            IsPresented = false;
        }

        private void Contactenos_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ContactoPage());
            IsPresented = false;
        }

        private void Acerca_Click(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AboutPage());
            IsPresented = false;
        }
    }
}
