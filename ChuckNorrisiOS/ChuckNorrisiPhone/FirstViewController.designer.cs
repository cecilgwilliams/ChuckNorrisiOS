// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace ChuckNorrisiPhone
{
	[Register ("FirstViewController")]
	partial class FirstViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton NextQuote { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView QuoteBox { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIView Quotes { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (NextQuote != null) {
				NextQuote.Dispose ();
				NextQuote = null;
			}
			if (QuoteBox != null) {
				QuoteBox.Dispose ();
				QuoteBox = null;
			}
			if (Quotes != null) {
				Quotes.Dispose ();
				Quotes = null;
			}
		}
	}
}
