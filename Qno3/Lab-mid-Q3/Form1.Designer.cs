﻿namespace Lab_mid_Q3
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
            label1 = new Label();
            label2 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnGenerate_Click = new Button();
            label3 = new Label();
            txtGeneratedPassword = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(169, 104);
            label1.Name = "label1";
            label1.Size = new Size(117, 30);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(559, 107);
            label2.Name = "label2";
            label2.Size = new Size(114, 30);
            label2.TabIndex = 1;
            label2.Text = "Last Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(333, 107);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(167, 27);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(692, 108);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(167, 27);
            txtLastName.TabIndex = 3;
            // 
            // btnGenerate_Click
            // 
            btnGenerate_Click.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerate_Click.Location = new Point(404, 178);
            btnGenerate_Click.Margin = new Padding(3, 4, 3, 4);
            btnGenerate_Click.Name = "btnGenerate_Click";
            btnGenerate_Click.Size = new Size(227, 46);
            btnGenerate_Click.TabIndex = 4;
            btnGenerate_Click.Text = " Generate Password";
            btnGenerate_Click.UseVisualStyleBackColor = true;
            btnGenerate_Click.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(257, 292);
            label3.Name = "label3";
            label3.Size = new Size(140, 30);
            label3.TabIndex = 5;
            label3.Text = "OUTPUT BOX";
            // 
            // txtGeneratedPassword
            // 
            txtGeneratedPassword.Location = new Point(419, 276);
            txtGeneratedPassword.Margin = new Padding(3, 4, 3, 4);
            txtGeneratedPassword.Name = "txtGeneratedPassword";
            txtGeneratedPassword.Size = new Size(203, 46);
            txtGeneratedPassword.TabIndex = 6;
            txtGeneratedPassword.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlueViolet;
            ClientSize = new Size(918, 484);
            Controls.Add(txtGeneratedPassword);
            Controls.Add(label3);
            Controls.Add(btnGenerate_Click);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnGenerate_Click;
        private Label label3;
        private RichTextBox txtGeneratedPassword;
    }
}