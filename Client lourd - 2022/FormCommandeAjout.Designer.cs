
namespace Client_lourd___2022
{
    partial class FormCommandeAjout
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
            this.txtDateCommande = new System.Windows.Forms.DateTimePicker();
            this.btnEnregistrerCommande = new System.Windows.Forms.Button();
            this.txtUtilCommande = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRefCommande = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.TabIndex = 2;
            // 
            // lbltext
            // 
            this.lbltext.AutoSize = true;
            this.lbltext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltext.ForeColor = System.Drawing.Color.White;
            this.lbltext.Location = new System.Drawing.Point(25, 51);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(268, 32);
            this.lbltext.TabIndex = 0;
            this.lbltext.Text = "Ajouter une commande";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtDateCommande);
            this.panel2.Controls.Add(this.btnEnregistrerCommande);
            this.panel2.Controls.Add(this.txtUtilCommande);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtRefCommande);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(31, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(411, 537);
            this.panel2.TabIndex = 4;
            // 
            // txtDateCommande
            // 
            this.txtDateCommande.Location = new System.Drawing.Point(51, 207);
            this.txtDateCommande.Name = "txtDateCommande";
            this.txtDateCommande.Size = new System.Drawing.Size(279, 26);
            this.txtDateCommande.TabIndex = 8;
            // 
            // btnEnregistrerCommande
            // 
            this.btnEnregistrerCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.btnEnregistrerCommande.FlatAppearance.BorderSize = 0;
            this.btnEnregistrerCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnregistrerCommande.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrerCommande.ForeColor = System.Drawing.Color.White;
            this.btnEnregistrerCommande.Location = new System.Drawing.Point(51, 452);
            this.btnEnregistrerCommande.Name = "btnEnregistrerCommande";
            this.btnEnregistrerCommande.Size = new System.Drawing.Size(121, 44);
            this.btnEnregistrerCommande.TabIndex = 7;
            this.btnEnregistrerCommande.Text = "Ajouter";
            this.btnEnregistrerCommande.UseVisualStyleBackColor = false;
            this.btnEnregistrerCommande.Click += new System.EventHandler(this.btnEnregistrerCommande_Click);
            // 
            // txtUtilCommande
            // 
            this.txtUtilCommande.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilCommande.Location = new System.Drawing.Point(51, 327);
            this.txtUtilCommande.Name = "txtUtilCommande";
            this.txtUtilCommande.Size = new System.Drawing.Size(279, 31);
            this.txtUtilCommande.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Utilisateur : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Date :";
            // 
            // txtRefCommande
            // 
            this.txtRefCommande.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefCommande.Location = new System.Drawing.Point(51, 82);
            this.txtRefCommande.Name = "txtRefCommande";
            this.txtRefCommande.Size = new System.Drawing.Size(279, 31);
            this.txtRefCommande.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Réference :";
            // 
            // FormCommandeAjout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 728);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCommandeAjout";
            this.Text = "Ajouter une commade";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltext;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker txtDateCommande;
        private System.Windows.Forms.Button btnEnregistrerCommande;
        private System.Windows.Forms.TextBox txtUtilCommande;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRefCommande;
        private System.Windows.Forms.Label label1;
    }
}