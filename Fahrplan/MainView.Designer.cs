namespace Fahrplan
{
    partial class MainView
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_nach = new System.Windows.Forms.ComboBox();
            this.txtbox_von = new System.Windows.Forms.ComboBox();
            this.Resultate = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_suche = new System.Windows.Forms.Button();
            this.btn_abfahrtsortsuche = new System.Windows.Forms.Button();
            this.btn_neuesuche = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.txtbox_nach);
            this.panel1.Controls.Add(this.txtbox_von);
            this.panel1.Controls.Add(this.Resultate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_suche);
            this.panel1.Controls.Add(this.btn_abfahrtsortsuche);
            this.panel1.Controls.Add(this.btn_neuesuche);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 386);
            this.panel1.TabIndex = 0;
            // 
            // txtbox_nach
            // 
            this.txtbox_nach.FormattingEnabled = true;
            this.txtbox_nach.Location = new System.Drawing.Point(121, 116);
            this.txtbox_nach.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_nach.Name = "txtbox_nach";
            this.txtbox_nach.Size = new System.Drawing.Size(196, 26);
            this.txtbox_nach.TabIndex = 10;
            this.txtbox_nach.TextUpdate += new System.EventHandler(this.Txt_nach_TextUpdate);
            // 
            // txtbox_von
            // 
            this.txtbox_von.FormattingEnabled = true;
            this.txtbox_von.Location = new System.Drawing.Point(121, 70);
            this.txtbox_von.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_von.Name = "txtbox_von";
            this.txtbox_von.Size = new System.Drawing.Size(196, 26);
            this.txtbox_von.TabIndex = 9;
            this.txtbox_von.TextUpdate += new System.EventHandler(this.Txt_von_TextUpdate);
            // 
            // Resultate
            // 
            this.Resultate.FormattingEnabled = true;
            this.Resultate.ItemHeight = 18;
            this.Resultate.Location = new System.Drawing.Point(40, 283);
            this.Resultate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resultate.Name = "Resultate";
            this.Resultate.Size = new System.Drawing.Size(277, 76);
            this.Resultate.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(34, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 36);
            this.label3.TabIndex = 7;
            this.label3.Text = "Fahrplan";
            // 
            // btn_suche
            // 
            this.btn_suche.BackColor = System.Drawing.Color.White;
            this.btn_suche.Location = new System.Drawing.Point(40, 163);
            this.btn_suche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_suche.Name = "btn_suche";
            this.btn_suche.Size = new System.Drawing.Size(128, 47);
            this.btn_suche.TabIndex = 6;
            this.btn_suche.Text = "Verbindungen suchen";
            this.btn_suche.UseVisualStyleBackColor = false;
            this.btn_suche.Click += new System.EventHandler(this.Btn_suche_Click);
            // 
            // btn_abfahrtsortsuche
            // 
            this.btn_abfahrtsortsuche.BackColor = System.Drawing.Color.White;
            this.btn_abfahrtsortsuche.Location = new System.Drawing.Point(40, 232);
            this.btn_abfahrtsortsuche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_abfahrtsortsuche.Name = "btn_abfahrtsortsuche";
            this.btn_abfahrtsortsuche.Size = new System.Drawing.Size(277, 30);
            this.btn_abfahrtsortsuche.TabIndex = 5;
            this.btn_abfahrtsortsuche.Text = "Verbindungen von Abfahrsort suchen";
            this.btn_abfahrtsortsuche.UseVisualStyleBackColor = false;
            this.btn_abfahrtsortsuche.Click += new System.EventHandler(this.Btn_abfahrtsortsuche_Click);
            // 
            // btn_neuesuche
            // 
            this.btn_neuesuche.BackColor = System.Drawing.Color.White;
            this.btn_neuesuche.Location = new System.Drawing.Point(208, 163);
            this.btn_neuesuche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_neuesuche.Name = "btn_neuesuche";
            this.btn_neuesuche.Size = new System.Drawing.Size(109, 47);
            this.btn_neuesuche.TabIndex = 4;
            this.btn_neuesuche.Text = "Neue Suche";
            this.btn_neuesuche.UseVisualStyleBackColor = false;
            this.btn_neuesuche.Click += new System.EventHandler(this.Btn_neuesuche_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Von";
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(397, 416);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainView";
            this.Text = "Fahrplan";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_suche;
        private System.Windows.Forms.Button btn_abfahrtsortsuche;
        private System.Windows.Forms.Button btn_neuesuche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Resultate;
        private System.Windows.Forms.ComboBox txtbox_von;
        private System.Windows.Forms.ComboBox txtbox_nach;
    }
}

