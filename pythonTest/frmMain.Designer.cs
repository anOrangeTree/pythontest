namespace pythonTest
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMain = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCallFun2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(365, 146);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(334, 35);
            this.txtMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "result：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 130);
            this.button1.TabIndex = 2;
            this.button1.Text = "call fun1 and return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCallFun2
            // 
            this.btnCallFun2.Location = new System.Drawing.Point(45, 284);
            this.btnCallFun2.Name = "btnCallFun2";
            this.btnCallFun2.Size = new System.Drawing.Size(239, 79);
            this.btnCallFun2.TabIndex = 3;
            this.btnCallFun2.Text = "Call Fun2";
            this.btnCallFun2.UseVisualStyleBackColor = true;
            this.btnCallFun2.Click += new System.EventHandler(this.btnCallFun2_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 624);
            this.Controls.Add(this.btnCallFun2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMain);
            this.Name = "frmMain";
            this.Text = "python test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCallFun2;
    }
}

