﻿
namespace Client_lourd___2022
{
    partial class FormProduit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnPharmacie = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewProduit = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchProduit = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAjouterProduit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 131);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les produits";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1235, 21);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(207, 144);
            this.panel4.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.label2.Location = new System.Drawing.Point(48, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Utilisateur";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Client_lourd___2022.Properties.Resources.Untitled_11;
            this.pictureBox2.Location = new System.Drawing.Point(72, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(63, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.btnCommande);
            this.panel3.Controls.Add(this.btnProduit);
            this.panel3.Controls.Add(this.btnEmploye);
            this.panel3.Controls.Add(this.btnPharmacie);
            this.panel3.Controls.Add(this.btnAccueil);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 669);
            this.panel3.TabIndex = 9;
            // 
            // btnCommande
            // 
            this.btnCommande.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCommande.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCommande.FlatAppearance.BorderSize = 0;
            this.btnCommande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCommande.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommande.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnCommande.Image = global::Client_lourd___2022.Properties.Resources.icons8_caddie_30;
            this.btnCommande.Location = new System.Drawing.Point(0, 404);
            this.btnCommande.Name = "btnCommande";
            this.btnCommande.Size = new System.Drawing.Size(207, 65);
            this.btnCommande.TabIndex = 1;
            this.btnCommande.Text = "Commandes";
            this.btnCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCommande.UseVisualStyleBackColor = true;
            // 
            // btnProduit
            // 
            this.btnProduit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnProduit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProduit.FlatAppearance.BorderSize = 0;
            this.btnProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduit.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnProduit.Image = global::Client_lourd___2022.Properties.Resources.icons8_pilule_30;
            this.btnProduit.Location = new System.Drawing.Point(0, 339);
            this.btnProduit.Name = "btnProduit";
            this.btnProduit.Size = new System.Drawing.Size(207, 65);
            this.btnProduit.TabIndex = 1;
            this.btnProduit.Text = "Produits   ";
            this.btnProduit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnProduit.UseVisualStyleBackColor = true;
            // 
            // btnEmploye
            // 
            this.btnEmploye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmploye.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmploye.FlatAppearance.BorderSize = 0;
            this.btnEmploye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmploye.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmploye.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnEmploye.Image = global::Client_lourd___2022.Properties.Resources.icons8_groupe_d__39_utilisateurs_30;
            this.btnEmploye.Location = new System.Drawing.Point(0, 274);
            this.btnEmploye.Name = "btnEmploye";
            this.btnEmploye.Size = new System.Drawing.Size(207, 65);
            this.btnEmploye.TabIndex = 1;
            this.btnEmploye.Text = "Employés";
            this.btnEmploye.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnEmploye.UseVisualStyleBackColor = true;
            // 
            // btnPharmacie
            // 
            this.btnPharmacie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPharmacie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPharmacie.FlatAppearance.BorderSize = 0;
            this.btnPharmacie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPharmacie.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPharmacie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnPharmacie.Image = global::Client_lourd___2022.Properties.Resources.icons8_pharmacy_shop_30;
            this.btnPharmacie.Location = new System.Drawing.Point(0, 209);
            this.btnPharmacie.Name = "btnPharmacie";
            this.btnPharmacie.Size = new System.Drawing.Size(207, 65);
            this.btnPharmacie.TabIndex = 1;
            this.btnPharmacie.Text = "Pharmacies";
            this.btnPharmacie.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPharmacie.UseVisualStyleBackColor = true;
            // 
            // btnAccueil
            // 
            this.btnAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAccueil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccueil.FlatAppearance.BorderSize = 0;
            this.btnAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccueil.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccueil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnAccueil.Image = global::Client_lourd___2022.Properties.Resources.icons8_niche_pour_chien_30;
            this.btnAccueil.Location = new System.Drawing.Point(0, 144);
            this.btnAccueil.Name = "btnAccueil";
            this.btnAccueil.Size = new System.Drawing.Size(207, 65);
            this.btnAccueil.TabIndex = 1;
            this.btnAccueil.Text = "Accueil    ";
            this.btnAccueil.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAccueil.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewProduit);
            this.panel2.Controls.Add(this.txtSearchProduit);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAjouterProduit);
            this.panel2.Location = new System.Drawing.Point(236, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 601);
            this.panel2.TabIndex = 10;
            // 
            // dataGridViewProduit
            // 
            this.dataGridViewProduit.AllowUserToAddRows = false;
            this.dataGridViewProduit.AllowUserToDeleteRows = false;
            this.dataGridViewProduit.AllowUserToResizeColumns = false;
            this.dataGridViewProduit.AllowUserToResizeRows = false;
            this.dataGridViewProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProduit.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7});
            this.dataGridViewProduit.GridColor = System.Drawing.Color.White;
            this.dataGridViewProduit.Location = new System.Drawing.Point(50, 101);
            this.dataGridViewProduit.MultiSelect = false;
            this.dataGridViewProduit.Name = "dataGridViewProduit";
            this.dataGridViewProduit.ReadOnly = true;
            this.dataGridViewProduit.RowHeadersVisible = false;
            this.dataGridViewProduit.RowHeadersWidth = 62;
            this.dataGridViewProduit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProduit.RowTemplate.Height = 28;
            this.dataGridViewProduit.ShowEditingIcon = false;
            this.dataGridViewProduit.Size = new System.Drawing.Size(984, 472);
            this.dataGridViewProduit.TabIndex = 0;
            this.dataGridViewProduit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduit_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PRODRef";
            this.Column1.HeaderText = "Référence";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PRODLibelle";
            this.Column2.FillWeight = 150F;
            this.Column2.HeaderText = "Libellé";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PRODPrixUnitaire";
            this.Column3.HeaderText = "Prix unitaire (€)";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle9;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Text = "Editer";
            this.Column6.UseColumnTextForButtonValue = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle10;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Supprimer";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // txtSearchProduit
            // 
            this.txtSearchProduit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchProduit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchProduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchProduit.Location = new System.Drawing.Point(676, 44);
            this.txtSearchProduit.Name = "txtSearchProduit";
            this.txtSearchProduit.Size = new System.Drawing.Size(296, 31);
            this.txtSearchProduit.TabIndex = 1;
            this.txtSearchProduit.TextChanged += new System.EventHandler(this.txtSearchProduit_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Client_lourd___2022.Properties.Resources.icons8_chercher_30;
            this.pictureBox1.Location = new System.Drawing.Point(978, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAjouterProduit
            // 
            this.btnAjouterProduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnAjouterProduit.FlatAppearance.BorderSize = 0;
            this.btnAjouterProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterProduit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterProduit.ForeColor = System.Drawing.Color.White;
            this.btnAjouterProduit.Location = new System.Drawing.Point(50, 31);
            this.btnAjouterProduit.Name = "btnAjouterProduit";
            this.btnAjouterProduit.Size = new System.Drawing.Size(121, 44);
            this.btnAjouterProduit.TabIndex = 2;
            this.btnAjouterProduit.Text = "Ajouter";
            this.btnAjouterProduit.UseVisualStyleBackColor = false;
            this.btnAjouterProduit.Click += new System.EventHandler(this.btnAjouterProduit_Click);
            // 
            // FormProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProduit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduit";
            this.Shown += new System.EventHandler(this.FormProduit_Shown_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Button btnPharmacie;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridViewProduit;
        private System.Windows.Forms.TextBox txtSearchProduit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAjouterProduit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}