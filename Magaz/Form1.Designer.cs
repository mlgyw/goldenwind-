
namespace Magaz
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Magaz.Properties.Resources.logo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(146, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(505, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loginField
            // 
            this.loginField.BackColor = System.Drawing.SystemColors.Window;
            this.loginField.CausesValidation = false;
            this.loginField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.loginField.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.loginField.Location = new System.Drawing.Point(323, 190);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(170, 22);
            this.loginField.TabIndex = 3;
            this.loginField.Text = "LOGIN";
            this.loginField.UseWaitCursor = true;
            this.loginField.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // passwordField
            // 
            this.passwordField.CausesValidation = false;
            this.passwordField.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.passwordField.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordField.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordField.Location = new System.Drawing.Point(323, 216);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(170, 22);
            this.passwordField.TabIndex = 4;
            this.passwordField.Text = "PASSWORD";
            this.passwordField.UseWaitCursor = true;
            this.passwordField.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogin.BackColor = System.Drawing.SystemColors.Window;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogin.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonLogin.Location = new System.Drawing.Point(353, 244);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(110, 30);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "ACCEPT";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(363, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "REGISTRATION";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Magaz.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox loginField;
        public System.Windows.Forms.TextBox passwordField;
    }
}

