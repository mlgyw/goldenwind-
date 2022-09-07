
namespace Magaz
{
    partial class Registration
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
            this.buttonRegistr = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.repasswordField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(346, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "REGISTRATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonRegistr
            // 
            this.buttonRegistr.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegistr.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonRegistr.Location = new System.Drawing.Point(354, 272);
            this.buttonRegistr.Name = "buttonRegistr";
            this.buttonRegistr.Size = new System.Drawing.Size(110, 30);
            this.buttonRegistr.TabIndex = 12;
            this.buttonRegistr.Text = "ACCEPT";
            this.buttonRegistr.UseVisualStyleBackColor = false;
            this.buttonRegistr.Click += new System.EventHandler(this.button1_Click);
            // 
            // passwordField
            // 
            this.passwordField.CausesValidation = false;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.passwordField.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.passwordField.Location = new System.Drawing.Point(323, 216);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(170, 22);
            this.passwordField.TabIndex = 11;
            this.passwordField.Text = "PASSWORD";
            this.passwordField.UseWaitCursor = true;
            this.passwordField.Click += new System.EventHandler(this.textBox2_Click);
            this.passwordField.TextChanged += new System.EventHandler(this.passwordField_TextChanged);
            // 
            // loginField
            // 
            this.loginField.CausesValidation = false;
            this.loginField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loginField.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.loginField.Location = new System.Drawing.Point(323, 190);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(170, 22);
            this.loginField.TabIndex = 10;
            this.loginField.Text = "LOGIN";
            this.loginField.UseWaitCursor = true;
            this.loginField.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Magaz.Properties.Resources.logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(147, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // repasswordField
            // 
            this.repasswordField.CausesValidation = false;
            this.repasswordField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.repasswordField.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repasswordField.ForeColor = System.Drawing.SystemColors.WindowText;
            this.repasswordField.Location = new System.Drawing.Point(323, 244);
            this.repasswordField.Name = "repasswordField";
            this.repasswordField.Size = new System.Drawing.Size(170, 22);
            this.repasswordField.TabIndex = 16;
            this.repasswordField.Text = "PASSWORD";
            this.repasswordField.UseWaitCursor = true;
            this.repasswordField.Click += new System.EventHandler(this.textBox3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(385, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "LOG IN";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            this.label4.MouseLeave += new System.EventHandler(this.label4_MouseLeave);
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magaz.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repasswordField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRegistr);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRegistr;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox repasswordField;
        private System.Windows.Forms.Label label4;
    }
}