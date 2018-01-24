using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TietoTest
{
    public partial class EnergyTest : System.Web.UI.Page
    {

        public void GetElectric()
        {
            string name;
            int price;

            switch (DropDownList1.SelectedItem.Value)
            {
                case "Flat":
                    name = "Small Energy";
                    lbl2.Text = name;                
                    price = 300;
                    lblPrice1.Text = price.ToString();            
                    break;
                case "House":
                    name = "Medium Energy";
                    lbl2.Text = name;
                    price = 600;
                    lblPrice1.Text = price.ToString();
                    break;
                case "Other":
                    name = "Unlimited Energy";
                    lbl2.Text = name;
                    price = 1200;
                    lblPrice1.Text = price.ToString();
                    break;
            }

            switch (DropDownList2.SelectedItem.Value)
            {
                case "Flat":
                    name = "Small Energy";          
                    Label1.Text = name;
                    price = 300;                  
                    Label2.Text = price.ToString();
                    break;
                case "House":
                    name = "Medium Energy";                 
                    Label1.Text = name;
                    price = 600;                   
                    Label2.Text = price.ToString();
                    break;
                case "Other":
                    name = "Unlimited Energy";                  
                    Label1.Text = name;
                    price = 1200;                
                    Label2.Text = price.ToString();
                    break;
            }

        }

        public void GetHeat()
        {
            int price;
            string name;
            int temp1 = Convert.ToInt32(numberBox1.Text);
            int temp2 = Convert.ToInt32(numberBox2.Text);

            if(temp1<=15)
            {
                name = "Cold Like Ice";
                lblHeatTop.Text = name;
                price = 200;
                lblPriceTop.Text = price.ToString();
            }
            else if(15<temp1 && temp1<=30)
            {
                name = "Warming Up";
                lblHeatTop.Text = name;
                price = 500;
                lblPriceTop.Text = price.ToString();
            }
            else if(30<temp1)
            {
                name = "Hot Like Lava";
                lblHeatTop.Text = name;
                price = 900;
                lblPriceTop.Text = price.ToString();
            }


            if (temp2 <= 15)
            {
                name = "Cold Like Ice";
                lblHeatBottom.Text = name;
                price = 200;
                lblPriceBottom.Text = price.ToString();
            }
            else if (15 < temp2 && temp2 <= 30)
            {
                name = "Warming Up";
                lblHeatBottom.Text = name;
                price = 500;
                lblPriceBottom.Text = price.ToString();
            }
            else if (30 < temp2)
            {
                name = "Hot Like Lava";
                lblHeatBottom.Text = name;
                price = 900;
                lblPriceBottom.Text = price.ToString();
            }
        }

       protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] type = { "House", "Flat", "Other" };
                DropDownList1.DataSource = type;
                DropDownList1.DataBind();
                DropDownList2.DataSource = type;
                DropDownList2.DataBind();
            }

            GetElectric();
            GetHeat();
        }
         

    }
}