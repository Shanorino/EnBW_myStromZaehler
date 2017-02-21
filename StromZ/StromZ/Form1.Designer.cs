namespace StromZ
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
            this.btn_viewrecord = new System.Windows.Forms.Button();
            this.lb_watts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_viewrecord
            // 
            this.btn_viewrecord.Location = new System.Drawing.Point(181, 227);
            this.btn_viewrecord.Name = "btn_viewrecord";
            this.btn_viewrecord.Size = new System.Drawing.Size(91, 23);
            this.btn_viewrecord.TabIndex = 0;
            this.btn_viewrecord.Text = "Rekord Lesen";
            this.btn_viewrecord.UseVisualStyleBackColor = true;
            // 
            // lb_watts
            // 
            this.lb_watts.AutoSize = true;
            this.lb_watts.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_watts.Location = new System.Drawing.Point(71, 97);
            this.lb_watts.Name = "lb_watts";
            this.lb_watts.Size = new System.Drawing.Size(146, 46);
            this.lb_watts.TabIndex = 1;
            this.lb_watts.Text = "0000W";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lb_watts);
            this.Controls.Add(this.btn_viewrecord);
            this.Name = "Form1";
            this.Text = "Stromzähler für EnBW";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_viewrecord;
        private System.Windows.Forms.Label lb_watts;
    }
}

