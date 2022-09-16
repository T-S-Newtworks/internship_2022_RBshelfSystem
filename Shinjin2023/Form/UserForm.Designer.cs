
namespace Shinjin2023
{
    partial class UserForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PnlSearch = new System.Windows.Forms.Panel();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.CmbSyozoku = new System.Windows.Forms.ComboBox();
            this.LblSyozoku = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUserName = new System.Windows.Forms.Label();
            this.TxtUserId = new System.Windows.Forms.TextBox();
            this.LblUserId = new System.Windows.Forms.Label();
            this.DgvUsers = new System.Windows.Forms.DataGridView();
            this.BtnClose = new System.Windows.Forms.Button();
            this.LblErrorMessage = new System.Windows.Forms.Label();
            this.PnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlSearch
            // 
            this.PnlSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PnlSearch.Controls.Add(this.BtnClear);
            this.PnlSearch.Controls.Add(this.BtnSearch);
            this.PnlSearch.Controls.Add(this.CmbSyozoku);
            this.PnlSearch.Controls.Add(this.LblSyozoku);
            this.PnlSearch.Controls.Add(this.TxtUserName);
            this.PnlSearch.Controls.Add(this.LblUserName);
            this.PnlSearch.Controls.Add(this.TxtUserId);
            this.PnlSearch.Controls.Add(this.LblUserId);
            this.PnlSearch.Location = new System.Drawing.Point(12, 12);
            this.PnlSearch.Name = "PnlSearch";
            this.PnlSearch.Size = new System.Drawing.Size(776, 62);
            this.PnlSearch.TabIndex = 0;
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClear.Location = new System.Drawing.Point(685, 18);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 26);
            this.BtnClear.TabIndex = 1;
            this.BtnClear.Text = "クリア";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnSearch.Location = new System.Drawing.Point(604, 18);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 26);
            this.BtnSearch.TabIndex = 1;
            this.BtnSearch.Text = "検索";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // CmbSyozoku
            // 
            this.CmbSyozoku.BackColor = System.Drawing.SystemColors.Window;
            this.CmbSyozoku.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSyozoku.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CmbSyozoku.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CmbSyozoku.FormattingEnabled = true;
            this.CmbSyozoku.Location = new System.Drawing.Point(448, 17);
            this.CmbSyozoku.Name = "CmbSyozoku";
            this.CmbSyozoku.Size = new System.Drawing.Size(150, 26);
            this.CmbSyozoku.TabIndex = 1;
            this.CmbSyozoku.SelectedIndexChanged += new System.EventHandler(this.CmbSyozoku_SelectedIndexChanged);
            // 
            // LblSyozoku
            // 
            this.LblSyozoku.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblSyozoku.Location = new System.Drawing.Point(406, 21);
            this.LblSyozoku.Name = "LblSyozoku";
            this.LblSyozoku.Size = new System.Drawing.Size(36, 18);
            this.LblSyozoku.TabIndex = 2;
            this.LblSyozoku.Text = "所属";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtUserName.Location = new System.Drawing.Point(250, 18);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(150, 25);
            this.TxtUserName.TabIndex = 1;
            // 
            // LblUserName
            // 
            this.LblUserName.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblUserName.Location = new System.Drawing.Point(210, 21);
            this.LblUserName.Name = "LblUserName";
            this.LblUserName.Size = new System.Drawing.Size(34, 18);
            this.LblUserName.TabIndex = 1;
            this.LblUserName.Text = "名前";
            // 
            // TxtUserId
            // 
            this.TxtUserId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TxtUserId.Location = new System.Drawing.Point(91, 18);
            this.TxtUserId.MaxLength = 5;
            this.TxtUserId.Name = "TxtUserId";
            this.TxtUserId.Size = new System.Drawing.Size(100, 25);
            this.TxtUserId.TabIndex = 1;
            // 
            // LblUserId
            // 
            this.LblUserId.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblUserId.Location = new System.Drawing.Point(18, 21);
            this.LblUserId.Name = "LblUserId";
            this.LblUserId.Size = new System.Drawing.Size(67, 18);
            this.LblUserId.TabIndex = 1;
            this.LblUserId.Text = "ユーザID";
            // 
            // DgvUsers
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.DgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.DgvUsers.Location = new System.Drawing.Point(12, 100);
            this.DgvUsers.Name = "DgvUsers";
            this.DgvUsers.ReadOnly = true;
            this.DgvUsers.RowTemplate.Height = 21;
            this.DgvUsers.Size = new System.Drawing.Size(776, 285);
            this.DgvUsers.TabIndex = 1;
            this.DgvUsers.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvUsers_CellDoubleClick);
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.BtnClose.Location = new System.Drawing.Point(698, 403);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 26);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Text = "閉じる";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblErrorMessage
            // 
            this.LblErrorMessage.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.LblErrorMessage.Location = new System.Drawing.Point(12, 77);
            this.LblErrorMessage.Name = "LblErrorMessage";
            this.LblErrorMessage.Size = new System.Drawing.Size(307, 20);
            this.LblErrorMessage.TabIndex = 3;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblErrorMessage);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.DgvUsers);
            this.Controls.Add(this.PnlSearch);
            this.MaximizeBox = false;
            this.Name = "UserForm";
            this.Text = "ユーザ管理";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.PnlSearch.ResumeLayout(false);
            this.PnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlSearch;
        private System.Windows.Forms.TextBox TxtUserId;
        private System.Windows.Forms.Label LblUserId;
        private System.Windows.Forms.Button BtnClear;
        public System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.ComboBox CmbSyozoku;
        private System.Windows.Forms.Label LblSyozoku;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUserName;
        private System.Windows.Forms.DataGridView DgvUsers;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label LblErrorMessage;
    }
}

