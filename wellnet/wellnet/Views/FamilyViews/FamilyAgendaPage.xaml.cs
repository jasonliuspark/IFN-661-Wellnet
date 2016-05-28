using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace wellnet.Views.FamilyViews
{
    public partial class FamilyAgenda : ContentPage
    {
        public FamilyAgenda()
        {
            InitializeComponent();
            /* Agenda */
            var AgendaStatus = new Label()
            {
                Text = "Agenda" ,
                TextColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };
            var AgendaStatusPic = new Image { Aspect = Aspect.Fill };
            {
                AgendaStatusPic.Source = ImageSource.FromFile("Agenda.jpg");
            };

             var BackgroundGrid = new Image();

            /*-----stacklayouts---*/
            /*  stack for blood presure  */
            var Agenda_Status = new StackLayout()
            {
                Spacing = 0,
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            /*monitoring grids layout */
            var AgendaGrid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions ={
                    new RowDefinition{Height=GridLength.Auto},
                    new RowDefinition{Height= new GridLength(1, GridUnitType.Star)},
                    },
                ColumnDefinitions ={
                    new ColumnDefinition{ Width=GridLength.Auto},
                    //new ColumnDefinition{ Width= new GridLength(1, GridUnitType.Star)},
                }
            };

            /*fill blood presure stack */
            AgendaGrid.Children.Add(AgendaStatusPic);
 
            /*grid style*/
            //this.Padding = new Thickness(30, 30, 10, 10);
            this.Content = AgendaGrid;
        }
    }
}
