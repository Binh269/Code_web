namespace AppGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_gio = new System.Windows.Forms.TextBox();
            this.bt_up = new System.Windows.Forms.Button();
            this.bt_down = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbt_mayvip = new System.Windows.Forms.RadioButton();
            this.rbt_maythuong = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbt_kodh = new System.Windows.Forms.RadioButton();
            this.rbt_codh = new System.Windows.Forms.RadioButton();
            this.bt_thanhtoan = new System.Windows.Forms.Button();
            this.biết_exit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương trình tính tiền máy quán Net";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian thuê máy (giờ) :";
            // 
            // txt_gio
            // 
            this.txt_gio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txt_gio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_gio.Location = new System.Drawing.Point(411, 133);
            this.txt_gio.Multiline = true;
            this.txt_gio.Name = "txt_gio";
            this.txt_gio.Size = new System.Drawing.Size(217, 45);
            this.txt_gio.TabIndex = 2;
            this.txt_gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bt_up
            // 
            this.bt_up.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_up.BackgroundImage")));
            this.bt_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_up.Location = new System.Drawing.Point(634, 129);
            this.bt_up.Name = "bt_up";
            this.bt_up.Size = new System.Drawing.Size(26, 27);
            this.bt_up.TabIndex = 3;
            this.bt_up.UseVisualStyleBackColor = true;
            this.bt_up.Click += new System.EventHandler(this.bt_up_Click);
            // 
            // bt_down
            // 
            this.bt_down.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_down.BackgroundImage")));
            this.bt_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_down.Location = new System.Drawing.Point(634, 162);
            this.bt_down.Name = "bt_down";
            this.bt_down.Size = new System.Drawing.Size(26, 27);
            this.bt_down.TabIndex = 4;
            this.bt_down.UseVisualStyleBackColor = true;
            this.bt_down.Click += new System.EventHandler(this.bt_down_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại máy ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbt_mayvip);
            this.panel1.Controls.Add(this.rbt_maythuong);
            this.panel1.Location = new System.Drawing.Point(149, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 100);
            this.panel1.TabIndex = 6;
            // 
            // rbt_mayvip
            // 
            this.rbt_mayvip.AutoSize = true;
            this.rbt_mayvip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_mayvip.Location = new System.Drawing.Point(309, 23);
            this.rbt_mayvip.Name = "rbt_mayvip";
            this.rbt_mayvip.Size = new System.Drawing.Size(154, 28);
            this.rbt_mayvip.TabIndex = 1;
            this.rbt_mayvip.TabStop = true;
            this.rbt_mayvip.Text = "Máy vip (20k/h)";
            this.rbt_mayvip.UseVisualStyleBackColor = true;
            // 
            // rbt_maythuong
            // 
            this.rbt_maythuong.AutoSize = true;
            this.rbt_maythuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_maythuong.Location = new System.Drawing.Point(50, 23);
            this.rbt_maythuong.Name = "rbt_maythuong";
            this.rbt_maythuong.Size = new System.Drawing.Size(189, 28);
            this.rbt_maythuong.TabIndex = 0;
            this.rbt_maythuong.TabStop = true;
            this.rbt_maythuong.Text = "Máy thường (15k/h)";
            this.rbt_maythuong.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(149, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phòng lạnh (5k/h) :";
            // 
            // rbt_kodh
            // 
            this.rbt_kodh.AutoSize = true;
            this.rbt_kodh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_kodh.Location = new System.Drawing.Point(493, 375);
            this.rbt_kodh.Name = "rbt_kodh";
            this.rbt_kodh.Size = new System.Drawing.Size(84, 28);
            this.rbt_kodh.TabIndex = 3;
            this.rbt_kodh.TabStop = true;
            this.rbt_kodh.Text = "Không";
            this.rbt_kodh.UseVisualStyleBackColor = true;
            // 
            // rbt_codh
            // 
            this.rbt_codh.AutoSize = true;
            this.rbt_codh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbt_codh.Location = new System.Drawing.Point(400, 375);
            this.rbt_codh.Name = "rbt_codh";
            this.rbt_codh.Size = new System.Drawing.Size(52, 28);
            this.rbt_codh.TabIndex = 2;
            this.rbt_codh.TabStop = true;
            this.rbt_codh.Text = "Có";
            this.rbt_codh.UseVisualStyleBackColor = true;
            // 
            // bt_thanhtoan
            // 
            this.bt_thanhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_thanhtoan.Location = new System.Drawing.Point(313, 452);
            this.bt_thanhtoan.Name = "bt_thanhtoan";
            this.bt_thanhtoan.Size = new System.Drawing.Size(169, 52);
            this.bt_thanhtoan.TabIndex = 8;
            this.bt_thanhtoan.Text = "Thanh toán";
            this.bt_thanhtoan.UseVisualStyleBackColor = true;
            this.bt_thanhtoan.Click += new System.EventHandler(this.bt_thanhtoan_Click);
            // 
            // biết_exit
            // 
            this.biết_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biết_exit.Location = new System.Drawing.Point(703, 505);
            this.biết_exit.Name = "biết_exit";
            this.biết_exit.Size = new System.Drawing.Size(85, 31);
            this.biết_exit.TabIndex = 9;
            this.biết_exit.Text = "Thoát";
            this.biết_exit.UseVisualStyleBackColor = true;
            this.biết_exit.Click += new System.EventHandler(this.biết_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.biết_exit);
            this.Controls.Add(this.bt_thanhtoan);
            this.Controls.Add(this.rbt_kodh);
            this.Controls.Add(this.rbt_codh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_down);
            this.Controls.Add(this.bt_up);
            this.Controls.Add(this.txt_gio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_gio;
        private System.Windows.Forms.Button bt_up;
        private System.Windows.Forms.Button bt_down;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbt_mayvip;
        private System.Windows.Forms.RadioButton rbt_maythuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbt_kodh;
        private System.Windows.Forms.RadioButton rbt_codh;
        private System.Windows.Forms.Button bt_thanhtoan;
        private System.Windows.Forms.Button biết_exit;
    }
}

