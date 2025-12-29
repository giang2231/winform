namespace ktrawimform
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer2 = new SplitContainer();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            txtmasp = new TextBox();
            btnxoa = new Button();
            btnsua = new Button();
            btnthem = new Button();
            label5 = new Label();
            txtsoluong = new TextBox();
            label4 = new Label();
            txtgia = new TextBox();
            label2 = new Label();
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            txtten = new TextBox();
            cbbloaisp = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(label3);
            splitContainer2.Panel2.Controls.Add(txtmasp);
            splitContainer2.Panel2.Controls.Add(btnxoa);
            splitContainer2.Panel2.Controls.Add(btnsua);
            splitContainer2.Panel2.Controls.Add(btnthem);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Panel2.Controls.Add(txtsoluong);
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Panel2.Controls.Add(txtgia);
            splitContainer2.Panel2.Controls.Add(label2);
            splitContainer2.Panel2.Controls.Add(label1);
            splitContainer2.Panel2.Controls.Add(radioButton2);
            splitContainer2.Panel2.Controls.Add(radioButton1);
            splitContainer2.Panel2.Controls.Add(txtten);
            splitContainer2.Panel2.Controls.Add(cbbloaisp);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(800, 450);
            splitContainer2.SplitterDistance = 274;
            splitContainer2.TabIndex = 4;
            splitContainer2.SplitterMoved += splitContainer2_SplitterMoved;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(800, 274);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(163, 34);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 16;
            label3.Text = "Mã Sản Phẩm";
            // 
            // txtmasp
            // 
            txtmasp.Location = new Point(163, 68);
            txtmasp.Name = "txtmasp";
            txtmasp.Size = new Size(100, 23);
            txtmasp.TabIndex = 15;
            // 
            // btnxoa
            // 
            btnxoa.Location = new Point(430, 137);
            btnxoa.Name = "btnxoa";
            btnxoa.Size = new Size(75, 23);
            btnxoa.TabIndex = 14;
            btnxoa.Text = "xóa";
            btnxoa.UseVisualStyleBackColor = true;
            btnxoa.Click += btnxoa_Click;
            // 
            // btnsua
            // 
            btnsua.Location = new Point(307, 140);
            btnsua.Name = "btnsua";
            btnsua.Size = new Size(75, 23);
            btnsua.TabIndex = 13;
            btnsua.Text = "Sửa";
            btnsua.UseVisualStyleBackColor = true;
            btnsua.Click += btnsua_Click;
            // 
            // btnthem
            // 
            btnthem.Location = new Point(168, 137);
            btnthem.Name = "btnthem";
            btnthem.Size = new Size(75, 23);
            btnthem.TabIndex = 12;
            btnthem.Text = "Thêm";
            btnthem.UseVisualStyleBackColor = true;
            btnthem.Click += btnthem_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(617, 34);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 11;
            label5.Text = "Số Lượng";
            // 
            // txtsoluong
            // 
            txtsoluong.Location = new Point(617, 68);
            txtsoluong.Name = "txtsoluong";
            txtsoluong.Size = new Size(100, 23);
            txtsoluong.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(453, 34);
            label4.Name = "label4";
            label4.Size = new Size(24, 15);
            label4.TabIndex = 9;
            label4.Text = "Giá";
            // 
            // txtgia
            // 
            txtgia.Location = new Point(453, 68);
            txtgia.Name = "txtgia";
            txtgia.Size = new Size(100, 23);
            txtgia.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 34);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 5;
            label2.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 34);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Loại Sản Phẩm";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(24, 144);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(75, 19);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "giảm dần";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(24, 119);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(72, 19);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "tăng dần";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtten
            // 
            txtten.Location = new Point(307, 68);
            txtten.Name = "txtten";
            txtten.Size = new Size(100, 23);
            txtten.TabIndex = 1;
            // 
            // cbbloaisp
            // 
            cbbloaisp.FormattingEnabled = true;
            cbbloaisp.Items.AddRange(new object[] { "quần áo", "đồ gia dụng ", "nội thất", "thuốc" });
            cbbloaisp.Location = new Point(24, 68);
            cbbloaisp.Name = "cbbloaisp";
            cbbloaisp.Size = new Size(108, 23);
            cbbloaisp.TabIndex = 0;
            cbbloaisp.SelectedIndexChanged += cbbloaisp_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer2;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox txtten;
        private ComboBox cbbloaisp;
        private Label label5;
        private TextBox txtsoluong;
        private Label label4;
        private TextBox txtgia;
        private Button btnxoa;
        private Button btnsua;
        private Button btnthem;
        private Label label3;
        private TextBox txtmasp;
    }
}
