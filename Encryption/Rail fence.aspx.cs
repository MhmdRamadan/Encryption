using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Encryption
{
    public partial class Rail_fence : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public  string Encrypt(string plaintext, string key)
        {
            string ciphertext = null;
            int j = 0, k = 0;
            char[] ptca = plaintext.ToCharArray();
            char[,] railarray = new char[2, 100];
            for (int i = 0; i < ptca.Length; ++i)
            {
                if (i % 2 == 0)
                {
                    railarray[0, j] = ptca[i];
                    ++j;
                }
                else
                {
                    railarray[1, k] = ptca[i];
                    ++k;
                }
            }
            railarray[0, j] = '\0';
            railarray[1, k] = '\0';
            for (int x = 0; x < 2; ++x)
            {
                for (int y = 0; railarray[x, y] != '\0'; ++y) ciphertext += railarray[x, y];
            }
            return ciphertext;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String st = TextBox1.Text;
            String num = TextBox2.Text;
          String result =  Encrypt(st, num);
            Response.Write("<script>alert('The Encrypted string equals : " + result + "')</script>");

        }
    }
  
    }
