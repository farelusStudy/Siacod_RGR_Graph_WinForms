namespace SiaCod_RGR
{
    partial class DataMatrix
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
            this.btnWidthPlus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWidthMinus = new System.Windows.Forms.Button();
            this.btnHeightPlus = new System.Windows.Forms.Button();
            this.btnHeightMinus = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnHeightMinus);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHeightPlus);
            this.panel1.Controls.Add(this.btnWidthMinus);
            this.panel1.Controls.Add(this.btnWidthPlus);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(686, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(114, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnWidthPlus
            // 
            this.btnWidthPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWidthPlus.Location = new System.Drawing.Point(8, 42);
            this.btnWidthPlus.Name = "btnWidthPlus";
            this.btnWidthPlus.Size = new System.Drawing.Size(46, 41);
            this.btnWidthPlus.TabIndex = 0;
            this.btnWidthPlus.Text = "+";
            this.btnWidthPlus.UseVisualStyleBackColor = true;
            this.btnWidthPlus.Click += new System.EventHandler(this.btnWidthPlus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Width size:";
            // 
            // btnWidthMinus
            // 
            this.btnWidthMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWidthMinus.Location = new System.Drawing.Point(60, 42);
            this.btnWidthMinus.Name = "btnWidthMinus";
            this.btnWidthMinus.Size = new System.Drawing.Size(46, 41);
            this.btnWidthMinus.TabIndex = 0;
            this.btnWidthMinus.Text = "-";
            this.btnWidthMinus.UseVisualStyleBackColor = true;
            this.btnWidthMinus.Click += new System.EventHandler(this.btnWidthMinus_Click);
            // 
            // btnHeightPlus
            // 
            this.btnHeightPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHeightPlus.Location = new System.Drawing.Point(8, 128);
            this.btnHeightPlus.Name = "btnHeightPlus";
            this.btnHeightPlus.Size = new System.Drawing.Size(46, 41);
            this.btnHeightPlus.TabIndex = 0;
            this.btnHeightPlus.Text = "+";
            this.btnHeightPlus.UseVisualStyleBackColor = true;
            this.btnHeightPlus.Click += new System.EventHandler(this.btnHeightPlus_Click);
            // 
            // btnHeightMinus
            // 
            this.btnHeightMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnHeightMinus.Location = new System.Drawing.Point(60, 128);
            this.btnHeightMinus.Name = "btnHeightMinus";
            this.btnHeightMinus.Size = new System.Drawing.Size(46, 41);
            this.btnHeightMinus.TabIndex = 0;
            this.btnHeightMinus.Text = "-";
            this.btnHeightMinus.UseVisualStyleBackColor = true;
            this.btnHeightMinus.Click += new System.EventHandler(this.btnHeightMinus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height size:";
            // 
            // DataMatrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "DataMatrix";
            this.Text = "Matrix";
            this.Load += new System.EventHandler(this.DataMatrix_Load);
            this.Click += new System.EventHandler(this.DataMatrix_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.DataMatrix_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataMatrix_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHeightMinus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHeightPlus;
        private System.Windows.Forms.Button btnWidthMinus;
        private System.Windows.Forms.Button btnWidthPlus;
    }
}