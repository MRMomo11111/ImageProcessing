using System;
using System.Windows.Forms;

namespace ImageProcessing
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picBoxSource;
        private PictureBox picBoxFiltered;
        private Button btnLoadImage;
        private Button btnApplyFilter;
        private GroupBox grpBoxFilters;
        private RadioButton radbtnGaussianBlur;
        private RadioButton radbtnSobelEdge;
        private RadioButton radbtnBrightness;
        private RadioButton radbtnNegative;
        private ToolStrip toolStrip;
        private ToolStripButton btnApply;
        private ToolStripButton btnFilter;
        private ToolStripButton btnFormHistogram;
        private ToolStripButton btnFormRGB;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picBoxSource = new System.Windows.Forms.PictureBox();
            this.picBoxFiltered = new System.Windows.Forms.PictureBox();
            this.btnLoadImage = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.grpBoxFilters = new System.Windows.Forms.GroupBox();
            this.radbtnGaussianBlur = new System.Windows.Forms.RadioButton();
            this.radbtnSobelEdge = new System.Windows.Forms.RadioButton();
            this.radbtnBrightness = new System.Windows.Forms.RadioButton();
            this.radbtnNegative = new System.Windows.Forms.RadioButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnApply = new System.Windows.Forms.ToolStripButton();
            this.btnFilter = new System.Windows.Forms.ToolStripButton();
            this.btnFormHistogram = new System.Windows.Forms.ToolStripButton();
            this.btnFormRGB = new System.Windows.Forms.ToolStripButton();

            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).BeginInit();
            this.grpBoxFilters.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();

            // 
            // picBoxSource
            // 
            this.picBoxSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxSource.Location = new System.Drawing.Point(12, 60);
            this.picBoxSource.Name = "picBoxSource";
            this.picBoxSource.Size = new System.Drawing.Size(300, 300);
            this.picBoxSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSource.TabIndex = 0;
            this.picBoxSource.TabStop = false;

            // 
            // picBoxFiltered
            // 
            this.picBoxFiltered.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBoxFiltered.Location = new System.Drawing.Point(330, 60);
            this.picBoxFiltered.Name = "picBoxFiltered";
            this.picBoxFiltered.Size = new System.Drawing.Size(300, 300);
            this.picBoxFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFiltered.TabIndex = 1;
            this.picBoxFiltered.TabStop = false;

            // 
            // btnLoadImage
            // 
            this.btnLoadImage.Location = new System.Drawing.Point(12, 375);
            this.btnLoadImage.Name = "btnLoadImage";
            this.btnLoadImage.Size = new System.Drawing.Size(120, 30);
            this.btnLoadImage.TabIndex = 2;
            this.btnLoadImage.Text = "Load Image";
            this.btnLoadImage.UseVisualStyleBackColor = true;
            this.btnLoadImage.Click += new System.EventHandler(this.btnLoadImage_Click);

            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(604, 375);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(115, 30);
            this.btnApplyFilter.TabIndex = 3;
            this.btnApplyFilter.Text = "Apply Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);

            // 
            // grpBoxFilters
            // 
            this.grpBoxFilters.Controls.Add(this.radbtnGaussianBlur);
            this.grpBoxFilters.Controls.Add(this.radbtnSobelEdge);
            this.grpBoxFilters.Controls.Add(this.radbtnBrightness);
            this.grpBoxFilters.Controls.Add(this.radbtnNegative);
            this.grpBoxFilters.Location = new System.Drawing.Point(150, 350);
            this.grpBoxFilters.Name = "grpBoxFilters";
            this.grpBoxFilters.Size = new System.Drawing.Size(448, 50);
            this.grpBoxFilters.TabIndex = 4;
            this.grpBoxFilters.TabStop = false;
            this.grpBoxFilters.Text = "Filters";

            // 
            // radbtnGaussianBlur
            // 
            this.radbtnGaussianBlur.AutoSize = true;
            this.radbtnGaussianBlur.Location = new System.Drawing.Point(10, 20);
            this.radbtnGaussianBlur.Name = "radbtnGaussianBlur";
            this.radbtnGaussianBlur.Size = new System.Drawing.Size(111, 20);
            this.radbtnGaussianBlur.TabIndex = 0;
            this.radbtnGaussianBlur.TabStop = true;
            this.radbtnGaussianBlur.Text = "Gaussian Blur";
            this.radbtnGaussianBlur.UseVisualStyleBackColor = true;

            // 
            // radbtnSobelEdge
            // 
            this.radbtnSobelEdge.AutoSize = true;
            this.radbtnSobelEdge.Location = new System.Drawing.Point(132, 20);
            this.radbtnSobelEdge.Name = "radbtnSobelEdge";
            this.radbtnSobelEdge.Size = new System.Drawing.Size(124, 20);
            this.radbtnSobelEdge.TabIndex = 1;
            this.radbtnSobelEdge.TabStop = true;
            this.radbtnSobelEdge.Text = "Sobel Detection";
            this.radbtnSobelEdge.UseVisualStyleBackColor = true;

            // 
            // radbtnBrightness
            // 
            this.radbtnBrightness.AutoSize = true;
            this.radbtnBrightness.Location = new System.Drawing.Point(262, 20);
            this.radbtnBrightness.Name = "radbtnBrightness";
            this.radbtnBrightness.Size = new System.Drawing.Size(91, 20);
            this.radbtnBrightness.TabIndex = 2;
            this.radbtnBrightness.TabStop = true;
            this.radbtnBrightness.Text = "Brightness";
            this.radbtnBrightness.UseVisualStyleBackColor = true;

            // 
            // radbtnNegative
            // 
            this.radbtnNegative.AutoSize = true;
            this.radbtnNegative.Location = new System.Drawing.Point(359, 20);
            this.radbtnNegative.Name = "radbtnNegative";
            this.radbtnNegative.Size = new System.Drawing.Size(80, 20);
            this.radbtnNegative.TabIndex = 3;
            this.radbtnNegative.TabStop = true;
            this.radbtnNegative.Text = "Negative";
            this.radbtnNegative.UseVisualStyleBackColor = true;

            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnApply,
            this.btnFilter,
            this.btnFormHistogram,
            this.btnFormRGB});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(740, 25);
            this.toolStrip.TabIndex = 5;
            this.toolStrip.Text = "toolStrip";

            // 
            // btnApply
            // 
           
            // 
            // btnFilter
            // 
            this.btnFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFilter.Text = "Filter";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);

            // 
            // btnFormHistogram
            // 
            this.btnFormHistogram.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFormHistogram.Text = "Histogram";
            this.btnFormHistogram.Click += new System.EventHandler(this.btnFormHistogram_Click);

            // 
            // btnFormRGB
            // 
            this.btnFormRGB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFormRGB.Text = "RGB";
            this.btnFormRGB.Click += new System.EventHandler(this.btnFormRGB_Click);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(740, 420);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.grpBoxFilters);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.btnLoadImage);
            this.Controls.Add(this.picBoxFiltered);
            this.Controls.Add(this.picBoxSource);
            this.Name = "Form1";
            this.Text = "Image Processing";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFiltered)).EndInit();
            this.grpBoxFilters.ResumeLayout(false);
            this.grpBoxFilters.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        // Methods for the new buttons
       
    }
}
