namespace Notes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Numero_Etudiant = new System.Windows.Forms.Label();
            this.Numero_Cours = new System.Windows.Forms.Label();
            this.Note = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NumEtudiant = new System.Windows.Forms.ColumnHeader();
            this.NumCours = new System.Windows.Forms.ColumnHeader();
            this.Notes = new System.Windows.Forms.ColumnHeader();
            this.Chercher = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(210, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(210, 131);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(210, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 27);
            this.textBox3.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(294, 351);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(94, 29);
            this.Supprimer.TabIndex = 4;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.button2_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(564, 351);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(94, 29);
            this.Modifier.TabIndex = 5;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(792, 351);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 6;
            this.button4.Text = "Enregistrer";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Numero_Etudiant
            // 
            this.Numero_Etudiant.AutoSize = true;
            this.Numero_Etudiant.Location = new System.Drawing.Point(31, 48);
            this.Numero_Etudiant.Name = "Numero_Etudiant";
            this.Numero_Etudiant.Size = new System.Drawing.Size(124, 20);
            this.Numero_Etudiant.TabIndex = 8;
            this.Numero_Etudiant.Text = "Numero_Etudiant";
            // 
            // Numero_Cours
            // 
            this.Numero_Cours.AutoSize = true;
            this.Numero_Cours.Location = new System.Drawing.Point(31, 134);
            this.Numero_Cours.Name = "Numero_Cours";
            this.Numero_Cours.Size = new System.Drawing.Size(106, 20);
            this.Numero_Cours.TabIndex = 9;
            this.Numero_Cours.Text = "Numero_Cours";
            // 
            // Note
            // 
            this.Note.AutoSize = true;
            this.Note.Location = new System.Drawing.Point(31, 241);
            this.Note.Name = "Note";
            this.Note.Size = new System.Drawing.Size(42, 20);
            this.Note.TabIndex = 10;
            this.Note.Text = "Note";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumEtudiant,
            this.NumCours,
            this.Notes});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(379, 31);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(303, 234);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NumEtudiant
            // 
            this.NumEtudiant.Text = "NumEtudiant";
            this.NumEtudiant.Width = 100;
            // 
            // NumCours
            // 
            this.NumCours.Text = "NumCours";
            this.NumCours.Width = 100;
            // 
            // Notes
            // 
            this.Notes.Text = "Notes";
            this.Notes.Width = 100;
            // 
            // Chercher
            // 
            this.Chercher.Location = new System.Drawing.Point(792, 236);
            this.Chercher.Name = "Chercher";
            this.Chercher.Size = new System.Drawing.Size(94, 29);
            this.Chercher.TabIndex = 12;
            this.Chercher.Text = "Chercher";
            this.Chercher.UseVisualStyleBackColor = true;
            this.Chercher.Click += new System.EventHandler(this.Chercher_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(156, 24);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 450);
            this.Controls.Add(this.Chercher);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Note);
            this.Controls.Add(this.Numero_Cours);
            this.Controls.Add(this.Numero_Etudiant);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Button Supprimer;
        private Button Modifier;
        private Button button4;
        private Label Numero_Etudiant;
        private Label Numero_Cours;
        private Label Note;
        private ListView listView1;
        private ColumnHeader NumEtudiant;
        private ColumnHeader NumCours;
        private ColumnHeader Notes;
        private Button Chercher;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
    }
}