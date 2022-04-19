namespace WinFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LeNumeroEtudiant = new System.Windows.Forms.TextBox();
            this.LePrenom = new System.Windows.Forms.TextBox();
            this.LeNom = new System.Windows.Forms.TextBox();
            this.LeCours = new System.Windows.Forms.TextBox();
            this.LaNotes = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.liste_Etudiants = new System.Windows.Forms.ListView();
            this.coloneNum_Etudiants = new System.Windows.Forms.ColumnHeader();
            this.coloneNom = new System.Windows.Forms.ColumnHeader();
            this.colonePrenom = new System.Windows.Forms.ColumnHeader();
            this.coloneCours = new System.Windows.Forms.ColumnHeader();
            this.coloneNotes = new System.Windows.Forms.ColumnHeader();
            this.LeMenue = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supprimerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.champ_recherche = new System.Windows.Forms.TextBox();
            this.accueilleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.Menue_Navigation = new System.Windows.Forms.ToolStripMenuItem();
            this.Menue_Accueille = new System.Windows.Forms.ToolStripMenuItem();
            this.Menue_Cours = new System.Windows.Forms.ToolStripMenuItem();
            this.Menue_Notes = new System.Windows.Forms.ToolStripMenuItem();
            this.Menue_Aides = new System.Windows.Forms.ToolStripMenuItem();
            this.LeMenue.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etudiants";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num_Etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prenom";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cours";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Notes";
            // 
            // LeNumeroEtudiant
            // 
            this.LeNumeroEtudiant.Location = new System.Drawing.Point(113, 100);
            this.LeNumeroEtudiant.Name = "LeNumeroEtudiant";
            this.LeNumeroEtudiant.Size = new System.Drawing.Size(100, 23);
            this.LeNumeroEtudiant.TabIndex = 6;
            // 
            // LePrenom
            // 
            this.LePrenom.Location = new System.Drawing.Point(113, 195);
            this.LePrenom.Name = "LePrenom";
            this.LePrenom.Size = new System.Drawing.Size(100, 23);
            this.LePrenom.TabIndex = 7;
            // 
            // LeNom
            // 
            this.LeNom.Location = new System.Drawing.Point(113, 147);
            this.LeNom.Name = "LeNom";
            this.LeNom.Size = new System.Drawing.Size(100, 23);
            this.LeNom.TabIndex = 8;
            // 
            // LeCours
            // 
            this.LeCours.Location = new System.Drawing.Point(113, 251);
            this.LeCours.Name = "LeCours";
            this.LeCours.Size = new System.Drawing.Size(100, 23);
            this.LeCours.TabIndex = 9;
            // 
            // LaNotes
            // 
            this.LaNotes.Location = new System.Drawing.Point(113, 302);
            this.LaNotes.Name = "LaNotes";
            this.LaNotes.Size = new System.Drawing.Size(100, 23);
            this.LaNotes.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // liste_Etudiants
            // 
            this.liste_Etudiants.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.coloneNum_Etudiants,
            this.coloneNom,
            this.colonePrenom,
            this.coloneCours,
            this.coloneNotes});
            this.liste_Etudiants.ContextMenuStrip = this.LeMenue;
            this.liste_Etudiants.FullRowSelect = true;
            this.liste_Etudiants.GridLines = true;
            this.liste_Etudiants.Location = new System.Drawing.Point(256, 100);
            this.liste_Etudiants.Name = "liste_Etudiants";
            this.liste_Etudiants.Size = new System.Drawing.Size(441, 225);
            this.liste_Etudiants.TabIndex = 15;
            this.liste_Etudiants.UseCompatibleStateImageBehavior = false;
            this.liste_Etudiants.View = System.Windows.Forms.View.Details;
            // 
            // coloneNum_Etudiants
            // 
            this.coloneNum_Etudiants.Text = "Num_Etudiants";
            this.coloneNum_Etudiants.Width = 100;
            // 
            // coloneNom
            // 
            this.coloneNom.Text = "Nom";
            this.coloneNom.Width = 100;
            // 
            // colonePrenom
            // 
            this.colonePrenom.Text = "Prenom";
            this.colonePrenom.Width = 100;
            // 
            // coloneCours
            // 
            this.coloneCours.Text = "Cours";
            this.coloneCours.Width = 70;
            // 
            // coloneNotes
            // 
            this.coloneNotes.Text = "Notes";
            this.coloneNotes.Width = 65;
            // 
            // LeMenue
            // 
            this.LeMenue.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modifierToolStripMenuItem,
            this.supprimerToolStripMenuItem});
            this.LeMenue.Name = "LeMenue";
            this.LeMenue.Size = new System.Drawing.Size(130, 48);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.modifierToolStripMenuItem.Text = "Modifier";
            this.modifierToolStripMenuItem.Click += new System.EventHandler(this.modifierToolStripMenuItem_Click);
            // 
            // supprimerToolStripMenuItem
            // 
            this.supprimerToolStripMenuItem.Name = "supprimerToolStripMenuItem";
            this.supprimerToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.supprimerToolStripMenuItem.Text = "Supprimer";
            this.supprimerToolStripMenuItem.Click += new System.EventHandler(this.supprimerToolStripMenuItem_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Enregistrer";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Chercher";
            // 
            // champ_recherche
            // 
            this.champ_recherche.Location = new System.Drawing.Point(113, 53);
            this.champ_recherche.Name = "champ_recherche";
            this.champ_recherche.Size = new System.Drawing.Size(100, 23);
            this.champ_recherche.TabIndex = 18;
            this.champ_recherche.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // accueilleToolStripMenuItem
            // 
            this.accueilleToolStripMenuItem.Name = "accueilleToolStripMenuItem";
            this.accueilleToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // coureToolStripMenuItem
            // 
            this.coureToolStripMenuItem.Name = "coureToolStripMenuItem";
            this.coureToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // coursToolStripMenuItem
            // 
            this.coursToolStripMenuItem.Name = "coursToolStripMenuItem";
            this.coursToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menue_Navigation,
            this.Menue_Aides});
            this.Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(709, 24);
            this.Menu.TabIndex = 19;
            this.Menu.Text = "Menue_de_navigation";
            // 
            // Menue_Navigation
            // 
            this.Menue_Navigation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menue_Accueille,
            this.Menue_Cours,
            this.Menue_Notes});
            this.Menue_Navigation.Name = "Menue_Navigation";
            this.Menue_Navigation.Size = new System.Drawing.Size(77, 20);
            this.Menue_Navigation.Text = "Navigation";
            // 
            // Menue_Accueille
            // 
            this.Menue_Accueille.Name = "Menue_Accueille";
            this.Menue_Accueille.Size = new System.Drawing.Size(122, 22);
            this.Menue_Accueille.Text = "Accueille";
            // 
            // Menue_Cours
            // 
            this.Menue_Cours.Name = "Menue_Cours";
            this.Menue_Cours.Size = new System.Drawing.Size(122, 22);
            this.Menue_Cours.Text = "Cours";
            // 
            // Menue_Notes
            // 
            this.Menue_Notes.Name = "Menue_Notes";
            this.Menue_Notes.Size = new System.Drawing.Size(122, 22);
            this.Menue_Notes.Text = "Notes";
            // 
            // Menue_Aides
            // 
            this.Menue_Aides.Name = "Menue_Aides";
            this.Menue_Aides.Size = new System.Drawing.Size(48, 20);
            this.Menue_Aides.Text = "Aides";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 408);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.champ_recherche);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.liste_Etudiants);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LaNotes);
            this.Controls.Add(this.LeCours);
            this.Controls.Add(this.LeNom);
            this.Controls.Add(this.LePrenom);
            this.Controls.Add(this.LeNumeroEtudiant);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.Menu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LeMenue.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox LeNumeroEtudiant;
        private TextBox LePrenom;
        private TextBox LeNom;
        private TextBox LeCours;
        private TextBox LaNotes;
        private Button button1;
        private ListView liste_Etudiants;
        private ColumnHeader coloneNum_Etudiants;
        private ColumnHeader coloneNom;
        private ColumnHeader colonePrenom;
        private ColumnHeader coloneCours;
        private ColumnHeader coloneNotes;
        private Button button5;
        private ContextMenuStrip LeMenue;
        private ToolStripMenuItem modifierToolStripMenuItem;
        private ToolStripMenuItem supprimerToolStripMenuItem;
        private Label label7;
        private TextBox champ_recherche;
        private ToolStripMenuItem accueilleToolStripMenuItem;
        private ToolStripMenuItem coureToolStripMenuItem;
        private ToolStripMenuItem coursToolStripMenuItem;
        private ToolStripMenuItem notesToolStripMenuItem;
        private MenuStrip Menu;
        private ToolStripMenuItem Menue_Navigation;
        private ToolStripMenuItem Menue_Accueille;
        private ToolStripMenuItem Menue_Cours;
        private ToolStripMenuItem Menue_Notes;
        private ToolStripMenuItem Menue_Aides;
    }
}