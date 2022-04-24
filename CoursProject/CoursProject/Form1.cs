using System;
using System.Windows.Forms;

namespace CoursProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            string[] tInfos = new string[] { textBox1.Text, textBox2.Text, textBox3.Text };
            ListViewItem list = new ListViewItem(tInfos);

            listViewCours.Items.Add(list);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            if (listViewCours.SelectedItems.Count > 0)
            {
                listViewCours.Items.Remove(listViewCours.SelectedItems[0]);
            }
        }

       private void Enregistrer_Click(object sender, EventArgs e)
        {
            StreamWriter saveList = new StreamWriter ("C:/Users/kamen/source/repos/CoursProject/CoursProject/Cour.txt", false);
            foreach (ListViewItem item in listViewCours.SelectedItems)
            {
                saveList.WriteLine(item.SubItems[0].Text + "/" +item.SubItems[1].Text +"/"+ item.SubItems[2].Text);
            }
            saveList.Close();
        }

        int indiceitem;
        private void Modifier_Click(object sender, EventArgs e)
        {
            if (listViewCours.SelectedItems.Count > 0)
            {
                 indiceitem = listViewCours.SelectedIndices[0];
                textBox1.Text = listViewCours.Items[indiceitem].SubItems[0].Text;
                textBox2.Text = listViewCours.Items[indiceitem].SubItems[1].Text;
                textBox3.Text = listViewCours.Items[indiceitem].SubItems[2].Text;
                
            }
            modif();
        }
        private void modif()
        {
            listViewCours.Items[indiceitem].SubItems[0].Text = textBox1.Text;
            listViewCours.Items[indiceitem].SubItems[1].Text = textBox2.Text;
            listViewCours.Items[indiceitem].SubItems[2].Text = textBox3.Text;
        }
    }
}
