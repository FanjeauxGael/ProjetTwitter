
namespace ProjetTwitter
{
    partial class Index
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
            this.Search = new System.Windows.Forms.Button();
            this.p_search = new System.Windows.Forms.Panel();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.p_progressBar = new System.Windows.Forms.Panel();
            this.pb_search = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.p_search.SuspendLayout();
            this.p_progressBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(702, 12);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(86, 24);
            this.Search.TabIndex = 0;
            this.Search.Text = "Recherche";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.button1_Click);
            // 
            // p_search
            // 
            this.p_search.Controls.Add(this.tb_search);
            this.p_search.Controls.Add(this.Search);
            this.p_search.Location = new System.Drawing.Point(0, 0);
            this.p_search.Name = "p_search";
            this.p_search.Size = new System.Drawing.Size(799, 50);
            this.p_search.TabIndex = 1;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(12, 13);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(684, 20);
            this.tb_search.TabIndex = 1;
            // 
            // p_progressBar
            // 
            this.p_progressBar.Controls.Add(this.pb_search);
            this.p_progressBar.Location = new System.Drawing.Point(0, 51);
            this.p_progressBar.Name = "p_progressBar";
            this.p_progressBar.Size = new System.Drawing.Size(799, 36);
            this.p_progressBar.TabIndex = 2;
            // 
            // pb_search
            // 
            this.pb_search.Location = new System.Drawing.Point(13, 6);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(775, 23);
            this.pb_search.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(0, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 366);
            this.panel1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(799, 366);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.p_progressBar);
            this.Controls.Add(this.p_search);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::ProjetTwitter.Properties.Settings.Default, "Title", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Name = "Index";
            this.Text = global::ProjetTwitter.Properties.Settings.Default.Title;
            this.p_search.ResumeLayout(false);
            this.p_search.PerformLayout();
            this.p_progressBar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Panel p_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Panel p_progressBar;
        private System.Windows.Forms.ProgressBar pb_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
    }
}

