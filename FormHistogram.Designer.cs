namespace ImageProcessing
{
    partial class FormHistogram
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.histoChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picBoxSource = new System.Windows.Forms.PictureBox();
            this.btnGetHistogram = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chartEqualizedHisto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.picBoxEqualizedImage = new System.Windows.Forms.PictureBox();
            this.btnGetEqualizedHistogram = new System.Windows.Forms.Button();
            this.btnEqualizeImage = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histoChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEqualizedHisto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEqualizedImage)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.histoChart);
            this.groupBox1.Controls.Add(this.picBoxSource);
            this.groupBox1.Controls.Add(this.btnGetHistogram);
            this.groupBox1.Controls.Add(this.menuStrip1);
            this.groupBox1.Location = new System.Drawing.Point(14, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(979, 415);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source Image";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // histoChart
            // 
            this.histoChart.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.Name = "ChartArea1";
            this.histoChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.histoChart.Legends.Add(legend1);
            this.histoChart.Location = new System.Drawing.Point(485, 57);
            this.histoChart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.histoChart.Name = "histoChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Red";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Legend = "Legend1";
            series2.Name = "Green";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Blue;
            series3.Legend = "Legend1";
            series3.Name = "Blue";
            this.histoChart.Series.Add(series1);
            this.histoChart.Series.Add(series2);
            this.histoChart.Series.Add(series3);
            this.histoChart.Size = new System.Drawing.Size(454, 315);
            this.histoChart.TabIndex = 4;
            this.histoChart.Text = "chart1";
            // 
            // picBoxSource
            // 
            this.picBoxSource.Location = new System.Drawing.Point(20, 57);
            this.picBoxSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxSource.Name = "picBoxSource";
            this.picBoxSource.Size = new System.Drawing.Size(362, 315);
            this.picBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSource.TabIndex = 0;
            this.picBoxSource.TabStop = false;
            // 
            // btnGetHistogram
            // 
            this.btnGetHistogram.Location = new System.Drawing.Point(485, 379);
            this.btnGetHistogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetHistogram.Name = "btnGetHistogram";
            this.btnGetHistogram.Size = new System.Drawing.Size(454, 28);
            this.btnGetHistogram.TabIndex = 1;
            this.btnGetHistogram.Text = "Get Histogram";
            this.btnGetHistogram.UseVisualStyleBackColor = true;
            this.btnGetHistogram.Click += new System.EventHandler(this.btnGetHistogram_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 21);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(973, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chartEqualizedHisto);
            this.groupBox2.Controls.Add(this.picBoxEqualizedImage);
            this.groupBox2.Controls.Add(this.btnGetEqualizedHistogram);
            this.groupBox2.Controls.Add(this.btnEqualizeImage);
            this.groupBox2.Location = new System.Drawing.Point(14, 453);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(979, 432);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Equalized Image";
            // 
            // chartEqualizedHisto
            // 
            this.chartEqualizedHisto.BackColor = System.Drawing.SystemColors.Control;
            this.chartEqualizedHisto.BorderlineWidth = 5;
            chartArea2.Name = "ChartArea1";
            this.chartEqualizedHisto.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartEqualizedHisto.Legends.Add(legend2);
            this.chartEqualizedHisto.Location = new System.Drawing.Point(485, 43);
            this.chartEqualizedHisto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartEqualizedHisto.Name = "chartEqualizedHisto";
            this.chartEqualizedHisto.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.Name = "Red";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.LimeGreen;
            series5.Legend = "Legend1";
            series5.Name = "Green";
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.Blue;
            series6.Legend = "Legend1";
            series6.Name = "Blue";
            this.chartEqualizedHisto.Series.Add(series4);
            this.chartEqualizedHisto.Series.Add(series5);
            this.chartEqualizedHisto.Series.Add(series6);
            this.chartEqualizedHisto.Size = new System.Drawing.Size(454, 315);
            this.chartEqualizedHisto.TabIndex = 2;
            this.chartEqualizedHisto.Text = "Histogram";
            title1.Name = "Title1";
            this.chartEqualizedHisto.Titles.Add(title1);
            this.chartEqualizedHisto.Click += new System.EventHandler(this.chartEqualizedHisto_Click);
            // 
            // picBoxEqualizedImage
            // 
            this.picBoxEqualizedImage.Location = new System.Drawing.Point(20, 43);
            this.picBoxEqualizedImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxEqualizedImage.Name = "picBoxEqualizedImage";
            this.picBoxEqualizedImage.Size = new System.Drawing.Size(362, 315);
            this.picBoxEqualizedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxEqualizedImage.TabIndex = 0;
            this.picBoxEqualizedImage.TabStop = false;
            // 
            // btnGetEqualizedHistogram
            // 
            this.btnGetEqualizedHistogram.Location = new System.Drawing.Point(485, 382);
            this.btnGetEqualizedHistogram.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGetEqualizedHistogram.Name = "btnGetEqualizedHistogram";
            this.btnGetEqualizedHistogram.Size = new System.Drawing.Size(454, 28);
            this.btnGetEqualizedHistogram.TabIndex = 1;
            this.btnGetEqualizedHistogram.Text = "Get Histogram";
            this.btnGetEqualizedHistogram.UseVisualStyleBackColor = true;
            this.btnGetEqualizedHistogram.Click += new System.EventHandler(this.btnGetEqualizedHistogram_Click);
            // 
            // btnEqualizeImage
            // 
            this.btnEqualizeImage.Location = new System.Drawing.Point(20, 382);
            this.btnEqualizeImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEqualizeImage.Name = "btnEqualizeImage";
            this.btnEqualizeImage.Size = new System.Drawing.Size(362, 28);
            this.btnEqualizeImage.TabIndex = 1;
            this.btnEqualizeImage.Text = "Equalize Image";
            this.btnEqualizeImage.UseVisualStyleBackColor = true;
            this.btnEqualizeImage.Click += new System.EventHandler(this.btnEqualizeImage_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormHistogram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 745);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormHistogram";
            this.Text = "FormHistogram";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.histoChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEqualizedHisto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEqualizedImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart histoChart;
        private System.Windows.Forms.PictureBox picBoxSource;
        private System.Windows.Forms.Button btnGetHistogram;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEqualizedHisto;
        private System.Windows.Forms.PictureBox picBoxEqualizedImage;
        private System.Windows.Forms.Button btnGetEqualizedHistogram;
        private System.Windows.Forms.Button btnEqualizeImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;

    }
}