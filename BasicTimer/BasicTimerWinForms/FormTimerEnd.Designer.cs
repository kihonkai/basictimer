namespace BasicTimerWinForms
{
    partial class FormTimerEnd
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
            this.labelTimerEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTimerEnd
            // 
            this.labelTimerEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimerEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimerEnd.Location = new System.Drawing.Point(0, 0);
            this.labelTimerEnd.Name = "labelTimerEnd";
            this.labelTimerEnd.Size = new System.Drawing.Size(435, 117);
            this.labelTimerEnd.TabIndex = 0;
            this.labelTimerEnd.Text = "Timer Finished!";
            this.labelTimerEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormTimerEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 117);
            this.Controls.Add(this.labelTimerEnd);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Name = "FormTimerEnd";
            this.Text = "Timer End";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTimerEnd;
    }
}