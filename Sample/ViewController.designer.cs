// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace Sample
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITableView DataTableView { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ReadButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView ReadText { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel StatusLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton StopButton { get; set; }

        [Action ("ClearButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClearButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("ReadButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ReadButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("StopButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void StopButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ClearButton != null) {
                ClearButton.Dispose ();
                ClearButton = null;
            }

            if (DataTableView != null) {
                DataTableView.Dispose ();
                DataTableView = null;
            }

            if (ReadButton != null) {
                ReadButton.Dispose ();
                ReadButton = null;
            }

            if (ReadText != null) {
                ReadText.Dispose ();
                ReadText = null;
            }

            if (StatusLabel != null) {
                StatusLabel.Dispose ();
                StatusLabel = null;
            }

            if (StopButton != null) {
                StopButton.Dispose ();
                StopButton = null;
            }
        }
    }
}