
namespace Shinjin2023
{
    partial class EditBookForm
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
            this.txtタイトル = new System.Windows.Forms.TextBox();
            this.lbl本ID = new System.Windows.Forms.Label();
            this.lblステータス = new System.Windows.Forms.Label();
            this.lbl登録者 = new System.Windows.Forms.Label();
            this.lblタイトル = new System.Windows.Forms.Label();
            this.btn追加確定 = new System.Windows.Forms.Button();
            this.btn追加閉じる = new System.Windows.Forms.Button();
            this.cmbステータス = new System.Windows.Forms.ComboBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.tableLayoutPanelAdd = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelEdit = new System.Windows.Forms.TableLayoutPanel();
            this.btn削除 = new System.Windows.Forms.Button();
            this.btn編集確定 = new System.Windows.Forms.Button();
            this.btn編集閉じる = new System.Windows.Forms.Button();
            this.txt本ID = new System.Windows.Forms.TextBox();
            this.txt登録者 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanelAdd.SuspendLayout();
            this.tableLayoutPanelEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtタイトル
            // 
            this.txtタイトル.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtタイトル.Location = new System.Drawing.Point(100, 66);
            this.txtタイトル.MaxLength = 80;
            this.txtタイトル.Name = "txtタイトル";
            this.txtタイトル.Size = new System.Drawing.Size(161, 25);
            this.txtタイトル.TabIndex = 11;
            this.txtタイトル.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lbl本ID
            // 
            this.lbl本ID.AutoSize = true;
            this.lbl本ID.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lbl本ID.Location = new System.Drawing.Point(12, 38);
            this.lbl本ID.Name = "lbl本ID";
            this.lbl本ID.Size = new System.Drawing.Size(34, 18);
            this.lbl本ID.TabIndex = 12;
            this.lbl本ID.Text = "本ID";
            this.lbl本ID.Click += new System.EventHandler(this.LblUserId_Click);
            // 
            // lblステータス
            // 
            this.lblステータス.AutoSize = true;
            this.lblステータス.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lblステータス.Location = new System.Drawing.Point(12, 131);
            this.lblステータス.Name = "lblステータス";
            this.lblステータス.Size = new System.Drawing.Size(68, 18);
            this.lblステータス.TabIndex = 13;
            this.lblステータス.Text = "ステータス";
            // 
            // lbl登録者
            // 
            this.lbl登録者.AutoSize = true;
            this.lbl登録者.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lbl登録者.Location = new System.Drawing.Point(12, 100);
            this.lbl登録者.Name = "lbl登録者";
            this.lbl登録者.Size = new System.Drawing.Size(44, 18);
            this.lbl登録者.TabIndex = 14;
            this.lbl登録者.Text = "登録者";
            // 
            // lblタイトル
            // 
            this.lblタイトル.AutoSize = true;
            this.lblタイトル.Font = new System.Drawing.Font("メイリオ", 9F);
            this.lblタイトル.Location = new System.Drawing.Point(10, 69);
            this.lblタイトル.Name = "lblタイトル";
            this.lblタイトル.Size = new System.Drawing.Size(80, 18);
            this.lblタイトル.TabIndex = 15;
            this.lblタイトル.Text = "本のタイトル";
            // 
            // btn追加確定
            // 
            this.btn追加確定.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn追加確定.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn追加確定.Location = new System.Drawing.Point(146, 7);
            this.btn追加確定.Name = "btn追加確定";
            this.btn追加確定.Size = new System.Drawing.Size(75, 26);
            this.btn追加確定.TabIndex = 16;
            this.btn追加確定.Text = "確定";
            this.btn追加確定.UseVisualStyleBackColor = true;
            this.btn追加確定.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btn追加閉じる
            // 
            this.btn追加閉じる.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn追加閉じる.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn追加閉じる.Location = new System.Drawing.Point(23, 7);
            this.btn追加閉じる.Name = "btn追加閉じる";
            this.btn追加閉じる.Size = new System.Drawing.Size(75, 26);
            this.btn追加閉じる.TabIndex = 17;
            this.btn追加閉じる.Text = "閉じる";
            this.btn追加閉じる.UseVisualStyleBackColor = true;
            this.btn追加閉じる.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbステータス
            // 
            this.cmbステータス.BackColor = System.Drawing.SystemColors.Window;
            this.cmbステータス.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbステータス.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmbステータス.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cmbステータス.FormattingEnabled = true;
            this.cmbステータス.Location = new System.Drawing.Point(100, 128);
            this.cmbステータス.Name = "cmbステータス";
            this.cmbステータス.Size = new System.Drawing.Size(161, 26);
            this.cmbステータス.TabIndex = 18;
            this.cmbステータス.SelectedIndexChanged += new System.EventHandler(this.cmbステータス_SelectedIndexChanged);
            // 
            // tableLayoutPanelAdd
            // 
            this.tableLayoutPanelAdd.ColumnCount = 2;
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.83819F));
            this.tableLayoutPanelAdd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.16181F));
            this.tableLayoutPanelAdd.Controls.Add(this.btn追加閉じる, 0, 0);
            this.tableLayoutPanelAdd.Controls.Add(this.btn追加確定, 1, 0);
            this.tableLayoutPanelAdd.Location = new System.Drawing.Point(15, 160);
            this.tableLayoutPanelAdd.Name = "tableLayoutPanelAdd";
            this.tableLayoutPanelAdd.RowCount = 1;
            this.tableLayoutPanelAdd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelAdd.Size = new System.Drawing.Size(246, 40);
            this.tableLayoutPanelAdd.TabIndex = 0;
            this.tableLayoutPanelAdd.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanelAdd_Paint);
            // 
            // tableLayoutPanelEdit
            // 
            this.tableLayoutPanelEdit.ColumnCount = 3;
            this.tableLayoutPanelEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEdit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelEdit.Controls.Add(this.btn削除, 0, 0);
            this.tableLayoutPanelEdit.Controls.Add(this.btn編集確定, 0, 0);
            this.tableLayoutPanelEdit.Controls.Add(this.btn編集閉じる, 0, 0);
            this.tableLayoutPanelEdit.Location = new System.Drawing.Point(15, 201);
            this.tableLayoutPanelEdit.Name = "tableLayoutPanelEdit";
            this.tableLayoutPanelEdit.RowCount = 1;
            this.tableLayoutPanelEdit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelEdit.Size = new System.Drawing.Size(246, 40);
            this.tableLayoutPanelEdit.TabIndex = 1;
            // 
            // btn削除
            // 
            this.btn削除.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn削除.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn削除.Location = new System.Drawing.Point(172, 7);
            this.btn削除.Name = "btn削除";
            this.btn削除.Size = new System.Drawing.Size(66, 26);
            this.btn削除.TabIndex = 20;
            this.btn削除.Text = "削除";
            this.btn削除.UseVisualStyleBackColor = true;
            // 
            // btn編集確定
            // 
            this.btn編集確定.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn編集確定.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn編集確定.Location = new System.Drawing.Point(85, 7);
            this.btn編集確定.Name = "btn編集確定";
            this.btn編集確定.Size = new System.Drawing.Size(75, 26);
            this.btn編集確定.TabIndex = 19;
            this.btn編集確定.Text = "確定";
            this.btn編集確定.UseVisualStyleBackColor = true;
            this.btn編集確定.Click += new System.EventHandler(this.btn編集確定_Click);
            // 
            // btn編集閉じる
            // 
            this.btn編集閉じる.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn編集閉じる.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btn編集閉じる.Location = new System.Drawing.Point(3, 7);
            this.btn編集閉じる.Name = "btn編集閉じる";
            this.btn編集閉じる.Size = new System.Drawing.Size(75, 26);
            this.btn編集閉じる.TabIndex = 18;
            this.btn編集閉じる.Text = "閉じる";
            this.btn編集閉じる.UseVisualStyleBackColor = true;
            this.btn編集閉じる.Click += new System.EventHandler(this.btn編集閉じる_Click);
            // 
            // txt本ID
            // 
            this.txt本ID.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt本ID.Location = new System.Drawing.Point(100, 35);
            this.txt本ID.MaxLength = 5;
            this.txt本ID.Name = "txt本ID";
            this.txt本ID.ReadOnly = true;
            this.txt本ID.Size = new System.Drawing.Size(161, 25);
            this.txt本ID.TabIndex = 20;
            // 
            // txt登録者
            // 
            this.txt登録者.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txt登録者.Location = new System.Drawing.Point(100, 97);
            this.txt登録者.MaxLength = 50;
            this.txt登録者.Name = "txt登録者";
            this.txt登録者.ReadOnly = true;
            this.txt登録者.Size = new System.Drawing.Size(161, 25);
            this.txt登録者.TabIndex = 21;
            // 
            // EditBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt登録者);
            this.Controls.Add(this.txt本ID);
            this.Controls.Add(this.tableLayoutPanelEdit);
            this.Controls.Add(this.tableLayoutPanelAdd);
            this.Controls.Add(this.cmbステータス);
            this.Controls.Add(this.lblタイトル);
            this.Controls.Add(this.lbl登録者);
            this.Controls.Add(this.lblステータス);
            this.Controls.Add(this.lbl本ID);
            this.Controls.Add(this.txtタイトル);
            this.Name = "EditBookForm";
            this.Text = "本の追加";
            this.Load += new System.EventHandler(this.EditBookForm_Load);
            this.tableLayoutPanelAdd.ResumeLayout(false);
            this.tableLayoutPanelEdit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtタイトル;
        private System.Windows.Forms.Label lbl本ID;
        private System.Windows.Forms.Label lblステータス;
        private System.Windows.Forms.Label lbl登録者;
        private System.Windows.Forms.Label lblタイトル;
        public System.Windows.Forms.Button btn追加確定;
        public System.Windows.Forms.Button btn追加閉じる;
        public System.Windows.Forms.ComboBox cmbステータス;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelEdit;
        public System.Windows.Forms.Button btn削除;
        public System.Windows.Forms.Button btn編集確定;
        public System.Windows.Forms.Button btn編集閉じる;
        public System.Windows.Forms.TextBox txt本ID;
        public System.Windows.Forms.TextBox txt登録者;
    }
}