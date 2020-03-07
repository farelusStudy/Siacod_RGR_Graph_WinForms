namespace SiaCod_RGR
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pInfo = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDrawModes = new System.Windows.Forms.Button();
            this.btnSetRD = new System.Windows.Forms.Button();
            this.txtFrom = new System.Windows.Forms.TextBox();
            this.txtTo = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewGraph = new System.Windows.Forms.Button();
            this.btnTestGraph = new System.Windows.Forms.Button();
            this.txtMainInfo = new System.Windows.Forms.TextBox();
            this.btnQn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCalc2 = new System.Windows.Forms.Button();
            this.pDraw = new System.Windows.Forms.Panel();
            this.tTpQn = new System.Windows.Forms.ToolTip(this.components);
            this.pInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pInfo
            // 
            this.pInfo.Controls.Add(this.groupBox1);
            this.pInfo.Controls.Add(this.btnNewGraph);
            this.pInfo.Controls.Add(this.btnTestGraph);
            this.pInfo.Controls.Add(this.btnQn);
            this.pInfo.Controls.Add(this.button1);
            this.pInfo.Controls.Add(this.btnCalc2);
            this.pInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pInfo.Location = new System.Drawing.Point(723, 0);
            this.pInfo.Name = "pInfo";
            this.pInfo.Size = new System.Drawing.Size(135, 450);
            this.pInfo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDrawModes);
            this.groupBox1.Controls.Add(this.btnSetRD);
            this.groupBox1.Controls.Add(this.txtFrom);
            this.groupBox1.Controls.Add(this.txtTo);
            this.groupBox1.Controls.Add(this.txtWeight);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(127, 204);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // btnDrawModes
            // 
            this.btnDrawModes.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.btnDrawModes.Location = new System.Drawing.Point(10, 154);
            this.btnDrawModes.Name = "btnDrawModes";
            this.btnDrawModes.Size = new System.Drawing.Size(106, 32);
            this.btnDrawModes.TabIndex = 13;
            this.btnDrawModes.Text = "Draw road mode";
            this.btnDrawModes.UseVisualStyleBackColor = true;
            this.btnDrawModes.Click += new System.EventHandler(this.btnDrawModes_Click);
            // 
            // btnSetRD
            // 
            this.btnSetRD.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSetRD.Location = new System.Drawing.Point(10, 14);
            this.btnSetRD.Name = "btnSetRD";
            this.btnSetRD.Size = new System.Drawing.Size(106, 29);
            this.btnSetRD.TabIndex = 0;
            this.btnSetRD.Text = "Set road";
            this.btnSetRD.UseVisualStyleBackColor = true;
            this.btnSetRD.Click += new System.EventHandler(this.btnSetRD_Click);
            // 
            // txtFrom
            // 
            this.txtFrom.Location = new System.Drawing.Point(65, 56);
            this.txtFrom.Name = "txtFrom";
            this.txtFrom.Size = new System.Drawing.Size(51, 20);
            this.txtFrom.TabIndex = 1;
            // 
            // txtTo
            // 
            this.txtTo.Location = new System.Drawing.Point(65, 87);
            this.txtTo.Name = "txtTo";
            this.txtTo.Size = new System.Drawing.Size(51, 20);
            this.txtTo.TabIndex = 1;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(65, 117);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(51, 20);
            this.txtWeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Weight";
            // 
            // btnNewGraph
            // 
            this.btnNewGraph.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.btnNewGraph.Location = new System.Drawing.Point(14, 355);
            this.btnNewGraph.Name = "btnNewGraph";
            this.btnNewGraph.Size = new System.Drawing.Size(106, 33);
            this.btnNewGraph.TabIndex = 12;
            this.btnNewGraph.Text = "New Graph";
            this.btnNewGraph.UseVisualStyleBackColor = true;
            this.btnNewGraph.Click += new System.EventHandler(this.btnNewGraph_Click);
            // 
            // btnTestGraph
            // 
            this.btnTestGraph.Location = new System.Drawing.Point(14, 394);
            this.btnTestGraph.Name = "btnTestGraph";
            this.btnTestGraph.Size = new System.Drawing.Size(106, 23);
            this.btnTestGraph.TabIndex = 11;
            this.btnTestGraph.Text = "Test Graph";
            this.btnTestGraph.UseVisualStyleBackColor = true;
            this.btnTestGraph.Click += new System.EventHandler(this.btnTestGraph_Click);
            // 
            // txtMainInfo
            // 
            this.txtMainInfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMainInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtMainInfo.Location = new System.Drawing.Point(0, 394);
            this.txtMainInfo.Multiline = true;
            this.txtMainInfo.Name = "txtMainInfo";
            this.txtMainInfo.ReadOnly = true;
            this.txtMainInfo.Size = new System.Drawing.Size(723, 56);
            this.txtMainInfo.TabIndex = 2;
            // 
            // btnQn
            // 
            this.btnQn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnQn.BackgroundImage")));
            this.btnQn.Location = new System.Drawing.Point(45, 0);
            this.btnQn.Name = "btnQn";
            this.btnQn.Size = new System.Drawing.Size(30, 29);
            this.btnQn.TabIndex = 8;
            this.btnQn.UseVisualStyleBackColor = true;
            this.btnQn.Click += new System.EventHandler(this.btnQn_Click);
            this.btnQn.MouseHover += new System.EventHandler(this.btnQn_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 29);
            this.button1.TabIndex = 7;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCalc2
            // 
            this.btnCalc2.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCalc2.Location = new System.Drawing.Point(14, 245);
            this.btnCalc2.Name = "btnCalc2";
            this.btnCalc2.Size = new System.Drawing.Size(106, 36);
            this.btnCalc2.TabIndex = 0;
            this.btnCalc2.Text = "Calculate";
            this.btnCalc2.UseVisualStyleBackColor = true;
            this.btnCalc2.Click += new System.EventHandler(this.btnCalc2_Click);
            // 
            // pDraw
            // 
            this.pDraw.BackColor = System.Drawing.Color.White;
            this.pDraw.Controls.Add(this.txtMainInfo);
            this.pDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDraw.Location = new System.Drawing.Point(0, 0);
            this.pDraw.Name = "pDraw";
            this.pDraw.Size = new System.Drawing.Size(723, 450);
            this.pDraw.TabIndex = 0;
            this.pDraw.Click += new System.EventHandler(this.pDraw_Click);
            this.pDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pDraw_Paint);
            this.pDraw.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pDraw_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.pDraw);
            this.Controls.Add(this.pInfo);
            this.Name = "Form1";
            this.Text = "Гафаров Рафаэл МО 216 РГР вариант 4";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.pInfo.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pDraw.ResumeLayout(false);
            this.pDraw.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pInfo;
        private System.Windows.Forms.Panel pDraw;
        private System.Windows.Forms.Button btnSetRD;
        private System.Windows.Forms.TextBox txtTo;
        private System.Windows.Forms.TextBox txtFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Button btnCalc2;
        private System.Windows.Forms.Button btnQn;
        private System.Windows.Forms.ToolTip tTpQn;
        private System.Windows.Forms.Button btnTestGraph;
        private System.Windows.Forms.Button btnNewGraph;
        private System.Windows.Forms.Button btnDrawModes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMainInfo;
    }
}

