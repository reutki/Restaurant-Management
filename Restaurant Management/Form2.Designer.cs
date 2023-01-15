namespace Restaurant_Management
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelright = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnnewquery = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelleft = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.seller = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.textboxprice = new System.Windows.Forms.TextBox();
            this.textboxseller = new System.Windows.Forms.TextBox();
            this.textboxquantity = new System.Windows.Forms.TextBox();
            this.textboxtype = new System.Windows.Forms.TextBox();
            this.textboxid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.user = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.erase = new System.Windows.Forms.Button();
            this.textboxsearch = new System.Windows.Forms.TextBox();
            this.control = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.control.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(937, 588);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelright);
            this.groupBox4.Controls.Add(this.btnsave);
            this.groupBox4.Controls.Add(this.btnedit);
            this.groupBox4.Controls.Add(this.btndelete);
            this.groupBox4.Controls.Add(this.btnnewquery);
            this.groupBox4.Location = new System.Drawing.Point(661, 385);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 190);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // labelright
            // 
            this.labelright.AutoSize = true;
            this.labelright.Location = new System.Drawing.Point(11, 19);
            this.labelright.Name = "labelright";
            this.labelright.Size = new System.Drawing.Size(72, 16);
            this.labelright.TabIndex = 4;
            this.labelright.Text = "Edit record";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(43, 138);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(194, 28);
            this.btnsave.TabIndex = 3;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnedit
            // 
            this.btnedit.Location = new System.Drawing.Point(43, 106);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(194, 28);
            this.btnedit.TabIndex = 2;
            this.btnedit.Text = "edit";
            this.btnedit.UseVisualStyleBackColor = true;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(43, 72);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(194, 28);
            this.btndelete.TabIndex = 1;
            this.btndelete.Text = "delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnnewquery
            // 
            this.btnnewquery.Location = new System.Drawing.Point(43, 38);
            this.btnnewquery.Name = "btnnewquery";
            this.btnnewquery.Size = new System.Drawing.Size(194, 28);
            this.btnnewquery.TabIndex = 0;
            this.btnnewquery.Text = "new query";
            this.btnnewquery.UseVisualStyleBackColor = true;
            this.btnnewquery.Click += new System.EventHandler(this.btnnewquery_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelleft);
            this.groupBox3.Controls.Add(this.price);
            this.groupBox3.Controls.Add(this.seller);
            this.groupBox3.Controls.Add(this.quantity);
            this.groupBox3.Controls.Add(this.type);
            this.groupBox3.Controls.Add(this.id);
            this.groupBox3.Controls.Add(this.textboxprice);
            this.groupBox3.Controls.Add(this.textboxseller);
            this.groupBox3.Controls.Add(this.textboxquantity);
            this.groupBox3.Controls.Add(this.textboxtype);
            this.groupBox3.Controls.Add(this.textboxid);
            this.groupBox3.Location = new System.Drawing.Point(6, 385);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 191);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // labelleft
            // 
            this.labelleft.AutoSize = true;
            this.labelleft.Location = new System.Drawing.Point(10, 29);
            this.labelleft.Name = "labelleft";
            this.labelleft.Size = new System.Drawing.Size(52, 16);
            this.labelleft.TabIndex = 10;
            this.labelleft.Text = "Record";
            this.labelleft.Click += new System.EventHandler(this.labelleft_Click);
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(152, 150);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 16);
            this.price.TabIndex = 9;
            this.price.Text = "price";
            this.price.Click += new System.EventHandler(this.label4_Click);
            // 
            // seller
            // 
            this.seller.AutoSize = true;
            this.seller.Location = new System.Drawing.Point(152, 125);
            this.seller.Name = "seller";
            this.seller.Size = new System.Drawing.Size(40, 16);
            this.seller.TabIndex = 8;
            this.seller.Text = "seller";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(152, 97);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(53, 16);
            this.quantity.TabIndex = 7;
            this.quantity.Text = "quantity";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(152, 66);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(33, 16);
            this.type.TabIndex = 6;
            this.type.Text = "type";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Location = new System.Drawing.Point(152, 42);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(18, 16);
            this.id.TabIndex = 5;
            this.id.Text = "id";
            // 
            // textboxprice
            // 
            this.textboxprice.Location = new System.Drawing.Point(230, 147);
            this.textboxprice.Name = "textboxprice";
            this.textboxprice.Size = new System.Drawing.Size(263, 22);
            this.textboxprice.TabIndex = 4;
            // 
            // textboxseller
            // 
            this.textboxseller.Location = new System.Drawing.Point(230, 119);
            this.textboxseller.Name = "textboxseller";
            this.textboxseller.Size = new System.Drawing.Size(263, 22);
            this.textboxseller.TabIndex = 3;
            // 
            // textboxquantity
            // 
            this.textboxquantity.Location = new System.Drawing.Point(230, 91);
            this.textboxquantity.Name = "textboxquantity";
            this.textboxquantity.Size = new System.Drawing.Size(263, 22);
            this.textboxquantity.TabIndex = 2;
            // 
            // textboxtype
            // 
            this.textboxtype.Location = new System.Drawing.Point(230, 63);
            this.textboxtype.Name = "textboxtype";
            this.textboxtype.Size = new System.Drawing.Size(263, 22);
            this.textboxtype.TabIndex = 1;
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(230, 35);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(263, 22);
            this.textboxid.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 282);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.user);
            this.groupBox2.Controls.Add(this.search);
            this.groupBox2.Controls.Add(this.refresh);
            this.groupBox2.Controls.Add(this.erase);
            this.groupBox2.Controls.Add(this.textboxsearch);
            this.groupBox2.Controls.Add(this.control);
            this.groupBox2.Location = new System.Drawing.Point(1, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(930, 66);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(250, 22);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(60, 29);
            this.user.TabIndex = 4;
            this.user.Text = "user";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(596, 20);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(85, 38);
            this.search.TabIndex = 3;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(505, 21);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(85, 38);
            this.refresh.TabIndex = 2;
            this.refresh.Text = "refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // erase
            // 
            this.erase.Location = new System.Drawing.Point(414, 21);
            this.erase.Name = "erase";
            this.erase.Size = new System.Drawing.Size(85, 38);
            this.erase.TabIndex = 1;
            this.erase.Text = "erase";
            this.erase.UseVisualStyleBackColor = true;
            this.erase.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textboxsearch
            // 
            this.textboxsearch.Location = new System.Drawing.Point(706, 28);
            this.textboxsearch.Name = "textboxsearch";
            this.textboxsearch.Size = new System.Drawing.Size(203, 22);
            this.textboxsearch.TabIndex = 0;
            this.textboxsearch.TextChanged += new System.EventHandler(this.textboxsearch_TextChanged);
            // 
            // control
            // 
            this.control.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.control.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem});
            this.control.Location = new System.Drawing.Point(3, 18);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(924, 28);
            this.control.TabIndex = 5;
            this.control.Text = "menuStrip2";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox});
            this.toolStrip1.Location = new System.Drawing.Point(3, 18);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(931, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripTextBox
            // 
            this.toolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox.Name = "toolStripTextBox";
            this.toolStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.toolStripTextBox.Click += new System.EventHandler(this.toolStripTextBox_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 592);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.control.ResumeLayout(false);
            this.control.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button erase;
        private System.Windows.Forms.TextBox textboxsearch;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textboxprice;
        private System.Windows.Forms.TextBox textboxseller;
        private System.Windows.Forms.TextBox textboxquantity;
        private System.Windows.Forms.TextBox textboxtype;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label seller;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnnewquery;
        private System.Windows.Forms.Label labelright;
        private System.Windows.Forms.Label labelleft;
        private System.Windows.Forms.MenuStrip control;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox;
    }
}