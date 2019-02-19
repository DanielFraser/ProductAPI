using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Summary description for Products
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Products : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public List<string> names(string prefix)
        {
            System.Diagnostics.Debug.WriteLine("a");
            List<string> temp;
            using (var context = new MyContext())
            {
                temp = context.Products.Select(a => a.name).Where(a => a.Contains(prefix)).ToList();
            }
            System.Diagnostics.Debug.WriteLine("b");
            return temp;
        }

        public void add()
        {

        }
    }
}
