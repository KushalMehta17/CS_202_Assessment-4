namespace Task1

{
    public partial class Form1 : Form
    {
        public event EventHandler<OrderEventArgs> OrderCreated;
        public event EventHandler OrderRejected;
        public event EventHandler<OrderEventArgs> OrderConfirmed;
        public event EventHandler<ShipEventArgs> OrderShipped;
        private bool orderWasConfirmed = false; // track if the order was confirmed


        public Form1()
        {
            InitializeComponent();

            OrderCreated += ValidateOrder;
            OrderCreated += DisplayOrderInfo;

            OrderRejected += ShowRejection;
            OrderConfirmed += ShowConfirmation;
            OrderShipped += ShowDispatch;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            cmbProduct.SelectedIndex = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            var product = cmbProduct.SelectedItem?.ToString() ?? string.Empty;
            var args = new OrderEventArgs(txtCustomer.Text.Trim(), product, (int)numQty.Value);
            OrderCreated?.Invoke(this, args);
        }
        private void ValidateOrder(object sender, OrderEventArgs e)
        {
            if (e.Quantity <= 0 || string.IsNullOrWhiteSpace(e.Product))
            {
                lblStatus.Text = "Invalid Quantity or Product";
                OrderRejected?.Invoke(this, EventArgs.Empty);
                return;
            }

            lblStatus.Text = "Validated";
            OrderConfirmed?.Invoke(this, e);
        }

        private void DisplayOrderInfo(object sender, OrderEventArgs e)
        {
            MessageBox.Show(
                $"Order Summary:\nCustomer: {e.Customer}\nProduct: {e.Product}\nQuantity: {e.Quantity}",
                "Order Info", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void ShowRejection(object sender, EventArgs e)
        {
            lblStatus.Text = "Order Invalid – Please retry";
        }

        private void ShowConfirmation(object sender, OrderEventArgs e)
        {
            lblStatus.Text = $"Order Processed Successfully for {e.Customer}";
            orderWasConfirmed = true; // mark that we can ship now
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ShowDispatch(object sender, ShipEventArgs e)
        {
            lblStatus.Text = $"Product dispatched: {e.Product}";
        }

        private void NotifyCourier(object sender, ShipEventArgs e)
        {
            if (e.Express)
                MessageBox.Show("Express delivery initiated!", "Courier Notification",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnShipOrder_Click(object sender, EventArgs e)
        {
            if (!orderWasConfirmed)
            {
                MessageBox.Show("Order must be confirmed before shipping.", "Cannot Ship",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // dynamic subscription management
            if (chkExpress.Checked)
                OrderShipped += NotifyCourier; // add courier notifier
            else
                OrderShipped -= NotifyCourier; // ensure it's removed

            var product = cmbProduct.SelectedItem?.ToString() ?? string.Empty;
            var args = new ShipEventArgs(product, chkExpress.Checked);
            OrderShipped?.Invoke(this, args);
        }
    }
}

