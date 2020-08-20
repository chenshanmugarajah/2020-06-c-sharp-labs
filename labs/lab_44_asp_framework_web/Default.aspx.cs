using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_44_asp_framework_web
{
    public partial class _Default : Page
    {
        static int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            counter++;
            Label1.Text = "Hey - You clicked " + counter + " times";
        }
    }
}