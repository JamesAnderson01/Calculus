namespace Calculus
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea18 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend18 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltageTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dVdtTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.graphsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // chart1
            // 
            chartArea18.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea18);
            legend18.Name = "Legend1";
            this.chart1.Legends.Add(legend18);
            this.chart1.Location = new System.Drawing.Point(146, 86);
            this.chart1.Name = "chart1";
            series18.ChartArea = "ChartArea1";
            series18.Legend = "Legend1";
            series18.Name = "Series1";
            this.chart1.Series.Add(series18);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // graphsToolStripMenuItem
            // 
            this.graphsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltageTimeToolStripMenuItem,
            this.currentTimeToolStripMenuItem,
            this.dVdtTimeToolStripMenuItem});
            this.graphsToolStripMenuItem.Name = "graphsToolStripMenuItem";
            this.graphsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.graphsToolStripMenuItem.Text = "Graphs";
            // 
            // voltageTimeToolStripMenuItem
            // 
            this.voltageTimeToolStripMenuItem.Name = "voltageTimeToolStripMenuItem";
            this.voltageTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.voltageTimeToolStripMenuItem.Text = "Voltage time";
            this.voltageTimeToolStripMenuItem.Click += new System.EventHandler(this.voltageTimeToolStripMenuItem_Click);
            // 
            // currentTimeToolStripMenuItem
            // 
            this.currentTimeToolStripMenuItem.Name = "currentTimeToolStripMenuItem";
            this.currentTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.currentTimeToolStripMenuItem.Text = "Current time";
            this.currentTimeToolStripMenuItem.Click += new System.EventHandler(this.currentTimeToolStripMenuItem_Click);
            // 
            // dVdtTimeToolStripMenuItem
            // 
            this.dVdtTimeToolStripMenuItem.Name = "dVdtTimeToolStripMenuItem";
            this.dVdtTimeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dVdtTimeToolStripMenuItem.Text = "dV/dt time";
            this.dVdtTimeToolStripMenuItem.Click += new System.EventHandler(this.dVdtTimeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 502);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ToolStripMenuItem graphsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltageTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dVdtTimeToolStripMenuItem;
    }
}

