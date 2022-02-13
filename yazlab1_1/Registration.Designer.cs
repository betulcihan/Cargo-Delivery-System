
namespace yazlab1_1
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtRegisterPass = new System.Windows.Forms.TextBox();
            this.lblRegisterPass = new System.Windows.Forms.Label();
            this.txtRegisterUserName = new System.Windows.Forms.TextBox();
            this.lblRegisterUserName = new System.Windows.Forms.Label();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.btnGoBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.Location = new System.Drawing.Point(256, 244);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 37);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtRegisterPass
            // 
            this.txtRegisterPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterPass.Location = new System.Drawing.Point(186, 114);
            this.txtRegisterPass.Name = "txtRegisterPass";
            this.txtRegisterPass.Size = new System.Drawing.Size(188, 22);
            this.txtRegisterPass.TabIndex = 12;
            // 
            // lblRegisterPass
            // 
            this.lblRegisterPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegisterPass.AutoSize = true;
            this.lblRegisterPass.Location = new System.Drawing.Point(67, 114);
            this.lblRegisterPass.Name = "lblRegisterPass";
            this.lblRegisterPass.Size = new System.Drawing.Size(41, 17);
            this.lblRegisterPass.TabIndex = 11;
            this.lblRegisterPass.Text = "Şifre:";
            // 
            // txtRegisterUserName
            // 
            this.txtRegisterUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRegisterUserName.Location = new System.Drawing.Point(186, 55);
            this.txtRegisterUserName.Name = "txtRegisterUserName";
            this.txtRegisterUserName.Size = new System.Drawing.Size(188, 22);
            this.txtRegisterUserName.TabIndex = 10;
            // 
            // lblRegisterUserName
            // 
            this.lblRegisterUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRegisterUserName.AutoSize = true;
            this.lblRegisterUserName.Location = new System.Drawing.Point(67, 55);
            this.lblRegisterUserName.Name = "lblRegisterUserName";
            this.lblRegisterUserName.Size = new System.Drawing.Size(88, 17);
            this.lblRegisterUserName.TabIndex = 9;
            this.lblRegisterUserName.Text = "Kullanıcı Adı:";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmPass.Location = new System.Drawing.Point(186, 172);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(188, 22);
            this.txtConfirmPass.TabIndex = 15;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Location = new System.Drawing.Point(67, 172);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(90, 17);
            this.lblConfirmPass.TabIndex = 14;
            this.lblConfirmPass.Text = "Şifre Onayla:";
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoBack.Location = new System.Drawing.Point(95, 244);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(118, 37);
            this.btnGoBack.TabIndex = 16;
            this.btnGoBack.Text = "Geri Dön";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 341);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtRegisterPass);
            this.Controls.Add(this.lblRegisterPass);
            this.Controls.Add(this.txtRegisterUserName);
            this.Controls.Add(this.lblRegisterUserName);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtRegisterPass;
        private System.Windows.Forms.Label lblRegisterPass;
        private System.Windows.Forms.TextBox txtRegisterUserName;
        private System.Windows.Forms.Label lblRegisterUserName;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Button btnGoBack;
    }
}