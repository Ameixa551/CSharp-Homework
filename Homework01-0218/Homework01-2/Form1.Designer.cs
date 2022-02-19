
namespace Homework01_2
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
            this.input1 = new System.Windows.Forms.TextBox();
            this.opr_choose = new System.Windows.Forms.ComboBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.Label();
            this.cal_btn = new System.Windows.Forms.Button();
            this.clr_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(53, 104);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(102, 38);
            this.input1.TabIndex = 0;
            this.input1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // opr_choose
            // 
            this.opr_choose.FormattingEnabled = true;
            this.opr_choose.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.opr_choose.Location = new System.Drawing.Point(198, 104);
            this.opr_choose.Name = "opr_choose";
            this.opr_choose.Size = new System.Drawing.Size(74, 39);
            this.opr_choose.TabIndex = 1;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(323, 104);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(109, 38);
            this.input2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(488, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "=";
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Location = new System.Drawing.Point(564, 107);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(42, 31);
            this.output.TabIndex = 4;
            this.output.Text = "00";
            // 
            // cal_btn
            // 
            this.cal_btn.Location = new System.Drawing.Point(323, 289);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(150, 46);
            this.cal_btn.TabIndex = 5;
            this.cal_btn.Text = "Calculate";
            this.cal_btn.UseVisualStyleBackColor = true;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // clr_btn
            // 
            this.clr_btn.Location = new System.Drawing.Point(564, 289);
            this.clr_btn.Name = "clr_btn";
            this.clr_btn.Size = new System.Drawing.Size(150, 46);
            this.clr_btn.TabIndex = 6;
            this.clr_btn.Text = "Clear";
            this.clr_btn.UseVisualStyleBackColor = true;
            this.clr_btn.Click += new System.EventHandler(this.clr_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clr_btn);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.opr_choose);
            this.Controls.Add(this.input1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.ComboBox opr_choose;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Button clr_btn;
    }
}

