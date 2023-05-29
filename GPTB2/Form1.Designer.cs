namespace GPTB2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBoxketqua = new System.Windows.Forms.RichTextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.Label();
            this.C = new System.Windows.Forms.Label();
            this.B = new System.Windows.Forms.Label();
            this.A = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.richTextBoxketqua);
            this.groupBox1.Controls.Add(this.btnTinh);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.ketqua);
            this.groupBox1.Controls.Add(this.C);
            this.groupBox1.Controls.Add(this.B);
            this.groupBox1.Controls.Add(this.A);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(57, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(658, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giải Phương Trình Bậc 2 By:Dobee";
            // 
            // richTextBoxketqua
            // 
            this.richTextBoxketqua.Location = new System.Drawing.Point(158, 220);
            this.richTextBoxketqua.Name = "richTextBoxketqua";
            this.richTextBoxketqua.Size = new System.Drawing.Size(284, 103);
            this.richTextBoxketqua.TabIndex = 8;
            this.richTextBoxketqua.Text = "";
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(281, 156);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(109, 47);
            this.btnTinh.TabIndex = 7;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(106, 180);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 34);
            this.txtC.TabIndex = 6;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(106, 133);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 34);
            this.txtB.TabIndex = 5;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(106, 89);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 34);
            this.txtA.TabIndex = 4;
            // 
            // ketqua
            // 
            this.ketqua.AutoSize = true;
            this.ketqua.Location = new System.Drawing.Point(56, 249);
            this.ketqua.Name = "ketqua";
            this.ketqua.Size = new System.Drawing.Size(91, 29);
            this.ketqua.TabIndex = 3;
            this.ketqua.Text = "kết quả";
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(56, 180);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(30, 29);
            this.C.TabIndex = 2;
            this.C.Text = "C";
            // 
            // B
            // 
            this.B.AutoSize = true;
            this.B.Location = new System.Drawing.Point(56, 139);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(29, 29);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(56, 95);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(28, 29);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(477, 156);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(107, 47);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxketqua;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label ketqua;
        private System.Windows.Forms.Label C;
        private System.Windows.Forms.Label B;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.Button btnXoa;
    }
}

