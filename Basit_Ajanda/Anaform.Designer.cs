
namespace Basit_Ajanda
{
    partial class Anaform
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Tarih = new System.Windows.Forms.Label();
            this.btn_sonraki = new System.Windows.Forms.Button();
            this.btn_onceki = new System.Windows.Forms.Button();
            this.btn_tarihe_git = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ekle);
            this.panel1.Controls.Add(this.btn_tarihe_git);
            this.panel1.Controls.Add(this.lbl_Tarih);
            this.panel1.Controls.Add(this.btn_onceki);
            this.panel1.Controls.Add(this.btn_sonraki);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 649);
            this.panel1.TabIndex = 0;
            // 
            // lbl_Tarih
            // 
            this.lbl_Tarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Tarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Tarih.Location = new System.Drawing.Point(0, 0);
            this.lbl_Tarih.Name = "lbl_Tarih";
            this.lbl_Tarih.Size = new System.Drawing.Size(294, 41);
            this.lbl_Tarih.TabIndex = 1;
            this.lbl_Tarih.Text = "...";
            this.lbl_Tarih.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_sonraki
            // 
            this.btn_sonraki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sonraki.Location = new System.Drawing.Point(193, 93);
            this.btn_sonraki.Name = "btn_sonraki";
            this.btn_sonraki.Size = new System.Drawing.Size(88, 43);
            this.btn_sonraki.TabIndex = 1;
            this.btn_sonraki.Text = "Sonraki";
            this.btn_sonraki.UseVisualStyleBackColor = true;
            this.btn_sonraki.Click += new System.EventHandler(this.btn_sonraki_Click);
            // 
            // btn_onceki
            // 
            this.btn_onceki.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_onceki.Location = new System.Drawing.Point(5, 93);
            this.btn_onceki.Name = "btn_onceki";
            this.btn_onceki.Size = new System.Drawing.Size(88, 43);
            this.btn_onceki.TabIndex = 2;
            this.btn_onceki.Text = "Önceki";
            this.btn_onceki.UseVisualStyleBackColor = true;
            this.btn_onceki.Click += new System.EventHandler(this.btn_onceki_Click);
            // 
            // btn_tarihe_git
            // 
            this.btn_tarihe_git.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tarihe_git.Location = new System.Drawing.Point(99, 93);
            this.btn_tarihe_git.Name = "btn_tarihe_git";
            this.btn_tarihe_git.Size = new System.Drawing.Size(88, 43);
            this.btn_tarihe_git.TabIndex = 3;
            this.btn_tarihe_git.Text = "Tarihe Git";
            this.btn_tarihe_git.UseVisualStyleBackColor = true;
            this.btn_tarihe_git.Click += new System.EventHandler(this.btn_tarihe_git_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(294, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 649);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.Location = new System.Drawing.Point(5, 44);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(276, 43);
            this.btn_ekle.TabIndex = 4;
            this.btn_ekle.Text = "Not Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // Anaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 649);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "Anaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.Anaform_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Tarih;
        private System.Windows.Forms.Button btn_sonraki;
        private System.Windows.Forms.Button btn_onceki;
        private System.Windows.Forms.Button btn_tarihe_git;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_ekle;
    }
}

