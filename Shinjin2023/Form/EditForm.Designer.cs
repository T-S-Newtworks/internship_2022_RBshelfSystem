
namespace Shinjin2023
{
    partial class EditForm
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
            this.LblUserId = new System.Windows.Forms.Label();
            this.LblUserName = new System.Windows.Forms.Label();
            this.LblSyozoku = new System.Windows.Forms.Label();
            this.LblKengen = new System.Windows.Forms.Label();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.LblRequiredUserName = new System.Windows.Forms.Label();
            this.CmbSyozoku = new System.Windows.Forms.ComboBox();
            this.CmbKengen = new System.Windows.Forms.ComboBox();
            this.LblPass = new System.Windows.Forms.Label();
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblRequiredPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblUserId
            // 
            this.LblUserId.AutoSize = true;
            this.LblUserId.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblUserId.Location = new System.Drawing.Point(12, 54);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(58, 18);
            this.LblUserId.TabIndex = 0;
            this.LblUserId.Text = "ユーザID";
            // 
            // LblUserName
            // 
            this.LblUserName.AutoSize = true;
            this.LblUserName.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblUserName.Location = new System.Drawing.Point(13, 88);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(32, 18);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "名前";
            // 
            // LblSyozoku
            // 
            this.LblSyozoku.AutoSize = true;
            this.LblSyozoku.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblSyozoku.Location = new System.Drawing.Point(13, 123);
            this.LblSyozoku.Name = "LblSyozoku";
            this.LblSyozoku.Size = new System.Drawing.Size(68, 18);
            this.LblSyozoku.TabIndex = 2;
            this.LblSyozoku.Text = "所属コード";
            // 
            // LblKengen
            // 
            this.LblKengen.AutoSize = true;
            this.LblKengen.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblKengen.Location = new System.Drawing.Point(13, 159);
            this.LblKengen.Name = "LblKengen";
            this.LblKengen.Size = new System.Drawing.Size(32, 18);
            this.LblKengen.TabIndex = 3;
            this.LblKengen.Text = "権限";
            // 
            // TxtUserId
            // 
            this.TxtUserId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtUserId.Location = new System.Drawing.Point(92, 51);
            this.TxtUserId.MaxLength = 5;
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.ReadOnly = true;
            this.TxtUserId.Size = new System.Drawing.Size(161, 25);
            this.TxtUserId.TabIndex = 4;
            this.TxtUserId.TextChanged += new System.EventHandler(this.TxtUserId_TextChanged);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtUserName.Location = new System.Drawing.Point(92, 85);
            this.TxtUserName.MaxLength = 5;
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(161, 25);
            this.TxtUserName.TabIndex = 5;
            this.TxtUserName.TextChanged += new System.EventHandler(this.TxtUserName_TextChanged);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnEdit.Location = new System.Drawing.Point(97, 12);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 26);
            this.BtnEdit.TabIndex = 8;
            this.BtnEdit.Text = "更新";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Red;
            this.BtnDelete.Location = new System.Drawing.Point(178, 12);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 26);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "削除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // LblRequiredUserName
            // 
            this.LblRequiredUserName.AutoSize = true;
            this.LblRequiredUserName.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblRequiredUserName.ForeColor = System.Drawing.Color.Red;
            this.LblRequiredUserName.Location = new System.Drawing.Point(2, 88);
            this.LblRequiredUserName.Name = "LblRequiredUserName";
            this.LblRequiredUserName.Size = new System.Drawing.Size(15, 18);
            this.LblRequiredUserName.TabIndex = 11;
            this.LblRequiredUserName.Text = "*";
            // 
            // CmbSyozoku
            // 
            this.CmbSyozoku.BackColor = System.Drawing.SystemColors.Window;
            this.CmbSyozoku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSyozoku.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CmbSyozoku.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbSyozoku.FormattingEnabled = true;
            this.CmbSyozoku.Location = new System.Drawing.Point(92, 120);
            this.CmbSyozoku.Name = "CmbSyozoku";
            this.CmbSyozoku.Size = new System.Drawing.Size(161, 26);
            this.CmbSyozoku.TabIndex = 12;
            this.CmbSyozoku.SelectedIndexChanged += new System.EventHandler(this.CmbSyozoku_SelectedIndexChanged);
            // 
            // CmbKengen
            // 
            this.CmbKengen.BackColor = System.Drawing.SystemColors.Window;
            this.CmbKengen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKengen.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CmbKengen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbKengen.FormattingEnabled = true;
            this.CmbKengen.Location = new System.Drawing.Point(92, 156);
            this.CmbKengen.Name = "CmbKengen";
            this.CmbKengen.Size = new System.Drawing.Size(161, 26);
            this.CmbKengen.TabIndex = 13;
            this.CmbKengen.SelectedIndexChanged += new System.EventHandler(this.CmbKengen_SelectedIndexChanged);
            // 
            // LblPass
            // 
            this.LblPass.AutoSize = true;
            this.LblPass.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblPass.Location = new System.Drawing.Point(13, 194);
            this.LblPass.Name = "LblPass";
            this.LblPass.Size = new System.Drawing.Size(68, 18);
            this.LblPass.TabIndex = 14;
            this.LblPass.Text = "パスワード";
            // 
            // TxtPass
            // 
            this.TxtPass.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtPass.Location = new System.Drawing.Point(92, 191);
            this.TxtPass.MaxLength = 100;
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.Size = new System.Drawing.Size(161, 25);
            this.TxtPass.TabIndex = 15;
            this.TxtPass.UseSystemPasswordChar = true;
            // 
            // LblRequiredPass
            // 
            this.LblRequiredPass.AutoSize = true;
            this.LblRequiredPass.Font = new System.Drawing.Font("メイリオ", 9F);
            this.LblRequiredPass.ForeColor = System.Drawing.Color.Red;
            this.LblRequiredPass.Location = new System.Drawing.Point(2, 191);
            this.LblRequiredPass.Name = "LblRequiredPass";
            this.LblRequiredPass.Size = new System.Drawing.Size(15, 18);
            this.LblRequiredPass.TabIndex = 16;
            this.LblRequiredPass.Text = "*";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 232);
            this.Controls.Add(this.LblRequiredPass);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LblPass);
            this.Controls.Add(this.CmbKengen);
            this.Controls.Add(this.CmbSyozoku);
            this.Controls.Add(this.LblRequiredUserName);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.TxtUserId);
            this.Controls.Add(this.LblKengen);
            this.Controls.Add(this.LblSyozoku);
            this.Controls.Add(this.LblUserName);
            this.Controls.Add(this.LblUserId);
            this.Name = "EditForm";
            this.Text = "編集";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.Label LblSyozoku;
        private System.Windows.Forms.Label LblKengen;
        public System.Windows.Forms.TextBox TxtUserId;
        public System.Windows.Forms.TextBox TxtUserName;
        public System.Windows.Forms.Button BtnEdit;
        public System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label LblRequiredUserName;
        public System.Windows.Forms.ComboBox CmbSyozoku;
        public System.Windows.Forms.ComboBox CmbKengen;
        private System.Windows.Forms.Label LblPass;
        public System.Windows.Forms.TextBox TxtPass;
        public System.Windows.Forms.Label LblRequiredPass;
    }
}