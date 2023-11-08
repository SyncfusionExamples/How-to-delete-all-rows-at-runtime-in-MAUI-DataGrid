
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.Inputs;

namespace MauiApp1
{

    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Delete_All_Button_Clicked(object sender, EventArgs e)
        {
            if (viewModel.OrderInfoCollection != null)
            {
                viewModel.OrderInfoCollection.Clear();
            }

        }
    }
}



