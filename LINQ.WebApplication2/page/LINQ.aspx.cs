using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LINQ.WebApplication2.page
{
    public partial class LINQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var allKeys = new string[] { "AA", "BB", "CC", "p_AA", "p_BB", "p_AA" };
            var pKeys = allKeys.Where(k => k.StartsWith("p_"));
            var @params = pKeys
                .Distinct()
                .Select(k => new KeyValuePair<string, string>(k.Substring(2), k));
            var param = @params.LastOrDefault();

        }
    }
}