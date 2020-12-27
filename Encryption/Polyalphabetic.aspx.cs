using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Encryption
{
    public partial class Polyalphabetic : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static Char encrypt(char text, int s)
        {
            StringBuilder result = new StringBuilder();


            //upper A starts with 65
            //lower a starts with 97
            char ch = ' ';
                if (char.IsUpper(text))
                {
                    ch = (char)(((int)text + s - 65) % 26 + 65);
                   
                }
                else
                {
                   ch = (char)(((int)text +
                                    s - 97) % 26 + 97);
                   
                }
            
            return ch;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = TextBox1.Text;
            char[] c = s.ToCharArray();

            int length = s.Length / 3;
            
            string[] sb = new string[1000];
            if (s.Length % 3 == 0)
            {
                for (int i = 0; i < s.Length; i = i + 3)
                {
                    c[i] = encrypt(c[i], Convert.ToInt32(TextBox2.Text));
                    c[i + 1] = encrypt(c[i], Convert.ToInt32(TextBox3.Text));
                    c[i + 2] = encrypt(c[i], Convert.ToInt32(TextBox4.Text));

                    sb[i] = sb[i] + c[i] + c[i + 1];
                    sb[i] = sb[i] + c[i + 2];
                }
            }else if (s.Length % 3 == 1)
            {
               
                for (int i = 0; i < s.Length; i = i + 3)
                {
                    c[i] = encrypt(c[i], Convert.ToInt32(TextBox2.Text));
                    c[i + 1] = encrypt(c[i], Convert.ToInt32(TextBox3.Text));
                    c[i + 2] = encrypt(c[i], Convert.ToInt32(TextBox4.Text));
                    if (i == s.Length - 1)
                    {
                        sb[i] = sb[i] + c[i];
                    }
                    else
                    {
                        sb[i] = sb[i] + c[i] + c[i + 1];
                        sb[i] = sb[i] + c[i + 2];
                    }
                }
            }
            else if (s.Length % 3 == 2)
            {

                for (int i = 0; i < s.Length; i = i + 3)
                {
                    c[i] = encrypt(c[i], Convert.ToInt32(TextBox2.Text));
                    c[i + 1] = encrypt(c[i], Convert.ToInt32(TextBox3.Text));
                    c[i + 2] = encrypt(c[i], Convert.ToInt32(TextBox4.Text));
                    if (i == s.Length - 2)
                    {
                        sb[i] = sb[i] + c[i]+c[i+1];
                    }
                    else
                    {
                        sb[i] = sb[i] + c[i] + c[i + 1];
                        sb[i] = sb[i] + c[i + 2];
                    }
                }
            }
            string ss1 = "";
            for (int i=0;i<sb.Length;i++)
            {
                if (sb[i] != null)
                    ss1 += sb[i];
              
            }
            Response.Write("<script>alert('The Encrypted string equals : " + ss1 + "')</script>");
        }
    }
}