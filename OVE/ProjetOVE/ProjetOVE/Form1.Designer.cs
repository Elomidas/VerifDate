namespace ProjetOVE
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Caisse = new System.Windows.Forms.TabPage();
            this.m_val = new System.Windows.Forms.Button();
            this.m_dgv = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ajout = new System.Windows.Forms.Button();
            this.m_total = new System.Windows.Forms.Label();
            this.Stock = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Références = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Libellé = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unités = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DLC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.Caisse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).BeginInit();
            this.Stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Caisse);
            this.tabControl1.Controls.Add(this.Stock);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1880, 1000);
            this.tabControl1.TabIndex = 0;
            // 
            // Caisse
            // 
            this.Caisse.AutoScroll = true;
            this.Caisse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Caisse.Controls.Add(this.m_val);
            this.Caisse.Controls.Add(this.m_dgv);
            this.Caisse.Controls.Add(this.m_ajout);
            this.Caisse.Controls.Add(this.m_total);
            this.Caisse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Caisse.Location = new System.Drawing.Point(4, 29);
            this.Caisse.Name = "Caisse";
            this.Caisse.Padding = new System.Windows.Forms.Padding(3);
            this.Caisse.Size = new System.Drawing.Size(1872, 967);
            this.Caisse.TabIndex = 0;
            this.Caisse.Text = "Caisse";
            this.Caisse.UseVisualStyleBackColor = true;
            // 
            // m_val
            // 
            this.m_val.Location = new System.Drawing.Point(902, 928);
            this.m_val.Name = "m_val";
            this.m_val.Size = new System.Drawing.Size(68, 30);
            this.m_val.TabIndex = 3;
            this.m_val.Text = "Valider";
            this.m_val.UseVisualStyleBackColor = true;
            this.m_val.Click += new System.EventHandler(this.m_val_Click);
            // 
            // m_dgv
            // 
            this.m_dgv.AllowUserToAddRows = false;
            this.m_dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.m_dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.m_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.m_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.m_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.m_dgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.m_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.m_dgv.Enabled = false;
            this.m_dgv.Location = new System.Drawing.Point(6, 42);
            this.m_dgv.Name = "m_dgv";
            this.m_dgv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.m_dgv.Size = new System.Drawing.Size(1840, 880);
            this.m_dgv.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Référence";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Libelé";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Quantité";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Prix";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "DLC";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // m_ajout
            // 
            this.m_ajout.Location = new System.Drawing.Point(3, 6);
            this.m_ajout.Name = "m_ajout";
            this.m_ajout.Size = new System.Drawing.Size(62, 30);
            this.m_ajout.TabIndex = 1;
            this.m_ajout.Text = "Scanner";
            this.m_ajout.UseVisualStyleBackColor = true;
            this.m_ajout.Click += new System.EventHandler(this.m_ajout_Click);
            // 
            // m_total
            // 
            this.m_total.AutoSize = true;
            this.m_total.Location = new System.Drawing.Point(477, 690);
            this.m_total.Name = "m_total";
            this.m_total.Size = new System.Drawing.Size(52, 20);
            this.m_total.TabIndex = 0;
            this.m_total.Text = "Total :";
            // 
            // Stock
            // 
            this.Stock.AutoScroll = true;
            this.Stock.Controls.Add(this.dataGridView1);
            this.Stock.Location = new System.Drawing.Point(4, 29);
            this.Stock.Name = "Stock";
            this.Stock.Padding = new System.Windows.Forms.Padding(3);
            this.Stock.Size = new System.Drawing.Size(1872, 967);
            this.Stock.TabIndex = 1;
            this.Stock.Text = "Stock";
            this.Stock.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Références,
            this.Libellé,
            this.Unités,
            this.Prix,
            this.DLC});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.Size = new System.Drawing.Size(1840, 955);
            this.dataGridView1.TabIndex = 0;
            // 
            // Références
            // 
            this.Références.HeaderText = "Référence";
            this.Références.Name = "Références";
            this.Références.ReadOnly = true;
            // 
            // Libellé
            // 
            this.Libellé.HeaderText = "Libelé";
            this.Libellé.Name = "Libellé";
            this.Libellé.ReadOnly = true;
            // 
            // Unités
            // 
            this.Unités.HeaderText = "Quantité";
            this.Unités.Name = "Unités";
            this.Unités.ReadOnly = true;
            // 
            // Prix
            // 
            this.Prix.HeaderText = "Prix";
            this.Prix.Name = "Prix";
            this.Prix.ReadOnly = true;
            // 
            // DLC
            // 
            this.DLC.HeaderText = "DLC";
            this.DLC.Name = "DLC";
            this.DLC.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1042);
            this.Controls.Add(this.tabControl1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Verif\'Date";
            this.tabControl1.ResumeLayout(false);
            this.Caisse.ResumeLayout(false);
            this.Caisse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_dgv)).EndInit();
            this.Stock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Stock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button m_ajout;
        private System.Windows.Forms.Label m_total;
        private System.Windows.Forms.Button m_val;
        private System.Windows.Forms.DataGridView m_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Références;
        private System.Windows.Forms.DataGridViewTextBoxColumn Libellé;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unités;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn DLC;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TabPage Caisse;
    }
}

