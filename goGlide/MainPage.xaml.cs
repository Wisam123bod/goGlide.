﻿using System;
using Microsoft.Maui.Controls;
using goGlide;

namespace goGlide;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	
	private void RegNewCarClicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(new RegNewCar());
    }

    private void ListAllCarsClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ListAllCars());
    }

    private void RentOutCarClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new RentOutCar());
    }
}


