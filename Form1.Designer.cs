﻿namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.wishList = new System.Windows.Forms.ListBox();
            this.fillB = new System.Windows.Forms.Button();
            this.sortB = new System.Windows.Forms.Button();
            this.clearB = new System.Windows.Forms.Button();
            this.countB = new System.Windows.Forms.Button();
            this.closeB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wish List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // wishList
            // 
            this.wishList.FormattingEnabled = true;
            this.wishList.Location = new System.Drawing.Point(35, 98);
            this.wishList.Name = "wishList";
            this.wishList.Size = new System.Drawing.Size(214, 264);
            this.wishList.TabIndex = 1;
            this.wishList.SelectedIndexChanged += new System.EventHandler(this.wishList_SelectedIndexChanged);
            // 
            // fillB
            // 
            this.fillB.Location = new System.Drawing.Point(297, 146);
            this.fillB.Name = "fillB";
            this.fillB.Size = new System.Drawing.Size(75, 23);
            this.fillB.TabIndex = 2;
            this.fillB.Text = "Fill";
            this.fillB.UseVisualStyleBackColor = true;
            this.fillB.Click += new System.EventHandler(this.fillB_Click);
            // 
            // sortB
            // 
            this.sortB.Location = new System.Drawing.Point(297, 185);
            this.sortB.Name = "sortB";
            this.sortB.Size = new System.Drawing.Size(75, 23);
            this.sortB.TabIndex = 3;
            this.sortB.Text = "Sort";
            this.sortB.UseVisualStyleBackColor = true;
            this.sortB.Click += new System.EventHandler(this.sortB_Click);
            // 
            // clearB
            // 
            this.clearB.Location = new System.Drawing.Point(297, 223);
            this.clearB.Name = "clearB";
            this.clearB.Size = new System.Drawing.Size(75, 23);
            this.clearB.TabIndex = 4;
            this.clearB.Text = "Clear";
            this.clearB.UseVisualStyleBackColor = true;
            this.clearB.Click += new System.EventHandler(this.clearB_Click);
            // 
            // countB
            // 
            this.countB.Location = new System.Drawing.Point(297, 262);
            this.countB.Name = "countB";
            this.countB.Size = new System.Drawing.Size(75, 23);
            this.countB.TabIndex = 5;
            this.countB.Text = "Count";
            this.countB.UseVisualStyleBackColor = true;
            this.countB.Click += new System.EventHandler(this.countB_Click);
            // 
            // closeB
            // 
            this.closeB.Location = new System.Drawing.Point(297, 300);
            this.closeB.Name = "closeB";
            this.closeB.Size = new System.Drawing.Size(75, 23);
            this.closeB.TabIndex = 6;
            this.closeB.Text = "Close";
            this.closeB.UseVisualStyleBackColor = true;
            this.closeB.Click += new System.EventHandler(this.closeB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Selection:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Count:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(102, 392);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(147, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 432);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 528);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.closeB);
            this.Controls.Add(this.countB);
            this.Controls.Add(this.clearB);
            this.Controls.Add(this.sortB);
            this.Controls.Add(this.fillB);
            this.Controls.Add(this.wishList);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wishList;
        private System.Windows.Forms.Button fillB;
        private System.Windows.Forms.Button sortB;
        private System.Windows.Forms.Button clearB;
        private System.Windows.Forms.Button countB;
        private System.Windows.Forms.Button closeB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

