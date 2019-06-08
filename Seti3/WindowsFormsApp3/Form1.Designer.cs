namespace WindowsFormsApp3
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button_solve = new System.Windows.Forms.Button();
            this.chart_polar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Em = new System.Windows.Forms.TabPage();
            this.H = new System.Windows.Forms.TabPage();
            this.chart_dekart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_border_zone_near = new System.Windows.Forms.Label();
            this.textBox_border_zone_far = new System.Windows.Forms.TextBox();
            this.textBox_border_zone_middle = new System.Windows.Forms.TextBox();
            this.textBox_border_zone_near = new System.Windows.Forms.TextBox();
            this.textBox_lyamda = new System.Windows.Forms.TextBox();
            this.label_lyamda = new System.Windows.Forms.Label();
            this.textBox_f = new System.Windows.Forms.TextBox();
            this.textBox_nu = new System.Windows.Forms.TextBox();
            this.textBox_l = new System.Windows.Forms.TextBox();
            this.textBox_e = new System.Windows.Forms.TextBox();
            this.textBox_r = new System.Windows.Forms.TextBox();
            this.textBox_Im = new System.Windows.Forms.TextBox();
            this.label_r = new System.Windows.Forms.Label();
            this.label_l = new System.Windows.Forms.Label();
            this.label_Im = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_nu = new System.Windows.Forms.Label();
            this.label_f = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_polar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Em.SuspendLayout();
            this.H.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_dekart)).BeginInit();
            this.SuspendLayout();
            // 
            // button_solve
            // 
            this.button_solve.BackColor = System.Drawing.Color.White;
            this.button_solve.FlatAppearance.BorderSize = 0;
            this.button_solve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_solve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button_solve.ForeColor = System.Drawing.Color.Black;
            this.button_solve.Location = new System.Drawing.Point(645, 403);
            this.button_solve.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(129, 81);
            this.button_solve.TabIndex = 0;
            this.button_solve.Text = "Выполнить";
            this.button_solve.UseVisualStyleBackColor = false;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // chart_polar
            // 
            chartArea3.Name = "ChartArea1";
            this.chart_polar.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart_polar.Legends.Add(legend3);
            this.chart_polar.Location = new System.Drawing.Point(557, -1);
            this.chart_polar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_polar.Name = "chart_polar";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Em_teta";
            this.chart_polar.Series.Add(series3);
            this.chart_polar.Size = new System.Drawing.Size(691, 380);
            this.chart_polar.TabIndex = 1;
            this.chart_polar.Text = "chart1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Em);
            this.tabControl1.Controls.Add(this.H);
            this.tabControl1.Location = new System.Drawing.Point(14, 85);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1252, 549);
            this.tabControl1.TabIndex = 4;
            // 
            // Em
            // 
            this.Em.Controls.Add(this.label3);
            this.Em.Controls.Add(this.button_solve);
            this.Em.Controls.Add(this.chart_polar);
            this.Em.Controls.Add(this.label_f);
            this.Em.Controls.Add(this.label_l);
            this.Em.Controls.Add(this.label2);
            this.Em.Controls.Add(this.textBox_e);
            this.Em.Controls.Add(this.label_border_zone_near);
            this.Em.Controls.Add(this.textBox_l);
            this.Em.Controls.Add(this.label_nu);
            this.Em.Controls.Add(this.textBox_r);
            this.Em.Controls.Add(this.textBox_border_zone_far);
            this.Em.Controls.Add(this.textBox_nu);
            this.Em.Controls.Add(this.textBox_Im);
            this.Em.Controls.Add(this.textBox_border_zone_middle);
            this.Em.Controls.Add(this.textBox_f);
            this.Em.Controls.Add(this.label1);
            this.Em.Controls.Add(this.label_r);
            this.Em.Controls.Add(this.textBox_border_zone_near);
            this.Em.Controls.Add(this.label_lyamda);
            this.Em.Controls.Add(this.label_Im);
            this.Em.Controls.Add(this.textBox_lyamda);
            this.Em.Location = new System.Drawing.Point(4, 25);
            this.Em.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Em.Name = "Em";
            this.Em.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Em.Size = new System.Drawing.Size(1244, 520);
            this.Em.TabIndex = 0;
            this.Em.Text = "Em";
            this.Em.UseVisualStyleBackColor = true;
            // 
            // H
            // 
            this.H.Controls.Add(this.chart_dekart);
            this.H.Location = new System.Drawing.Point(4, 25);
            this.H.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.H.Name = "H";
            this.H.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.H.Size = new System.Drawing.Size(1244, 520);
            this.H.TabIndex = 1;
            this.H.Text = "H";
            this.H.UseVisualStyleBackColor = true;
            // 
            // chart_dekart
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_dekart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_dekart.Legends.Add(legend4);
            this.chart_dekart.Location = new System.Drawing.Point(142, 13);
            this.chart_dekart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chart_dekart.Name = "chart_dekart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "H";
            this.chart_dekart.Series.Add(series4);
            this.chart_dekart.Size = new System.Drawing.Size(1099, 380);
            this.chart_dekart.TabIndex = 0;
            this.chart_dekart.Text = "chart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 480);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Границы дальней зоны";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Границы средней зоны";
            // 
            // label_border_zone_near
            // 
            this.label_border_zone_near.AutoSize = true;
            this.label_border_zone_near.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_border_zone_near.ForeColor = System.Drawing.Color.Black;
            this.label_border_zone_near.Location = new System.Drawing.Point(15, 380);
            this.label_border_zone_near.Name = "label_border_zone_near";
            this.label_border_zone_near.Size = new System.Drawing.Size(184, 17);
            this.label_border_zone_near.TabIndex = 17;
            this.label_border_zone_near.Text = "Границы ближней зоны";
            // 
            // textBox_border_zone_far
            // 
            this.textBox_border_zone_far.Location = new System.Drawing.Point(236, 473);
            this.textBox_border_zone_far.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_border_zone_far.Name = "textBox_border_zone_far";
            this.textBox_border_zone_far.Size = new System.Drawing.Size(76, 23);
            this.textBox_border_zone_far.TabIndex = 16;
            // 
            // textBox_border_zone_middle
            // 
            this.textBox_border_zone_middle.Location = new System.Drawing.Point(236, 419);
            this.textBox_border_zone_middle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_border_zone_middle.Name = "textBox_border_zone_middle";
            this.textBox_border_zone_middle.Size = new System.Drawing.Size(76, 23);
            this.textBox_border_zone_middle.TabIndex = 15;
            // 
            // textBox_border_zone_near
            // 
            this.textBox_border_zone_near.Location = new System.Drawing.Point(236, 374);
            this.textBox_border_zone_near.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_border_zone_near.Name = "textBox_border_zone_near";
            this.textBox_border_zone_near.Size = new System.Drawing.Size(76, 23);
            this.textBox_border_zone_near.TabIndex = 14;
            // 
            // textBox_lyamda
            // 
            this.textBox_lyamda.Location = new System.Drawing.Point(236, 328);
            this.textBox_lyamda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_lyamda.Name = "textBox_lyamda";
            this.textBox_lyamda.Size = new System.Drawing.Size(76, 23);
            this.textBox_lyamda.TabIndex = 4;
            // 
            // label_lyamda
            // 
            this.label_lyamda.AutoSize = true;
            this.label_lyamda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_lyamda.ForeColor = System.Drawing.Color.Black;
            this.label_lyamda.Location = new System.Drawing.Point(15, 330);
            this.label_lyamda.Name = "label_lyamda";
            this.label_lyamda.Size = new System.Drawing.Size(107, 17);
            this.label_lyamda.TabIndex = 13;
            this.label_lyamda.Text = "Длина волны";
            // 
            // textBox_f
            // 
            this.textBox_f.Location = new System.Drawing.Point(236, 226);
            this.textBox_f.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_f.Name = "textBox_f";
            this.textBox_f.Size = new System.Drawing.Size(50, 23);
            this.textBox_f.TabIndex = 5;
            this.textBox_f.Text = "900";
            // 
            // textBox_nu
            // 
            this.textBox_nu.Location = new System.Drawing.Point(236, 174);
            this.textBox_nu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_nu.Name = "textBox_nu";
            this.textBox_nu.Size = new System.Drawing.Size(50, 23);
            this.textBox_nu.TabIndex = 6;
            this.textBox_nu.Text = "3";
            // 
            // textBox_l
            // 
            this.textBox_l.Location = new System.Drawing.Point(236, 20);
            this.textBox_l.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_l.Name = "textBox_l";
            this.textBox_l.Size = new System.Drawing.Size(50, 23);
            this.textBox_l.TabIndex = 7;
            this.textBox_l.Text = "0,8";
            // 
            // textBox_e
            // 
            this.textBox_e.Location = new System.Drawing.Point(236, 120);
            this.textBox_e.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_e.Name = "textBox_e";
            this.textBox_e.Size = new System.Drawing.Size(50, 23);
            this.textBox_e.TabIndex = 8;
            this.textBox_e.Text = "2";
            // 
            // textBox_r
            // 
            this.textBox_r.Location = new System.Drawing.Point(236, 282);
            this.textBox_r.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_r.Name = "textBox_r";
            this.textBox_r.Size = new System.Drawing.Size(76, 23);
            this.textBox_r.TabIndex = 2;
            // 
            // textBox_Im
            // 
            this.textBox_Im.Location = new System.Drawing.Point(236, 70);
            this.textBox_Im.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Im.Name = "textBox_Im";
            this.textBox_Im.Size = new System.Drawing.Size(50, 23);
            this.textBox_Im.TabIndex = 9;
            this.textBox_Im.Text = "0,03";
            // 
            // label_r
            // 
            this.label_r.AutoSize = true;
            this.label_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_r.ForeColor = System.Drawing.Color.Black;
            this.label_r.Location = new System.Drawing.Point(15, 288);
            this.label_r.Name = "label_r";
            this.label_r.Size = new System.Drawing.Size(14, 17);
            this.label_r.TabIndex = 3;
            this.label_r.Text = "r";
            // 
            // label_l
            // 
            this.label_l.AutoSize = true;
            this.label_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_l.ForeColor = System.Drawing.Color.Black;
            this.label_l.Location = new System.Drawing.Point(15, 27);
            this.label_l.Name = "label_l";
            this.label_l.Size = new System.Drawing.Size(12, 17);
            this.label_l.TabIndex = 10;
            this.label_l.Text = "l";
            // 
            // label_Im
            // 
            this.label_Im.AutoSize = true;
            this.label_Im.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_Im.ForeColor = System.Drawing.Color.Black;
            this.label_Im.Location = new System.Drawing.Point(15, 68);
            this.label_Im.Name = "label_Im";
            this.label_Im.Size = new System.Drawing.Size(24, 17);
            this.label_Im.TabIndex = 11;
            this.label_Im.Text = "Im";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "e";
            // 
            // label_nu
            // 
            this.label_nu.AutoSize = true;
            this.label_nu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_nu.ForeColor = System.Drawing.Color.Black;
            this.label_nu.Location = new System.Drawing.Point(14, 176);
            this.label_nu.Name = "label_nu";
            this.label_nu.Size = new System.Drawing.Size(26, 17);
            this.label_nu.TabIndex = 14;
            this.label_nu.Text = "nu";
            // 
            // label_f
            // 
            this.label_f.AutoSize = true;
            this.label_f.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label_f.ForeColor = System.Drawing.Color.Black;
            this.label_f.Location = new System.Drawing.Point(15, 233);
            this.label_f.Name = "label_f";
            this.label_f.Size = new System.Drawing.Size(13, 17);
            this.label_f.TabIndex = 15;
            this.label_f.Text = "f";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 612);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(30, 74, 30, 25);
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Лабораторная номер 3 Лаггай Артур";
            ((System.ComponentModel.ISupportInitialize)(this.chart_polar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Em.ResumeLayout(false);
            this.Em.PerformLayout();
            this.H.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_dekart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_polar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Em;
        private System.Windows.Forms.TabPage H;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_dekart;
        private System.Windows.Forms.TextBox textBox_lyamda;
        private System.Windows.Forms.Label label_lyamda;
        private System.Windows.Forms.Label label_border_zone_near;
        private System.Windows.Forms.TextBox textBox_border_zone_far;
        private System.Windows.Forms.TextBox textBox_border_zone_middle;
        private System.Windows.Forms.TextBox textBox_border_zone_near;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_f;
        private System.Windows.Forms.TextBox textBox_nu;
        private System.Windows.Forms.TextBox textBox_l;
        private System.Windows.Forms.TextBox textBox_e;
        private System.Windows.Forms.TextBox textBox_r;
        private System.Windows.Forms.TextBox textBox_Im;
        private System.Windows.Forms.Label label_r;
        private System.Windows.Forms.Label label_l;
        private System.Windows.Forms.Label label_Im;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_nu;
        private System.Windows.Forms.Label label_f;
    }
}

