﻿namespace programme_Vierge
{
    partial class frmAccueil
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
            this.btnToPoly = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToPoly
            // 
            this.btnToPoly.Location = new System.Drawing.Point(31, 25);
            this.btnToPoly.Name = "btnToPoly";
            this.btnToPoly.Size = new System.Drawing.Size(90, 48);
            this.btnToPoly.TabIndex = 0;
            this.btnToPoly.Text = "Vers poly";
            this.btnToPoly.UseVisualStyleBackColor = true;
            this.btnToPoly.Click += new System.EventHandler(this.btnToPoly_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Vers Interface";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnToPoly);
            this.Name = "frmAccueil";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnToPoly;
        private System.Windows.Forms.Button button1;
    }
}

