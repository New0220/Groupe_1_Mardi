using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesNotes
{
    public partial class Etudiant : Form
    {
        public Etudiant()
        {
            InitializeComponent();
        }
        //bouton ajouter 
        private void button1_Click(object sender, EventArgs e)
        {
            //on verifie si l'etudiant ajouter existe deje si c'est le cas on ne l'ajoute plus 
            bool existance = false;
            foreach (ListViewItem laListe in liste_Etudiants.Items)
            {

                if (laListe.SubItems[0].Text == LeNumeroEtudiant.Text)
                {
                    existance = true;
                }
            }

            if (existance == true)
            {
                MessageBox.Show("Cet Etudaints existe deja", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                DialogResult reponse = MessageBox.Show("Est ce une modification que vous voulez effectuer ?",
                    "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1);

                if (reponse == DialogResult.Yes)
                {
                    //si le boutons est modifier on effectue les modicications
                    if (button1.Text == "Modifier")
                    {
                        liste_Etudiants.Items[indiceDelaligne].SubItems[0].Text = LeNumeroEtudiant.Text;
                        liste_Etudiants.Items[indiceDelaligne].SubItems[1].Text = LeNom.Text;
                        liste_Etudiants.Items[indiceDelaligne].SubItems[2].Text = LePrenom.Text;
                        liste_Etudiants.Items[indiceDelaligne].SubItems[3].Text = LeCours.Text;
                        liste_Etudiants.Items[indiceDelaligne].SubItems[4].Text = LaNotes.Text;

                        //et on change le bouton modifier a Ajouter
                        button1.Text = "Ajouter";

                        //ici on vide le contenue de chauqe champ d'entrer
                        viderLeconteDechampText();
                    }
                }
            }
            else
            {
                //si le bouton est ajouter on effectue un ajout
                if (button1.Text == "Ajouter")
                {
                    // ici ont ajoute des element dans le tableau

                    string[] donneEtudiants = new string[] { LeNumeroEtudiant.Text, LeNom.Text, LePrenom.Text, LeCours.Text, LaNotes.Text };
                    ListViewItem listDeDonne = new ListViewItem(donneEtudiants);

                    liste_Etudiants.Items.Add(listDeDonne);

                    //ici on vide le contenue de chauqe champ d'entrer
                    viderLeconteDechampText();

                    MessageBox.Show("Ajout Reussi");
                }
            }
        }

        //methode pour vider le contenue de champs texte
        public void viderLeconteDechampText()
        {
            LeNumeroEtudiant.Clear();
            LeNom.Clear();
            LePrenom.Clear();
            LeCours.Clear();
            LaNotes.Clear();
        }

        //Bouton enregister
        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                //ici on ecrit dans un ficher txt grace a streamwrite
                StreamWriter enregistreList = new StreamWriter("C:/Users/Admin/Dropbox/PC/Desktop/listeDesEtudiants.txt", false);

                //ici on parcour la liste et on ecrit dans le fichier de sauvegarde toute les donne de notre liste 
                foreach (ListViewItem laliste in liste_Etudiants.Items)
                {
                    enregistreList.WriteLine(laliste.SubItems[0].Text + "/" +
                        laliste.SubItems[1].Text + "/" + laliste.SubItems[2].Text + "/" +
                        laliste.SubItems[3].Text + "/" + laliste.SubItems[4].Text);
                }

                enregistreList.Close();

                MessageBox.Show("Enregistrement Effectuer");
            }catch (Exception ex)
            {
                MessageBox.Show("Erreur veuillez recommencer");
            }
        }

        //l'affichage de la liste des etudians au demarage du formulaire 
        private void Form1_Load(object sender, EventArgs e)
        {
            //ici on li la liste des etudiant enregistrer dans le fichier txt
            StreamReader lireLaiste = new StreamReader("C:/Users/Admin/Dropbox/PC/Desktop/listeDesEtudiants.txt");
            string ligne;
            //ici on verifie si le document est vide ou pas 
            while ((ligne = lireLaiste.ReadLine()) != null)
            {
                string[] tabLigne = ligne.Split('/');
                ListViewItem donneDeLeListe = new ListViewItem(tabLigne);
                liste_Etudiants.Items.Add(donneDeLeListe);
            }

            lireLaiste.Close();
        }

        //suppression 
        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ici on suprime un elements selectionner dans le tableau 

            if (liste_Etudiants.SelectedIndices.Count > 0)
            {
                //ici on demande a l'utilisateur s'il veut vraiment faire cette action si oui l'action est effectuer
                DialogResult reponse = MessageBox.Show("Voules vous vraimennt supprimer la ligne ? ",
                    "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button3);

                if (reponse == DialogResult.Yes)
                {
                    liste_Etudiants.Items.Remove(liste_Etudiants.SelectedItems[0]);
                    MessageBox.Show("Suppression Reussi");
                }
                else
                {
                    MessageBox.Show("Suppression annuler");
                }
            }

        }

        //Modification
        int indiceDelaligne;
        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //on verifi si un element est selectionner

            if (liste_Etudiants.SelectedItems.Count > 0)
            {
                //on recupere l'element selectionner dans une variable
                indiceDelaligne = liste_Etudiants.SelectedIndices[0];

                //une fois l'element selectionner on affiche le contenue dans les champs texte
                LeNumeroEtudiant.Text = liste_Etudiants.Items[indiceDelaligne].SubItems[0].Text;
                LeNom.Text = liste_Etudiants.Items[indiceDelaligne].SubItems[1].Text;
                LePrenom.Text = liste_Etudiants.Items[indiceDelaligne].SubItems[2].Text;
                LeCours.Text = liste_Etudiants.Items[indiceDelaligne].SubItems[3].Text;
                LaNotes.Text = liste_Etudiants.Items[indiceDelaligne].SubItems[4].Text;
            }

            //puis on change le bouton Ajouter par modifier
            button1.Text = "Modifier";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // liste_Etudiants.Items.Clear();

            foreach (ListViewItem listes in liste_Etudiants.Items)
            {
                if (listes.SubItems[0].Text == champ_recherche.Text)
                {
                    MessageBox.Show("Etudiant trouvé");
                }
            }
        }

        //informe l'utilisateur comment utilise l'interface 
        private void Menue_Aides_Click(object sender, EventArgs e)
        {
            MessageBox.Show("l'utilisation de cette interface etudiant est simple : \n" +
                " *_Pour Ajouter un etudiant il faut renplire le differents champs de texte sauf celui de chercher en suit cliquez sur Ajouter \n" +
                " *_Pour Suprimer un etudiant selectionner celui-ci avec la sourie puis faire un clique droit en suite cliquer sur Suprimer \n" +
                " *_Pour Modifier un etudiant cliquer sur l'etudiant en questionet puis faire un clique droit ensuite cliquer sur Modifier \n" +
                "en suite effectuer les modifiation dans les differents champs et en fin cliquer sur le bouton Modifiern \n" +
                " *_Pour Enregistrer cliquer sur le bouton enregistrer apres avoir effectuer toute vos action", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}

