using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int swellYes = 0,swellNo=0,skinYes=0,skinNo=0,bPainYes=0,bPainNo=0,rNYes=0,rNNo=0,sNYes=0,sNNo=0211,resYes=0,resNo=0;
    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\\Users\\Dell\\Downloads\\SYMPTOMS.mdf;Integrated Security=True;Connect Timeout=30");
    SqlDataReader rd = null;
    protected void Page_Load(object sender, EventArgs e)
    {
        conn.Open();
       
            SqlCommand cmd = new SqlCommand("Select * from dbo.Table");
            rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd[1].Equals("Yes")) swellYes++;
                else swellNo++;
                if (rd[2].Equals("Yes")) skinYes++;
                else skinNo++;
                if (rd[3].Equals("Yes")) bPainYes++;
                else bPainNo++;
                if (rd[3].Equals("Yes")) rNYes++;
                else rNNo++;
                if (rd[4].Equals("Yes")) sNYes++;
                else sNNo++;
                if (rd[5].Equals("Yes")) resYes++;
                else resNo++;
            }
            String Attribute1 = rd[1].ToString();
            String Attribute2 = rd[2].ToString();
            String Attribute3 = rd[3].ToString();
            String Attribute4 = rd[4].ToString();
            String Result = rd[5].ToString();
            if(rd[1].ToString()=="Yes"&&rd[1].ToString()=="Yes"&&rd[2].ToString()=="Yes"&&rd[3].ToString()=="Yes"&&rd[4].ToString()=="Yes")
            Console.WriteLine("You Might Have Breast Cancer");
            if (rd != null) rd.Close();
            if (conn != null) conn.Close();
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
        
    }
}