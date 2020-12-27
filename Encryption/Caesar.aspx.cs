using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encryption
{
    public partial class Caesar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public class CaesarCipher
        {
           
            public static StringBuilder encrypt(String text, int s)
            {
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < text.Length; i++)
                {
                    //upper A starts with 65
                    //lower a starts with 97
                    if (char.IsUpper(text[i]))
                    {
                        char ch = (char)(((int)text[i] +s - 65) % 26 + 65);
                        result.Append(ch);
                    }
                    else
                    {
                        char ch = (char)(((int)text[i] +
                                        s - 97) % 26 + 97);
                        result.Append(ch);
                    }
                }
                return result;
            }

           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text.ToString();
            int num =Convert.ToInt32( TextBox2.Text);
            StringBuilder cipher = CaesarCipher.encrypt(s, num);
            Response.Write("<script>alert('The Encrypted string equals : "+cipher+"')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}