﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Wandelen
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class previewRoute : ContentPage
	{
        bool isNewRoute;

		public previewRoute (bool isNew = false)
		{
			InitializeComponent ();
            isNewRoute = isNew;
        }
	}
}