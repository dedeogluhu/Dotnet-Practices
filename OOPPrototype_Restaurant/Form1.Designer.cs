namespace OOPPrototype_Restaurant
{
    partial class Form1
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
            this.gbxOrderFood = new System.Windows.Forms.GroupBox();
            this.btnOrderFood = new System.Windows.Forms.Button();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.cbxTableNo = new System.Windows.Forms.ComboBox();
            this.lbxFoodToOrder = new System.Windows.Forms.ListBox();
            this.btnAddFoodToList = new System.Windows.Forms.Button();
            this.lbxMenu = new System.Windows.Forms.ListBox();
            this.gbxTableList = new System.Windows.Forms.GroupBox();
            this.btnGetPayment = new System.Windows.Forms.Button();
            this.lbxTableListForPayment = new System.Windows.Forms.ListBox();
            this.gbxOrderList = new System.Windows.Forms.GroupBox();
            this.btnOrderReady = new System.Windows.Forms.Button();
            this.lbxOrderListForCook = new System.Windows.Forms.ListBox();
            this.gbxOldOrders = new System.Windows.Forms.GroupBox();
            this.lblShowCash = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.btnWithdrawCash = new System.Windows.Forms.Button();
            this.lbxOldOrders = new System.Windows.Forms.ListBox();
            this.gbxWorkersList = new System.Windows.Forms.GroupBox();
            this.lbxWorkers = new System.Windows.Forms.ListBox();
            this.gbxOrderFood.SuspendLayout();
            this.gbxTableList.SuspendLayout();
            this.gbxOrderList.SuspendLayout();
            this.gbxOldOrders.SuspendLayout();
            this.gbxWorkersList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxOrderFood
            // 
            this.gbxOrderFood.Controls.Add(this.btnOrderFood);
            this.gbxOrderFood.Controls.Add(this.lblTotalAmount);
            this.gbxOrderFood.Controls.Add(this.lblTotalPrice);
            this.gbxOrderFood.Controls.Add(this.lblTableNo);
            this.gbxOrderFood.Controls.Add(this.cbxTableNo);
            this.gbxOrderFood.Controls.Add(this.lbxFoodToOrder);
            this.gbxOrderFood.Controls.Add(this.btnAddFoodToList);
            this.gbxOrderFood.Controls.Add(this.lbxMenu);
            this.gbxOrderFood.Location = new System.Drawing.Point(13, 13);
            this.gbxOrderFood.Name = "gbxOrderFood";
            this.gbxOrderFood.Size = new System.Drawing.Size(546, 638);
            this.gbxOrderFood.TabIndex = 0;
            this.gbxOrderFood.TabStop = false;
            this.gbxOrderFood.Text = "Order Food";
            // 
            // btnOrderFood
            // 
            this.btnOrderFood.Location = new System.Drawing.Point(335, 501);
            this.btnOrderFood.Name = "btnOrderFood";
            this.btnOrderFood.Size = new System.Drawing.Size(204, 44);
            this.btnOrderFood.TabIndex = 7;
            this.btnOrderFood.Text = "Order Food";
            this.btnOrderFood.UseVisualStyleBackColor = true;
            this.btnOrderFood.Click += new System.EventHandler(this.btnOrderFood_Click);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(523, 450);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(16, 17);
            this.lblTotalAmount.TabIndex = 6;
            this.lblTotalAmount.Text = "0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(332, 450);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(44, 17);
            this.lblTotalPrice.TabIndex = 5;
            this.lblTotalPrice.Text = "Total:";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.Location = new System.Drawing.Point(332, 364);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(70, 17);
            this.lblTableNo.TabIndex = 4;
            this.lblTableNo.Text = "Table No:";
            // 
            // cbxTableNo
            // 
            this.cbxTableNo.FormattingEnabled = true;
            this.cbxTableNo.Location = new System.Drawing.Point(335, 402);
            this.cbxTableNo.Name = "cbxTableNo";
            this.cbxTableNo.Size = new System.Drawing.Size(204, 24);
            this.cbxTableNo.TabIndex = 3;
            // 
            // lbxFoodToOrder
            // 
            this.lbxFoodToOrder.FormattingEnabled = true;
            this.lbxFoodToOrder.ItemHeight = 16;
            this.lbxFoodToOrder.Location = new System.Drawing.Point(335, 21);
            this.lbxFoodToOrder.Name = "lbxFoodToOrder";
            this.lbxFoodToOrder.Size = new System.Drawing.Size(204, 308);
            this.lbxFoodToOrder.TabIndex = 2;
            // 
            // btnAddFoodToList
            // 
            this.btnAddFoodToList.Location = new System.Drawing.Point(243, 167);
            this.btnAddFoodToList.Name = "btnAddFoodToList";
            this.btnAddFoodToList.Size = new System.Drawing.Size(86, 40);
            this.btnAddFoodToList.TabIndex = 1;
            this.btnAddFoodToList.Text = ">>";
            this.btnAddFoodToList.UseVisualStyleBackColor = true;
            this.btnAddFoodToList.Click += new System.EventHandler(this.btnAddFoodToList_Click);
            // 
            // lbxMenu
            // 
            this.lbxMenu.FormattingEnabled = true;
            this.lbxMenu.ItemHeight = 16;
            this.lbxMenu.Location = new System.Drawing.Point(7, 21);
            this.lbxMenu.Name = "lbxMenu";
            this.lbxMenu.Size = new System.Drawing.Size(230, 596);
            this.lbxMenu.TabIndex = 0;
            // 
            // gbxTableList
            // 
            this.gbxTableList.Controls.Add(this.btnGetPayment);
            this.gbxTableList.Controls.Add(this.lbxTableListForPayment);
            this.gbxTableList.Location = new System.Drawing.Point(566, 13);
            this.gbxTableList.Name = "gbxTableList";
            this.gbxTableList.Size = new System.Drawing.Size(582, 321);
            this.gbxTableList.TabIndex = 1;
            this.gbxTableList.TabStop = false;
            this.gbxTableList.Text = "Table List";
            // 
            // btnGetPayment
            // 
            this.btnGetPayment.Location = new System.Drawing.Point(414, 272);
            this.btnGetPayment.Name = "btnGetPayment";
            this.btnGetPayment.Size = new System.Drawing.Size(162, 43);
            this.btnGetPayment.TabIndex = 1;
            this.btnGetPayment.Text = "Get Payment";
            this.btnGetPayment.UseVisualStyleBackColor = true;
            this.btnGetPayment.Click += new System.EventHandler(this.btnGetPayment_Click);
            // 
            // lbxTableListForPayment
            // 
            this.lbxTableListForPayment.FormattingEnabled = true;
            this.lbxTableListForPayment.ItemHeight = 16;
            this.lbxTableListForPayment.Location = new System.Drawing.Point(6, 21);
            this.lbxTableListForPayment.Name = "lbxTableListForPayment";
            this.lbxTableListForPayment.Size = new System.Drawing.Size(570, 244);
            this.lbxTableListForPayment.TabIndex = 0;
            // 
            // gbxOrderList
            // 
            this.gbxOrderList.Controls.Add(this.btnOrderReady);
            this.gbxOrderList.Controls.Add(this.lbxOrderListForCook);
            this.gbxOrderList.Location = new System.Drawing.Point(566, 340);
            this.gbxOrderList.Name = "gbxOrderList";
            this.gbxOrderList.Size = new System.Drawing.Size(582, 311);
            this.gbxOrderList.TabIndex = 2;
            this.gbxOrderList.TabStop = false;
            this.gbxOrderList.Text = "Order List For Cook";
            // 
            // btnOrderReady
            // 
            this.btnOrderReady.Location = new System.Drawing.Point(414, 257);
            this.btnOrderReady.Name = "btnOrderReady";
            this.btnOrderReady.Size = new System.Drawing.Size(162, 45);
            this.btnOrderReady.TabIndex = 1;
            this.btnOrderReady.Text = "Order Ready";
            this.btnOrderReady.UseVisualStyleBackColor = true;
            this.btnOrderReady.Click += new System.EventHandler(this.btnOrderReady_Click);
            // 
            // lbxOrderListForCook
            // 
            this.lbxOrderListForCook.FormattingEnabled = true;
            this.lbxOrderListForCook.ItemHeight = 16;
            this.lbxOrderListForCook.Location = new System.Drawing.Point(7, 22);
            this.lbxOrderListForCook.Name = "lbxOrderListForCook";
            this.lbxOrderListForCook.Size = new System.Drawing.Size(569, 228);
            this.lbxOrderListForCook.TabIndex = 0;
            // 
            // gbxOldOrders
            // 
            this.gbxOldOrders.Controls.Add(this.lblShowCash);
            this.gbxOldOrders.Controls.Add(this.lblCash);
            this.gbxOldOrders.Controls.Add(this.btnWithdrawCash);
            this.gbxOldOrders.Controls.Add(this.lbxOldOrders);
            this.gbxOldOrders.Location = new System.Drawing.Point(1155, 13);
            this.gbxOldOrders.Name = "gbxOldOrders";
            this.gbxOldOrders.Size = new System.Drawing.Size(343, 321);
            this.gbxOldOrders.TabIndex = 3;
            this.gbxOldOrders.TabStop = false;
            this.gbxOldOrders.Text = "Old Orders";
            // 
            // lblShowCash
            // 
            this.lblShowCash.AutoSize = true;
            this.lblShowCash.Location = new System.Drawing.Point(113, 282);
            this.lblShowCash.Name = "lblShowCash";
            this.lblShowCash.Size = new System.Drawing.Size(16, 17);
            this.lblShowCash.TabIndex = 3;
            this.lblShowCash.Text = "0";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(7, 282);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(44, 17);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "Cash:";
            // 
            // btnWithdrawCash
            // 
            this.btnWithdrawCash.Location = new System.Drawing.Point(181, 271);
            this.btnWithdrawCash.Name = "btnWithdrawCash";
            this.btnWithdrawCash.Size = new System.Drawing.Size(156, 43);
            this.btnWithdrawCash.TabIndex = 1;
            this.btnWithdrawCash.Text = "Withdraw Money";
            this.btnWithdrawCash.UseVisualStyleBackColor = true;
            this.btnWithdrawCash.Click += new System.EventHandler(this.btnWithdrawCash_Click);
            // 
            // lbxOldOrders
            // 
            this.lbxOldOrders.FormattingEnabled = true;
            this.lbxOldOrders.ItemHeight = 16;
            this.lbxOldOrders.Location = new System.Drawing.Point(10, 21);
            this.lbxOldOrders.Name = "lbxOldOrders";
            this.lbxOldOrders.Size = new System.Drawing.Size(327, 244);
            this.lbxOldOrders.TabIndex = 0;
            // 
            // gbxWorkersList
            // 
            this.gbxWorkersList.Controls.Add(this.lbxWorkers);
            this.gbxWorkersList.Location = new System.Drawing.Point(1155, 341);
            this.gbxWorkersList.Name = "gbxWorkersList";
            this.gbxWorkersList.Size = new System.Drawing.Size(343, 310);
            this.gbxWorkersList.TabIndex = 4;
            this.gbxWorkersList.TabStop = false;
            this.gbxWorkersList.Text = "Workers";
            // 
            // lbxWorkers
            // 
            this.lbxWorkers.FormattingEnabled = true;
            this.lbxWorkers.ItemHeight = 16;
            this.lbxWorkers.Location = new System.Drawing.Point(7, 21);
            this.lbxWorkers.Name = "lbxWorkers";
            this.lbxWorkers.Size = new System.Drawing.Size(330, 276);
            this.lbxWorkers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1796, 733);
            this.Controls.Add(this.gbxWorkersList);
            this.Controls.Add(this.gbxOldOrders);
            this.Controls.Add(this.gbxOrderList);
            this.Controls.Add(this.gbxTableList);
            this.Controls.Add(this.gbxOrderFood);
            this.Name = "Form1";
            this.Text = "Restaurant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxOrderFood.ResumeLayout(false);
            this.gbxOrderFood.PerformLayout();
            this.gbxTableList.ResumeLayout(false);
            this.gbxOrderList.ResumeLayout(false);
            this.gbxOldOrders.ResumeLayout(false);
            this.gbxOldOrders.PerformLayout();
            this.gbxWorkersList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxOrderFood;
        private System.Windows.Forms.Button btnOrderFood;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.ComboBox cbxTableNo;
        private System.Windows.Forms.ListBox lbxFoodToOrder;
        private System.Windows.Forms.Button btnAddFoodToList;
        private System.Windows.Forms.ListBox lbxMenu;
        private System.Windows.Forms.GroupBox gbxTableList;
        private System.Windows.Forms.Button btnGetPayment;
        private System.Windows.Forms.ListBox lbxTableListForPayment;
        private System.Windows.Forms.GroupBox gbxOrderList;
        private System.Windows.Forms.Button btnOrderReady;
        private System.Windows.Forms.ListBox lbxOrderListForCook;
        private System.Windows.Forms.GroupBox gbxOldOrders;
        private System.Windows.Forms.Label lblShowCash;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Button btnWithdrawCash;
        private System.Windows.Forms.ListBox lbxOldOrders;
        private System.Windows.Forms.GroupBox gbxWorkersList;
        private System.Windows.Forms.ListBox lbxWorkers;
    }
}

