namespace PlayWithFire
{
    partial class GamePanel
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
            this.components = new System.ComponentModel.Container();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.tmPlayerMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCanvas.Location = new System.Drawing.Point(109, 76);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(100, 50);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // tmPlayerMovement
            // 
            this.tmPlayerMovement.Enabled = true;
            this.tmPlayerMovement.Interval = 10;
            this.tmPlayerMovement.Tick += new System.EventHandler(this.tmPlayerMovement_Tick);
            // 
            // GamePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbCanvas);
            this.Name = "GamePanel";
            this.Text = "GamePanel";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePanel_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GamePanel_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePanel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer tmPlayerMovement;
    }
}

