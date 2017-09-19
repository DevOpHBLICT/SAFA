using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

using Xamarin.Forms;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace SAFA
{
    public class App : Application
    {
        public static string data;
        public static string version_no;
        public static string current_version;
        public static int loaded;
        public static int Network_Connection;
        public static List<Pages> pages = new List<Pages>();
        public static String app_title { get; set; }
       
        public static NavigationPage NavPage { get; set; }
        public NavigationPage nav;
        public void Home_Clicked(object sender, EventArgs args)
        {
            if ((Device.OS == TargetPlatform.WinPhone) || (Device.OS == TargetPlatform.Windows))
            {

                var page = nav.Navigation.NavigationStack.First();

                while (page.Navigation.NavigationStack.Count > 1)
                {
                    page.Navigation.PopAsync();
                }
            }
            else
            { nav.PopToRootAsync(); }


            // Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PopToRootAsync());
        }

        public void Back_Clicked(object sender, EventArgs args)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PopAsync());
        }

        public void Info_Clicked(object sender, EventArgs args)
        {
            if (string.IsNullOrEmpty(App.app_title))
            {

                var tg = new info_2("");
                Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PushAsync(tg));

               
            }
            else
            {
                var tg = new info_2(App.app_title);
                Xamarin.Forms.Device.BeginInvokeOnMainThread(() => nav.PushAsync(tg));

         

            }
        }

    


    public App()
        {
            nav = new NavigationPage(new Contents());
            nav.BarTextColor = Color.White;
            nav.BackgroundColor = Color.White;
            nav.BarBackgroundColor = Color.FromHex("923b3d");




            ToolbarItem tbbSync = new ToolbarItem() { Icon = "home.png" };
            tbbSync.Text = "Home";
            tbbSync.Clicked += Home_Clicked;
            tbbSync.Order = Device.OnPlatform(ToolbarItemOrder.Primary, ToolbarItemOrder.Primary, ToolbarItemOrder.Primary);
            nav.ToolbarItems.Add(tbbSync);

        
            ToolbarItem tbbSettings2 = new ToolbarItem() { Icon = "info2.png" };
            tbbSettings2.Text = "Info";
            tbbSettings2.Clicked += Info_Clicked;
            tbbSettings2.Order = Device.OnPlatform(ToolbarItemOrder.Primary, ToolbarItemOrder.Primary, ToolbarItemOrder.Primary);
            nav.ToolbarItems.Add(tbbSettings2);




            MainPage = nav;

        }

     


       



        public static ListView p;

     
        protected override void OnStart()
        {
        //    CheckCurrentVersion();

        //    CheckVersion();


        //    if (Convert.ToInt32(version_no) > Convert.ToInt32(current_version))
        //    {
        //        GetOnlineData();
        //    }

               
        //    SaveOnlineData();

           
            var st = "\t\u2022 This app has been developed by the Hertfordshire Safeguarding Adults Board (HSAB) ";
            st = st + "It is to be used for guidance and information only\r\n";
            st = st + "\t\u2022 Click on each button and information section to see more guidance\r\n ";
    
            var answer =  App.Current.MainPage.DisplayAlert("Disclaimer", st, "I agree");
         
            
            // Handle when your app starts
        }




        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }
    }
}