namespace DanhSachBanVeTauLua
{
    partial class FormDanhSachVe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDanhSachVe));
            this.lvDSVe = new System.Windows.Forms.ListView();
            this.lbDanhSachVe = new System.Windows.Forms.Label();
            this.btnDatVe = new System.Windows.Forms.Button();
            this.btnTaiLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvDSVe
            // 
            this.lvDSVe.BackColor = System.Drawing.Color.White;
            this.lvDSVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDSVe.FullRowSelect = true;
            this.lvDSVe.GridLines = true;
            this.lvDSVe.HideSelection = false;
            this.lvDSVe.Location = new System.Drawing.Point(70, 87);
            this.lvDSVe.Name = "lvDSVe";
            this.lvDSVe.Size = new System.Drawing.Size(672, 379);
            this.lvDSVe.TabIndex = 0;
            this.lvDSVe.UseCompatibleStateImageBehavior = false;
            this.lvDSVe.SelectedIndexChanged += new System.EventHandler(this.lvDSVe_SelectedIndexChanged);
            // 
            // lbDanhSachVe
            // 
            this.lbDanhSachVe.AutoSize = true;
            this.lbDanhSachVe.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDanhSachVe.Location = new System.Drawing.Point(307, 28);
            this.lbDanhSachVe.Name = "lbDanhSachVe";
            this.lbDanhSachVe.Size = new System.Drawing.Size(216, 37);
            this.lbDanhSachVe.TabIndex = 1;
            this.lbDanhSachVe.Text = "DANH SÁCH VÉ";
            // 
            // btnDatVe
            // 
            this.btnDatVe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDatVe.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatVe.Location = new System.Drawing.Point(485, 472);
            this.btnDatVe.Name = "btnDatVe";
            this.btnDatVe.Size = new System.Drawing.Size(119, 35);
            this.btnDatVe.TabIndex = 2;
            this.btnDatVe.Text = "Đặt vé";
            this.btnDatVe.UseVisualStyleBackColor = true;
            this.btnDatVe.Click += new System.EventHandler(this.btnDatVe_Click);
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiLai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiLai.Location = new System.Drawing.Point(623, 472);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(119, 35);
            this.btnTaiLai.TabIndex = 2;
            this.btnTaiLai.Text = "Tải lại";
            this.btnTaiLai.UseVisualStyleBackColor = true;
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // FormDanhSachVe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(233)))), ((int)(((byte)(213)))));
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.Controls.Add(this.btnTaiLai);
            this.Controls.Add(this.btnDatVe);
            this.Controls.Add(this.lbDanhSachVe);
            this.Controls.Add(this.lvDSVe);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormDanhSachVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách vé";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvDSVe;
        private System.Windows.Forms.Label lbDanhSachVe;
        private System.Windows.Forms.Button btnDatVe;
        private System.Windows.Forms.Button btnTaiLai;
    }
}