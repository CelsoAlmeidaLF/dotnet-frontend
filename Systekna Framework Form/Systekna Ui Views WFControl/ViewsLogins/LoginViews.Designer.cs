
namespace Systekna_Ui_Views_WFControl.ViewsLogins
{
    partial class LoginViews
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
            this.Login = new System.Windows.Forms.Panel();
            this.imgBackground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.Dock = System.Windows.Forms.DockStyle.Left;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(516, 632);
            this.Login.TabIndex = 0;
            // 
            // imgBackground
            // 
            this.imgBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgBackground.Image = global::Systekna_Ui_Views_WFControl.Properties.Resources.PortaEntrada;
            this.imgBackground.Location = new System.Drawing.Point(516, 0);
            this.imgBackground.Name = "imgBackground";
            this.imgBackground.Size = new System.Drawing.Size(516, 632);
            this.imgBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgBackground.TabIndex = 1;
            this.imgBackground.TabStop = false;
            // 
            // LoginViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgBackground);
            this.Controls.Add(this.Login);
            this.Name = "LoginViews";
            this.Size = new System.Drawing.Size(1032, 632);
            ((System.ComponentModel.ISupportInitialize)(this.imgBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.PictureBox imgBackground;
    }
}
