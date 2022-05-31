
namespace Client_lourd___2022
{
    partial class FormPharmacie
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPharmacie = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtSearchPharmacie = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAjouterPharmacie = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCommande = new System.Windows.Forms.Button();
            this.btnProduit = new System.Windows.Forms.Button();
            this.btnEmploye = new System.Windows.Forms.Button();
            this.btnPharmacie = new System.Windows.Forms.Button();
            this.btnAccueil = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1458, 131);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Les pharmacies";
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1411, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridViewPharmacie);
            this.panel2.Controls.Add(this.txtSearchPharmacie);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnAjouterPharmacie);
            this.panel2.Location = new System.Drawing.Point(247, 170);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 568);
            this.panel2.TabIndex = 0;
            // 
            // dataGridViewPharmacie
            // 
            this.dataGridViewPharmacie.AllowUserToAddRows = false;
            this.dataGridViewPharmacie.AllowUserToDeleteRows = false;
            this.dataGridViewPharmacie.AllowUserToResizeColumns = false;
            this.dataGridViewPharmacie.AllowUserToResizeRows = false;
            this.dataGridViewPharmacie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewPharmacie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPharmacie.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPharmacie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPharmacie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPharmacie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridViewPharmacie.GridColor = System.Drawing.Color.White;
            this.dataGridViewPharmacie.Location = new System.Drawing.Point(50, 101);
            this.dataGridViewPharmacie.MultiSelect = false;
            this.dataGridViewPharmacie.Name = "dataGridViewPharmacie";
            this.dataGridViewPharmacie.ReadOnly = true;
            this.dataGridViewPharmacie.RowHeadersVisible = false;
            this.dataGridViewPharmacie.RowHeadersWidth = 62;
            this.dataGridViewPharmacie.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPharmacie.RowTemplate.Height = 28;
            this.dataGridViewPharmacie.ShowEditingIcon = false;
            this.dataGridViewPharmacie.Size = new System.Drawing.Size(1087, 439);
            this.dataGridViewPharmacie.TabIndex = 0;
            this.dataGridViewPharmacie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPharmacie_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PHARMACode";
            this.Column1.HeaderText = "Code";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PHARMAVille";
            this.Column2.HeaderText = "Ville";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "PHARMAAdresse";
            this.Column3.HeaderText = "Adresse";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PHARMATelephone";
            this.Column4.HeaderText = "Téléphone";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PHARMAMail";
            this.Column5.HeaderText = "Mail";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column7.HeaderText = "";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Text = "Supprimer";
            this.Column7.UseColumnTextForButtonValue = true;
            // 
            // txtSearchPharmacie
            // 
            this.txtSearchPharmacie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchPharmacie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchPharmacie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchPharmacie.Location = new System.Drawing.Point(779, 44);
            this.txtSearchPharmacie.Name = "txtSearchPharmacie";
            this.txtSearchPharmacie.Size = new System.Drawing.Size(296, 31);
            this.txtSearchPharmacie.TabIndex = 1;
            this.txtSearchPharmacie.TextChanged += new System.EventHandler(this.txtSearchPharmacie_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = global::Client_lourd___2022.Properties.Resources.icons8_chercher_30;
            this.pictureBox1.Location = new System.Drawing.Point(1081, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnAjouterPharmacie
            // 
            this.btnAjouterPharmacie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.btnAjouterPharmacie.FlatAppearance.BorderSize = 0;
            this.btnAjouterPharmacie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjouterPharmacie.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterPharmacie.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPharmacie.Location = new System.Drawing.Point(50, 31);
            this.btnAjouterPharmacie.Name = "btnAjouterPharmacie";
            this.btnAjouterPharmacie.Size = new System.Drawing.Size(121, 44);
            this.btnAjouterPharmacie.TabIndex = 2;
            this.btnAjouterPharmacie.Text = "Ajouter";
            this.btnAjouterPharmacie.UseVisualStyleBackColor = false;
            this.btnAjouterPharmacie.Click += new System.EventHandler(this.btnAjouterPharmacie_Click);
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
            this.panel3.Size = new System.Drawing.Size(207, 647);
            this.panel3.TabIndex = 5;
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
            this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
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
            this.btnAccueil.Click += new System.EventHandler(this.btnAccueil_Click);
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
            // FormPharmacie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1458, 778);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPharmacie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pharmacie";
            this.Load += new System.EventHandler(this.FormPharmacie_Load);
            this.Shown += new System.EventHandler(this.FormPharmacie_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPharmacie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchPharmacie;
        private System.Windows.Forms.Button btnAjouterPharmacie;
        private System.Windows.Forms.DataGridView dataGridViewPharmacie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCommande;
        private System.Windows.Forms.Button btnProduit;
        private System.Windows.Forms.Button btnEmploye;
        private System.Windows.Forms.Button btnPharmacie;
        private System.Windows.Forms.Button btnAccueil;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

