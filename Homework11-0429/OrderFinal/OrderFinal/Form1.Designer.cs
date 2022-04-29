namespace OrderFinal
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
            this.label_add = new System.Windows.Forms.Label();
            this.label_buyer = new System.Windows.Forms.Label();
            this.txtbox_buyer = new System.Windows.Forms.TextBox();
            this.txtbox_seller = new System.Windows.Forms.TextBox();
            this.label_seller = new System.Windows.Forms.Label();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.label_additem = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_price = new System.Windows.Forms.Label();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_num = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_orderid = new System.Windows.Forms.TextBox();
            this.btn_additem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbox_searchid = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_delid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtbox_itemname = new System.Windows.Forms.TextBox();
            this.btn_delitem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbox_delOrderid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.label_suc2 = new System.Windows.Forms.Label();
            this.label_suc1 = new System.Windows.Forms.Label();
            this.btn_delorder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_add.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_add.Location = new System.Drawing.Point(74, 57);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(159, 33);
            this.label_add.TabIndex = 0;
            this.label_add.Text = "Add Order";
            // 
            // label_buyer
            // 
            this.label_buyer.AutoSize = true;
            this.label_buyer.Location = new System.Drawing.Point(88, 140);
            this.label_buyer.Name = "label_buyer";
            this.label_buyer.Size = new System.Drawing.Size(70, 24);
            this.label_buyer.TabIndex = 1;
            this.label_buyer.Text = "Buyer";
            // 
            // txtbox_buyer
            // 
            this.txtbox_buyer.Location = new System.Drawing.Point(198, 140);
            this.txtbox_buyer.Name = "txtbox_buyer";
            this.txtbox_buyer.Size = new System.Drawing.Size(100, 35);
            this.txtbox_buyer.TabIndex = 2;
            // 
            // txtbox_seller
            // 
            this.txtbox_seller.Location = new System.Drawing.Point(665, 137);
            this.txtbox_seller.Name = "txtbox_seller";
            this.txtbox_seller.Size = new System.Drawing.Size(100, 35);
            this.txtbox_seller.TabIndex = 3;
            // 
            // label_seller
            // 
            this.label_seller.AutoSize = true;
            this.label_seller.Location = new System.Drawing.Point(569, 142);
            this.label_seller.Name = "label_seller";
            this.label_seller.Size = new System.Drawing.Size(82, 24);
            this.label_seller.TabIndex = 4;
            this.label_seller.Text = "Seller";
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.Location = new System.Drawing.Point(1158, 57);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(122, 49);
            this.btn_addOrder.TabIndex = 5;
            this.btn_addOrder.Text = "添加";
            this.btn_addOrder.UseVisualStyleBackColor = true;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // label_additem
            // 
            this.label_additem.AutoSize = true;
            this.label_additem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_additem.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_additem.Location = new System.Drawing.Point(71, 216);
            this.label_additem.Name = "label_additem";
            this.label_additem.Size = new System.Drawing.Size(143, 33);
            this.label_additem.TabIndex = 6;
            this.label_additem.Text = "Add Item";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(85, 295);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(58, 24);
            this.label_name.TabIndex = 7;
            this.label_name.Text = "Name";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(195, 292);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(100, 35);
            this.textBox_name.TabIndex = 8;
            // 
            // label_price
            // 
            this.label_price.AutoSize = true;
            this.label_price.Location = new System.Drawing.Point(409, 295);
            this.label_price.Name = "label_price";
            this.label_price.Size = new System.Drawing.Size(70, 24);
            this.label_price.TabIndex = 9;
            this.label_price.Text = "Price";
            // 
            // textBox_price
            // 
            this.textBox_price.Location = new System.Drawing.Point(518, 292);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(100, 35);
            this.textBox_price.TabIndex = 10;
            // 
            // textBox_number
            // 
            this.textBox_number.Location = new System.Drawing.Point(790, 284);
            this.textBox_number.Name = "textBox_number";
            this.textBox_number.Size = new System.Drawing.Size(100, 35);
            this.textBox_number.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(720, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 11;
            // 
            // label_num
            // 
            this.label_num.AutoSize = true;
            this.label_num.Location = new System.Drawing.Point(692, 295);
            this.label_num.Name = "label_num";
            this.label_num.Size = new System.Drawing.Size(82, 24);
            this.label_num.TabIndex = 13;
            this.label_num.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(978, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Order id";
            // 
            // textBox_orderid
            // 
            this.textBox_orderid.Location = new System.Drawing.Point(1127, 284);
            this.textBox_orderid.Name = "textBox_orderid";
            this.textBox_orderid.Size = new System.Drawing.Size(100, 35);
            this.textBox_orderid.TabIndex = 15;
            // 
            // btn_additem
            // 
            this.btn_additem.Location = new System.Drawing.Point(1155, 211);
            this.btn_additem.Name = "btn_additem";
            this.btn_additem.Size = new System.Drawing.Size(122, 49);
            this.btn_additem.TabIndex = 16;
            this.btn_additem.Text = "添加";
            this.btn_additem.UseVisualStyleBackColor = true;
            this.btn_additem.Click += new System.EventHandler(this.btn_additem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(71, 376);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 33);
            this.label3.TabIndex = 17;
            this.label3.Text = "Search order by id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "ID";
            // 
            // txtbox_searchid
            // 
            this.txtbox_searchid.Location = new System.Drawing.Point(195, 459);
            this.txtbox_searchid.Name = "txtbox_searchid";
            this.txtbox_searchid.Size = new System.Drawing.Size(100, 35);
            this.txtbox_searchid.TabIndex = 19;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(1155, 360);
            this.btn_search.Name = "btn_search";
            this.btn_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_search.Size = new System.Drawing.Size(122, 49);
            this.btn_search.TabIndex = 20;
            this.btn_search.Text = "搜索";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(71, 534);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 33);
            this.label5.TabIndex = 21;
            this.label5.Text = "Delete Item";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 22;
            this.label6.Text = "order ID";
            // 
            // txtbox_delid
            // 
            this.txtbox_delid.Location = new System.Drawing.Point(274, 596);
            this.txtbox_delid.Name = "txtbox_delid";
            this.txtbox_delid.Size = new System.Drawing.Size(100, 35);
            this.txtbox_delid.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(483, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "item name";
            // 
            // txtbox_itemname
            // 
            this.txtbox_itemname.Location = new System.Drawing.Point(662, 596);
            this.txtbox_itemname.Name = "txtbox_itemname";
            this.txtbox_itemname.Size = new System.Drawing.Size(100, 35);
            this.txtbox_itemname.TabIndex = 25;
            // 
            // btn_delitem
            // 
            this.btn_delitem.Location = new System.Drawing.Point(1155, 534);
            this.btn_delitem.Name = "btn_delitem";
            this.btn_delitem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delitem.Size = new System.Drawing.Size(122, 49);
            this.btn_delitem.TabIndex = 26;
            this.btn_delitem.Text = "删除";
            this.btn_delitem.UseVisualStyleBackColor = true;
            this.btn_delitem.Click += new System.EventHandler(this.btn_delitem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(71, 665);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 33);
            this.label8.TabIndex = 27;
            this.label8.Text = "Delete Order";
            // 
            // txtbox_delOrderid
            // 
            this.txtbox_delOrderid.Location = new System.Drawing.Point(277, 743);
            this.txtbox_delOrderid.Name = "txtbox_delOrderid";
            this.txtbox_delOrderid.Size = new System.Drawing.Size(100, 35);
            this.txtbox_delOrderid.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(88, 743);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 24);
            this.label9.TabIndex = 28;
            this.label9.Text = "order ID";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_output.Location = new System.Drawing.Point(483, 462);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(0, 24);
            this.label_output.TabIndex = 30;
            // 
            // label_suc2
            // 
            this.label_suc2.AutoSize = true;
            this.label_suc2.Location = new System.Drawing.Point(340, 223);
            this.label_suc2.Name = "label_suc2";
            this.label_suc2.Size = new System.Drawing.Size(0, 24);
            this.label_suc2.TabIndex = 31;
            // 
            // label_suc1
            // 
            this.label_suc1.AutoSize = true;
            this.label_suc1.Location = new System.Drawing.Point(353, 64);
            this.label_suc1.Name = "label_suc1";
            this.label_suc1.Size = new System.Drawing.Size(0, 24);
            this.label_suc1.TabIndex = 32;
            // 
            // btn_delorder
            // 
            this.btn_delorder.Location = new System.Drawing.Point(1158, 674);
            this.btn_delorder.Name = "btn_delorder";
            this.btn_delorder.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btn_delorder.Size = new System.Drawing.Size(122, 49);
            this.btn_delorder.TabIndex = 33;
            this.btn_delorder.Text = "删除";
            this.btn_delorder.UseVisualStyleBackColor = true;
            this.btn_delorder.Click += new System.EventHandler(this.btn_delorder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 832);
            this.Controls.Add(this.btn_delorder);
            this.Controls.Add(this.label_suc1);
            this.Controls.Add(this.label_suc2);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.txtbox_delOrderid);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_delitem);
            this.Controls.Add(this.txtbox_itemname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtbox_delid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txtbox_searchid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_additem);
            this.Controls.Add(this.textBox_orderid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_num);
            this.Controls.Add(this.textBox_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.label_price);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_additem);
            this.Controls.Add(this.btn_addOrder);
            this.Controls.Add(this.label_seller);
            this.Controls.Add(this.txtbox_seller);
            this.Controls.Add(this.txtbox_buyer);
            this.Controls.Add(this.label_buyer);
            this.Controls.Add(this.label_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_buyer;
        private System.Windows.Forms.TextBox txtbox_buyer;
        private System.Windows.Forms.TextBox txtbox_seller;
        private System.Windows.Forms.Label label_seller;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Label label_additem;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_price;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_orderid;
        private System.Windows.Forms.Button btn_additem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbox_searchid;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_delid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtbox_itemname;
        private System.Windows.Forms.Button btn_delitem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbox_delOrderid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_suc2;
        private System.Windows.Forms.Label label_suc1;
        private System.Windows.Forms.Button btn_delorder;
    }
}