using System;
using System.Drawing;
using System.Collections.Generic;
using Foundation;
using UIKit;
using ChuckNorris;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Xamarin.iOS;
using CoreGraphics;

namespace ChuckNorrisiPhone
{
    public partial class SecondViewController : UIViewController
    {
        public SecondViewController(IntPtr handle)
            : base(handle)
        {
            Title = NSBundle.MainBundle.LocalizedString("Graph", "Graphs");
            TabBarItem.Image = UIImage.FromBundle("Images/second");
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        #region View lifecycle

        private PlotModel CreatePlotModel()
        {
            ChuckNorrisActions chuckNorrisActions = new ChuckNorrisActions();

            var plotModel = new PlotModel { Title = chuckNorrisActions.Title };

            //plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            //plotModel.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Maximum = 10, Minimum = 0 });

            plotModel.Series.Add(new LineSeries
            {
                ItemsSource = chuckNorrisActions.Kicks,
                Title = "Kicks"
            });

            plotModel.Series.Add(new LineSeries
            {
                ItemsSource = chuckNorrisActions.Punches,
                Title = "Punches"
            });

            return plotModel;
        }

        PlotView plotView;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
            //PlotView plotView = new PlotView();
            var plotModel = new PlotModel { Title = "OxyPlot Demo" };

            CGRect viewFrame = this.View.Frame;
            CGRect graphFrame = new CGRect(viewFrame.Left, viewFrame.Top + 10, viewFrame.Right - 10, viewFrame.Bottom - 60);

            plotView = new PlotView
            {
                Model = CreatePlotModel(),
                Frame = graphFrame
            };
            this.View.AddSubview(plotView);
        }

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);
        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
        }

        public override void ViewWillDisappear(bool animated)
        {
            base.ViewWillDisappear(animated);
        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
        }

        public override void DidRotate(UIInterfaceOrientation fromInterfaceOrientation)
        {
            base.DidRotate(fromInterfaceOrientation);

            CGRect viewFrame = this.View.Frame;
            CGRect graphFrame = new CGRect(viewFrame.Left, viewFrame.Top + 10, viewFrame.Right - 10, viewFrame.Bottom - 60);
            this.plotView.Frame = graphFrame;
            this.plotView.InvalidatePlot(false);
        }

        #endregion
    }
}