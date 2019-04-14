namespace interTest
{
    partial class frmFRM
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBTN = new System.Windows.Forms.Button();
            this.btnBTN2 = new System.Windows.Forms.Button();
            this.btnBTN3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBTN
            // 
            this.btnBTN.Location = new System.Drawing.Point(12, 12);
            this.btnBTN.Name = "btnBTN";
            this.btnBTN.Size = new System.Drawing.Size(93, 75);
            this.btnBTN.TabIndex = 0;
            this.btnBTN.Text = "Bouton qui boutonne";
            this.btnBTN.UseVisualStyleBackColor = true;
            this.btnBTN.Click += new System.EventHandler(this.btnBTN_Click);
            // 
            // btnBTN2
            // 
            this.btnBTN2.Location = new System.Drawing.Point(252, 12);
            this.btnBTN2.Name = "btnBTN2";
            this.btnBTN2.Size = new System.Drawing.Size(93, 75);
            this.btnBTN2.TabIndex = 1;
            this.btnBTN2.Text = "Bouton qui boutonne2";
            this.btnBTN2.UseVisualStyleBackColor = true;
            this.btnBTN2.Click += new System.EventHandler(this.btnBTN2_Click);
            // 
            // btnBTN3
            // 
            this.btnBTN3.Location = new System.Drawing.Point(493, 12);
            this.btnBTN3.Name = "btnBTN3";
            this.btnBTN3.Size = new System.Drawing.Size(93, 75);
            this.btnBTN3.TabIndex = 2;
            this.btnBTN3.Text = "Bouton qui boutonne3";
            this.btnBTN3.UseVisualStyleBackColor = true;
            this.btnBTN3.Click += new System.EventHandler(this.btnBTN3_Click);
            // 
            // frmFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 98);
            this.Controls.Add(this.btnBTN3);
            this.Controls.Add(this.btnBTN2);
            this.Controls.Add(this.btnBTN);
            this.Name = "frmFRM";
            this.Text = "Form qui formule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBTN;
        private System.Windows.Forms.Button btnBTN2;
        private System.Windows.Forms.Button btnBTN3;
    }
}

