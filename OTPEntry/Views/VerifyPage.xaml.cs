using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OTPEntry.Views
{
    public partial class VerifyPage : ContentPage
    {
        public VerifyPage()
        {
            InitializeComponent();           

            FirstCode.TextChanged += FirstCode_TextChanged;
            SecondCode.TextChanged += SecondCode_TextChanged;
            ThirdCode.TextChanged += ThirdCode_TextChanged;
            FourthCode.TextChanged += FourthCode_TextChanged;
            FifthCode.TextChanged += FifthCode_TextChanged;
            SixthCode.TextChanged += SixthCode_TextChanged;
        }

        private void FirstCode_TextChanged(object sender, TextChangedEventArgs e)
        {

            string _text = FirstCode.Text;

            if (!string.IsNullOrWhiteSpace(_text))
            {
                if (FirstCode.Text.Length > 0 && FirstCode.Text.Length == 1)
                {
                    FirstCode.TextColor = Color.FromHex("#6f348f");
                    FirstFrame.BorderColor = Color.FromHex("#6f348f");
                    SecondCode.Focus();
                }
                else if (FirstCode.Text.Length > 1)
                {
                    var Extra = _text[_text.Length - 1];
                    _text = _text.Remove(_text.Length - 1);  // Remove Last character
                    FirstFrame.BorderColor = Color.FromHex("#6f348f");
                    FirstCode.TextColor = Color.FromHex("#6f348f");
                    FirstCode.Text = _text;
                    SecondCode.Focus();
                    SecondCode.Text = Extra.ToString();
                }
                else
                {
                    FirstFrame.BorderColor = Color.FromHex("#dbdbdb");
                }
            }
            else
            {
                FirstCode.Text = string.Empty;
                FirstFrame.BorderColor = Color.FromHex("#dbdbdb");
            }
        }

        private void SecondCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string _text = SecondCode.Text;

            if (!string.IsNullOrWhiteSpace(_text))
            {
                if (SecondCode.Text.Length > 0 && SecondCode.Text.Length == 1)
                {
                    SecondCode.TextColor = Color.FromHex("#6f348f");
                    SecondFrame.BorderColor = Color.FromHex("#6f348f");
                    ThirdCode.Focus();
                }
                else if (SecondCode.Text.Length > 1)
                {
                    var Extra = _text[_text.Length - 1];
                    _text = _text.Remove(_text.Length - 1);  // Remove Last character
                    SecondCode.TextColor = Color.FromHex("#6f348f");
                    SecondFrame.BorderColor = Color.FromHex("#6f348f");
                    SecondCode.Text = _text;
                    ThirdCode.Focus();
                    ThirdCode.Text = Extra.ToString();
                }
                else
                {
                    SecondFrame.BorderColor = Color.FromHex("#dbdbdb");
                    FirstCode.Focus();
                }
            }
            else
            {
                SecondCode.Text = string.Empty;
                SecondFrame.BorderColor = Color.FromHex("#dbdbdb");
                FirstCode.Focus();
            }
        }

        private void ThirdCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string _text = ThirdCode.Text;

            if (!string.IsNullOrWhiteSpace(_text))
            {
                if (ThirdCode.Text.Length > 0 && ThirdCode.Text.Length == 1)
                {
                    ThirdCode.TextColor = Color.FromHex("#6f348f");
                    ThirdFrame.BorderColor = Color.FromHex("#6f348f");
                    FourthCode.Focus();
                }
                else if (ThirdCode.Text.Length > 1)
                {
                    var Extra = _text[_text.Length - 1];
                    _text = _text.Remove(_text.Length - 1);  // Remove Last character
                    ThirdCode.TextColor = Color.FromHex("#6f348f");
                    ThirdFrame.BorderColor = Color.FromHex("#6f348f");
                    ThirdCode.Text = _text;
                    FourthCode.Focus();
                    FourthCode.Text = Extra.ToString();
                }
                else
                {

                    ThirdFrame.BorderColor = Color.FromHex("#dbdbdb");
                    SecondCode.Focus();
                }
            }
            else
            {
                ThirdCode.Text = string.Empty;
                ThirdFrame.BorderColor = Color.FromHex("#dbdbdb");
                SecondCode.Focus();
            }

        }

        private void FourthCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string _text = FourthCode.Text;

            if (!string.IsNullOrWhiteSpace(_text))
            {
                if (FourthCode.Text.Length > 0 && FourthCode.Text.Length == 1)
                {
                    FourthCode.TextColor = Color.FromHex("#6f348f");
                    FourthFrame.BorderColor = Color.FromHex("#6f348f");
                    FifthCode.Focus();
                }
                else if (FourthCode.Text.Length > 1)
                {
                    var Extra = _text[_text.Length - 1];
                    _text = _text.Remove(_text.Length - 1);  // Remove Last character
                    FourthCode.TextColor = Color.FromHex("#6f348f");
                    FourthFrame.BorderColor = Color.FromHex("#6f348f");
                    FourthCode.Text = _text;
                    FifthCode.Focus();
                    FifthCode.Text = Extra.ToString();
                }
                else
                {
                    FourthFrame.BorderColor = Color.FromHex("#dbdbdb");
                    ThirdCode.Focus();
                }
            }
            else
            {
                FourthCode.Text = string.Empty;
                FourthFrame.BorderColor = Color.FromHex("#dbdbdb");
                ThirdCode.Focus();
            }
        }

        private void FifthCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string _text = FifthCode.Text;

            if (!string.IsNullOrWhiteSpace(_text))
            {
                if (FifthCode.Text.Length > 0 && FifthCode.Text.Length == 1)
                {
                    FifthFrame.BorderColor = Color.FromHex("#6f348f");
                    FifthCode.TextColor = Color.FromHex("#6f348f");
                    SixthCode.Focus();
                }
                else if (FifthCode.Text.Length > 1)
                {
                    var Extra = _text[_text.Length - 1];
                    _text = _text.Remove(_text.Length - 1);  // Remove Last character
                    FifthCode.TextColor = Color.FromHex("#6f348f");
                    FifthFrame.BorderColor = Color.FromHex("#6f348f");
                    FifthCode.Text = _text;
                    SixthCode.Focus();
                    SixthCode.Text = Extra.ToString();
                }
                else
                {
                    FifthFrame.BorderColor = Color.FromHex("#dbdbdb");
                    FourthCode.Focus();
                }
            }
            else
            {
                FifthCode.Text = string.Empty;
                FifthFrame.BorderColor = Color.FromHex("#dbdbdb");
                FourthCode.Focus();
            }
        }

        private void SixthCode_TextChanged(object sender, TextChangedEventArgs e)
        {
            string _text = SixthCode.Text;

            if (!string.IsNullOrWhiteSpace(_text))
            {
                if (SixthCode.Text.Length > 1)
                {
                    SixthFrame.BorderColor = Color.FromHex("#6f348f");
                    SixthCode.TextColor = Color.FromHex("#6f348f");
                    _text = _text.Remove(_text.Length - 1);  // Remove Last character
                    SixthCode.Text = _text;
                }
                else if (SixthCode.Text.Length == 0)
                {
                    SixthFrame.BorderColor = Color.FromHex("#dbdbdb");
                    SixthCode.TextColor = Color.FromHex("##dbdbdb");
                    FifthCode.Focus();
                }
                else
                {
                    SixthFrame.BorderColor = Color.FromHex("#6f348f");
                    SixthCode.TextColor = Color.FromHex("#6f348f");
                }
            }
            else
            {
                SixthCode.Text = string.Empty;
                SixthFrame.BorderColor = Color.FromHex("#dbdbdb");
                SixthCode.TextColor = Color.FromHex("##dbdbdb");
                FifthCode.Focus();
            }
        }
    }
}
