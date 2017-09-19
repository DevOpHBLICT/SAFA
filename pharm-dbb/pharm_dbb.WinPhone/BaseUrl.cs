using SAFA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

[assembly: Dependency(typeof(BaseUrl_Windows))]
namespace SAFA
{
    public class BaseUrl_Windows : IBaseUrl
    {
        
public string Get()
        {
            return "";
        }
    }
}
