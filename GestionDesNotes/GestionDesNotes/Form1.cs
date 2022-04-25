namespace GestionDesNotes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cliquez sur le bouton etudiant pour accedez a l'interface etudiant, \n " +
                "Cliquez sur le bouton ecours pour accedez a l'interface cours, \n" +
                "Cliquez sur le bouton note pour accedez a l'interface note ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Etudiant interfaceEtudiant = new Etudiant();
            interfaceEtudiant.Show(); 
        }
    }
}