
namespace Shinjin2023
{
    partial class TopForm
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
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnUser = new System.Windows.Forms.Button();
            this.BtnA = new System.Windows.Forms.Button();
            this.BtnB = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.LblLoginUserSyozoku = new System.Windows.Forms.Label();
            this.PnlUserInfo = new System.Windows.Forms.Panel();
            this.LblLoginUserName = new System.Windows.Forms.Label();
            this.LblBorder = new System.Windows.Forms.Label();
            this.LblManagerTitle = new System.Windows.Forms.Label();
            this.LblManagerBorder = new System.Windows.Forms.Label();
            this.PnlUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.Font = new System.Drawing.Font("メイリオ", 15F);
            this.LblTitle.Location = new System.Drawing.Point(12, 3);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(776, 40);
            this.LblTitle.TabIndex = 0;
            this.LblTitle.Text = "ユーザー管理システム";
            this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnUser
            // 
            this.BtnUser.BackColor = System.Drawing.Color.White;
            this.BtnUser.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnUser.Location = new System.Drawing.Point(162, 229);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(212, 44);
            this.BtnUser.TabIndex = 1;
            this.BtnUser.Text = "ユーザー管理";
            this.BtnUser.UseVisualStyleBackColor = false;
            this.BtnUser.Visible = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnA
            // 
            this.BtnA.BackColor = System.Drawing.Color.White;
            this.BtnA.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnA.Location = new System.Drawing.Point(163, 95);
            this.BtnA.Name = "BtnA";
            this.BtnA.Size = new System.Drawing.Size(212, 44);
            this.BtnA.TabIndex = 2;
            this.BtnA.Text = "機能A";
            this.BtnA.UseVisualStyleBackColor = false;
            this.BtnA.Click += new System.EventHandler(this.BtnA_Click);
            // 
            // BtnB
            // 
            this.BtnB.BackColor = System.Drawing.Color.White;
            this.BtnB.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnB.Location = new System.Drawing.Point(381, 95);
            this.BtnB.Name = "BtnB";
            this.BtnB.Size = new System.Drawing.Size(212, 44);
            this.BtnB.TabIndex = 3;
            this.BtnB.Text = "機能B";
            this.BtnB.UseVisualStyleBackColor = false;
            this.BtnB.Click += new System.EventHandler(this.BtnB_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnLogOut.Location = new System.Drawing.Point(699, 12);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(89, 26);
            this.BtnLogOut.TabIndex = 5;
            this.BtnLogOut.Text = "ログアウト";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.BtnLogOut_Click);
            // 
            // LblLoginUserSyozoku
            // 
            this.LblLoginUserSyozoku.AutoSize = true;
            this.LblLoginUserSyozoku.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblLoginUserSyozoku.Location = new System.Drawing.Point(3, 4);
            this.LblLoginUserSyozoku.Name = "LblLoginUserSyozoku";
            this.LblLoginUserSyozoku.Size = new System.Drawing.Size(0, 18);
            this.LblLoginUserSyozoku.TabIndex = 6;
            // 
            // PnlUserInfo
            // 
            this.PnlUserInfo.BackColor = System.Drawing.SystemColors.Window;
            this.PnlUserInfo.Controls.Add(this.LblLoginUserName);
            this.PnlUserInfo.Controls.Add(this.LblLoginUserSyozoku);
            this.PnlUserInfo.Location = new System.Drawing.Point(556, 12);
            this.PnlUserInfo.Name = "PnlUserInfo";
            this.PnlUserInfo.Size = new System.Drawing.Size(137, 26);
            this.PnlUserInfo.TabIndex = 7;
            this.PnlUserInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlUserInfo_Paint);
            // 
            // LblLoginUserName
            // 
            this.LblLoginUserName.AutoSize = true;
            this.LblLoginUserName.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblLoginUserName.Location = new System.Drawing.Point(53, 4);
            this.LblLoginUserName.Name = "LblLoginUserName";
            this.LblLoginUserName.Size = new System.Drawing.Size(0, 18);
            this.LblLoginUserName.TabIndex = 8;
            // 
            // LblBorder
            // 
            this.LblBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblBorder.Location = new System.Drawing.Point(12, 49);
            this.LblBorder.Name = "LblBorder";
            this.LblBorder.Size = new System.Drawing.Size(776, 1);
            this.LblBorder.TabIndex = 8;
            // 
            // LblManagerTitle
            // 
            this.LblManagerTitle.Font = new System.Drawing.Font("メイリオ", 10F);
            this.LblManagerTitle.Location = new System.Drawing.Point(12, 160);
            this.LblManagerTitle.Name = "LblManagerTitle";
            this.LblManagerTitle.Size = new System.Drawing.Size(776, 40);
            this.LblManagerTitle.TabIndex = 9;
            this.LblManagerTitle.Text = "管理者機能";
            this.LblManagerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblManagerTitle.Visible = false;
            // 
            // LblManagerBorder
            // 
            this.LblManagerBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblManagerBorder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.LblManagerBorder.Location = new System.Drawing.Point(12, 200);
            this.LblManagerBorder.Name = "LblManagerBorder";
            this.LblManagerBorder.Size = new System.Drawing.Size(776, 1);
            this.LblManagerBorder.TabIndex = 10;
            this.LblManagerBorder.Visible = false;
            // 
            // TopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.LblManagerBorder);
            this.Controls.Add(this.LblManagerTitle);
            this.Controls.Add(this.LblBorder);
            this.Controls.Add(this.PnlUserInfo);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnB);
            this.Controls.Add(this.BtnA);
            this.Controls.Add(this.BtnUser);
            this.Controls.Add(this.LblTitle);
            this.MaximizeBox = false;
            this.Name = "TopForm";
            this.Text = "TOP";
            this.Load += new System.EventHandler(this.TopForm_Load);
            this.PnlUserInfo.ResumeLayout(false);
            this.PnlUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Button BtnUser;
        private System.Windows.Forms.Button BtnA;
        private System.Windows.Forms.Button BtnB;
        private System.Windows.Forms.Button BtnLogOut;
        public System.Windows.Forms.Label LblLoginUserSyozoku;
        private System.Windows.Forms.Panel PnlUserInfo;
        public System.Windows.Forms.Label LblLoginUserName;
        private System.Windows.Forms.Label LblBorder;
        public System.Windows.Forms.Label LblManagerTitle;
        public System.Windows.Forms.Label LblManagerBorder;
    }
}