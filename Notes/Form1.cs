namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] tableauInfo = new string[] { textBox1.Text, textBox2.Text, textBox3.Text };

            ListViewItem list = new ListViewItem(tableauInfo);

            listView1.Items.Add(list);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {   
            if(listView1.SelectedIndices.Count > 0)
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter streamWriter = new StreamWriter("C:/Users/angeb/Dropbox/PC/Downloads/EnregistrementProjetFinalClasseNotes/Notes.Txt", false);

            foreach(ListViewItem item in listView1.Items)
            {
                streamWriter.WriteLine(item.SubItems[0].Text + "/" + item.SubItems[1].Text + "/"+ item.SubItems[2].Text);
            }
            streamWriter.Close();
        }

        private void Chercher_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem listes in listView1.Items)
            {
                if (listes.SubItems[0].Text == textBox1.Text)
                {
                    MessageBox.Show("l'etudiant exixte");
                }
            }

            foreach (ListViewItem listes in listView1.Items)
            {
                if (listes.SubItems[0].Text != textBox1.Text)
                {
                    MessageBox.Show("l'etudiant n'existe pas");
                }
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}