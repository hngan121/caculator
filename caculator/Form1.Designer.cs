namespace caculator
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsoa = new System.Windows.Forms.TextBox();
            this.txtsob = new System.Windows.Forms.TextBox();
            this.bnTru = new System.Windows.Forms.Button();
            this.bnCong = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtkq = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(11, 6);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(8, 4);
            this.checkedListBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số b";
            // 
            // txtsoa
            // 
            this.txtsoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsoa.Location = new System.Drawing.Point(161, 78);
            this.txtsoa.Name = "txtsoa";
            this.txtsoa.Size = new System.Drawing.Size(90, 26);
            this.txtsoa.TabIndex = 3;
            // 
            // txtsob
            // 
            this.txtsob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsob.Location = new System.Drawing.Point(161, 121);
            this.txtsob.Name = "txtsob";
            this.txtsob.Size = new System.Drawing.Size(90, 26);
            this.txtsob.TabIndex = 4;
            // 
            // bnTru
            // 
            this.bnTru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnTru.ForeColor = System.Drawing.Color.White;
            this.bnTru.Location = new System.Drawing.Point(59, 213);
            this.bnTru.Name = "bnTru";
            this.bnTru.Size = new System.Drawing.Size(103, 36);
            this.bnTru.TabIndex = 6;
            this.bnTru.Text = "Trừ";
            this.bnTru.UseVisualStyleBackColor = false;
            // 
            // bnCong
            // 
            this.bnCong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.bnCong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCong.ForeColor = System.Drawing.Color.White;
            this.bnCong.Location = new System.Drawing.Point(201, 212);
            this.bnCong.Name = "bnCong";
            this.bnCong.Size = new System.Drawing.Size(103, 36);
            this.bnCong.TabIndex = 7;
            this.bnCong.Text = "Cộng";
            this.bnCong.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết Quả";
            // 
            // txtkq
            // 
            this.txtkq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkq.Location = new System.Drawing.Point(161, 167);
            this.txtkq.Name = "txtkq";
            this.txtkq.Size = new System.Drawing.Size(90, 26);
            this.txtkq.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(403, 261);
            this.Controls.Add(this.txtkq);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnCong);
            this.Controls.Add(this.bnTru);
            this.Controls.Add(this.txtsob);
            this.Controls.Add(this.txtsoa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsoa;
        private System.Windows.Forms.TextBox txtsob;
        private System.Windows.Forms.Button bnTru;
        private System.Windows.Forms.Button bnCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtkq;
    }
}

