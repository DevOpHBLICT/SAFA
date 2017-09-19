
using System;
using System.Collections.Generic;



using System.Text;
using System.IO;
using Xamarin.Forms;
using System.Linq;

namespace SAFA
{




    public class definition : ContentPage
    {

         Button back;

        

        void OnyesButtonClicked(object sender, EventArgs e)
        {
          
            var tg = new What_Is_Safeguarding("What is Safeguarding?");
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PushAsync(tg));
        }



     
        void BackButtonClicked(object sender, EventArgs e)
        {
            back.IsEnabled = false;

            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }
        void HomeButtonClicked(object sender, EventArgs e)
        {

            var page = Navigation.NavigationStack.First();
            while (page.Navigation.NavigationStack.Count > 1)
            { page.Navigation.PopAsync(); }




        }




        public definition(string startpage, String Titles, String BGColor)
        {
            Title = "Definition";
            Label l = new Label { Text = "\r\n According to The Care Act (2014), an adult at risk is a person who:" };
             

               var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();

           


            htmlSource.Html = @"<html> 
 <head> 
<style>
*{
color:#878787;
}
.box {

  border: 2px solid #7d2732;
     border-radius: 5px;
margin-top:5px;
padding:5px;5px;5px;5px;
}

textblock
{
padding:5px;5px;5px;5px;
}
#id
{
color:#923b3d !important;
}
b{
color:#923b3d !important;
}
pre{overflow:auto; max-width:100%}
h2,h3{
color:#923b3d;
}
.down-arrow1 {
   margin-left:20%;
	width: 0; 
  height: 0; 
  border-left: 20px solid transparent;
  border-right: 20px solid transparent;
  
  border-top: 20px solid #923b3d;
}
.down-arrow2 {
   margin-left:50%;
	width: 0; 
  height: 0; 
  border-left: 20px solid transparent;
  border-right: 20px solid transparent;
  
  border-top: 20px solid #923b3d;
}
body
{
margin:10px;
}
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body> 
<p><h3 id='bb'>Definition of an adult at risk</h3>
<p>According to The Care Act (2014), an adult at risk is a person who:  
 
<p>Has care and support needs, whether or not the Local Authority e.g. Hertfordshire County Council (HCC) is meeting any of those needs <b>And</b>;

<p>Is experiencing, or at risk of, abuse or neglect; <b>And;</b>

<p>As a result of those care and support needs is unable to protect themselves from abuse or neglect or the risk of it. </div>



  </body>
</html>";


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }


            Button yes = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Xamarin.Forms.Label)), Text = "What is Safeguarding?", IsVisible = true, Image = "tick", BackgroundColor = Color.FromHex("#953735"), TextColor = Color.White };
            yes.Clicked += OnyesButtonClicked;
            yes.HeightRequest = 50;

            BackgroundColor = Color.White;

            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
                browser.Source = htmlSource;
            browser.HeightRequest = 500;


           
               Content = new StackLayout
            {
                Padding = 10,
                Children = { browser, yes }
            };

          
            }
        }
    }

