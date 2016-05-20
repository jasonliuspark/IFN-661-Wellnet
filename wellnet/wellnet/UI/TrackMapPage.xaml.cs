using System;
using System.Collections.Generic;
using Xamarin.Forms;


namespace wellnet
{
	public partial class TrackMapPage : ContentPage
	{	

		public TrackMapPage ()
		{  	// Jack Test set hospital level map as a backgroundimage
				var layout = new StackLayout { Padding = 0 };

				var backgroundImage = new Image()
					{
					  Source = FileImageSource.FromFile("hospital_level.gif")
					};

						var relativeLayout = new RelativeLayout();

						relativeLayout.Children.Add(backgroundImage,
							Constraint.Constant(0),
							Constraint.Constant(0),
							Constraint.RelativeToParent((parent) => { return parent.Width; }),
							Constraint.RelativeToParent((parent) => { return parent.Height; }));
			
						relativeLayout.Children.Add(layout,
							Constraint.Constant(0),
							Constraint.Constant(0),
							Constraint.RelativeToParent((parent) => { return parent.Width; }),
							Constraint.RelativeToParent((parent) => { return parent.Height; }));
			
						Content = relativeLayout ;
					}


			// Jack test set up a large scrollable hospital level map
			//			var backgroundImage = new Image () {
			//				Source = FileImageSource.FromFile ("hospital_level.gif")
			//				};

			}
		}

