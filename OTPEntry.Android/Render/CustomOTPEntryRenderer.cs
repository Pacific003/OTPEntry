using System;
using Android.Content.Res;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Views;
using OTPEntry.Controls;
using OTPEntry.Droid.Render;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomEntryOTP), typeof(CustomOTPEntryRenderer))]
namespace OTPEntry.Droid.Render
{
    [Obsolete]
    public class CustomOTPEntryRenderer : EntryRenderer
    {        
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                GradientDrawable gd = new GradientDrawable();
                gd.SetColor(global::Android.Graphics.Color.Transparent);
                this.Control.SetBackgroundDrawable(gd);
                this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.Gray));

            }

            Control.KeyPress += (object sender, KeyEventArgs even) =>
            {
                even.Handled = false;
                if (even.Event.Action == KeyEventActions.Down && even.KeyCode == Keycode.Del)
                {
                    even.Handled = true;
                    Control.Text = " ";
                }
            };
        }
    }
}
