namespace market_takip
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAra = new System.Windows.Forms.Button();
            this.kapat = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.ekle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tümü",
            "Müşteri Adı",
            "Müşteri Soyadı",
            "Tc Kimlik",
            "Cep Tel",
            "Ev Tel",
            "Adres"});
            this.comboBox1.Location = new System.Drawing.Point(281, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 127;
            this.comboBox1.Text = "Tümü";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 126;
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "add.png");
            this.ımageList1.Images.SetKeyName(1, "ara.gif");
            this.ımageList1.Images.SetKeyName(2, "hhh.jpg");
            this.ımageList1.Images.SetKeyName(3, "sil.gif");
            // 
            // btnAra
            // 
            this.btnAra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAra.ImageList = this.ımageList1;
            this.btnAra.Location = new System.Drawing.Point(436, 12);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(34, 35);
            this.btnAra.TabIndex = 125;
            this.btnAra.Text = "Ara";
            this.btnAra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // kapat
            // 
            this.kapat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kapat.ImageList = this.ımageList1;
            this.kapat.Location = new System.Drawing.Point(640, 324);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(75, 28);
            this.kapat.TabIndex = 124;
            this.kapat.Text = "Kapat";
            this.kapat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kapat.UseVisualStyleBackColor = true;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // sil
            // 
            this.sil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.sil.ImageList = this.ımageList1;
            this.sil.Location = new System.Drawing.Point(539, 324);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 28);
            this.sil.TabIndex = 123;
            this.sil.Text = "Sil";
            this.sil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // ekle
            // 
            this.ekle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ekle.ImageList = this.ımageList1;
            this.ekle.Location = new System.Drawing.Point(438, 324);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 28);
            this.ekle.TabIndex = 122;
            this.ekle.Text = "Ekle";
            this.ekle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(18, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(697, 216);
            this.dataGridView1.TabIndex = 121;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(737, 375);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.kapat);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Name = "Form3";
            this.Text = "HC E-Ticaret ";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button ekle;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}