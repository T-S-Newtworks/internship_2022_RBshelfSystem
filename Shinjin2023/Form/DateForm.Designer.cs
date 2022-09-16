
namespace Shinjin2023
{
    partial class DateForm
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
            this.dgv貸出 = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn閉じる = new System.Windows.Forms.Button();
            this.btn確定 = new System.Windows.Forms.Button();
            this.lbl貸出期限決定画面 = new System.Windows.Forms.Label();
            this.btn一括 = new System.Windows.Forms.Button();
            this.lblシステム名 = new System.Windows.Forms.Label();
            this.pnl社員名 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl社員名 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv貸出)).BeginInit();
            this.pnl社員名.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv貸出
            // 
            this.dgv貸出.AllowUserToAddRows = false;
            this.dgv貸出.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv貸出.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.Title,
            this.Return_Date});
            this.dgv貸出.Location = new System.Drawing.Point(158, 101);
            this.dgv貸出.Name = "dgv貸出";
            this.dgv貸出.RowHeadersVisible = false;
            this.dgv貸出.RowTemplate.Height = 21;
            this.dgv貸出.Size = new System.Drawing.Size(463, 240);
            this.dgv貸出.TabIndex = 0;
            this.dgv貸出.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Book_ID
            // 
            this.Book_ID.HeaderText = "本ID";
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.ReadOnly = true;
            this.Book_ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Book_ID.Width = 80;
            // 
            // Title
            // 
            this.Title.HeaderText = "本タイトル";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 250;
            // 
            // Return_Date
            // 
            this.Return_Date.HeaderText = "返却予定日";
            this.Return_Date.Name = "Return_Date";
            this.Return_Date.Width = 130;
            // 
            // btn閉じる
            // 
            this.btn閉じる.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn閉じる.Location = new System.Drawing.Point(158, 369);
            this.btn閉じる.Name = "btn閉じる";
            this.btn閉じる.Size = new System.Drawing.Size(75, 26);
            this.btn閉じる.TabIndex = 4;
            this.btn閉じる.Text = "閉じる";
            this.btn閉じる.UseVisualStyleBackColor = true;
            this.btn閉じる.Click += new System.EventHandler(this.btn閉じる_Click);
            // 
            // btn確定
            // 
            this.btn確定.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn確定.Location = new System.Drawing.Point(546, 369);
            this.btn確定.Name = "btn確定";
            this.btn確定.Size = new System.Drawing.Size(75, 26);
            this.btn確定.TabIndex = 5;
            this.btn確定.Text = "確定";
            this.btn確定.UseVisualStyleBackColor = true;
            this.btn確定.Click += new System.EventHandler(this.btn確定_Click);
            // 
            // lbl貸出期限決定画面
            // 
            this.lbl貸出期限決定画面.AutoSize = true;
            this.lbl貸出期限決定画面.Font = new System.Drawing.Font("メイリオ", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl貸出期限決定画面.Location = new System.Drawing.Point(316, 9);
            this.lbl貸出期限決定画面.Name = "lbl貸出期限決定画面";
            this.lbl貸出期限決定画面.Size = new System.Drawing.Size(173, 30);
            this.lbl貸出期限決定画面.TabIndex = 20;
            this.lbl貸出期限決定画面.Text = "貸出期限決定画面";
            // 
            // btn一括
            // 
            this.btn一括.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn一括.Location = new System.Drawing.Point(546, 58);
            this.btn一括.Name = "btn一括";
            this.btn一括.Size = new System.Drawing.Size(75, 26);
            this.btn一括.TabIndex = 21;
            this.btn一括.Text = "一括";
            this.btn一括.UseVisualStyleBackColor = true;
            this.btn一括.Click += new System.EventHandler(this.btn一括_Click);
            // 
            // lblシステム名
            // 
            this.lblシステム名.AutoSize = true;
            this.lblシステム名.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lblシステム名.Location = new System.Drawing.Point(12, 9);
            this.lblシステム名.Name = "lblシステム名";
            this.lblシステム名.Size = new System.Drawing.Size(99, 18);
            this.lblシステム名.TabIndex = 22;
            this.lblシステム名.Text = "RBshelfシステム";
            // 
            // pnl社員名
            // 
            this.pnl社員名.BackColor = System.Drawing.SystemColors.Window;
            this.pnl社員名.Controls.Add(this.lbl社員名);
            this.pnl社員名.Controls.Add(this.label4);
            this.pnl社員名.Controls.Add(this.label5);
            this.pnl社員名.Location = new System.Drawing.Point(651, 9);
            this.pnl社員名.Name = "pnl社員名";
            this.pnl社員名.Size = new System.Drawing.Size(137, 26);
            this.pnl社員名.TabIndex = 23;
            this.pnl社員名.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl社員名_Paint);
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
            // lbl社員名
            // 
            this.lbl社員名.AutoSize = true;
            this.lbl社員名.Location = new System.Drawing.Point(39, 7);
            this.lbl社員名.Name = "lbl社員名";
            this.lbl社員名.Size = new System.Drawing.Size(35, 12);
            this.lbl社員名.TabIndex = 9;
            this.lbl社員名.Text = "label1";
            // 
            // DateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnl社員名);
            this.Controls.Add(this.lblシステム名);
            this.Controls.Add(this.btn一括);
            this.Controls.Add(this.lbl貸出期限決定画面);
            this.Controls.Add(this.btn確定);
            this.Controls.Add(this.btn閉じる);
            this.Controls.Add(this.dgv貸出);
            this.Name = "DateForm";
            this.Text = "DateForm";
            this.Load += new System.EventHandler(this.DateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv貸出)).EndInit();
            this.pnl社員名.ResumeLayout(false);
            this.pnl社員名.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv貸出;
        private System.Windows.Forms.Button btn閉じる;
        private System.Windows.Forms.Button btn確定;
        private System.Windows.Forms.Label lbl貸出期限決定画面;
        private System.Windows.Forms.Button btn一括;
        private System.Windows.Forms.Label lblシステム名;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
        private System.Windows.Forms.Panel pnl社員名;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl社員名;
    }
}