﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App07_ListaBrasil.Modelo;

namespace App07_ListaBrasil
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Estados : ContentPage
	{
		public Estados ()
		{
			InitializeComponent ();
            ListaEstados.ItemsSource = Servico.Servico.GetEstados();
		}

        private void SelecaoEstadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Estado estado = (Estado)args.SelectedItem;

            Navigation.PushAsync(new Municipios(estado));
        }

    }
}