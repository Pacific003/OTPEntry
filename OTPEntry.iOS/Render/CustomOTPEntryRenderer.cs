using System;
using OTPEntry.Controls;
using OTPEntry.iOS.Render;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomEntryOTP), typeof(CustomOTPEntryRenderer))]
namespace OTPEntry.iOS.Render
{
    public class CustomOTPEntryRenderer : EntryRenderer, IUITextFieldDelegate
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {

            if (Element == null)
            {
                return;
            }

            var entry = (CustomEntryOTP)Element;
            var textField = new CustomTextField();

            textField.EditingChanged += OnEditingChanged;
            textField.OnDeleteBackwardKey += (sender, a) =>
            {
                entry.Text = " ";
                //entry.OnBackButtonPress();
            };

            SetNativeControl(textField);

            base.OnElementChanged(e);

            if (Control != null)
            {

                Control.BorderStyle = UITextBorderStyle.None;
                Control.Layer.CornerRadius = 10;
                Control.TextColor = UIColor.White;

            }
        }

        IElementController ElementController => Element as IElementController;


        void OnEditingChanged(object sender, EventArgs eventArgs)
        {
            ElementController.SetValueFromRenderer(Entry.TextProperty, Control.Text);
        }
    }

    public class CustomTextField : UITextField
    {
        // A delegate type for hooking up change notifications.
        public delegate void DeleteBackwardKeyEventHandler(object sender, EventArgs e);

        // An event that clients can use to be notified whenever the
        // elements of the list change.
        public event DeleteBackwardKeyEventHandler OnDeleteBackwardKey;


        public void OnDeleteBackwardKeyPressed()
        {
            if (OnDeleteBackwardKey != null)
            {
                OnDeleteBackwardKey(null, null);
            }
        }

        public override void DeleteBackward()
        {
            base.DeleteBackward();
            OnDeleteBackwardKeyPressed();
        }
    }
}
