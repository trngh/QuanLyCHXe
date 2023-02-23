namespace Ex1GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.giaBan_text = new System.Windows.Forms.TextBox();
            this.tenXe_text = new System.Windows.Forms.TextBox();
            this.maXe_text = new System.Windows.Forms.TextBox();
            this.phienBan_comboBox = new System.Windows.Forms.ComboBox();
            this.dongXe_comboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 661);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.comboBox1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.giaBan_text);
            this.panel3.Controls.Add(this.tenXe_text);
            this.panel3.Controls.Add(this.maXe_text);
            this.panel3.Controls.Add(this.phienBan_comboBox);
            this.panel3.Controls.Add(this.dongXe_comboBox);
            this.panel3.Location = new System.Drawing.Point(10, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1247, 93);
            this.panel3.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(1099, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "SẮP XẾP ";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Giá xe tăng dần",
            "Giá xe giảm dần",
            "Thứ tự tên xe A - Z",
            "Thứ tự tên xe Z - A",
            "Thứ tự mã xe tăng",
            "Thứ tự mã xe giảm"});
            this.comboBox1.Location = new System.Drawing.Point(1031, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(213, 31);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SapXep_comboBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(493, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 50;
            this.label5.Text = "GIÁ BÁN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(886, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 49;
            this.label4.Text = "PHIÊN BẢN ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(718, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "DÒNG XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(227, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "TÊN XE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "MÃ XE";
            // 
            // giaBan_text
            // 
            this.giaBan_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.giaBan_text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.giaBan_text.Location = new System.Drawing.Point(429, 37);
            this.giaBan_text.Multiline = true;
            this.giaBan_text.Name = "giaBan_text";
            this.giaBan_text.Size = new System.Drawing.Size(211, 34);
            this.giaBan_text.TabIndex = 2;
            this.giaBan_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tenXe_text
            // 
            this.tenXe_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tenXe_text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tenXe_text.Location = new System.Drawing.Point(112, 38);
            this.tenXe_text.Multiline = true;
            this.tenXe_text.Name = "tenXe_text";
            this.tenXe_text.Size = new System.Drawing.Size(298, 33);
            this.tenXe_text.TabIndex = 1;
            this.tenXe_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maXe_text
            // 
            this.maXe_text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maXe_text.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.maXe_text.Location = new System.Drawing.Point(6, 38);
            this.maXe_text.Multiline = true;
            this.maXe_text.Name = "maXe_text";
            this.maXe_text.Size = new System.Drawing.Size(89, 33);
            this.maXe_text.TabIndex = 0;
            this.maXe_text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phienBan_comboBox
            // 
            this.phienBan_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.phienBan_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.phienBan_comboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.phienBan_comboBox.FormattingEnabled = true;
            this.phienBan_comboBox.Items.AddRange(new object[] {
            "AT",
            "MT"});
            this.phienBan_comboBox.Location = new System.Drawing.Point(874, 37);
            this.phienBan_comboBox.Name = "phienBan_comboBox";
            this.phienBan_comboBox.Size = new System.Drawing.Size(137, 31);
            this.phienBan_comboBox.TabIndex = 4;
            // 
            // dongXe_comboBox
            // 
            this.dongXe_comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.dongXe_comboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.dongXe_comboBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dongXe_comboBox.FormattingEnabled = true;
            this.dongXe_comboBox.ItemHeight = 23;
            this.dongXe_comboBox.Items.AddRange(new object[] {
            "Hyundai",
            "Toyota",
            "Mazda",
            "Honda",
            "Kia"});
            this.dongXe_comboBox.Location = new System.Drawing.Point(659, 37);
            this.dongXe_comboBox.Name = "dongXe_comboBox";
            this.dongXe_comboBox.Size = new System.Drawing.Size(197, 31);
            this.dongXe_comboBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(1087, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 541);
            this.panel2.TabIndex = 38;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Menu;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button6.Location = new System.Drawing.Point(9, 465);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(154, 63);
            this.button6.TabIndex = 11;
            this.button6.Text = "Bắt đầu  ";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.BatDau_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Menu;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button5.Location = new System.Drawing.Point(9, 377);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 63);
            this.button5.TabIndex = 10;
            this.button5.Text = "Tìm kiếm ";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Menu;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button4.Location = new System.Drawing.Point(9, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 63);
            this.button4.TabIndex = 8;
            this.button4.Text = "Danh sách ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.XuatDS_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Menu;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button3.Location = new System.Drawing.Point(9, 287);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 63);
            this.button3.TabIndex = 9;
            this.button3.Text = "Cập nhật ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.CapNhatThongTin_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Menu;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button2.Location = new System.Drawing.Point(9, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 63);
            this.button2.TabIndex = 7;
            this.button2.Text = "Xóa ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Menu;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(9, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Them_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Lavender;
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(10, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1071, 534);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách thông tin xe ";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(6, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1059, 497);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1274, 701);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automobile management";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox giaBan_text;
        private System.Windows.Forms.TextBox tenXe_text;
        private System.Windows.Forms.TextBox maXe_text;
        private System.Windows.Forms.ComboBox phienBan_comboBox;
        private System.Windows.Forms.ComboBox dongXe_comboBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

