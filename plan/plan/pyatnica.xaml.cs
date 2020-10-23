using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace plan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pyatnica : ContentPage
    {
        public pyatnica()
            {
                string[] tasks = new string[] { "Встаю", "Кушаю", "Гуляю", "Иду на ужин", "Занимаюсь спортом", "Ложусь спать" };
                ListView list = new ListView();//список для отображения значений массива
                Button back = new Button { Text = "Назад", BackgroundColor = Color.SkyBlue };
                back.Clicked += Back_Clicked;
                list.ItemsSource = tasks;//данные из массива отображаем в списке
                list.ItemSelected += List_ItemSelected;//инициализируем функцию при клике на пункты списка
                Content = new StackLayout { Children = { list,back } };//отображаем список на страницу
            }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        string kell;
            private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
            {
                if (e.SelectedItem != null)
                {
                    string text = e.SelectedItem.ToString();
                    if (e.SelectedItemIndex == 0)//если выбран первый элемент списка
                    {
                        kell = "10:00";
                    }
                    else if (e.SelectedItemIndex == 1)//если выбран второй элемент списка
                    {
                        kell = "10:30";
                    }
                    else if (e.SelectedItemIndex == 2)//если выбран второй элемент списка
                    {
                        kell = "12:30";
                    }
                    else if (e.SelectedItemIndex == 3)//если выбран второй элемент списка
                    {
                        kell = "18:00";
                    }
                    else if (e.SelectedItemIndex == 4)//если выбран второй элемент списка
                    {
                        kell = "19:00";
                    }
                    else if (e.SelectedItemIndex == 5)//если выбран второй элемент списка
                    {
                        kell = "22:00";
                    }
                    await DisplayAlert(kell, text, "Да");
                }
            }
        }
    }