﻿using System;

using UIKit;
using CoreGraphics;
using C1.iOS.Chart;
using Foundation;
using System.Collections.Generic;

namespace FlexChart101
{
	public partial class CustomPlotElementsController : UIViewController
	{
		public CustomPlotElementsController() : base("CustomPlotElementsController", null)
		{
		}

		public CustomPlotElementsController(IntPtr handle) : base(handle)
		{
		}
		FlexChart chart;
		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
			chart = new FlexChart();
			this.Add(chart);

			var cList = new List<Company>
			{
				new Company { Name = "Apple", DevicesSold = 15.58} ,
				new Company { Name = "Google", DevicesSold = 20.23 },
				new Company { Name = "Microsoft", DevicesSold = 10.46 },
			};

			chart.ItemsSource = cList;

			chart.BindingX = "Name";
			chart.Series.Add(new ChartSeries() { SeriesName = "DevicesSold", Binding = "DevicesSold,DevicesSold" });

			chart.LegendPosition = ChartPositionType.None;
			chart.AxisY.AxisLine = false;
			chart.AxisY.Title = "Devices Sold (billions)";
			chart.AxisY.Style = new ChartStyle() { FontAttributes = CoreText.CTFontSymbolicTraits.Italic, FontSize = 16 };


			chart.Series[0].SymbolRendered += (object sender, RenderSymbolEventArgs e) =>
			{
				var img = cList[e.Index].Name.ToLower();
				UIImage image = new UIImage("Images/" + img);
				image.Draw(new CGRect(e.Point.X - e.Size.Width / 2 + 10, e.Point.Y + (e.Size.Height - e.Size.Width) / 2 + 10, e.Size.Width - 20, e.Size.Width - 20));
			};
		}

		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();
			chart.Frame = new CGRect(this.View.Frame.X, this.View.Frame.Y + 80,
									 this.View.Frame.Width, this.View.Frame.Height - 80);
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}

	public class Company
	{
		string name;
		public string Name
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}
		public double DevicesSold { get; set; }
	}
}

