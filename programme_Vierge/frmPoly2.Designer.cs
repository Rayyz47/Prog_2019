namespace programme_Vierge
{
    partial class frmPoly2
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
            this.btnExect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExect
            // 
            this.btnExect.Location = new System.Drawing.Point(60, 45);
            this.btnExect.Name = "btnExect";
            this.btnExect.Size = new System.Drawing.Size(183, 106);
            this.btnExect.TabIndex = 0;
            this.btnExect.Text = "Executer Avec Un For Each";
            this.btnExect.UseVisualStyleBackColor = true;
            this.btnExect.Click += new System.EventHandler(this.btnExect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(340, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 106);
            this.button1.TabIndex = 1;
            this.button1.Text = "Executer Avec Parametre";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPoly2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExect);
            this.Name = "frmPoly2";
            this.Text = "frmPoly2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExect;
        private System.Windows.Forms.Button button1;
    }
}