namespace winFormSenValAnalyzer.form
{
    partial class frmGraph
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
            this.chrtAcceleration = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcceleration)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chrtAcceleration
            // 
            chartArea1.Name = "ChartArea1";
            this.chrtAcceleration.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrtAcceleration.Legends.Add(legend1);
            this.chrtAcceleration.Location = new System.Drawing.Point(8, 6);
            this.chrtAcceleration.Name = "chrtAcceleration";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrtAcceleration.Series.Add(series1);
            this.chrtAcceleration.Size = new System.Drawing.Size(807, 506);
            this.chrtAcceleration.TabIndex = 1;
            this.chrtAcceleration.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chrtAcceleration);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 526);
            this.panel1.TabIndex = 2;
            // 
            // frmGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 544);
            this.Controls.Add(this.panel1);
            this.Name = "frmGraph";
            this.Text = "frmGraph";
            this.Resize += new System.EventHandler(this.frmGraph_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chrtAcceleration)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chrtAcceleration;
        private System.Windows.Forms.Panel panel1;
    }
}