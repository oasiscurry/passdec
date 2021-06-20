
namespace passdec
{
    partial class passdec
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
            this.DecBtn = new System.Windows.Forms.Button();
            this.EncBtn = new System.Windows.Forms.Button();
            this.InputTxt = new System.Windows.Forms.TextBox();
            this.DecEncTxt = new System.Windows.Forms.Label();
            this.CopyBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DecBtn
            // 
            this.DecBtn.Location = new System.Drawing.Point(350, 14);
            this.DecBtn.Name = "DecBtn";
            this.DecBtn.Size = new System.Drawing.Size(75, 23);
            this.DecBtn.TabIndex = 0;
            this.DecBtn.Text = "復号化";
            this.DecBtn.UseVisualStyleBackColor = true;
            this.DecBtn.Click += new System.EventHandler(this.DecBtn_Click);
            // 
            // EncBtn
            // 
            this.EncBtn.Location = new System.Drawing.Point(434, 14);
            this.EncBtn.Name = "EncBtn";
            this.EncBtn.Size = new System.Drawing.Size(75, 23);
            this.EncBtn.TabIndex = 1;
            this.EncBtn.Text = "暗号化";
            this.EncBtn.UseVisualStyleBackColor = true;
            this.EncBtn.Click += new System.EventHandler(this.EncBtn_Click);
            // 
            // InputTxt
            // 
            this.InputTxt.Location = new System.Drawing.Point(16, 16);
            this.InputTxt.Name = "InputTxt";
            this.InputTxt.Size = new System.Drawing.Size(324, 19);
            this.InputTxt.TabIndex = 2;
            // 
            // DecEncTxt
            // 
            this.DecEncTxt.AutoSize = true;
            this.DecEncTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DecEncTxt.Location = new System.Drawing.Point(20, 56);
            this.DecEncTxt.Name = "DecEncTxt";
            this.DecEncTxt.Size = new System.Drawing.Size(37, 14);
            this.DecEncTxt.TabIndex = 3;
            this.DecEncTxt.Text = "inittxt";
            // 
            // CopyBtn
            // 
            this.CopyBtn.Location = new System.Drawing.Point(350, 48);
            this.CopyBtn.Name = "CopyBtn";
            this.CopyBtn.Size = new System.Drawing.Size(75, 23);
            this.CopyBtn.TabIndex = 4;
            this.CopyBtn.Text = "コピー";
            this.CopyBtn.UseVisualStyleBackColor = true;
            this.CopyBtn.Click += new System.EventHandler(this.CopyBtn_Click);
            // 
            // passdec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 85);
            this.Controls.Add(this.CopyBtn);
            this.Controls.Add(this.DecEncTxt);
            this.Controls.Add(this.InputTxt);
            this.Controls.Add(this.EncBtn);
            this.Controls.Add(this.DecBtn);
            this.Name = "passdec";
            this.Text = "passdec";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DecBtn;
        private System.Windows.Forms.Button EncBtn;
        private System.Windows.Forms.TextBox InputTxt;
        private System.Windows.Forms.Label DecEncTxt;
        private System.Windows.Forms.Button CopyBtn;
    }
}

