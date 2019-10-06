namespace GachaTool.Views
{
    partial class frmCharaParamSetter
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtProbability = new System.Windows.Forms.TextBox();
            this.TxtRarity = new System.Windows.Forms.TextBox();
            this.TxtImage = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblRarity = new System.Windows.Forms.Label();
            this.lblProbability = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.BtnSaveCharaParam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(66, 74);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(100, 19);
            this.TxtName.TabIndex = 0;
            // 
            // TxtProbability
            // 
            this.TxtProbability.Location = new System.Drawing.Point(190, 74);
            this.TxtProbability.Name = "TxtProbability";
            this.TxtProbability.Size = new System.Drawing.Size(100, 19);
            this.TxtProbability.TabIndex = 1;
            this.TxtProbability.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProbability_KeyPress);
            // 
            // TxtRarity
            // 
            this.TxtRarity.Location = new System.Drawing.Point(317, 73);
            this.TxtRarity.Name = "TxtRarity";
            this.TxtRarity.Size = new System.Drawing.Size(100, 19);
            this.TxtRarity.TabIndex = 2;
            this.TxtRarity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRarity_KeyPress);
            // 
            // TxtImage
            // 
            this.TxtImage.Location = new System.Drawing.Point(450, 73);
            this.TxtImage.Name = "TxtImage";
            this.TxtImage.Size = new System.Drawing.Size(100, 19);
            this.TxtImage.TabIndex = 3;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(448, 58);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(35, 12);
            this.lblImage.TabIndex = 4;
            this.lblImage.Text = "Image";
            // 
            // lblRarity
            // 
            this.lblRarity.AutoSize = true;
            this.lblRarity.Location = new System.Drawing.Point(315, 58);
            this.lblRarity.Name = "lblRarity";
            this.lblRarity.Size = new System.Drawing.Size(36, 12);
            this.lblRarity.TabIndex = 5;
            this.lblRarity.Text = "Rarity";
            // 
            // lblProbability
            // 
            this.lblProbability.AutoSize = true;
            this.lblProbability.Location = new System.Drawing.Point(190, 57);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(59, 12);
            this.lblProbability.TabIndex = 6;
            this.lblProbability.Text = "Probability";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(66, 57);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(34, 12);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Name";
            // 
            // BtnSaveCharaParam
            // 
            this.BtnSaveCharaParam.Location = new System.Drawing.Point(563, 114);
            this.BtnSaveCharaParam.Name = "BtnSaveCharaParam";
            this.BtnSaveCharaParam.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveCharaParam.TabIndex = 8;
            this.BtnSaveCharaParam.Text = "決定";
            this.BtnSaveCharaParam.UseVisualStyleBackColor = true;
            this.BtnSaveCharaParam.Click += new System.EventHandler(this.BtnSaveCharaParam_Click);
            // 
            // frmCharaParamSetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 149);
            this.Controls.Add(this.BtnSaveCharaParam);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblProbability);
            this.Controls.Add(this.lblRarity);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.TxtImage);
            this.Controls.Add(this.TxtRarity);
            this.Controls.Add(this.TxtProbability);
            this.Controls.Add(this.TxtName);
            this.Name = "frmCharaParamSetter";
            this.Text = "frmCharaParamSetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtProbability;
        private System.Windows.Forms.TextBox TxtRarity;
        private System.Windows.Forms.TextBox TxtImage;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblRarity;
        private System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button BtnSaveCharaParam;
    }
}