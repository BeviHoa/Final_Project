namespace Project_Entity
{
    partial class fHome
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btLogout = new System.Windows.Forms.Button();
            this.txbTotalPrice = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btPayment = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btAdd = new System.Windows.Forms.Button();
            this.cbFood = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btNhanVien = new System.Windows.Forms.Button();
            this.btFoodManager = new System.Windows.Forms.Button();
            this.btManagerAccount = new System.Windows.Forms.Button();
            this.btManagerTable = new System.Windows.Forms.Button();
            this.btDeleteTable = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btLogout);
            this.panel2.Controls.Add(this.txbTotalPrice);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.btPayment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.btAdd);
            this.panel2.Controls.Add(this.cbFood);
            this.panel2.Location = new System.Drawing.Point(418, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(448, 521);
            this.panel2.TabIndex = 1;
            // 
            // btLogout
            // 
            this.btLogout.Location = new System.Drawing.Point(346, 461);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(83, 52);
            this.btLogout.TabIndex = 8;
            this.btLogout.Text = "Logout";
            this.btLogout.UseVisualStyleBackColor = true;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // txbTotalPrice
            // 
            this.txbTotalPrice.Location = new System.Drawing.Point(3, 461);
            this.txbTotalPrice.Multiline = true;
            this.txbTotalPrice.Name = "txbTotalPrice";
            this.txbTotalPrice.Size = new System.Drawing.Size(143, 40);
            this.txbTotalPrice.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(434, 393);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên món";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thành tiền";
            // 
            // btPayment
            // 
            this.btPayment.Location = new System.Drawing.Point(193, 461);
            this.btPayment.Name = "btPayment";
            this.btPayment.Size = new System.Drawing.Size(82, 52);
            this.btPayment.TabIndex = 7;
            this.btPayment.Text = "Payment";
            this.btPayment.UseVisualStyleBackColor = true;
            this.btPayment.Click += new System.EventHandler(this.btPayment_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Food";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(346, 8);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(83, 23);
            this.numericUpDown1.TabIndex = 3;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(203, 11);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(56, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // cbFood
            // 
            this.cbFood.FormattingEnabled = true;
            this.cbFood.Location = new System.Drawing.Point(62, 8);
            this.cbFood.Name = "cbFood";
            this.cbFood.Size = new System.Drawing.Size(121, 23);
            this.cbFood.TabIndex = 1;
            this.cbFood.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(406, 478);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // btNhanVien
            // 
            this.btNhanVien.Location = new System.Drawing.Point(6, 6);
            this.btNhanVien.Name = "btNhanVien";
            this.btNhanVien.Size = new System.Drawing.Size(75, 39);
            this.btNhanVien.TabIndex = 3;
            this.btNhanVien.Text = "Nhân viên";
            this.btNhanVien.UseVisualStyleBackColor = true;
            this.btNhanVien.Click += new System.EventHandler(this.btControl_Click);
            // 
            // btFoodManager
            // 
            this.btFoodManager.Location = new System.Drawing.Point(87, 6);
            this.btFoodManager.Name = "btFoodManager";
            this.btFoodManager.Size = new System.Drawing.Size(63, 39);
            this.btFoodManager.TabIndex = 4;
            this.btFoodManager.Text = "Food Manager";
            this.btFoodManager.UseVisualStyleBackColor = true;
            this.btFoodManager.Click += new System.EventHandler(this.btFoodManager_Click);
            // 
            // btManagerAccount
            // 
            this.btManagerAccount.Location = new System.Drawing.Point(156, 6);
            this.btManagerAccount.Name = "btManagerAccount";
            this.btManagerAccount.Size = new System.Drawing.Size(98, 39);
            this.btManagerAccount.TabIndex = 5;
            this.btManagerAccount.Text = "Register Account";
            this.btManagerAccount.UseVisualStyleBackColor = true;
            this.btManagerAccount.Click += new System.EventHandler(this.btManagerAccount_Click);
            // 
            // btManagerTable
            // 
            this.btManagerTable.Location = new System.Drawing.Point(260, 6);
            this.btManagerTable.Name = "btManagerTable";
            this.btManagerTable.Size = new System.Drawing.Size(50, 39);
            this.btManagerTable.TabIndex = 6;
            this.btManagerTable.Text = "+Table";
            this.btManagerTable.UseVisualStyleBackColor = true;
            this.btManagerTable.Click += new System.EventHandler(this.btManagerTable_Click);
            // 
            // btDeleteTable
            // 
            this.btDeleteTable.Location = new System.Drawing.Point(316, 6);
            this.btDeleteTable.Name = "btDeleteTable";
            this.btDeleteTable.Size = new System.Drawing.Size(65, 39);
            this.btDeleteTable.TabIndex = 7;
            this.btDeleteTable.Text = "- Table";
            this.btDeleteTable.UseVisualStyleBackColor = true;
            this.btDeleteTable.Click += new System.EventHandler(this.btDeleteTable_Click);
            // 
            // fHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 537);
            this.Controls.Add(this.btDeleteTable);
            this.Controls.Add(this.btManagerTable);
            this.Controls.Add(this.btManagerAccount);
            this.Controls.Add(this.btFoodManager);
            this.Controls.Add(this.btNhanVien);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Name = "fHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.fHome_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.ComboBox cbFood;
        private System.Windows.Forms.Button btPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btControl;
        private System.Windows.Forms.Button btFoodManager;
        private System.Windows.Forms.Button btManagerAccount;
        private System.Windows.Forms.Button btNhanVien;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txbTotalPrice;
        private System.Windows.Forms.Button btManagerTable;
        private System.Windows.Forms.Button btDeleteTable;
        private System.Windows.Forms.Button btLogout;
    }
}