namespace CoffeeShopPOS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lstOrderItems = new System.Windows.Forms.ListBox();
            this.btnCalculateTotal = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(800, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(179, 26);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Coffee Shop POS";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.Controls.Add(this.btnPrintReceipt);
            this.panelSideMenu.Controls.Add(this.btnCalculateTotal);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 50);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 400);
            this.panelSideMenu.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.lstOrderItems);
            this.panelMain.Controls.Add(this.btnAddItem);
            this.panelMain.Controls.Add(this.txtItemPrice);
            this.panelMain.Controls.Add(this.txtItemName);
            this.panelMain.Controls.Add(this.lblTotal);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 50);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 400);
            this.panelMain.TabIndex = 2;
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(16, 16);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(100, 20);
            this.txtItemName.TabIndex = 0;
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.Location = new System.Drawing.Point(122, 16);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(100, 20);
            this.txtItemPrice.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(228, 14);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lstOrderItems
            // 
            this.lstOrderItems.FormattingEnabled = true;
            this.lstOrderItems.Location = new System.Drawing.Point(16, 42);
            this.lstOrderItems.Name = "lstOrderItems";
            this.lstOrderItems.Size = new System.Drawing.Size(206, 147);
            this.lstOrderItems.TabIndex = 3;
            // 
            // btnCalculateTotal
            // 
            this.btnCalculateTotal.Location = new System.Drawing.Point(12, 16);
            this.btnCalculateTotal.Name = "btnCalculateTotal";
            this.btnCalculateTotal.Size = new System.Drawing.Size(175, 23);
            this.btnCalculateTotal.TabIndex = 4;
            this.btnCalculateTotal.Text = "Calculate Total";
            this.btnCalculateTotal.UseVisualStyleBackColor = true;
            this.btnCalculateTotal.Click += new System.EventHandler(this.btnCalculateTotal_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(228, 42);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(12, 45);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(175, 23);
            this.btnPrintReceipt.TabIndex = 6;
            this.btnPrintReceipt.Text = "Print Receipt";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSideMenu);
            this.Controls.Add(this.panelHeader);
            this.Name = "Form1";
            this.Text = "Coffee Shop POS";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtItemPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.ListBox lstOrderItems;
        private System.Windows.Forms.Button btnCalculateTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lblHeader;
    }
}