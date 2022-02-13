
namespace yazlab1_1
{
    partial class ForgotPassword
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
            this.btnGoBack = new System.Windows.Forms.Button();
            this.txtConfirmNewPass = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPass = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.lbNewPass = new System.Windows.Forms.Label();
            this.txtForgotUserName = new System.Windows.Forms.TextBox();
            this.lbForgotUserName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGoBack
            // 
            this.btnGoBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGoBack.Location = new System.Drawing.Point(83, 239);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(118, 37);
            this.btnGoBack.TabIndex = 24;
            this.btnGoBack.Text = "Geri Dön";
            this.btnGoBack.UseVisualStyleBackColor = true;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // txtConfirmNewPass
            // 
            this.txtConfirmNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtConfirmNewPass.Location = new System.Drawing.Point(174, 167);
            this.txtConfirmNewPass.Name = "txtConfirmNewPass";
            this.txtConfirmNewPass.Size = new System.Drawing.Size(188, 22);
            this.txtConfirmNewPass.TabIndex = 23;
            // 
            // lblConfirmNewPass
            // 
            this.lblConfirmNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblConfirmNewPass.AutoSize = true;
            this.lblConfirmNewPass.Location = new System.Drawing.Point(55, 167);
            this.lblConfirmNewPass.Name = "lblConfirmNewPass";
            this.lblConfirmNewPass.Size = new System.Drawing.Size(90, 17);
            this.lblConfirmNewPass.TabIndex = 22;
            this.lblConfirmNewPass.Text = "Şifre Onayla:";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSave.Location = new System.Drawing.Point(244, 239);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 37);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNewPass.Location = new System.Drawing.Point(174, 109);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(188, 22);
            this.txtNewPass.TabIndex = 20;
            // 
            // lbNewPass
            // 
            this.lbNewPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbNewPass.AutoSize = true;
            this.lbNewPass.Location = new System.Drawing.Point(55, 109);
            this.lbNewPass.Name = "lbNewPass";
            this.lbNewPass.Size = new System.Drawing.Size(73, 17);
            this.lbNewPass.TabIndex = 19;
            this.lbNewPass.Text = "Yeni Şifre:";
            // 
            // txtForgotUserName
            // 
            this.txtForgotUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtForgotUserName.Location = new System.Drawing.Point(174, 50);
            this.txtForgotUserName.Name = "txtForgotUserName";
            this.txtForgotUserName.Size = new System.Drawing.Size(188, 22);
            this.txtForgotUserName.TabIndex = 18;
            // 
            // lbForgotUserName
            // 
            this.lbForgotUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbForgotUserName.AutoSize = true;
            this.lbForgotUserName.Location = new System.Drawing.Point(55, 50);
            this.lbForgotUserName.Name = "lbForgotUserName";
            this.lbForgotUserName.Size = new System.Drawing.Size(88, 17);
            this.lbForgotUserName.TabIndex = 17;
            this.lbForgotUserName.Text = "Kullanıcı Adı:";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 336);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.txtConfirmNewPass);
            this.Controls.Add(this.lblConfirmNewPass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.lbNewPass);
            this.Controls.Add(this.txtForgotUserName);
            this.Controls.Add(this.lbForgotUserName);
            this.Name = "ForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Şifremi Unuttum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGoBack;
        private System.Windows.Forms.TextBox txtConfirmNewPass;
        private System.Windows.Forms.Label lblConfirmNewPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label lbNewPass;
        private System.Windows.Forms.TextBox txtForgotUserName;
        private System.Windows.Forms.Label lbForgotUserName;
    }
}