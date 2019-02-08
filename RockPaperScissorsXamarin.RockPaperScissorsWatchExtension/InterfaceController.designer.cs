// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RockPaperScissorsXamarin.RockPaperScissorsWatchExtension
{
    [Register ("InterfaceController")]
    partial class InterfaceController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel OponentLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton PaperButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel ResultLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton RockButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceButton ScissorsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceTimer Timer { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        WatchKit.WKInterfaceLabel WinnerLabel { get; set; }

        [Action ("PaperButton_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void PaperButton_Activated ();

        [Action ("RockButton_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RockButton_Activated ();

        [Action ("ScissorsButton_Activated")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ScissorsButton_Activated ();

        void ReleaseDesignerOutlets ()
        {
            if (OponentLabel != null) {
                OponentLabel.Dispose ();
                OponentLabel = null;
            }

            if (PaperButton != null) {
                PaperButton.Dispose ();
                PaperButton = null;
            }

            if (ResultLabel != null) {
                ResultLabel.Dispose ();
                ResultLabel = null;
            }

            if (RockButton != null) {
                RockButton.Dispose ();
                RockButton = null;
            }

            if (ScissorsButton != null) {
                ScissorsButton.Dispose ();
                ScissorsButton = null;
            }

            if (Timer != null) {
                Timer.Dispose ();
                Timer = null;
            }

            if (WinnerLabel != null) {
                WinnerLabel.Dispose ();
                WinnerLabel = null;
            }
        }
    }
}