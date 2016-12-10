using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           PopulateToppings();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        MealOrder meal = new MealOrder();
        string size = RBLSize.SelectedValue;
        meal.GetSize(size); 
        
        foreach (ListItem item in CBLToppings.Items)
        {
            if (item.Selected)
            {
                meal.AddTopping(item.Text);
            }
        }//end of foreach
        Session["meal"] = meal;
        Response.Redirect("Receipt.aspx");
    }//end of the button


    protected void PopulateToppings()
    {
        string[] toppings = { "Mushrooms", "Olives", "Green peppers", "Feta cheese", "Pineapple" };
        CBLToppings.DataSource = toppings;
        CBLToppings.DataBind();
    }




}
