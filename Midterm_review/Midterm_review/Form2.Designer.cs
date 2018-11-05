namespace Midterm_review
{
    partial class portfolio_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_stockvalue = new System.Windows.Forms.TextBox();
            this.txt_portvalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtrich_list = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Portfolio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stock Value:";
            // 
            // txt_stockvalue
            // 
            this.txt_stockvalue.Location = new System.Drawing.Point(99, 248);
            this.txt_stockvalue.Name = "txt_stockvalue";
            this.txt_stockvalue.Size = new System.Drawing.Size(100, 20);
            this.txt_stockvalue.TabIndex = 3;
            // 
            // txt_portvalue
            // 
            this.txt_portvalue.Location = new System.Drawing.Point(302, 251);
            this.txt_portvalue.Name = "txt_portvalue";
            this.txt_portvalue.Size = new System.Drawing.Size(100, 20);
            this.txt_portvalue.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Portfolio Value:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(419, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtrich_list
            // 
            this.txtrich_list.FormattingEnabled = true;
            this.txtrich_list.Location = new System.Drawing.Point(28, 53);
            this.txtrich_list.Name = "txtrich_list";
            this.txtrich_list.Size = new System.Drawing.Size(466, 186);
            this.txtrich_list.TabIndex = 7;
            this.txtrich_list.SelectedIndexChanged += new System.EventHandler(this.txtrich_list_SelectedIndexChanged);
            // 
            // portfolio_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 320);
            this.Controls.Add(this.txtrich_list);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_portvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_stockvalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "portfolio_form";
            this.Text = "Portfolio Summary";
            this.Load += new System.EventHandler(this.portfolio_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_stockvalue;
        private System.Windows.Forms.TextBox txt_portvalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox txtrich_list;
    }
}