﻿namespace S42B_terminal
{
	partial class PidResultControl
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
			this.plotView1 = new OxyPlot.WindowsForms.PlotView();
			this.pnlInfo = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// plotView1
			// 
			this.plotView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plotView1.Location = new System.Drawing.Point(0, 29);
			this.plotView1.Name = "plotView1";
			this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
			this.plotView1.Size = new System.Drawing.Size(683, 276);
			this.plotView1.TabIndex = 0;
			this.plotView1.Text = "plotView1";
			this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
			this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
			this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
			// 
			// pnlInfo
			// 
			this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlInfo.Location = new System.Drawing.Point(0, 0);
			this.pnlInfo.Name = "pnlInfo";
			this.pnlInfo.Size = new System.Drawing.Size(683, 29);
			this.pnlInfo.TabIndex = 1;
			this.pnlInfo.WrapContents = false;
			// 
			// PidResultControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.plotView1);
			this.Controls.Add(this.pnlInfo);
			this.Name = "PidResultControl";
			this.Size = new System.Drawing.Size(683, 305);
			this.ResumeLayout(false);

		}

		#endregion

		private OxyPlot.WindowsForms.PlotView plotView1;
		private System.Windows.Forms.FlowLayoutPanel pnlInfo;
	}
}
