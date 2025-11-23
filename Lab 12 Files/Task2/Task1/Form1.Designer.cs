namespace Task1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtCustomer = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblStatus = new Label();
            cmbProduct = new ComboBox();
            numQty = new NumericUpDown();
            btnProcessOrder = new Button();
            chkExpress = new CheckBox();
            btnShipOrder = new Button();
            ((System.ComponentModel.ISupportInitialize)numQty).BeginInit();
            SuspendLayout();
            // 
            // txtCustomer
            // 
            txtCustomer.Location = new Point(223, 52);
            txtCustomer.Name = "txtCustomer";
            txtCustomer.Size = new Size(180, 31);
            txtCustomer.TabIndex = 0;
            txtCustomer.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 58);
            label1.Name = "label1";
            label1.Size = new Size(145, 25);
            label1.TabIndex = 1;
            label1.Text = "Customer Name:";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 108);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 2;
            label2.Text = "Product:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 167);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 3;
            label3.Text = "Quantity:";
            // 
            // lblStatus
            // 
            lblStatus.AccessibleRole = AccessibleRole.None;
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(63, 348);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(71, 25);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status:-";
            // 
            // cmbProduct
            // 
            cmbProduct.FormattingEnabled = true;
            cmbProduct.Items.AddRange(new object[] { "Laptop", "Mouse", "Keyboard" });
            cmbProduct.Location = new Point(221, 108);
            cmbProduct.Name = "cmbProduct";
            cmbProduct.Size = new Size(182, 33);
            cmbProduct.TabIndex = 5;
            cmbProduct.SelectedIndexChanged += cmbProduct_SelectedIndexChanged;
            // 
            // numQty
            // 
            numQty.Location = new Point(223, 167);
            numQty.Name = "numQty";
            numQty.Size = new Size(180, 31);
            numQty.TabIndex = 6;
            // 
            // btnProcessOrder
            // 
            btnProcessOrder.Location = new Point(63, 288);
            btnProcessOrder.Name = "btnProcessOrder";
            btnProcessOrder.Size = new Size(141, 34);
            btnProcessOrder.TabIndex = 7;
            btnProcessOrder.Text = "Process Order";
            btnProcessOrder.UseVisualStyleBackColor = true;
            btnProcessOrder.Click += btnProcessOrder_Click;
            // 
            // chkExpress
            // 
            chkExpress.AutoSize = true;
            chkExpress.Location = new Point(221, 234);
            chkExpress.Name = "chkExpress";
            chkExpress.Size = new Size(97, 29);
            chkExpress.TabIndex = 8;
            chkExpress.Text = "Express";
            chkExpress.UseVisualStyleBackColor = true;
            chkExpress.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnShipOrder
            // 
            btnShipOrder.Location = new Point(291, 288);
            btnShipOrder.Name = "btnShipOrder";
            btnShipOrder.Size = new Size(112, 34);
            btnShipOrder.TabIndex = 9;
            btnShipOrder.Text = "Ship Order";
            btnShipOrder.UseVisualStyleBackColor = true;
            btnShipOrder.Click += btnShipOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 483);
            Controls.Add(btnShipOrder);
            Controls.Add(chkExpress);
            Controls.Add(btnProcessOrder);
            Controls.Add(numQty);
            Controls.Add(cmbProduct);
            Controls.Add(lblStatus);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCustomer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += btnProcessOrder_Click;
            ((System.ComponentModel.ISupportInitialize)numQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblStatus;
        private ComboBox cmbProduct;
        private NumericUpDown numQty;
        private Button btnProcessOrder;
        private CheckBox chkExpress;
        private Button btnShipOrder;
    }
}
