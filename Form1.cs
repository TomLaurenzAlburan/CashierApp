namespace CashierApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            MenuStrip menuStrip = new MenuStrip();
            ToolStripMenuItem fileToolStripMenuItem = new ToolStripMenuItem("File");
            ToolStripMenuItem logoutToolStripMenuItem = new ToolStripMenuItem("Logout");
            ToolStripMenuItem exitToolStripMenuItem = new ToolStripMenuItem("Exit");

            fileToolStripMenuItem.DropDownItems.Add(logoutToolStripMenuItem);
            fileToolStripMenuItem.DropDownItems.Add(exitToolStripMenuItem);
            menuStrip.Items.Add(fileToolStripMenuItem);

            this.Controls.Add(menuStrip);


            logoutToolStripMenuItem.Click += (sender, e) =>
            {
                this.Close();
                Form1 form = new Form1();
                form.Show();
            };


            exitToolStripMenuItem.Click += (sender, e) =>
            {
                Application.Exit();
            }
            ;
        }
        private void TextItemName_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextDiscount_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                string itemName = TextItemName.Text;
                double price = Convert.ToDouble(TextPrice.Text);
                int quantity = Convert.ToInt32(TextQuantity.Text);
                double discount = Convert.ToDouble(TextDiscount.Text);

                ItemNamespace.DiscountedItem item = new ItemNamespace.DiscountedItem(itemName, price, quantity, discount);

                double totalAmount = item.ComputeTotalAmount();
                lblTotalAmount.Text = "Total Amount: " + totalAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextAmountPaid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                double totalAmount = Convert.ToDouble(lblTotalAmount.Text.Replace("Total Amount: ", ""));
                double amountPaid = Convert.ToDouble(TextAmountPaid.Text);

                double change = amountPaid - totalAmount;
                lblChange.Text = "Change: " + change.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
        namespace ItemNamespace
    {

        public class Item
        {
            protected string itemName;
            protected double price;
            protected int quantity;

            public Item(string itemName, double price, int quantity)
            {
                this.itemName = itemName;
                this.price = price;
                this.quantity = quantity;
            }

            public virtual double ComputeTotalAmount()
            {
                return price * quantity;
            }
        }


        public class DiscountedItem : Item
        {
            private double discount;

            public DiscountedItem(string itemName, double price, int quantity, double discount)
                : base(itemName, price, quantity)
            {
                this.discount = discount;
            }

            public override double ComputeTotalAmount()
            {
                double discountedPrice = base.price - (base.price * (discount * 0.01));
                return discountedPrice * base.quantity;
            }
        }
    }
}

