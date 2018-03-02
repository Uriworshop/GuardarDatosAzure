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

namespace AzureExamenUri
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton btnBuscar { get; set; }


        [Outlet]
        UIKit.UIButton btnGuardar { get; set; }


        [Outlet]
        UIKit.UITextField txtCorreo { get; set; }


        [Outlet]
        UIKit.UITextField txtDomicilio { get; set; }


        [Outlet]
        UIKit.UITextField txtEdad { get; set; }


        [Outlet]
        UIKit.UITextField txtid { get; set; }


        [Outlet]
        UIKit.UITextField txtNombre { get; set; }


        [Outlet]
        UIKit.UITextField txtNombre2 { get; set; }


        [Outlet]
        UIKit.UITextField txtSaldo { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnBuscar != null) {
                btnBuscar.Dispose ();
                btnBuscar = null;
            }

            if (btnGuardar != null) {
                btnGuardar.Dispose ();
                btnGuardar = null;
            }

            if (txtCorreo != null) {
                txtCorreo.Dispose ();
                txtCorreo = null;
            }

            if (txtDomicilio != null) {
                txtDomicilio.Dispose ();
                txtDomicilio = null;
            }

            if (txtEdad != null) {
                txtEdad.Dispose ();
                txtEdad = null;
            }

            if (txtNombre != null) {
                txtNombre.Dispose ();
                txtNombre = null;
            }

            if (txtNombre2 != null) {
                txtNombre2.Dispose ();
                txtNombre2 = null;
            }

            if (txtSaldo != null) {
                txtSaldo.Dispose ();
                txtSaldo = null;
            }
        }
    }
}