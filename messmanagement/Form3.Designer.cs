namespace messmanagement
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tlpRoot = new System.Windows.Forms.TableLayoutPanel();
            this.tlpStatstableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMyMeal = new System.Windows.Forms.Panel();
            this.lblMyMealTitle = new System.Windows.Forms.Label();
            this.lblMyMealValue = new System.Windows.Forms.Label();
            this.pnlMyDeposit = new System.Windows.Forms.Panel();
            this.lblMyDepositTitle = new System.Windows.Forms.Label();
            this.lblMyDepositValue = new System.Windows.Forms.Label();
            this.pnlMyCost = new System.Windows.Forms.Panel();
            this.lblMyCostTitle = new System.Windows.Forms.Label();
            this.lblMyCostValue = new System.Windows.Forms.Label();
            this.pnlMyBalance = new System.Windows.Forms.Panel();
            this.lblMyBalanceTitle = new System.Windows.Forms.Label();
            this.lblMyBalanceValue = new System.Windows.Forms.Label();
            this.pnlMessSummarypanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlActions = new System.Windows.Forms.Panel();
            this.flowActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnGetMembership = new System.Windows.Forms.Button();
            this.pnlMembers = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tlpRoot.SuspendLayout();
            this.tlpStatstableLayoutPanel1.SuspendLayout();
            this.pnlMyMeal.SuspendLayout();
            this.pnlMyDeposit.SuspendLayout();
            this.pnlMyCost.SuspendLayout();
            this.pnlMyBalance.SuspendLayout();
            this.pnlMessSummarypanel.SuspendLayout();
            this.pnlActions.SuspendLayout();
            this.flowActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1111, 68);
            this.panel1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(708, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(62, 45);
            this.button5.TabIndex = 11;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(615, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(62, 45);
            this.button4.TabIndex = 10;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Image = global::messmanagement.Properties.Resources.Opera_Snapshot_2025_09_13_190053_messmanager_app;
            this.button3.Location = new System.Drawing.Point(523, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 45);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(435, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 45);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Image = global::messmanagement.Properties.Resources.Screenshot_2025_09_13_0037061;
            this.button1.Location = new System.Drawing.Point(341, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 45);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlpRoot
            // 
            this.tlpRoot.ColumnCount = 2;
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpRoot.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpRoot.Controls.Add(this.tlpStatstableLayoutPanel1, 1, 0);
            this.tlpRoot.Controls.Add(this.pnlMessSummarypanel, 0, 0);
            this.tlpRoot.Controls.Add(this.pnlActions, 1, 1);
            this.tlpRoot.Controls.Add(this.pnlMembers, 0, 2);
            this.tlpRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpRoot.Location = new System.Drawing.Point(0, 68);
            this.tlpRoot.Name = "tlpRoot";
            this.tlpRoot.Padding = new System.Windows.Forms.Padding(16);
            this.tlpRoot.RowCount = 3;
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpRoot.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpRoot.Size = new System.Drawing.Size(1111, 527);
            this.tlpRoot.TabIndex = 1;
            // 
            // tlpStatstableLayoutPanel1
            // 
            this.tlpStatstableLayoutPanel1.ColumnCount = 2;
            this.tlpStatstableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatstableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatstableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStatstableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpStatstableLayoutPanel1.Controls.Add(this.pnlMyMeal, 0, 0);
            this.tlpStatstableLayoutPanel1.Controls.Add(this.pnlMyDeposit, 1, 0);
            this.tlpStatstableLayoutPanel1.Controls.Add(this.pnlMyCost, 0, 1);
            this.tlpStatstableLayoutPanel1.Controls.Add(this.pnlMyBalance, 1, 1);
            this.tlpStatstableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpStatstableLayoutPanel1.Location = new System.Drawing.Point(612, 19);
            this.tlpStatstableLayoutPanel1.Name = "tlpStatstableLayoutPanel1";
            this.tlpStatstableLayoutPanel1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tlpStatstableLayoutPanel1.RowCount = 2;
            this.tlpStatstableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatstableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpStatstableLayoutPanel1.Size = new System.Drawing.Size(480, 171);
            this.tlpStatstableLayoutPanel1.TabIndex = 2;
            // 
            // pnlMyMeal
            // 
            this.pnlMyMeal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlMyMeal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyMeal.Controls.Add(this.lblMyMealTitle);
            this.pnlMyMeal.Controls.Add(this.lblMyMealValue);
            this.pnlMyMeal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyMeal.Location = new System.Drawing.Point(12, 6);
            this.pnlMyMeal.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMyMeal.Name = "pnlMyMeal";
            this.pnlMyMeal.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMyMeal.Size = new System.Drawing.Size(225, 73);
            this.pnlMyMeal.TabIndex = 0;
            // 
            // lblMyMealTitle
            // 
            this.lblMyMealTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMyMealTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyMealTitle.Location = new System.Drawing.Point(12, 37);
            this.lblMyMealTitle.Name = "lblMyMealTitle";
            this.lblMyMealTitle.Size = new System.Drawing.Size(199, 22);
            this.lblMyMealTitle.TabIndex = 3;
            this.lblMyMealTitle.Text = "My Total Meal";
            this.lblMyMealTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyMealValue
            // 
            this.lblMyMealValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMyMealValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyMealValue.Location = new System.Drawing.Point(12, 12);
            this.lblMyMealValue.Name = "lblMyMealValue";
            this.lblMyMealValue.Size = new System.Drawing.Size(199, 32);
            this.lblMyMealValue.TabIndex = 4;
            this.lblMyMealValue.Text = "0.00 (placeholder)";
            this.lblMyMealValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMyDeposit
            // 
            this.pnlMyDeposit.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlMyDeposit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyDeposit.Controls.Add(this.lblMyDepositTitle);
            this.pnlMyDeposit.Controls.Add(this.lblMyDepositValue);
            this.pnlMyDeposit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyDeposit.Location = new System.Drawing.Point(249, 6);
            this.pnlMyDeposit.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMyDeposit.Name = "pnlMyDeposit";
            this.pnlMyDeposit.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMyDeposit.Size = new System.Drawing.Size(225, 73);
            this.pnlMyDeposit.TabIndex = 1;
            // 
            // lblMyDepositTitle
            // 
            this.lblMyDepositTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMyDepositTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDepositTitle.Location = new System.Drawing.Point(12, 37);
            this.lblMyDepositTitle.Name = "lblMyDepositTitle";
            this.lblMyDepositTitle.Size = new System.Drawing.Size(199, 22);
            this.lblMyDepositTitle.TabIndex = 5;
            this.lblMyDepositTitle.Text = "My Deposit";
            this.lblMyDepositTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyDepositValue
            // 
            this.lblMyDepositValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMyDepositValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyDepositValue.Location = new System.Drawing.Point(12, 12);
            this.lblMyDepositValue.Name = "lblMyDepositValue";
            this.lblMyDepositValue.Size = new System.Drawing.Size(199, 32);
            this.lblMyDepositValue.TabIndex = 6;
            this.lblMyDepositValue.Text = "0.00 (placeholder)";
            this.lblMyDepositValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMyCost
            // 
            this.pnlMyCost.BackColor = System.Drawing.Color.Salmon;
            this.pnlMyCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyCost.Controls.Add(this.lblMyCostTitle);
            this.pnlMyCost.Controls.Add(this.lblMyCostValue);
            this.pnlMyCost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyCost.Location = new System.Drawing.Point(12, 91);
            this.pnlMyCost.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMyCost.Name = "pnlMyCost";
            this.pnlMyCost.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMyCost.Size = new System.Drawing.Size(225, 74);
            this.pnlMyCost.TabIndex = 2;
            // 
            // lblMyCostTitle
            // 
            this.lblMyCostTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMyCostTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyCostTitle.Location = new System.Drawing.Point(12, 38);
            this.lblMyCostTitle.Name = "lblMyCostTitle";
            this.lblMyCostTitle.Size = new System.Drawing.Size(199, 22);
            this.lblMyCostTitle.TabIndex = 5;
            this.lblMyCostTitle.Text = "My Cost";
            this.lblMyCostTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyCostValue
            // 
            this.lblMyCostValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMyCostValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyCostValue.Location = new System.Drawing.Point(12, 12);
            this.lblMyCostValue.Name = "lblMyCostValue";
            this.lblMyCostValue.Size = new System.Drawing.Size(199, 32);
            this.lblMyCostValue.TabIndex = 6;
            this.lblMyCostValue.Text = "0.00 (placeholder)";
            this.lblMyCostValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblMyCostValue.Click += new System.EventHandler(this.label6_Click);
            // 
            // pnlMyBalance
            // 
            this.pnlMyBalance.BackColor = System.Drawing.Color.Khaki;
            this.pnlMyBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyBalance.Controls.Add(this.lblMyBalanceTitle);
            this.pnlMyBalance.Controls.Add(this.lblMyBalanceValue);
            this.pnlMyBalance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMyBalance.Location = new System.Drawing.Point(249, 91);
            this.pnlMyBalance.Margin = new System.Windows.Forms.Padding(6);
            this.pnlMyBalance.Name = "pnlMyBalance";
            this.pnlMyBalance.Padding = new System.Windows.Forms.Padding(12);
            this.pnlMyBalance.Size = new System.Drawing.Size(225, 74);
            this.pnlMyBalance.TabIndex = 3;
            // 
            // lblMyBalanceTitle
            // 
            this.lblMyBalanceTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMyBalanceTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBalanceTitle.Location = new System.Drawing.Point(12, 38);
            this.lblMyBalanceTitle.Name = "lblMyBalanceTitle";
            this.lblMyBalanceTitle.Size = new System.Drawing.Size(199, 22);
            this.lblMyBalanceTitle.TabIndex = 5;
            this.lblMyBalanceTitle.Text = "My Balance";
            this.lblMyBalanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMyBalanceValue
            // 
            this.lblMyBalanceValue.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMyBalanceValue.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyBalanceValue.Location = new System.Drawing.Point(12, 12);
            this.lblMyBalanceValue.Name = "lblMyBalanceValue";
            this.lblMyBalanceValue.Size = new System.Drawing.Size(199, 32);
            this.lblMyBalanceValue.TabIndex = 6;
            this.lblMyBalanceValue.Text = "0.00 (placeholder)";
            this.lblMyBalanceValue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlMessSummarypanel
            // 
            this.pnlMessSummarypanel.Controls.Add(this.label2);
            this.pnlMessSummarypanel.Controls.Add(this.label1);
            this.pnlMessSummarypanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMessSummarypanel.Location = new System.Drawing.Point(16, 16);
            this.pnlMessSummarypanel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 8);
            this.pnlMessSummarypanel.Name = "pnlMessSummarypanel";
            this.tlpRoot.SetRowSpan(this.pnlMessSummarypanel, 2);
            this.pnlMessSummarypanel.Size = new System.Drawing.Size(585, 269);
            this.pnlMessSummarypanel.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 24);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(6);
            this.label2.Size = new System.Drawing.Size(206, 117);
            this.label2.TabIndex = 1;
            this.label2.Text = "• Mess Balance: 0.00 ৳\r\n• Total Deposit: 0.00 ৳\r\n• Total Meal: 0.00\r\n• Total Meal" +
    " Cost: 0.00 ৳\r\n• Meal Rate: — — —\r\n• Total Individual Other Cost: 0.00 ৳\r\n• Tota" +
    "l Shared Other Cost: 0.00 ৳";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.label1.Size = new System.Drawing.Size(318, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "our mess, {period} (Running) (placeholder)";
            // 
            // pnlActions
            // 
            this.pnlActions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlActions.Controls.Add(this.flowActions);
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlActions.Location = new System.Drawing.Point(615, 193);
            this.pnlActions.Margin = new System.Windows.Forms.Padding(6, 0, 6, 8);
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Padding = new System.Windows.Forms.Padding(12);
            this.pnlActions.Size = new System.Drawing.Size(474, 92);
            this.pnlActions.TabIndex = 3;
            // 
            // flowActions
            // 
            this.flowActions.Controls.Add(this.btnGetMembership);
            this.flowActions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowActions.Location = new System.Drawing.Point(12, 12);
            this.flowActions.Name = "flowActions";
            this.flowActions.Size = new System.Drawing.Size(448, 66);
            this.flowActions.TabIndex = 0;
            this.flowActions.WrapContents = false;
            // 
            // btnGetMembership
            // 
            this.btnGetMembership.AutoSize = true;
            this.btnGetMembership.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnGetMembership.FlatAppearance.BorderSize = 0;
            this.btnGetMembership.Location = new System.Drawing.Point(6, 6);
            this.btnGetMembership.Margin = new System.Windows.Forms.Padding(6);
            this.btnGetMembership.Name = "btnGetMembership";
            this.btnGetMembership.Size = new System.Drawing.Size(90, 25);
            this.btnGetMembership.TabIndex = 0;
            this.btnGetMembership.Text = "Set Bazar date";
            this.btnGetMembership.UseVisualStyleBackColor = false;
            // 
            // pnlMembers
            // 
            this.tlpRoot.SetColumnSpan(this.pnlMembers, 2);
            this.pnlMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMembers.Location = new System.Drawing.Point(16, 301);
            this.pnlMembers.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.pnlMembers.Name = "pnlMembers";
            this.pnlMembers.Padding = new System.Windows.Forms.Padding(6);
            this.pnlMembers.Size = new System.Drawing.Size(1079, 210);
            this.pnlMembers.TabIndex = 4;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 595);
            this.Controls.Add(this.tlpRoot);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mess Dashbord";
            this.panel1.ResumeLayout(false);
            this.tlpRoot.ResumeLayout(false);
            this.tlpStatstableLayoutPanel1.ResumeLayout(false);
            this.pnlMyMeal.ResumeLayout(false);
            this.pnlMyDeposit.ResumeLayout(false);
            this.pnlMyCost.ResumeLayout(false);
            this.pnlMyBalance.ResumeLayout(false);
            this.pnlMessSummarypanel.ResumeLayout(false);
            this.pnlMessSummarypanel.PerformLayout();
            this.pnlActions.ResumeLayout(false);
            this.flowActions.ResumeLayout(false);
            this.flowActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tlpRoot;
        private System.Windows.Forms.Panel pnlMessSummarypanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tlpStatstableLayoutPanel1;
        private System.Windows.Forms.Panel pnlMyMeal;
        private System.Windows.Forms.Panel pnlMyDeposit;
        private System.Windows.Forms.Panel pnlMyCost;
        private System.Windows.Forms.Panel pnlMyBalance;
        private System.Windows.Forms.Label lblMyMealTitle;
        private System.Windows.Forms.Label lblMyMealValue;
        private System.Windows.Forms.Label lblMyDepositTitle;
        private System.Windows.Forms.Label lblMyDepositValue;
        private System.Windows.Forms.Label lblMyCostTitle;
        private System.Windows.Forms.Label lblMyCostValue;
        private System.Windows.Forms.Label lblMyBalanceTitle;
        private System.Windows.Forms.Label lblMyBalanceValue;
        private System.Windows.Forms.Panel pnlActions;
        private System.Windows.Forms.FlowLayoutPanel flowActions;
        private System.Windows.Forms.Button btnGetMembership;
        private System.Windows.Forms.Panel pnlMembers;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}