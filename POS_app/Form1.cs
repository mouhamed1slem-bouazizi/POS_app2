using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnToggleMenu = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelSeparator = new System.Windows.Forms.Panel(); // New separator panel
            this.panelHeader.SuspendLayout();
            this.panelSideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.btnToggleMenu);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0); // Adjusted to start after the side menu
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 50); // Adjusted width
            this.panelHeader.TabIndex = 0;
            this.panelHeader.BackColor = Color.LightGray; // Set background color
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.Location = new System.Drawing.Point(12, 12);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.Size = new Size(30, 30);
            this.btnToggleMenu.TabIndex = 1;
            this.btnToggleMenu.UseVisualStyleBackColor = true;
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // Set the image for the button
            string userHomePath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            string imagePath = Path.Combine(userHomePath, "source/repos/POS_app/menu_toggle.png");
            this.btnToggleMenu.Image = Image.FromFile(imagePath);
            this.btnToggleMenu.ImageAlign = ContentAlignment.MiddleCenter;
            this.btnToggleMenu.FlatStyle = FlatStyle.Flat;
            this.btnToggleMenu.FlatAppearance.BorderSize = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeader.Location = new System.Drawing.Point(100, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(244, 31);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Coffee Shop POS";
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = Color.LightGray; // Set background color
            this.panelSideMenu.Controls.Add(this.treeViewMenu);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(300, 450); // Full height of the form
            this.panelSideMenu.TabIndex = 1;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Name = "treeViewMenu";
            this.treeViewMenu.Size = new System.Drawing.Size(200, 450);
            this.treeViewMenu.TabIndex = 0;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = Color.LightGray; // Set background color
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 60); // Adjusted to start after the separator
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(600, 390); // Adjusted height
            this.panelMain.TabIndex = 2;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = Color.Black; // Set background color to black
            this.panelSeparator.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSeparator.Location = new System.Drawing.Point(200, 50); // Adjusted to start after the header
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(600, 2); // Set height for the separator
            this.panelSeparator.TabIndex = 3;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSeparator);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Coffee Shop POS";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelSideMenu.ResumeLayout(false);
            this.ResumeLayout(false);

            // Call InitializeTreeView to set up the tree view menu
            InitializeTreeView();
        }

        private void InitializeTreeView()
        {
            TreeNode adminNode = new TreeNode("Admin");
            adminNode.Nodes.Add("Dashboard");
            adminNode.Nodes.Add("POS");

            TreeNode servicesNode = new TreeNode("Services");
            servicesNode.Nodes.Add("Suppliers");
            servicesNode.Nodes.Add("Purchases").Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Purchases"),
                new TreeNode("Return")
            });
            servicesNode.Nodes.Add("Orders");
            servicesNode.Nodes.Add("Products").Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Categories"),
                new TreeNode("Units"),
                new TreeNode("Products"),
                new TreeNode("Barcode")
            });
            servicesNode.Nodes.Add("Stock");
            servicesNode.Nodes.Add("Services");
            servicesNode.Nodes.Add("Customers");
            servicesNode.Nodes.Add("Transactions");
            servicesNode.Nodes.Add("Delivery");
            servicesNode.Nodes.Add("Expenses").Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Expenses"),
                new TreeNode("Expenses Type")
            });
            servicesNode.Nodes.Add("Reports").Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("Sales Summary"),
                new TreeNode("Purchases Report"),
                new TreeNode("Stock Report"),
                new TreeNode("Expenses"),
                new TreeNode("Income"),
                new TreeNode("Profit"),
                new TreeNode("Loss"),
                new TreeNode("Users"),
                new TreeNode("Best Customers"),
                new TreeNode("Suppliers"),
                new TreeNode("Top Selling Products"),
                new TreeNode("Payment Report"),
            });
            TreeNode settingsNode = new TreeNode("Controls");
            settingsNode.Nodes.Add("Team members");
            settingsNode.Nodes.Add("Buisness");
            settingsNode.Nodes.Add("Settings").Nodes.AddRange(new TreeNode[]
            {
                new TreeNode("General"),
                new TreeNode("Email"),
                new TreeNode("Language"),
                new TreeNode("Backup"),
                new TreeNode("About Us"),
                new TreeNode("Privacy Policy"),
                new TreeNode("Terms & Conditions"),
                new TreeNode("Refund Policy"),
                new TreeNode("Tax"),
                new TreeNode("System Updater")
            });


            treeViewMenu.Nodes.AddRange(new TreeNode[]
            {
                adminNode,
                servicesNode,
                settingsNode
            });

            // Expand all nodes by default
            treeViewMenu.ExpandAll();
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            panelSideMenu.Visible = !panelSideMenu.Visible;
        }

        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Change the header and main panel content based on the selected node
            lblHeader.Text = $"Coffee Shop POS - {e.Node.Text}";
            panelMain.Controls.Clear();

            Label lblContent = new Label
            {
                Text = $"Content for {e.Node.Text}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Point)
            };

            panelMain.Controls.Add(lblContent);
        }

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnToggleMenu;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelSeparator; // New separator panel
    }
}