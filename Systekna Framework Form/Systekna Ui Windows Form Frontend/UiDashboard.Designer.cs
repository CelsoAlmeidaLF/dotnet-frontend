
namespace Systekna.Windows.Frontend
{
    partial class Dashboard
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
            this.homeViews = new Systekna.WFControl.Views.HomeViews();
            this.SuspendLayout();
            // 
            // homeViews
            // 
            this.homeViews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homeViews.Location = new System.Drawing.Point(0, 0);
            this.homeViews.Name = "homeViews";
            this.homeViews.Size = new System.Drawing.Size(1016, 593);
            this.homeViews.TabIndex = 0;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 593);
            this.Controls.Add(this.homeViews);
            this.MinimumSize = new System.Drawing.Size(1032, 632);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Systekna Dashboard v0.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private WFControl.Views.HomeViews homeViews;
    }
}