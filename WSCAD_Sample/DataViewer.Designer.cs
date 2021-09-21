
namespace WSCAD_Sample
{
    partial class DataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolCursor = new System.Windows.Forms.ToolStripButton();
            this.toolZoomExtent = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.mapControl = new AxMapWinGIS.AxMap();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCursor,
            this.toolZoomExtent,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolPan,
            this.btnLoad});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(986, 33);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolCursor
            // 
            this.toolCursor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCursor.Image = global::WSCAD_Sample.Properties.Resources.cursor;
            this.toolCursor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCursor.Name = "toolCursor";
            this.toolCursor.Size = new System.Drawing.Size(34, 28);
            this.toolCursor.Text = "Cursor";
            this.toolCursor.Click += new System.EventHandler(this.toolCursor_Click);
            // 
            // toolZoomExtent
            // 
            this.toolZoomExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomExtent.Image = global::WSCAD_Sample.Properties.Resources.zoom_more;
            this.toolZoomExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomExtent.Name = "toolZoomExtent";
            this.toolZoomExtent.Size = new System.Drawing.Size(34, 28);
            this.toolZoomExtent.Text = "Zoom to Full Extent";
            this.toolZoomExtent.Click += new System.EventHandler(this.toolZoomExtent_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = global::WSCAD_Sample.Properties.Resources.zoom_in;
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(34, 28);
            this.toolZoomIn.Text = "Zoom In";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = global::WSCAD_Sample.Properties.Resources.zoom_out;
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(34, 28);
            this.toolZoomOut.Text = "Zoom Out";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = global::WSCAD_Sample.Properties.Resources.pan;
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(34, 28);
            this.toolPan.Text = "Pan";
            this.toolPan.Click += new System.EventHandler(this.toolPan_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(34, 28);
            this.btnLoad.Text = "toolStripButton1";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl.Enabled = true;
            this.mapControl.Location = new System.Drawing.Point(0, 33);
            this.mapControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mapControl.Name = "mapControl";
            this.mapControl.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("mapControl.OcxState")));
            this.mapControl.Size = new System.Drawing.Size(986, 829);
            this.mapControl.TabIndex = 1;
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 862);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DataViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolCursor;
        private System.Windows.Forms.ToolStripButton toolZoomExtent;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripButton toolPan;
        private AxMapWinGIS.AxMap mapControl;
        private System.Windows.Forms.ToolStripButton btnLoad;
    }
}

