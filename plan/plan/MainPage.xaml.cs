using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace plan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            StackLayout st = new StackLayout();
            Title = "Дни недели";
            BackgroundColor = Color.LightBlue;
            Button pon_btn = new Button { Text = "Понедельник", BackgroundColor=Color.SkyBlue, ImageSource = "dni.png" };
            Button vtor_btn = new Button { Text = "Вторник", BackgroundColor = Color.SkyBlue, ImageSource = "dni.png" };
            Button sred_btn = new Button { Text = "Среда", BackgroundColor = Color.SkyBlue, ImageSource = "dni.png" };
            Button chet_btn = new Button { Text = "Четверг", BackgroundColor = Color.SkyBlue, ImageSource = "dni.png" };
            Button pyat_btn = new Button { Text = "Пятница", BackgroundColor = Color.SkyBlue, ImageSource = "dni.png" };
            Button subb_btn = new Button { Text = "Суббота", BackgroundColor = Color.SkyBlue, ImageSource = "dni.png" };
            Button vos_btn = new Button { Text = "Воскресенье", BackgroundColor = Color.SkyBlue, ImageSource = "dni.png" };
            pon_btn.Clicked += new EventHandler(Buttons_Clicked);
            vtor_btn.Clicked += new EventHandler(Buttons_Clicked);
            sred_btn.Clicked += new EventHandler(Buttons_Clicked);
            chet_btn.Clicked += new EventHandler(Buttons_Clicked);
            pyat_btn.Clicked += new EventHandler(Buttons_Clicked);
            subb_btn.Clicked += new EventHandler(Buttons_Clicked);
            vos_btn.Clicked += new EventHandler(Buttons_Clicked);
            st.Children.Add(pon_btn);
            st.Children.Add(vtor_btn);
            st.Children.Add(sred_btn);
            st.Children.Add(chet_btn);
            st.Children.Add(pyat_btn);
            st.Children.Add(subb_btn);
            st.Children.Add(vos_btn);

            Content = st;
        }
        private async void Buttons_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Понедельник":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new ponedelnik());//открываем страницу
                    break;
                case "Вторник":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new vtornik());//открываем страницу
                    break;
                case "Среда":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new sreda());//открываем страницу
                    break;
                case "Четверг":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new chetverg());//открываем страницу
                    break; 
                case "Пятница":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new pyatnica());//открываем страницу
                    break;
                case "Суббота":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new subbota());//открываем страницу
                    break;
                case "Воскресенье":
                    await Navigation.PopAsync();//закрываем страницу
                    await Navigation.PushAsync(new voskresenie());//открываем страницу
                    break;
            }
        }
    }
}
