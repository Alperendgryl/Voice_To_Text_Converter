
namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnSpeak = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnListen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSpeak
            // 
            this.BtnSpeak.Location = new System.Drawing.Point(0, 0);
            this.BtnSpeak.Name = "BtnSpeak";
            this.BtnSpeak.Size = new System.Drawing.Size(211, 62);
            this.BtnSpeak.TabIndex = 0;
            this.BtnSpeak.Text = "Speak";
            this.BtnSpeak.UseVisualStyleBackColor = true;
            this.BtnSpeak.Click += new System.EventHandler(this.BtnSpeak_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(2, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(426, 109);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnListen
            // 
            this.BtnListen.Location = new System.Drawing.Point(217, 0);
            this.BtnListen.Name = "BtnListen";
            this.BtnListen.Size = new System.Drawing.Size(211, 62);
            this.BtnListen.TabIndex = 2;
            this.BtnListen.Text = "Listen";
            this.BtnListen.UseVisualStyleBackColor = true;
            this.BtnListen.Click += new System.EventHandler(this.BtnListen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 183);
            this.Controls.Add(this.BtnListen);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.BtnSpeak);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnSpeak;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnListen;
    }
}

