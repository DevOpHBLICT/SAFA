using System;
using System.Collections.Generic;


using System.Text;
using Xamarin.Forms;
namespace SAFA


{



    public class info_2 : ContentPage
    {
      

        void BackButtonClicked(object sender, EventArgs e)
        {
            Xamarin.Forms.Device.BeginInvokeOnMainThread(() => Navigation.PopAsync());
        }

        public info_2(String info)
        {
            BackgroundColor = Color.White;

              Title = "More Information";
       
            // Label title = null;
            Button home = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "home", TextColor = Color.Black };
            home.IsVisible = false;
            if (Device.OS == TargetPlatform.Windows)
            {
                Button back = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Image = "back" };
                Button next = new Button { FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)), IsVisible = true, Text = "next", TextColor = Color.Black };
                back.Image = (FileImageSource)ImageSource.FromFile("back.png");
                back.HorizontalOptions = LayoutOptions.End;
                back.VerticalOptions = LayoutOptions.End;
                back.BackgroundColor = Color.Transparent;

                back.Clicked += BackButtonClicked;
                home.IsVisible = true;
                BackgroundColor = Color.White;
                NavigationPage.SetHasNavigationBar(this, false);
                //   this.TranslationY = -40;
            }

            Label LItalic = new Label
            {
                //    HorizontalTextAlignment = TextAlignment.Center,

            };

            var fs = new FormattedString();

            fs.Spans.Add(new Span { ForegroundColor = Color.Black, FontSize = 14, FontAttributes = FontAttributes.Italic, Text = "'The requirement for continuous / complete supervision and control cannot and should not be interpreted as requiring 24 hour monitoring and/or that the person is to be physically accompanied over a continuous 24 hour period. In other words, if the individual is subject to such monitoring or such degree of accompaniment, then the necessary degree of continuity or completeness will be satisfied. But it is capable of being satisfied even if the supervision and control is 'lighter touch'" });

         
            var browser = new BaseUrlWebView(); // temporarily use this so we can custom-render in iOS 
            var htmlSource = new HtmlWebViewSource();



            var header_string = @"<html>
 <head>
 <meta name='viewport' content='width = device-width, initial-scale = 0.25, maximum-scale = 3.0 user-scalable = 1'>

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
b,h2,h3{
color:#923b3d !important;
}
pre{overflow:auto; max-width:100%}
h2{
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





<textblock>
{
                padding: 5px; 5px; 5px; 5px;
            }
# id
            {
                color:#923b3d !important;
}
            b{
                color:#923b3d !important;
}
            pre{ overflow: auto; max - width:100 %}
body
{
margin:15px;
}
</style>
<meta name = 'viewport' content = 'width =device -width, initial-scale = 1.0, maximum-scale = 1.0' >
</head>
    <body>";

            if (info == "Categories of Abuse")
            {

            }


                if ((info == "HSAB SAFA Prompts") || (string.IsNullOrEmpty(info)))
            {
                htmlSource.Html = header_string + "<textblock><b id='bb'>Additional Information</b>  <p>        Copyright <b id='bb'>HSAB and HBL ICT Services</b>. The following staff developed this app:<center> <br/><br/>Tracy Cooper <br/> Jane Newcombe <br/> Neil Wallace <br/> Michael Lamb <br/> Caroline Raut <br/><br/><p> </center> The responsible officers for this app are: <p> <b id='bb'>Caroline.Aitken@hertfordshire.gov.uk</b> or<b id='bb'> Loraine.Waterworth@hertfordshire.gov.uk</b></textblock></body></html>";
              }

            if (info == "Domestic")
            {
                htmlSource.Html = header_string + @" <body>

<p> In 2013, the Home Office made changes to the definition of <b id = 'bb'> Domestic Abuse </b> to include:

<br/>· <b id = 'bb'> Incidents </b> of controlling, coercive or threatening behaviour, violence or abuse by someone who is or has been an intimate partner or family member(regardless of gender or sexuality)
          <br/>· Domestic abuse also includes honour based violence, Female Genital Mutilation and forced marriage.
<br/>· Local Domestic abuse resources and helplines: < b id = 'bb' > www.HertsSunflower.org </b>
   


   <p> Tel: <b id = 'bb'> 08 088 088 088 </b> or offer to refer to Independent Domestic Violence Advisor.";

};
            if ((info == "Financial"))
            {
                htmlSource.Html = header_string + @" <body>
<h3 id='bb'> Financial Abuse </h3>
<p>Potential indicators of <b id='bb'>Financial Abuse</b> include:
<br/>· Change in living conditions
<br/>· Lack of heating, clothing or food
<br/>· Inability to pay bills/unexplained shortage of money
<br/>· Unexplained  withdrawals from an account
<br/>· Unexplained loss/misplacement of financial documents
<br/>· The recent addition of authorised signers on a client or donor’s signature card
<br/>· Sudden or unexplained changes in a will or other financial documents

";
            };

                if ((info == "Sexual")||(info == "Modern Slavery"))
            {
                htmlSource.Html = header_string + @" <body>
<b id='bb'> Sexual Abuse and Modern Slavery </b>
            <p><b id = 'bb'> Sexual exploitation </b> could be considered under Sexual abuse or Modern Slavery.";
};


            if (info == "Domestic")
            {
                htmlSource.Html = header_string + @" <body>
<b id='bb'> Domestic Abuse </b>
<p> In 2013, the Home Office made changes to the definition of <b id = 'bb'> Domestic Abuse </b> to include:

<br/>· <b id = 'bb' > Incidents </b> of controlling, coercive or threatening behaviour, violence or abuse by someone who is or has been an intimate partner or family member(regardless of gender or sexuality)
          <br/>· Domestic abuse also includes honour based violence, Female Genital Mutilation and forced marriage.
<br/>· Local Domestic abuse resources and helplines: <b id = 'bb' > www.HertsSunflower.org </b>
   


   <p> Tel: <b id = 'bb' > 08 088 088 088 </b> or offer to refer to Independent Domestic Violence Advisor.";

            };





            if (info == "Categories of Abuse")
            {
                htmlSource.Html =header_string +  @" <body>
<h3><b id='bb'> Categories of Abuse </b></h3>

<p>Incidents of abuse may be one-off or multiple, and affect one person or more. Professionals and others should look beyond single incidents or individuals to identify patterns of harm. Repeated instances of poor care may be an indication of more serious problems e.g. organisational abuse. It is therefore important to share this information appropriately. 

<p>In 2013, the Home Office made changes to the definition of <b id='bb'>Domestic Abuse</b> to include:

<br/>· <b id='bb'>Incidents</b> of controlling, coercive or threatening behaviour, violence or abuse by someone who is or has been an intimate partner or family member (regardless of gender or sexuality) 
<br/>· Domestic abuse also includes honour based violence, Female Genital Mutilation and forced marriage.
<br/>· Local Domestic abuse resources and helplines: <b id='bb'> www.HertsSunflower.org  </b> 


<p>Tel: <b id='bb'>08 088 088 088</b> or offer to refer to Independent Domestic Violence Advisor.
<p><b id='bb'>Sexual exploitation</b> could be considered under Sexual abuse or Modern Slavery.
<p>Potential indicators of <b id='bb'>Financial Abuse</b> include:
<br/>· Change in living conditions
<br/>· Lack of heating, clothing or food
<br/>· Inability to pay bills/unexplained shortage of money
<br/>· Unexplained  withdrawals from an account
<br/>· Unexplained loss/misplacement of financial documents
<br/>· The recent addition of authorised signers on a client or donor’s signature card
<br/>· Sudden or unexplained changes in a will or other financial documents
</body>
</html>         ";
}

            if (info == "Definition of an Adult at Risk")
            {
                htmlSource.Html = header_string + @"<p><h2 id='bb'>Definition of an Adult at Risk</p></h2>
<b id='bb'>The Care Act (2014)</b>
<p>Implemented in April 2015 and the biggest change to social care policy in the last 30 years. Safeguarding duties apply to an adult who:
<br/><p>• Has needs for care and support (whether or not the local authority is meeting any of those needs).
<br/><p>• Is experiencing, or at risk of, abuse or neglect; <b id='bb'>and</b>
<br/><p>• As a result of the those care and support needs is unable to protect themselves from the risk of, or the experience of abuse or neglect.

<p> ‘The local authority must make (or cause to be made) whatever enquiries it thinks necessary to enable it to decide whether any action should be taken in the adult’s case (whether under this Part or otherwise) and, if so, what and by whom.’ (Care Act 2014: Section 42)

<p>Six key principles underpin all adult safeguarding work:

<br/><p><b id ='bb'>Empowerment:</b> People being supported and encouraged to make their own decisions and give informed consent.

<br/><p><b id='bb'>Prevention:</b> It is better to take action before harm occurs.

<br><p><b id='bb'>Proportionality:</b> The least intrusive response appropriate to the risk presented.

<br><p><b id='bb'>Protection:</b> Support and representation for those in greatest need.

<br><p><b id='bb'>Partnership:</b> Local solutions through services working with their communities. Communities have a part to play in preventing, detecting and reporting neglect and abuse.

<br><p><b id='bb'>Accountability:</b> Accountability and transparency in delivering safeguarding.

<p>If a Safeguarding enquiry is not pursued by the relevant agency, there may be an individual case review for the person to reassess the care package and support, to ensure it is appropriate and meeting the individual’s needs.
<p><b id='bb'>Hertfordshire Safeguarding Adults Board(HSAB)</b>
<p>Under the Care Act 2014 there is a legal obligation to have a local Safeguarding Adults Board. This is a multi-agency partnership where all agencies in Hertfordshire with a responsibility to safeguard adults at risk meet to coordinate activity and promote wellbeing.
<p>The <b id='bb'>HSAB</b> are central to the development interagency policies, scrutinise safeguarding work of the individual agencies and challenge current practices.
<p>The <b id='bb'>HSAB</b> can also commission Safeguarding Adult Reviews (SARs) which look in detail into cases where there has been a death or serious harm to an adult at risk and scrutinise how individual agencies dealt with the risks and concerns. From this the HSAB can make recommendations to change in practice and procedures in the organisations involved.
</textblock>
</body>
</html>"; }
            
if (info == "Recognising Abuse")
                {
                    htmlSource.Html = header_string + @"<p><h2 id='bb'>Recognizing Abuse</p></h2>

<p><b id='bb'>Anyone</b> can witness or become aware of information suggesting that abuse and neglect is occurring. The adult may say or do things that hint that all is not well. Regardless of how the safeguarding concern is identified, everyone should understand what to do and where to go locally to get help and advice.
<p><b id='bb'>Professionals</b> should:
<p>·Know about the different types of abuse and neglect and their signs.
<p>·Support the adult to keep safe.
<p>·Knowing who to tell about suspected abuse or neglect.
<p>·Support adults to think and weigh up the risks and benefits of different options when exercising choice and control.";

}
                if (info == "Reporting a concern")
                {
                    htmlSource.Html = header_string + @" <p><h2 id='bb'>Reporting a concern</p></h2>


               <p> 1.<b id='bb'> Is there an immediate risk?</b> Consider if the Police need to be called or the person removed to a place of safety. Do you need to inform your line manager?

<p>2.<b id='bb'> Call</b> the relevant agency and follow up with a concern form.

<p>3.<b id='bb'> Discuss</b> concern with person. Record their wishes on the concern form but you have a duty to report even if they say <b id='bb'>NO</b>.

<p>4.<b id='bb'>  Describe</b> the circumstances of the suspected or actual abuse and what actions you have taken to try to protect the person. 

<p>5.<b id='bb'> Discuss</b> with the Safeguarding lead for your organisation or line manager if you are in any doubt.

<p>6.<b id='bb'> Email</b> or fax the concern form to the relevant agency.";
                }


                if (info == "Personal Safeguarding")
                {
                    htmlSource.Html = header_string + @" <p><h3 id='bb'>Making Safeguarding Personal</p></h3>


<b id='bb'>‘Making Safeguarding Personal’</b> Informs the safeguarding enquiries. The person should be involved at every stage of the process, be given all relevant information and have the opportunity to attend meetings. This includes the initial discussion about reporting the concern and what they wish to happen.  Even if they do not wish a concern to be raised it is important to explain that there is Duty of Care to pass on the concern but that their wishes are recorded.

<p><b id='bb'> 6 principles </b></p>
<b id='bb'>“I”</b> statements which are linked to the 6 Principles are:
<p><b id='bb'>I</b> am asked what I want as the outcomes from the safeguarding process and these directly inform what happens.

<p><b id='bb'>I</b> receive clear and simple information about what abuse is, how to recognise the signs and what I can do to seek help.

<p><b id='bb'>I</b> am sure that the professionals will work in my interest, as I see them and they will only get involved as much as needed.

<p><b id='bb'>I</b> get help and support to report abuse and neglect. I get help so that I am able to take part in the safeguarding process to the extent to which I want.

<p><b id='bb'>I</b> know that staff treat any personal and sensitive information in confidence, only sharing what is helpful and necessary. I am confident that professionals will work together and with me to get the best result for me.

<p><b id='bb'>I</b> understand the role of everyone involved in my life and so do they.

<p><b id='bb'>References:</b>
 
<p><b id='bb'>The Care Act 2014</b>

</html";
                }

            
            if (info == "What is Safeguarding?")
            {
                htmlSource.Html = header_string + @"<p><h2 id='bb'>What is Safeguarding?</p></h2><b id='bb'>Incidents of abuse</b> may be one-off or multiple, and affect one person or more. Professionals and others should look beyond single incidents or individuals to identify patterns of harm. Repeated instances of poor care may be an indication of more serious problems e.g. organisational abuse. It is therefore important to share this information appropriately.
               <p>In 2013, the Home Office made changes to the definition of Domestic Abuse to include:
               <br/> · Incidents of controlling, coercive or threatening behaviour, violence or abuse by someone who is or has been an intimate partner or family member (regardless of gender or sexuality) 
                <br/>· Domestic abuse also includes honour based violence, Female Genital Mutilation and forced marriage.
               <br/> · Local Domestic abuse resources and helplines: www.HertsSunflower.org
               <br/>Tel:<b id='bb'> 08 088 088 088</b> or offer to refer to Independent Domestic Violence Advisor.
                <p><b id='bb'>Sexual exploitation</b> could be considered under Sexual abuse or Modern Slavery.
                <p>Potential indicators of <b id='bb'>Financial Abuse</b> include:
                <br/>· Change in living conditions
                <br/>· Lack of heating, clothing or food
                <br/>· Inability to pay bills/unexplained shortage of money
                <br/>· Unexplained withdrawals form an account
                <br/>· Unexplained loss/misplacement of financial documents
                <br/>· The recent addition of authorised signers on a client or donor’s signature card
                <br/>· Sudden or unexplained changes in a will or other financial documents";



            }
            
              

            


            htmlSource.BaseUrl = DependencyService.Get<IBaseUrl>().Get();
            browser.Source = htmlSource;



            Content = browser;



        }



    }
}





