namespace GachaTool.Views
{
    partial class frmGachaCharactor
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
            this.dgShowGachaChara = new System.Windows.Forms.DataGridView();
            this.BtnLoadGachaChara = new System.Windows.Forms.Button();
            this.BtnGachaCharaUpdate = new System.Windows.Forms.Button();
            this.BtnInsertChara = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGachaChara)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShowGachaChara
            // 
            this.dgShowGachaChara.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShowGachaChara.Location = new System.Drawing.Point(12, 26);
            this.dgShowGachaChara.Name = "dgShowGachaChara";
            this.dgShowGachaChara.RowTemplate.Height = 21;
            this.dgShowGachaChara.Size = new System.Drawing.Size(776, 295);
            this.dgShowGachaChara.TabIndex = 0;
            // 
            // BtnLoadGachaChara
            // 
            this.BtnLoadGachaChara.Location = new System.Drawing.Point(88, 371);
            this.BtnLoadGachaChara.Name = "BtnLoadGachaChara";
            this.BtnLoadGachaChara.Size = new System.Drawing.Size(117, 32);
            this.BtnLoadGachaChara.TabIndex = 1;
            this.BtnLoadGachaChara.Text = "ガチャキャラ読み込み";
            this.BtnLoadGachaChara.UseVisualStyleBackColor = true;
            this.BtnLoadGachaChara.Click += new System.EventHandler(this.BtnLoadGachaChara_Click);
            // 
            // BtnGachaCharaUpdate
            // 
            this.BtnGachaCharaUpdate.Location = new System.Drawing.Point(296, 371);
            this.BtnGachaCharaUpdate.Name = "BtnGachaCharaUpdate";
            this.BtnGachaCharaUpdate.Size = new System.Drawing.Size(101, 32);
            this.BtnGachaCharaUpdate.TabIndex = 2;
            this.BtnGachaCharaUpdate.Text = "ガチャキャラ更新";
            this.BtnGachaCharaUpdate.UseVisualStyleBackColor = true;
            this.BtnGachaCharaUpdate.Click += new System.EventHandler(this.BtnGachaCharaUpdate_Click);
            // 
            // BtnInsertChara
            // 
            this.BtnInsertChara.Location = new System.Drawing.Point(466, 371);
            this.BtnInsertChara.Name = "BtnInsertChara";
            this.BtnInsertChara.Size = new System.Drawing.Size(90, 32);
            this.BtnInsertChara.TabIndex = 3;
            this.BtnInsertChara.Text = "キャラ追加";
            this.BtnInsertChara.UseVisualStyleBackColor = true;
            this.BtnInsertChara.Click += new System.EventHandler(this.BtnInsertChara_Click);
            // 
            // frmGachaCharactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnInsertChara);
            this.Controls.Add(this.BtnGachaCharaUpdate);
            this.Controls.Add(this.BtnLoadGachaChara);
            this.Controls.Add(this.dgShowGachaChara);
            this.Name = "frmGachaCharactor";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmGachaCharactor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGachaChara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgShowGachaChara;
        private System.Windows.Forms.Button BtnLoadGachaChara;
        private System.Windows.Forms.Button BtnGachaCharaUpdate;
        private System.Windows.Forms.Button BtnInsertChara;
    }
}

