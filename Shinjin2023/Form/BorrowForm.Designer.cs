
namespace Shinjin2023
{
    partial class BorrowForm
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
            this.dgv本一覧 = new System.Windows.Forms.DataGridView();
            this.CheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.User_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv予定一覧 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn貸出追加 = new System.Windows.Forms.Button();
            this.btn貸出削除 = new System.Windows.Forms.Button();
            this.btn追加 = new System.Windows.Forms.Button();
            this.btn編集 = new System.Windows.Forms.Button();
            this.btn貸出 = new System.Windows.Forms.Button();
            this.btn返却 = new System.Windows.Forms.Button();
            this.Txt検索 = new System.Windows.Forms.TextBox();
            this.pnl件数 = new System.Windows.Forms.Panel();
            this.LblLoginUserName = new System.Windows.Forms.Label();
            this.LblLoginUserSyozoku = new System.Windows.Forms.Label();
            this.lblシステム名 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn検索 = new System.Windows.Forms.Button();
            this.lblTOP画面 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl本一覧 = new System.Windows.Forms.Label();
            this.lbl予定一覧 = new System.Windows.Forms.Label();
            this.pnl社員名 = new System.Windows.Forms.Panel();
            this.lbl社員名 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv本一覧)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv予定一覧)).BeginInit();
            this.pnl件数.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.pnl社員名.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv本一覧
            // 
            this.dgv本一覧.AllowUserToAddRows = false;
            this.dgv本一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv本一覧.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckBox,
            this.Book_ID,
            this.Title,
            this.User_Name,
            this.Return_Date,
            this.Status_Name});
            this.dgv本一覧.Location = new System.Drawing.Point(12, 114);
            this.dgv本一覧.Name = "dgv本一覧";
            this.dgv本一覧.RowHeadersVisible = false;
            this.dgv本一覧.RowTemplate.Height = 21;
            this.dgv本一覧.Size = new System.Drawing.Size(643, 254);
            this.dgv本一覧.TabIndex = 6;
            this.dgv本一覧.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv本一覧_CellClick);
            // 
            // CheckBox
            // 
            this.CheckBox.HeaderText = "";
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Width = 50;
            // 
            // Book_ID
            // 
            this.Book_ID.DataPropertyName = "Book_ID";
            this.Book_ID.HeaderText = "本ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Width = 80;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "本タイトル";
            this.Title.Name = "Title";
            this.Title.Width = 250;
            // 
            // User_Name
            // 
            this.User_Name.DataPropertyName = "User_Name";
            this.User_Name.HeaderText = "社員名";
            this.User_Name.Name = "User_Name";
            this.User_Name.Width = 80;
            // 
            // Return_Date
            // 
            this.Return_Date.DataPropertyName = "Return_Date";
            this.Return_Date.HeaderText = "返却予定日";
            this.Return_Date.Name = "Return_Date";
            // 
            // Status_Name
            // 
            this.Status_Name.DataPropertyName = "Status_Name";
            this.Status_Name.HeaderText = "状態";
            this.Status_Name.Name = "Status_Name";
            this.Status_Name.Width = 80;
            // 
            // dgv予定一覧
            // 
            this.dgv予定一覧.AllowUserToAddRows = false;
            this.dgv予定一覧.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv予定一覧.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dgv予定一覧.Location = new System.Drawing.Point(744, 114);
            this.dgv予定一覧.Name = "dgv予定一覧";
            this.dgv予定一覧.RowHeadersVisible = false;
            this.dgv予定一覧.RowTemplate.Height = 21;
            this.dgv予定一覧.Size = new System.Drawing.Size(383, 254);
            this.dgv予定一覧.TabIndex = 7;
            this.dgv予定一覧.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "本ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "本タイトル";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // btn貸出追加
            // 
            this.btn貸出追加.Location = new System.Drawing.Point(663, 166);
            this.btn貸出追加.Name = "btn貸出追加";
            this.btn貸出追加.Size = new System.Drawing.Size(75, 23);
            this.btn貸出追加.TabIndex = 8;
            this.btn貸出追加.Text = "→";
            this.btn貸出追加.UseVisualStyleBackColor = true;
            this.btn貸出追加.Click += new System.EventHandler(this.btn貸出追加_Click);
            // 
            // btn貸出削除
            // 
            this.btn貸出削除.Location = new System.Drawing.Point(663, 232);
            this.btn貸出削除.Name = "btn貸出削除";
            this.btn貸出削除.Size = new System.Drawing.Size(75, 23);
            this.btn貸出削除.TabIndex = 9;
            this.btn貸出削除.Text = "←";
            this.btn貸出削除.UseVisualStyleBackColor = true;
            this.btn貸出削除.Click += new System.EventHandler(this.btn貸出削除_Click);
            // 
            // btn追加
            // 
            this.btn追加.BackColor = System.Drawing.Color.White;
            this.btn追加.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn追加.Location = new System.Drawing.Point(32, 18);
            this.btn追加.Name = "btn追加";
            this.btn追加.Size = new System.Drawing.Size(212, 44);
            this.btn追加.TabIndex = 10;
            this.btn追加.Text = "追加";
            this.btn追加.UseVisualStyleBackColor = false;
            this.btn追加.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // btn編集
            // 
            this.btn編集.BackColor = System.Drawing.Color.White;
            this.btn編集.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn編集.Location = new System.Drawing.Point(352, 18);
            this.btn編集.Name = "btn編集";
            this.btn編集.Size = new System.Drawing.Size(212, 44);
            this.btn編集.TabIndex = 11;
            this.btn編集.Text = "編集";
            this.btn編集.UseVisualStyleBackColor = false;
            this.btn編集.Click += new System.EventHandler(this.btn編集_Click);
            // 
            // btn貸出
            // 
            this.btn貸出.BackColor = System.Drawing.Color.White;
            this.btn貸出.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn貸出.Location = new System.Drawing.Point(831, 392);
            this.btn貸出.Name = "btn貸出";
            this.btn貸出.Size = new System.Drawing.Size(212, 44);
            this.btn貸出.TabIndex = 12;
            this.btn貸出.Text = "貸出";
            this.btn貸出.UseVisualStyleBackColor = false;
            this.btn貸出.Click += new System.EventHandler(this.btn貸出_Click);
            // 
            // btn返却
            // 
            this.btn返却.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn返却.Location = new System.Drawing.Point(1030, 41);
            this.btn返却.Name = "btn返却";
            this.btn返却.Size = new System.Drawing.Size(75, 26);
            this.btn返却.TabIndex = 13;
            this.btn返却.Text = "返却";
            this.btn返却.UseVisualStyleBackColor = true;
            this.btn返却.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Txt検索
            // 
            this.Txt検索.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Txt検索.Location = new System.Drawing.Point(17, 18);
            this.Txt検索.MaxLength = 5;
            this.Txt検索.Name = "Txt検索";
            this.Txt検索.Size = new System.Drawing.Size(161, 25);
            this.Txt検索.TabIndex = 14;
            // 
            // pnl件数
            // 
            this.pnl件数.AllowDrop = true;
            this.pnl件数.BackColor = System.Drawing.SystemColors.Window;
            this.pnl件数.Controls.Add(this.LblLoginUserName);
            this.pnl件数.Controls.Add(this.LblLoginUserSyozoku);
            this.pnl件数.Location = new System.Drawing.Point(887, 9);
            this.pnl件数.Name = "pnl件数";
            this.pnl件数.Size = new System.Drawing.Size(137, 26);
            this.pnl件数.TabIndex = 16;
            this.pnl件数.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl件数_Paint);
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
            // LblLoginUserSyozoku
            // 
            this.LblLoginUserSyozoku.AutoSize = true;
            this.LblLoginUserSyozoku.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.LblLoginUserSyozoku.Location = new System.Drawing.Point(3, 4);
            this.LblLoginUserSyozoku.Name = "LblLoginUserSyozoku";
            this.LblLoginUserSyozoku.Size = new System.Drawing.Size(0, 18);
            this.LblLoginUserSyozoku.TabIndex = 6;
            // 
            // lblシステム名
            // 
            this.lblシステム名.AutoSize = true;
            this.lblシステム名.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lblシステム名.Location = new System.Drawing.Point(12, 9);
            this.lblシステム名.Name = "lblシステム名";
            this.lblシステム名.Size = new System.Drawing.Size(99, 18);
            this.lblシステム名.TabIndex = 17;
            this.lblシステム名.Text = "RBshelfシステム";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn検索);
            this.groupBox1.Controls.Add(this.Txt検索);
            this.groupBox1.Location = new System.Drawing.Point(60, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 58);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "検索";
            // 
            // btn検索
            // 
            this.btn検索.Location = new System.Drawing.Point(184, 20);
            this.btn検索.Name = "btn検索";
            this.btn検索.Size = new System.Drawing.Size(75, 23);
            this.btn検索.TabIndex = 15;
            this.btn検索.Text = "🔍";
            this.btn検索.UseVisualStyleBackColor = true;
            // 
            // lblTOP画面
            // 
            this.lblTOP画面.AutoSize = true;
            this.lblTOP画面.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTOP画面.Location = new System.Drawing.Point(523, 13);
            this.lblTOP画面.Name = "lblTOP画面";
            this.lblTOP画面.Size = new System.Drawing.Size(93, 30);
            this.lblTOP画面.TabIndex = 19;
            this.lblTOP画面.Text = "TOP画面";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn編集);
            this.groupBox2.Controls.Add(this.btn追加);
            this.groupBox2.Location = new System.Drawing.Point(15, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(642, 93);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "管理者用";
            // 
            // lbl本一覧
            // 
            this.lbl本一覧.AutoSize = true;
            this.lbl本一覧.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lbl本一覧.Location = new System.Drawing.Point(241, 93);
            this.lbl本一覧.Name = "lbl本一覧";
            this.lbl本一覧.Size = new System.Drawing.Size(44, 18);
            this.lbl本一覧.TabIndex = 21;
            this.lbl本一覧.Text = "本一覧";
            // 
            // lbl予定一覧
            // 
            this.lbl予定一覧.AutoSize = true;
            this.lbl予定一覧.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lbl予定一覧.Location = new System.Drawing.Point(884, 93);
            this.lbl予定一覧.Name = "lbl予定一覧";
            this.lbl予定一覧.Size = new System.Drawing.Size(92, 18);
            this.lbl予定一覧.TabIndex = 22;
            this.lbl予定一覧.Text = "貸出予定本一覧";
            // 
            // pnl社員名
            // 
            this.pnl社員名.BackColor = System.Drawing.SystemColors.Window;
            this.pnl社員名.Controls.Add(this.lbl社員名);
            this.pnl社員名.Controls.Add(this.label4);
            this.pnl社員名.Controls.Add(this.label5);
            this.pnl社員名.Location = new System.Drawing.Point(887, 41);
            this.pnl社員名.Name = "pnl社員名";
            this.pnl社員名.Size = new System.Drawing.Size(137, 26);
            this.pnl社員名.TabIndex = 17;
            this.pnl社員名.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl社員名
            // 
            this.lbl社員名.AutoSize = true;
            this.lbl社員名.Location = new System.Drawing.Point(18, 8);
            this.lbl社員名.Name = "lbl社員名";
            this.lbl社員名.Size = new System.Drawing.Size(35, 12);
            this.lbl社員名.TabIndex = 9;
            this.lbl社員名.Text = "label1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(53, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 6;
            // 
            // BorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 479);
            this.Controls.Add(this.pnl社員名);
            this.Controls.Add(this.lbl予定一覧);
            this.Controls.Add(this.lbl本一覧);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn貸出);
            this.Controls.Add(this.lblTOP画面);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblシステム名);
            this.Controls.Add(this.pnl件数);
            this.Controls.Add(this.dgv本一覧);
            this.Controls.Add(this.btn返却);
            this.Controls.Add(this.btn貸出削除);
            this.Controls.Add(this.btn貸出追加);
            this.Controls.Add(this.dgv予定一覧);
            this.Name = "BorrowForm";
            this.Text = "BorrowForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BorrowForm_FormClosed);
            this.Load += new System.EventHandler(this.BorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv本一覧)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv予定一覧)).EndInit();
            this.pnl件数.ResumeLayout(false);
            this.pnl件数.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.pnl社員名.ResumeLayout(false);
            this.pnl社員名.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv本一覧;
        private System.Windows.Forms.DataGridView dgv予定一覧;
        private System.Windows.Forms.Button btn貸出追加;
        private System.Windows.Forms.Button btn貸出削除;
        private System.Windows.Forms.Button btn追加;
        private System.Windows.Forms.Button btn編集;
        private System.Windows.Forms.Button btn貸出;
        public System.Windows.Forms.Button btn返却;
        public System.Windows.Forms.TextBox Txt検索;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Panel pnl件数;
        public System.Windows.Forms.Label LblLoginUserName;
        public System.Windows.Forms.Label LblLoginUserSyozoku;
        private System.Windows.Forms.Label lblシステム名;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn検索;
        private System.Windows.Forms.Label lblTOP画面;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl本一覧;
        private System.Windows.Forms.Label lbl予定一覧;
        private System.Windows.Forms.Panel pnl社員名;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn User_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status_Name;
        private System.Windows.Forms.Label lbl社員名;
    }
}