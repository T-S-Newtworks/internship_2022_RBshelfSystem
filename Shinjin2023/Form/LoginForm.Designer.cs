
namespace Shinjin2023
{
    partial class LoginForm
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
            this.LblLogin = new System.Windows.Forms.Label();
            this.LblBorder = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.TxtLoginId = new System.Windows.Forms.TextBox();
            this.LblLoginId = new System.Windows.Forms.Label();
            this.LblPass = new System.Windows.Forms.Label();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblLogin
            // 
            this.LblLogin.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblLogin.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.LblLogin.Location = new System.Drawing.Point(9, 9);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(130, 27);
            this.LblLogin.TabIndex = 0;
            this.LblLogin.Text = "ユーザー管理システム";
            this.LblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblLogin.UseMnemonic = false;
            // 
            // LblBorder
            // 
            this.LblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBorder.Location = new System.Drawing.Point(12, 36);
            this.LblBorder.Name = "LblBorder";
            this.LblBorder.Size = new System.Drawing.Size(360, 1);
            this.LblBorder.TabIndex = 1;
            // 
            // TxtPass
            // 
            this.TxtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPass.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPass.Location = new System.Drawing.Point(94, 135);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(200, 25);
            this.TxtPass.TabIndex = 3;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.BackColor = System.Drawing.SystemColors.Window;
            this.BtnLogIn.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnLogIn.Location = new System.Drawing.Point(94, 189);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(200, 30);
            this.BtnLogIn.TabIndex = 4;
            this.BtnLogIn.Text = "ログイン";
            this.BtnLogIn.UseVisualStyleBackColor = false;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // TxtLoginId
            // 
            this.TxtLoginId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtLoginId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtLoginId.Location = new System.Drawing.Point(94, 86);
            this.TxtLoginId.MaxLength = 5;
            this.TxtLoginId.Name = "TxtLoginId";
            this.TxtLoginId.Size = new System.Drawing.Size(200, 25);
            this.TxtLoginId.TabIndex = 2;
            // 
            // LblLoginId
            // 
            this.LblLoginId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblLoginId.Location = new System.Drawing.Point(91, 65);
            this.LblLoginId.Name = "LblLoginId";
            this.LblLoginId.Size = new System.Drawing.Size(78, 18);
            this.LblLoginId.TabIndex = 5;
            this.LblLoginId.Text = "ログインID";
            // 
            // LblPass
            // 
            this.LblPass.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblPass.Location = new System.Drawing.Point(91, 114);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(78, 18);
            this.LblPass.TabIndex = 6;
            this.LblPass.Text = "パスワード";
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.AutoSize = true;
            this.LblErrorMessage.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessage.Location = new System.Drawing.Point(12, 46);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(0, 18);
            this.LblErrorMessage.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 245);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.LblLoginId);
            this.Controls.Add(this.BtnLogIn);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.TxtLoginId);
            this.Controls.Add(this.LblBorder);
            this.Controls.Add(this.LblLogin);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "ログイン";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblLogin;
        private System.Windows.Forms.Label LblBorder;
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Button BtnLogIn;
        private System.Windows.Forms.TextBox TxtLoginId;
        private System.Windows.Forms.Label LblLoginId;
        private System.Windows.Forms.Label LblPass;
        private System.Windows.Forms.Label LblErrorMessage;
    }
}