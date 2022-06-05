using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace BMICaculation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Caculator : Page
    {
        private static float height, weight, stat;
        public static decimal BMI;
        public Caculator()
        {
            this.InitializeComponent();
            textWeight.Focus(FocusState.Programmatic);
            rbtnMale.IsChecked = true;
        }


        //private void textHeight_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
        //        e.Handled = true;
        //}

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(textHeight.Text) || string.IsNullOrEmpty(textWeight.Text)
                || (textHeight.Text == "" && textWeight.Text == ""))
            {
                textNote.Text = "Các chỉ số không đúng hoặc bị bỏ trống!";
            }
            else
            {
                height = float.Parse(textHeight.Text, CultureInfo.InvariantCulture.NumberFormat);
                //height = (float)Convert.ToDouble(textHeight.Text);
                if (height < 0 || height >= 3)
                {
                    textNote.Text = "Chiều cao hư cấu! Vui lòng nhập lại.";
                }
                weight = float.Parse(textWeight.Text, CultureInfo.InvariantCulture.NumberFormat);
                if (weight < 0 || weight >= 1000)
                {
                    textNote.Text = "Cân nặng hư cấu! Vui lòng nhập lại.";

                }
                stat = weight / (height * height);
                BMI = Math.Round((decimal)stat, 1);
                Frame.Navigate(typeof(Result));
            }

          

            //if(Char.IsNumber(textHeight.Text, 3) || Char.IsNumber(textWeight.Text, 3))
            //{
            //    textNote.Text = "Các chỉ số phải là số!";
            //}
        }


        

        

    }
}
