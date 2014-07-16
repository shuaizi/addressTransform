namespace addressTransform
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBAddr = new System.Windows.Forms.TextBox();
            this.btnTrans = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入你要转换的地址";
            // 
            // txtBAddr
            // 
            this.txtBAddr.Location = new System.Drawing.Point(15, 27);
            this.txtBAddr.Name = "txtBAddr";
            this.txtBAddr.Size = new System.Drawing.Size(412, 21);
            this.txtBAddr.TabIndex = 1;
            // 
            // btnTrans
            // 
            this.btnTrans.Location = new System.Drawing.Point(434, 25);
            this.btnTrans.Name = "btnTrans";
            this.btnTrans.Size = new System.Drawing.Size(59, 23);
            this.btnTrans.TabIndex = 2;
            this.btnTrans.Text = "转换";
            this.btnTrans.UseVisualStyleBackColor = true;
            this.btnTrans.Click += new System.EventHandler(this.btnTrans_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "转换结果";
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.Location = new System.Drawing.Point(15, 90);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.Size = new System.Drawing.Size(478, 168);
            this.rtbAnswer.TabIndex = 4;
            this.rtbAnswer.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "made by zs  email:shuaizi614@gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ctrl+C 复制  Ctrl+V 粘帖";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 282);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTrans);
            this.Controls.Add(this.txtBAddr);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "常用下载软件地址转换器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBAddr;
        private System.Windows.Forms.Button btnTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

