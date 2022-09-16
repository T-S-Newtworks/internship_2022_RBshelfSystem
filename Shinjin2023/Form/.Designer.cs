
namespace Shinjin2023
{
    partial class ReturnBookForm
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
            this.dgv返却 = new System.Windows.Forms.DataGridView();
            this.btn返却閉じる = new System.Windows.Forms.Button();
            this.btn返却確定 = new System.Windows.Forms.Button();
            this.btn全選択 = new System.Windows.Forms.Button();
            this.lblシステム名 = new System.Windows.Forms.Label();
            this.lbl返却 = new System.Windows.Forms.Label();
            this.Checkbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Return_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv返却)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv返却
            // 
            this.dgv返却.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv返却.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checkbox,
            this.Book_ID,
            this.Title,
            this.Return_Date});
            this.dgv返却.Location = new System.Drawing.Point(175, 96);
            this.dgv返却.Name = "dgv返却";
            this.dgv返却.RowHeadersVisible = false;
            this.dgv返却.RowTemplate.Height = 21;
            this.dgv返却.Size = new System.Drawing.Size(513, 317);
            this.dgv返却.TabIndex = 0;
            this.dgv返却.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv返却_CellContentClick);
            // 
            // btn返却閉じる
            // 
            this.btn返却閉じる.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn返却閉じる.Location = new System.Drawing.Point(175, 429);
            this.btn返却閉じる.Name = "btn返却閉じる";
            this.btn返却閉じる.Size = new System.Drawing.Size(75, 26);
            this.btn返却閉じる.TabIndex = 18;
            this.btn返却閉じる.Text = "閉じる";
            this.btn返却閉じる.UseVisualStyleBackColor = true;
            this.btn返却閉じる.Click += new System.EventHandler(this.btn返却閉じる_Click);
            // 
            // btn返却確定
            // 
            this.btn返却確定.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn返却確定.Location = new System.Drawing.Point(613, 429);
            this.btn返却確定.Name = "btn返却確定";
            this.btn返却確定.Size = new System.Drawing.Size(75, 26);
            this.btn返却確定.TabIndex = 19;
            this.btn返却確定.Text = "確定";
            this.btn返却確定.UseVisualStyleBackColor = true;
            this.btn返却確定.Click += new System.EventHandler(this.btn返却確定_Click);
            // 
            // btn全選択
            // 
            this.btn全選択.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn全選択.Location = new System.Drawing.Point(175, 47);
            this.btn全選択.Name = "btn全選択";
            this.btn全選択.Size = new System.Drawing.Size(75, 26);
            this.btn全選択.TabIndex = 20;
            this.btn全選択.Text = "全選択";
            this.btn全選択.UseVisualStyleBackColor = true;
            // 
            // lblシステム名
            // 
            this.lblシステム名.AutoSize = true;
            this.lblシステム名.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lblシステム名.Location = new System.Drawing.Point(12, 9);
            this.lblシステム名.Name = "lblシステム名";
            this.lblシステム名.Size = new System.Drawing.Size(99, 18);
            this.lblシステム名.TabIndex = 21;
            this.lblシステム名.Text = "RBshelfシステム";
            // 
            // lbl返却
            // 
            this.lbl返却.AutoSize = true;
            this.lbl返却.Font = new System.Drawing.Font("メイリオ", 15F);
            this.lbl返却.Location = new System.Drawing.Point(390, 9);
            this.lbl返却.Name = "lbl返却";
            this.lbl返却.Size = new System.Drawing.Size(93, 30);
            this.lbl返却.TabIndex = 22;
            this.lbl返却.Text = "返却画面";
            // 
            // Checkbox
            // 
            this.Checkbox.HeaderText = "";
            this.Checkbox.Name = "Checkbox";
            this.Checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Checkbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Checkbox.Width = 50;
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
            this.Title.HeaderText = "本のタイトル";
            this.Title.Name = "Title";
            this.Title.Width = 250;
            // 
            // Return_Date
            // 
            this.Return_Date.DataPropertyName = "Return_Date";
            this.Return_Date.HeaderText = "返却予定日";
            this.Return_Date.Name = "Return_Date";
            this.Return_Date.Width = 130;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 490);
            this.Controls.Add(this.lbl返却);
            this.Controls.Add(this.lblシステム名);
            this.Controls.Add(this.btn全選択);
            this.Controls.Add(this.btn返却確定);
            this.Controls.Add(this.btn返却閉じる);
            this.Controls.Add(this.dgv返却);
            this.Name = "ReturnBookForm";
            this.Text = "本の返却";
            this.Load += new System.EventHandler(this.ReturnBookForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv返却)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv返却;
        public System.Windows.Forms.Button btn返却閉じる;
        public System.Windows.Forms.Button btn返却確定;
        public System.Windows.Forms.Button btn全選択;
        private System.Windows.Forms.Label lblシステム名;
        private System.Windows.Forms.Label lbl返却;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checkbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Return_Date;
    }
}