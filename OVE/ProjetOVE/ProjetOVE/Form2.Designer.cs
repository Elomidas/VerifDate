namespace ProjetOVE
{
    partial class Form2
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
            this.m_lib = new System.Windows.Forms.Label();
            this.m_prix = new System.Windows.Forms.Label();
            this.m_date = new System.Windows.Forms.Label();
            this.m_qtt = new System.Windows.Forms.TextBox();
            this.m_ref = new System.Windows.Forms.ComboBox();
            this.m_val = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_lib
            // 
            this.m_lib.AutoSize = true;
            this.m_lib.Location = new System.Drawing.Point(60, 82);
            this.m_lib.Name = "m_lib";
            this.m_lib.Size = new System.Drawing.Size(17, 13);
            this.m_lib.TabIndex = 0;
            this.m_lib.Text = "lib";
            // 
            // m_prix
            // 
            this.m_prix.AutoSize = true;
            this.m_prix.Location = new System.Drawing.Point(60, 104);
            this.m_prix.Name = "m_prix";
            this.m_prix.Size = new System.Drawing.Size(49, 13);
            this.m_prix.TabIndex = 1;
            this.m_prix.Text = "prix unité";
            // 
            // m_date
            // 
            this.m_date.AutoSize = true;
            this.m_date.Location = new System.Drawing.Point(60, 126);
            this.m_date.Name = "m_date";
            this.m_date.Size = new System.Drawing.Size(28, 13);
            this.m_date.TabIndex = 2;
            this.m_date.Text = "DLC";
            // 
            // m_qtt
            // 
            this.m_qtt.Location = new System.Drawing.Point(60, 153);
            this.m_qtt.Name = "m_qtt";
            this.m_qtt.Size = new System.Drawing.Size(100, 20);
            this.m_qtt.TabIndex = 3;
            this.m_qtt.Text = "1";
            this.m_qtt.TextChanged += new System.EventHandler(this.m_qtt_TextChanged);
            // 
            // m_ref
            // 
            this.m_ref.FormattingEnabled = true;
            this.m_ref.Location = new System.Drawing.Point(60, 55);
            this.m_ref.Name = "m_ref";
            this.m_ref.Size = new System.Drawing.Size(364, 21);
            this.m_ref.TabIndex = 4;
            this.m_ref.Text = "Produit";
            this.m_ref.TextChanged += new System.EventHandler(this.m_ref_SelectedIndexChanged);
            // 
            // m_val
            // 
            this.m_val.Location = new System.Drawing.Point(201, 227);
            this.m_val.Name = "m_val";
            this.m_val.Size = new System.Drawing.Size(75, 23);
            this.m_val.TabIndex = 5;
            this.m_val.Text = "Valider";
            this.m_val.UseVisualStyleBackColor = true;
            this.m_val.Click += new System.EventHandler(this.m_val_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 262);
            this.Controls.Add(this.m_val);
            this.Controls.Add(this.m_ref);
            this.Controls.Add(this.m_qtt);
            this.Controls.Add(this.m_date);
            this.Controls.Add(this.m_prix);
            this.Controls.Add(this.m_lib);
            this.Name = "Form2";
            this.Text = "Scanner";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_Close);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lib;
        private System.Windows.Forms.Label m_prix;
        private System.Windows.Forms.Label m_date;
        private System.Windows.Forms.TextBox m_qtt;
        private System.Windows.Forms.ComboBox m_ref;
        private System.Windows.Forms.Button m_val;
    }
}