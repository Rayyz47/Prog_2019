namespace programme_Vierge
{
    partial class frmInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnBTN3 = new System.Windows.Forms.Button();
            this.btnBTN2 = new System.Windows.Forms.Button();
            this.btnBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(121, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBTN3
            // 
            this.btnBTN3.Location = new System.Drawing.Point(121, 8);
            this.btnBTN3.Name = "btnBTN3";
            this.btnBTN3.Size = new System.Drawing.Size(93, 75);
            this.btnBTN3.TabIndex = 6;
            this.btnBTN3.Text = "Afficher tous";
            this.btnBTN3.UseVisualStyleBackColor = true;
            this.btnBTN3.Click += new System.EventHandler(this.btnBTN3_Click);
            // 
            // btnBTN2
            // 
            this.btnBTN2.Location = new System.Drawing.Point(7, 89);
            this.btnBTN2.Name = "btnBTN2";
            this.btnBTN2.Size = new System.Drawing.Size(93, 75);
            this.btnBTN2.TabIndex = 5;
            this.btnBTN2.Text = "Afficher nombre aléatoire";
            this.btnBTN2.UseVisualStyleBackColor = true;
            this.btnBTN2.Click += new System.EventHandler(this.btnBTN2_Click);
            // 
            // btnBTN
            // 
            this.btnBTN.Location = new System.Drawing.Point(7, 8);
            this.btnBTN.Name = "btnBTN";
            this.btnBTN.Size = new System.Drawing.Size(93, 75);
            this.btnBTN.TabIndex = 4;
            this.btnBTN.Text = "Afficher String";
            this.btnBTN.UseVisualStyleBackColor = true;
            this.btnBTN.Click += new System.EventHandler(this.btnBTN_Click);
            // 
            // frmInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 178);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBTN3);
            this.Controls.Add(this.btnBTN2);
            this.Controls.Add(this.btnBTN);
            this.Name = "frmInterface";
            this.Text = "frmInterface";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBTN3;
        private System.Windows.Forms.Button btnBTN2;
        private System.Windows.Forms.Button btnBTN;
    }
}