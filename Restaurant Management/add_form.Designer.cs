namespace Restaurant_Management
{
    partial class add_form
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
            this.price = new System.Windows.Forms.Label();
            this.seller = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.textboxprice = new System.Windows.Forms.TextBox();
            this.textboxseller = new System.Windows.Forms.TextBox();
            this.textboxquantity = new System.Windows.Forms.TextBox();
            this.textboxtype = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(240, 247);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 16);
            this.price.TabIndex = 19;
            this.price.Text = "price";
            // 
            // seller
            // 
            this.seller.AutoSize = true;
            this.seller.Location = new System.Drawing.Point(240, 222);
            this.seller.Name = "seller";
            this.seller.Size = new System.Drawing.Size(40, 16);
            this.seller.TabIndex = 18;
            this.seller.Text = "seller";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(240, 194);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(53, 16);
            this.quantity.TabIndex = 17;
            this.quantity.Text = "quantity";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.Location = new System.Drawing.Point(240, 163);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(33, 16);
            this.type.TabIndex = 16;
            this.type.Text = "type";
            // 
            // textboxprice
            // 
            this.textboxprice.Location = new System.Drawing.Point(318, 244);
            this.textboxprice.Name = "textboxprice";
            this.textboxprice.Size = new System.Drawing.Size(263, 22);
            this.textboxprice.TabIndex = 14;
            // 
            // textboxseller
            // 
            this.textboxseller.Location = new System.Drawing.Point(318, 216);
            this.textboxseller.Name = "textboxseller";
            this.textboxseller.Size = new System.Drawing.Size(263, 22);
            this.textboxseller.TabIndex = 13;
            // 
            // textboxquantity
            // 
            this.textboxquantity.Location = new System.Drawing.Point(318, 188);
            this.textboxquantity.Name = "textboxquantity";
            this.textboxquantity.Size = new System.Drawing.Size(263, 22);
            this.textboxquantity.TabIndex = 12;
            // 
            // textboxtype
            // 
            this.textboxtype.Location = new System.Drawing.Point(318, 160);
            this.textboxtype.Name = "textboxtype";
            this.textboxtype.Size = new System.Drawing.Size(263, 22);
            this.textboxtype.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 69);
            this.label1.TabIndex = 20;
            this.label1.Text = "New Record";
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(324, 297);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(256, 61);
            this.btnsave.TabIndex = 21;
            this.btnsave.Text = "save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // add_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.price);
            this.Controls.Add(this.seller);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.type);
            this.Controls.Add(this.textboxprice);
            this.Controls.Add(this.textboxseller);
            this.Controls.Add(this.textboxquantity);
            this.Controls.Add(this.textboxtype);
            this.Name = "add_form";
            this.Text = "add_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label seller;
        private System.Windows.Forms.Label quantity;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.TextBox textboxprice;
        private System.Windows.Forms.TextBox textboxseller;
        private System.Windows.Forms.TextBox textboxquantity;
        private System.Windows.Forms.TextBox textboxtype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnsave;
    }
}