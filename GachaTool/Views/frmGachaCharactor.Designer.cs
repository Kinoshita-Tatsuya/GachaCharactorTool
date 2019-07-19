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
            this.btnLoadGachaChara = new System.Windows.Forms.Button();
            this.btnGachaCharaUpdate = new System.Windows.Forms.Button();
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
            // btnLoadGachaChara
            // 
            this.btnLoadGachaChara.Location = new System.Drawing.Point(88, 371);
            this.btnLoadGachaChara.Name = "btnLoadGachaChara";
            this.btnLoadGachaChara.Size = new System.Drawing.Size(117, 32);
            this.btnLoadGachaChara.TabIndex = 1;
            this.btnLoadGachaChara.Text = "ガチャキャラ読み込み";
            this.btnLoadGachaChara.UseVisualStyleBackColor = true;
            this.btnLoadGachaChara.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // btnGachaCharaUpdate
            // 
            this.btnGachaCharaUpdate.Location = new System.Drawing.Point(296, 371);
            this.btnGachaCharaUpdate.Name = "btnGachaCharaUpdate";
            this.btnGachaCharaUpdate.Size = new System.Drawing.Size(101, 32);
            this.btnGachaCharaUpdate.TabIndex = 2;
            this.btnGachaCharaUpdate.Text = "ガチャキャラ更新";
            this.btnGachaCharaUpdate.UseVisualStyleBackColor = true;
            this.btnGachaCharaUpdate.Click += new System.EventHandler(this.Button1_Click);
            // 
            // frmGachaCharactor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGachaCharaUpdate);
            this.Controls.Add(this.btnLoadGachaChara);
            this.Controls.Add(this.dgShowGachaChara);
            this.Name = "frmGachaCharactor";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgShowGachaChara)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgShowGachaChara;
        private System.Windows.Forms.Button btnLoadGachaChara;
        private System.Windows.Forms.Button btnGachaCharaUpdate;
    }
}

