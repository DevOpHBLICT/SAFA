
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;

using Xamarin.Forms;

namespace SAFA
{






    public class Making_Safeguarding_Better : ContentPage
    {
     

        void OnyesButtonClicked(object sender, EventArgs e)
        {
            var tg = new Making_Safeguarding_Better();
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



        public Making_Safeguarding_Better()
        {
            
            App.app_title = "Personal Safeguarding";
            Title = "Personal Safeguarding";
            BackgroundColor = Color.White;

          
            //  BackgroundColor = Color.FromHex("#e6b9b8");


            if (Device.OS == TargetPlatform.Windows)
            {
                NavigationPage.SetHasNavigationBar(this, false);
            }

            BackgroundColor = Color.White;

            
            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();
          
            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            htmlSource.Html = @"<html> 
 <head> 
<style>
html, body {
    margin: 5;
    padding: 10px
}

body, p, h1 {
    font-family: 'Roboto';
}

h3 {
    color: #953735;
}
#triangle-right {
    width: 0;
    height: 0;
    border-top: 8px solid transparent;
    border-left: 13px solid #953735;
    border-bottom: 8px solid transparent;
}
</style> 
</head> 
 <body> 
<h3 style='color:#953735'>Making Safeguarding Personal </h3>
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td> Is a shift in culture and professional practice. </td></tr> 
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td>It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.  </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div><td><td>It is about empowering the adult at risk to ensure that their wishes/ desired outcomes are considered as part of the safeguarding process. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div><td><td>It is about seeing people as experts in their own lives and working alongside them. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td>The alerter must note the person's wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.  </td></tr></table>

 </ body> 
 </html>";






            htmlSource.Html = @"<html> 
 <head> 
<style>
#triangle-right {
    width: 0;
    height: 0;
    border-top: 8px solid transparent;
    border-left: 13px solid #953735;
    border-bottom: 8px solid transparent;
}
#id
{
color:#923b3d !important;
}
b{
color:#923b3d !important;
}

html, body {  padding: 0; margin: 0; }
*{
color:#878787;
}
body
{
margin:10px;
}
}
</style>
<meta name='viewport' content='width =device -width, initial-scale = 1.0, maximum-scale = 1.0'>
                 </head> 
 <body>
<h3 style='color:#953735'>Making Safeguarding Personal </h3>
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td> Is a shift in culture and professional practice. </td></tr> 
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td>It is about having conversations with people about how we might respond in safeguarding situations to enhance involvement, choice and control as well as improving quality of life, wellbeing & safety.  </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div><td><td>It is about empowering the adult at risk to ensure that their wishes/ desired outcomes are considered as part of the safeguarding process. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px'> <div id='triangle-right'></div><td><td>It is about seeing people as experts in their own lives and working alongside them. </td></tr>
<table><tr><td style='vertical-align:top;margin-top:8px' > <div id='triangle-right'></div><td><td>The alerter must note the person's wishes but still has a duty to raise any safeguarding concerns that are disclosed, witnessed or suspected to the Local Authority.  </td></tr></table>


  </body>
</html>";










            browser.Source = htmlSource;



            Content =  browser  ;
            

        }
    }
}