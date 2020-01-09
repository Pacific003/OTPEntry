using System;
using Xamarin.Forms;

namespace OTPEntry.Controls
{
    public class CustomEntryOTP : Entry
    {
        public delegate void BackButtonPressEventHandler(object sender, EventArgs e);

        public event BackButtonPressEventHandler OnBackButton;

        public CustomEntryOTP() { }

        public void OnBackButtonPress()
        {
            if (OnBackButton != null)
            {
                OnBackButton(null, null);
            }
        }
    }
}
