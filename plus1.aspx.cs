using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace design
{
    public partial class plus1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["x"]);
            int y = Convert.ToInt32(Request.QueryString["y"]);


            for (int i = 1; i <= x; i++)
                PlaceHolder1.Controls.Add(NewImage("images/apple.png"));

            for (int i = 1; i <= y; i++)
                PlaceHolder2.Controls.Add(NewImage("images/apple.png"));
        }

        public Image NewImage(string pathName)
        {

            Image img = new Image();
            img.ImageUrl = pathName;
            img.Width = 100;
            img.Height = 100;
            return img;
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["x"]);
            int y = Convert.ToInt32(Request.QueryString["y"]);
            for (int i = 1; i <= x + y; i++)
                PlaceHolder3.Controls.Add(NewImage("images/apple.png"));
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("plus.aspx");
        }
    }
}