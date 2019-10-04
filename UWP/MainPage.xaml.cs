using Notyes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Xml;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            splitView.IsPaneOpen = !splitView.IsPaneOpen;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Confirm_First_Step();
        }

        async void Confirm_First_Step()
        {
            ContentDialog deleteFileDialog = new ContentDialog()
            {
                Title = "Подтверждение действия",
                Content = "Вы действительно хотите Перейти на станицу 2?",
                PrimaryButtonText = "ОК",
                SecondaryButtonText = "Отмена",
                
            };

            ContentDialogResult result = await deleteFileDialog.ShowAsync();

            if (result == ContentDialogResult.Primary)
            {
                header.Text = "Переход осуществлен";
                Frame.Navigate(typeof(Page2), "Hello");
            }
            else if (result == ContentDialogResult.Secondary)
            {
                header.Text = "Отмена действия";
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) =>Notyficator.Notify("CPU", "Hello my user");
    }
}
