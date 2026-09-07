namespace LunchOrder
{
    public partial class Form1 : Form
    {
        private double mainCourseCost = 6.95;
        private double addOnCost = 0.75;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ClearTotals()
        {
            txtSubtotal.Text = string.Empty;
            txtSalesTax.Text = string.Empty;
            txtOrderTotal.Text = string.Empty;
        }

        private void ClearAddOns()
        {
            addOnCheckBox1.Checked = false;
            addOnCheckBox2.Checked = false;
            addOnCheckBox3.Checked = false;
        }

        // Dylan Bausch
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            double subTotal = mainCourseCost;

            if (addOnCheckBox1.Checked)
            {
                subTotal += addOnCost;
            }
            if (addOnCheckBox2.Checked)
            {
                subTotal += addOnCost;
            }
            if (addOnCheckBox3.Checked)
            {
                subTotal += addOnCost;
            }

            double tax = subTotal * 0.0775;
            double total = subTotal + tax;

            txtSubtotal.Text = $"${subTotal:F2}";
            txtSalesTax.Text = $"${tax:F2}";
            txtOrderTotal.Text = $"${total:F2}";
        }

        // Dylan Bausch
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (mainCourseButton1.Checked)
            {
                gbxAddOns.Text = "Add-on items ($.75/each)";
                addOnCheckBox1.Text = "Lettuce, tomato and onions";
                addOnCheckBox2.Text = "Ketchup, mustard and mayo";
                addOnCheckBox3.Text = "French fries";
                mainCourseCost = 6.95;
                addOnCost = 0.75;
            }
            else if (mainCourseButton2.Checked)
            {
                gbxAddOns.Text = "Add-on items ($.50/each)";
                addOnCheckBox1.Text = "Pepperoni";
                addOnCheckBox2.Text = "Sausage";
                addOnCheckBox3.Text = "Olives";
                mainCourseCost = 5.95;
                addOnCost = 0.5;
            }
            else if (mainCourseButton3.Checked)
            {
                gbxAddOns.Text = "Add-on items ($.25/each)";
                addOnCheckBox1.Text = "Croutons";
                addOnCheckBox2.Text = "Bacon bits";
                addOnCheckBox3.Text = "Bread sticks";
                mainCourseCost = 4.95;
                addOnCost = 0.25;
            }

            ClearTotals();
            ClearAddOns();
        }

        // Dylan Bausch
        private void addOnCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ClearTotals();
        }
    }
}
