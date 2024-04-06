namespace LoginForm1
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
            txtemail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtpw = new TextBox();
            btnlogin = new Button();
            SuspendLayout();
            // 
            // txtemail
            // 
            txtemail.Location = new Point(366, 124);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(170, 27);
            txtemail.TabIndex = 0;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(320, 43);
            label1.Name = "label1";
            label1.Size = new Size(174, 41);
            label1.TabIndex = 1;
            label1.Text = "LoginForm";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(237, 124);
            label2.Name = "label2";
            label2.Size = new Size(54, 23);
            label2.TabIndex = 2;
            label2.Text = "Email";
            label2.Click += this.label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(237, 200);
            label3.Name = "label3";
            label3.Size = new Size(86, 23);
            label3.TabIndex = 3;
            label3.Text = "Password";
            label3.Click += this.label3_Click;
            // 
            // txtpw
            // 
            txtpw.Location = new Point(366, 200);
            txtpw.Name = "txtpw";
            txtpw.Size = new Size(170, 27);
            txtpw.TabIndex = 4;
            txtpw.TextChanged += this.txtpw_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.IndianRed;
            btnlogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btnlogin.Location = new Point(375, 270);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(116, 42);
            btnlogin.TabIndex = 5;
            btnlogin.Text = "Sing in";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnlogin);
            Controls.Add(txtpw);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtemail);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtemail;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtpw;
        private Button btnlogin;
    }
}
