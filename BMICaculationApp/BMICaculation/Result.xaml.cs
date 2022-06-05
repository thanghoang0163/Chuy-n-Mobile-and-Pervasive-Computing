using System;
using System.Collections.Generic;
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
    public sealed partial class Result : Page
    {
        public Result()
        {
            this.InitializeComponent();

            textResult.Text = "Chỉ số BMI của bạn là:";
            textResult.Text += (Caculator.BMI).ToString();

            if(Caculator.BMI < (decimal)18.5)
            {
                textAdvise.Text = "Hmm!!! Theo như các chuyên gia thì có vẻ bạn bị còi xương rồi. Cần ăn nhiều lên nhé!";
            }
            else if (Caculator.BMI >= (decimal)18.5 && Caculator.BMI <= (decimal)22.9)
            {
                textAdvise.Text = "Bạn đang có chỉ số bình thường. Cố gắng phát huy nhé!";
            }
            else if (Caculator.BMI == (decimal)23)
            {
                textAdvise.Text = "Bạn đang thừa cân. Dành chút thời gian để tập thể dục thể thao nhé!";
            }
            else if (Caculator.BMI > (decimal)23 && Caculator.BMI <= (decimal)24.9)
            {
                textAdvise.Text = "Bạn đang có dấu hiệu béo phì. Hạn chế ăn vặt nhé!";
            }
            else if (Caculator.BMI >= (decimal)25 && Caculator.BMI <= (decimal)29.9)
            {
                textAdvise.Text = "Bạn đang ở thể trạng béo phì. Hạn chế ăn đồ ăn nhanh và nhớ tập thể dục đi nhé!";
            }
            else if (Caculator.BMI >= (decimal)30 && Caculator.BMI <= (decimal)40)
            {
                textAdvise.Text = "Bạn bị béo phì loại 1 rồi. Hãy xem lại khẩu phần ăn vầ nhớ siêng tập luyện thể dục đi nhé!";
            }
            else if (Caculator.BMI > (decimal)40 && Caculator.BMI <= (decimal)50)
            {
                textAdvise.Text = "Bạn bị béo phì loại 2 rồi. Hãy xem lại khẩu phần ăn vầ nhớ siêng tập luyện thể dục đi nhé!";

            }
            else if (Caculator.BMI > (decimal)50)
            {
                textAdvise.Text = "Bạn bị béo phì loại 3 rồi. Phát hiện 1 giống heo mới...";

            }

        }

        private void btnResult_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Caculator));
        }
    }
}
