namespace DoAn_QuanLyKhoaHoc
{
    partial class QuanLyKhoaHoc
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnQLTK = new System.Windows.Forms.Button();
            this.btnQLBH = new System.Windows.Forms.Button();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btnQLTK);
            this.panel1.Controls.Add(this.btnQLBH);
            this.panel1.Controls.Add(this.btnTK);
            this.panel1.Controls.Add(this.btnQLKH);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnQLTK
            // 
            this.btnQLTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLTK.Location = new System.Drawing.Point(56, 221);
            this.btnQLTK.Name = "btnQLTK";
            this.btnQLTK.Size = new System.Drawing.Size(150, 39);
            this.btnQLTK.TabIndex = 3;
            this.btnQLTK.Text = "Quản Lý Tài Khoản";
            this.btnQLTK.UseVisualStyleBackColor = true;
            // 
            // btnQLBH
            // 
            this.btnQLBH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLBH.Location = new System.Drawing.Point(56, 66);
            this.btnQLBH.Name = "btnQLBH";
            this.btnQLBH.Size = new System.Drawing.Size(150, 39);
            this.btnQLBH.TabIndex = 1;
            this.btnQLBH.Text = "Quản Lý Bài Học";
            this.btnQLBH.UseVisualStyleBackColor = true;
            this.btnQLBH.Click += new System.EventHandler(this.btnQLBH_Click);
            // 
            // btnTK
            // 
            this.btnTK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.Location = new System.Drawing.Point(56, 304);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(150, 39);
            this.btnTK.TabIndex = 4;
            this.btnTK.Text = "Thống Kê";
            this.btnTK.UseVisualStyleBackColor = true;
            // 
            // btnQLKH
            // 
            this.btnQLKH.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKH.Location = new System.Drawing.Point(56, 141);
            this.btnQLKH.Name = "btnQLKH";
            this.btnQLKH.Size = new System.Drawing.Size(150, 39);
            this.btnQLKH.TabIndex = 2;
            this.btnQLKH.Text = "Quản Lý Khóa Học";
            this.btnQLKH.UseVisualStyleBackColor = true;
            // 
            // QuanLyKhoaHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "QuanLyKhoaHoc";
            this.Text = "Quản Lý";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnQLTK;
        private System.Windows.Forms.Button btnQLBH;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Timer timer1;
    }
}

