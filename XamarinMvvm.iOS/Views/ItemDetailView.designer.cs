// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinMvvm.iOS.Views
{
    [Register ("ItemDetailView")]
    partial class ItemDetailView
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel VcDescription { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (VcDescription != null) {
                VcDescription.Dispose ();
                VcDescription = null;
            }
        }
    }
}