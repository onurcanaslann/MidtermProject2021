
namespace _201735018EMS
{
    partial class Form4
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_info = new System.Windows.Forms.Button();
            this.btn_sall = new System.Windows.Forms.Button();
            this.btn_rep = new System.Windows.Forms.Button();
            this.btn_ex = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1146, 73);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_201735018EMS.Properties.Resources.proje;
            this.pictureBox1.Location = new System.Drawing.Point(3, -13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 83);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.btn_ex);
            this.panel2.Controls.Add(this.btn_rep);
            this.panel2.Controls.Add(this.btn_sall);
            this.panel2.Controls.Add(this.btn_info);
            this.panel2.Location = new System.Drawing.Point(1, 68);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 558);
            this.panel2.TabIndex = 1;
            // 
            // btn_info
            // 
            this.btn_info.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_info.ForeColor = System.Drawing.Color.White;
            this.btn_info.Location = new System.Drawing.Point(0, 3);
            this.btn_info.Name = "btn_info";
            this.btn_info.Size = new System.Drawing.Size(97, 132);
            this.btn_info.TabIndex = 2;
            this.btn_info.Text = "GENERAL";
            this.btn_info.UseVisualStyleBackColor = false;
            this.btn_info.Click += new System.EventHandler(this.btn_info_Click);
            // 
            // btn_sall
            // 
            this.btn_sall.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_sall.ForeColor = System.Drawing.Color.White;
            this.btn_sall.Location = new System.Drawing.Point(0, 141);
            this.btn_sall.Name = "btn_sall";
            this.btn_sall.Size = new System.Drawing.Size(97, 132);
            this.btn_sall.TabIndex = 2;
            this.btn_sall.Text = "SALARY";
            this.btn_sall.UseVisualStyleBackColor = false;
            this.btn_sall.Click += new System.EventHandler(this.btn_sall_Click);
            // 
            // btn_rep
            // 
            this.btn_rep.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_rep.ForeColor = System.Drawing.Color.White;
            this.btn_rep.Location = new System.Drawing.Point(0, 279);
            this.btn_rep.Name = "btn_rep";
            this.btn_rep.Size = new System.Drawing.Size(97, 132);
            this.btn_rep.TabIndex = 2;
            this.btn_rep.Text = "REPORT";
            this.btn_rep.UseVisualStyleBackColor = false;
            this.btn_rep.Click += new System.EventHandler(this.btn_rep_Click);
            // 
            // btn_ex
            // 
            this.btn_ex.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_ex.ForeColor = System.Drawing.Color.White;
            this.btn_ex.Location = new System.Drawing.Point(0, 417);
            this.btn_ex.Name = "btn_ex";
            this.btn_ex.Size = new System.Drawing.Size(97, 132);
            this.btn_ex.TabIndex = 2;
            this.btn_ex.Text = "EXIT";
            this.btn_ex.UseVisualStyleBackColor = false;
            this.btn_ex.Click += new System.EventHandler(this.btn_ex_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(212, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(802, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPLOYEE INFORMATION SYSTEM";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(107, 79);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "monthpay";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1030, 538);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 626);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "EIS";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_info;
        private System.Windows.Forms.Button btn_ex;
        private System.Windows.Forms.Button btn_rep;
        private System.Windows.Forms.Button btn_sall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}