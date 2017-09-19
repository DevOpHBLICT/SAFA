
using System;
using System.Collections.Generic;


using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Recognising_Abuse2 : ContentPage
    {
       

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            App.app_title = "Reporting a concern";
            var tg = new d("17", "Reporting a concern", "#bfbfbf");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }


        public void refresh()
        {
            //         listView.ItemsSource = _database.GetContents();
        }




        
        public class GetFrontPage2
        {
            public String Image { get; set; }

            public string Name { get; set; }
            public GetFrontPage2(string name, string image)
            {
                Name = name;
                Image = image;


            }

        }



        public Recognising_Abuse2()
        {

        
            App.app_title = "Recognising Abuse";
            Title = "Recognising Abuse";
            BackgroundColor = Color.White;

          
            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.White;
                  
            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)), Text = "Suspected", IsVisible = true, Image = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White };
            yes.Clicked += OnyesButtonClicked;

            yes.HeightRequest = 50;

            

            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
            browser.HeightRequest = 600;
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;




            htmlSource.Html = @"<html> 
 <head> 
<style>

#id
{
color:#923b3d !important;
}
b{
color:#923b3d !important;
}

html, body { height: 80%; padding: 0; margin: 0; }
*{
color:#878787;
}
body
{
margin:20px;
}
}
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body>

<h3><b id ='bb'>Personal Hygiene</b></h3>They may not take as much care as normal with their appearance, such as not bathing, shaving or washing their hair.
<h3><b id='bb'>Behaviour</b></h3>They may become  withdrawn, depressed or tearful. They may also be angry or aggressive for little reason.
<h3><b id='bb'>Injuries</b></h3> They may have unexplained or frequent injuries.
<h3><b id='bb'>Lifestyle</b></h3> They may stop going out, not  have any money to buy food or access leisure services, not want to be left alone with certain people or lose their appetite.
  </body>
</html>";




         




            Content = new StackLayout {
               Children = { browser,yes }
            };






       
        }
    }
}