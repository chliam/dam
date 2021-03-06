﻿namespace com.tk.dam.Views
{
    partial class Wxzt_xzb
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel1 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesLabel sideBySideBarSeriesLabel2 = new DevExpress.XtraCharts.SideBySideBarSeriesLabel();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl2
            // 
            this.chartControl2.AppearanceNameSerializable = "Nature Colors";
            this.chartControl2.BackColor = System.Drawing.Color.Transparent;
            this.chartControl2.BorderOptions.Color = System.Drawing.Color.Transparent;
            xyDiagram1.AxisX.NumericScaleOptions.AutoGrid = false;
            xyDiagram1.AxisX.NumericScaleOptions.GridOffset = 1D;
            xyDiagram1.AxisX.NumericScaleOptions.ScaleMode = DevExpress.XtraCharts.ScaleMode.Manual;
            xyDiagram1.AxisX.Tickmarks.Length = 2;
            xyDiagram1.AxisX.Tickmarks.MinorVisible = false;
            xyDiagram1.AxisX.Title.Text = "卫星编号";
            xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisX.WholeRange.AutoSideMargins = true;
            xyDiagram1.AxisY.GridLines.Color = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            xyDiagram1.AxisY.Title.Text = "信噪比";
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True;
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            xyDiagram1.DefaultPane.BackColor = System.Drawing.Color.Transparent;
            this.chartControl2.Diagram = xyDiagram1;
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
            this.chartControl2.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside;
            this.chartControl2.Legend.BackColor = System.Drawing.Color.Transparent;
            this.chartControl2.Legend.Border.Color = System.Drawing.Color.Transparent;
            this.chartControl2.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartControl2.Legend.EquallySpacedItems = false;
            this.chartControl2.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.Padding.Bottom = 10;
            this.chartControl2.Padding.Left = 10;
            this.chartControl2.Padding.Right = 10;
            this.chartControl2.Padding.Top = 10;
            sideBySideBarSeriesLabel1.BackColor = System.Drawing.Color.Transparent;
            sideBySideBarSeriesLabel1.Border.Color = System.Drawing.Color.Transparent;
            sideBySideBarSeriesLabel1.Indent = 5;
            sideBySideBarSeriesLabel1.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.BottomInside;
            sideBySideBarSeriesLabel1.ShowForZeroValues = true;
            sideBySideBarSeriesLabel1.TextAlignment = System.Drawing.StringAlignment.Far;
            sideBySideBarSeriesLabel1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series1.Label = sideBySideBarSeriesLabel1;
            series1.LegendText = "L1";
            series1.Name = "L1";
            sideBySideBarSeriesLabel2.BackColor = System.Drawing.Color.Transparent;
            sideBySideBarSeriesLabel2.Border.Color = System.Drawing.Color.Transparent;
            sideBySideBarSeriesLabel2.Indent = 5;
            sideBySideBarSeriesLabel2.Position = DevExpress.XtraCharts.BarSeriesLabelPosition.BottomInside;
            sideBySideBarSeriesLabel2.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            series2.Label = sideBySideBarSeriesLabel2;
            series2.LegendText = "L2";
            series2.Name = "L2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartControl2.SideBySideBarDistanceFixed = 0;
            this.chartControl2.Size = new System.Drawing.Size(900, 600);
            this.chartControl2.TabIndex = 1;
            chartTitle1.Text = "卫星信噪比柱状图";
            this.chartControl2.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            this.chartControl2.CustomDrawSeriesPoint += new DevExpress.XtraCharts.CustomDrawSeriesPointEventHandler(this.chartControl2_CustomDrawSeriesPoint);
            this.chartControl2.CustomDrawAxisLabel += new DevExpress.XtraCharts.CustomDrawAxisLabelEventHandler(this.chartControl2_CustomDrawAxisLabel);
            // 
            // Wxzt_xzb
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(161)))), ((int)(((byte)(246)))));
            this.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.Appearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(110)))), ((int)(((byte)(167)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartControl2);
            this.Name = "Wxzt_xzb";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.Wxzt_xzb_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl2;


    }
}
