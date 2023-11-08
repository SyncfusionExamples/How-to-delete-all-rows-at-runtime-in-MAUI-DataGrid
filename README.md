# How-to-delete-all-rows-at-runtime-in-MAUI-DataGrid

This article illustrates deleting all the rows at runtime in a [.NET MAUI DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid). In this example, we will delete all the rows through a button click.

Initialize the [SfDataGrid](https://help.syncfusion.com/maui/datagrid/getting-started) with the required properties. Then, in the button click event, you can delete all records in the `ItemsSource` ObservableCollection by using the `Clear` function. The `SfDataGrid` will automatically refresh its view whenever you add or remove rows.

**XAML:**

 ```xml
<?xml version="1.0" encoding="utf-8"?>
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             xmlns:local="clr-namespace:MauiApp1"
             xmlns:dataGrid="clr-namespace:Syncfusion.Maui.DataGrid;assembly=Syncfusion.Maui.DataGrid"
             x:Class="MauiApp1.MainPage">
    <ContentPage.BindingContext>
        <local:OrderInfoRepository x:Name="viewModel"/>
    </ContentPage.BindingContext>
    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="Auto"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Button Text="Delete All the Rows" Clicked="Delete_All_Button_Clicked" Grid.Row="0" Margin="0,10,0,10"></Button>
    <dataGrid:SfDataGrid x:Name="dataGrid"
                         ItemsSource="{Binding OrderInfoCollection}" 
                         ColumnWidthMode="Auto"
                         Grid.Row="1"
                         >
    </dataGrid:SfDataGrid>
    </Grid>

</ContentPage>
 ```

**MainPage.xaml.cs**

 ```c#
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

 ```

![ezgif.com-video-to-gif.gif](https://support.syncfusion.com/kb/agent/attachment/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEzODA5Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.FSSGs0zt6LjP3LPjIOGPoBj9ktPJhmRkBinZFdGFVJg)

