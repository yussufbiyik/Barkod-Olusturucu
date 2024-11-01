namespace Barkod_Oluşturucu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.productTypeInput = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.manufacturerCodeInput = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.productCodeInput = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.barcodeNumberInput = new System.Windows.Forms.NumericUpDown();
            this.createButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerCodeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCodeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeNumberInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.productTypeInput);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.manufacturerCodeInput);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.productCodeInput);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.barcodeNumberInput);
            this.flowLayoutPanel1.Controls.Add(this.createButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(266, 202);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 14);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürün Türü:";
            // 
            // productTypeInput
            // 
            this.productTypeInput.Location = new System.Drawing.Point(3, 17);
            this.productTypeInput.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.productTypeInput.Name = "productTypeInput";
            this.productTypeInput.Size = new System.Drawing.Size(263, 20);
            this.productTypeInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Barkod Oluşturucu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(3, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Üretici Kodu:";
            // 
            // manufacturerCodeInput
            // 
            this.manufacturerCodeInput.Location = new System.Drawing.Point(3, 57);
            this.manufacturerCodeInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.manufacturerCodeInput.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.manufacturerCodeInput.Name = "manufacturerCodeInput";
            this.manufacturerCodeInput.Size = new System.Drawing.Size(263, 20);
            this.manufacturerCodeInput.TabIndex = 6;
            this.manufacturerCodeInput.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(3, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ürün Kodu:";
            // 
            // productCodeInput
            // 
            this.productCodeInput.Location = new System.Drawing.Point(3, 97);
            this.productCodeInput.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.productCodeInput.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.productCodeInput.Name = "productCodeInput";
            this.productCodeInput.Size = new System.Drawing.Size(263, 20);
            this.productCodeInput.TabIndex = 8;
            this.productCodeInput.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Barkod Numarası:";
            // 
            // barcodeNumberInput
            // 
            this.barcodeNumberInput.Location = new System.Drawing.Point(3, 137);
            this.barcodeNumberInput.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.barcodeNumberInput.Name = "barcodeNumberInput";
            this.barcodeNumberInput.Size = new System.Drawing.Size(263, 20);
            this.barcodeNumberInput.TabIndex = 10;
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(3, 163);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(263, 35);
            this.createButton.TabIndex = 11;
            this.createButton.Text = "Oluştur";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 227);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Barkod Konfigürasyonu";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 268);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barkod Çıktısı";
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(12, 19);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(259, 75);
            this.resultBox.TabIndex = 0;
            this.resultBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(317, 414);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(317, 414);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Barkod Oluşturucu";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productTypeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerCodeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productCodeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barcodeNumberInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown productTypeInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown manufacturerCodeInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown productCodeInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown barcodeNumberInput;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox resultBox;
    }
}

