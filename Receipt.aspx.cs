using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;


public partial class Receipt : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["Meal"] == null)
        {
            Response.Redirect("Default.aspx");
        }
        DisplayReceipt();
    }


    protected void DisplayReceipt()
    {
        StringBuilder sb = new StringBuilder();
        MealOrder meal = (MealOrder)Session["Meal"];
        //string size = meal.Size;
        //double cost = meal.sizeCost;
       // List<string> toppings = meal.Toppings;

        sb.Append("Pizza Size: <br/>"+meal.Size+" @"+meal.GetSizeCost().ToString("C2")+"<br/>");

        if (meal.Toppings.Count > 0)
        {
            sb.Append("<br/>Toppings:<br/>");
        }
        
        foreach (string topping in meal.Toppings)
        {
            sb.Append(topping+" @"+meal.toppingCost.ToString("C2")+"<br/>");
        }
        sb.Append("<br/><br/>Tax:<br/>"+meal.tax+"%<br/>Total:<br/>"+meal.CalculateTotal().ToString("C2"));
                
        Label1.Text = sb.ToString();
    }
}
