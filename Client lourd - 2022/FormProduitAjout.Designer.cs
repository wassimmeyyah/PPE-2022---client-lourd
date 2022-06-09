
namespace Client_lourd___2022
{
    partial class FormProduitAjout
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltext = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrixUnitaireProduit = new System.Windows.Forms.NumericUpDown();
            this.btnEnregistrerProduit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLibelleProduit = new System.Windows.Forms.TextBox();
            this.txtRefProduit = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrixUnitaireProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbltext);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 131);
            this.panel1.TabIndex = 1;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(25, 51);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(213, 32);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Ajouter un produit";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtRefProduit);
            this.panel2.Controls.Add(this.txtPrixUnitaireProduit);
            this.panel2.Controls.Add(this.btnEnregistrerProduit);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtLibelleProduit);
            this.panel2.Location = new System.Drawing.Point(31, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 512);
            this.panel2.TabIndex = 5;
            // 
            // txtPrixUnitaireProduit
            // 
            this.txtPrixUnitaireProduit.Location = new System.Drawing.Point(53, 327);
            this.txtPrixUnitaireProduit.Name = "txtPrixUnitaireProduit";
            this.txtPrixUnitaireProduit.Size = new System.Drawing.Size(279, 26);
            this.txtPrixUnitaireProduit.TabIndex = 8;
            // 
            // btnEnregistrerProduit
            // 
            this.btnEnregistrerProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnEnregistrerProduit.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerProduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerProduit.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrerProduit.Location = new System.Drawing.Point(53, 418);
            this.btnEnregistrerProduit.Name = "btnEnregistrerProduit";
            this.btnEnregistrerProduit.Size = new System.Drawing.Size(121, 44);
            this.btnEnregistrerProduit.TabIndex = 7;
            this.btnEnregistrerProduit.Text = "Ajouter";
            this.btnEnregistrerProduit.UseVisualStyleBackColor = false;
            this.btnEnregistrerProduit.Click += new System.EventHandler(this.btnEnregistrerProduit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Prix unitaire :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Référence :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Libellé :";
            // 
            // txtLibelleProduit
            // 
            this.txtLibelleProduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLibelleProduit.Location = new System.Drawing.Point(53, 196);
            this.txtLibelleProduit.Name = "txtLibelleProduit";
            this.txtLibelleProduit.Size = new System.Drawing.Size(279, 31);
            this.txtLibelleProduit.TabIndex = 2;
            // 
            // txtRefProduit
            // 
            this.txtRefProduit.Location = new System.Drawing.Point(53, 76);
            this.txtRefProduit.Name = "txtRefProduit";
            this.txtRefProduit.Size = new System.Drawing.Size(279, 26);
            this.txtRefProduit.TabIndex = 9;
            // 
            // FormProduitAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 719);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormProduitAjout";
            this.Text = "Ajouter un produit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrixUnitaireProduit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnregistrerProduit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLibelleProduit;
        private System.Windows.Forms.NumericUpDown txtPrixUnitaireProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRefProduit;
    }
}