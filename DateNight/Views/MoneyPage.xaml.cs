using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class MoneyPage : ContentPage
{
    public MoneyPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        try
        {
        lblDisplay.Text = App.dateCalc.GetTotalCost();
        }
        catch (Exception e)
        {
            lblDisplay.Text = $"0.00";
            DisplayAlert("Error", e.Message, "Okay");
        }
    }
}