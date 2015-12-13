﻿namespace Duality.Editor.Plugins.Tilemaps
{
	partial class TilemapToolSourcePalette
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TilemapToolSourcePalette));
			this.mainToolStrip = new System.Windows.Forms.ToolStrip();
			this.tilesetView = new Duality.Editor.Plugins.Tilemaps.TilesetView();
			this.labelTileset = new System.Windows.Forms.ToolStripLabel();
			this.mainToolStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// mainToolStrip
			// 
			this.mainToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
			this.mainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelTileset});
			this.mainToolStrip.Location = new System.Drawing.Point(0, 0);
			this.mainToolStrip.Name = "mainToolStrip";
			this.mainToolStrip.Size = new System.Drawing.Size(479, 25);
			this.mainToolStrip.TabIndex = 1;
			// 
			// tilesetView
			// 
			this.tilesetView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tilesetView.Location = new System.Drawing.Point(0, 25);
			this.tilesetView.Name = "tilesetView";
			this.tilesetView.Size = new System.Drawing.Size(479, 422);
			this.tilesetView.TabIndex = 0;
			// 
			// labelTileset
			// 
			this.labelTileset.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.labelTileset.Name = "labelTileset";
			this.labelTileset.Size = new System.Drawing.Size(41, 22);
			this.labelTileset.Text = "Tileset";
			// 
			// TilemapToolSourcePalette
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(196)))), ((int)(((byte)(196)))));
			this.ClientSize = new System.Drawing.Size(479, 447);
			this.Controls.Add(this.tilesetView);
			this.Controls.Add(this.mainToolStrip);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "TilemapToolSourcePalette";
			this.ShowHint = WeifenLuo.WinFormsUI.Docking.DockState.DockLeft;
			this.Text = "Tile Palette";
			this.mainToolStrip.ResumeLayout(false);
			this.mainToolStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TilesetView tilesetView;
		private System.Windows.Forms.ToolStrip mainToolStrip;
		private System.Windows.Forms.ToolStripLabel labelTileset;
	}
}