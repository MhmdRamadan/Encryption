using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encryption
{
    public partial class Monoalphabetic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string Encrypt(string plainText, string key)
        {
            char[] chars = new char[plainText.Length+1];
           
            for (int i = 0; i < plainText.Length; i++)
            {
               
                    int j = plainText[i] % 97;

                    chars[i] = key[j];
                
            }

            return new string(chars);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = TextBox1.Text;
            string k = TextBox2.Text;
            string result = Encrypt(s,k);
            Response.Write("<script>alert('The Encrypted string equals : " + result + "')</script>");
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}