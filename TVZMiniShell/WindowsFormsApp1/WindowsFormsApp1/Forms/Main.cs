using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void UcitavanjeDirektorija()
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();
            string tempPath = "";           

            if (browser.ShowDialog() == DialogResult.OK)
            {
                tempPath = browser.SelectedPath;

            }
            string[] popisDirektorija = Directory.GetFiles(tempPath);
            foreach (string popis in popisDirektorija)
            {
                lbDirektoriji.Items.Add(Path.GetFileName(popis));
            }
        }

        private void btnUcitajDirektorije_Click(object sender, System.EventArgs e)
        {
            UcitavanjeDirektorija();
        }

        private void lbDirektoriji_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string name = lbDirektoriji.SelectedItem.ToString();
            tbNaziv.Clear();
            tbBiljeske.Clear();
            if(ProvjeraZapisa(name)==true)
            {
                tbNaziv.Text = name + ".txt";
                ReadNote(name);
            }          
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            SpremiBiljesku();
        }

        private bool ProvjeraZapisa(string name)
        {
            if (File.Exists($"{name}.txt"))
            {
               
                return true;
            }
            return false;
        }
        private void ReadNote(string name)
        {
            using (StreamReader SR = new StreamReader($"{name}.txt"))
            {
                tbBiljeske.Text = SR.ReadToEnd();

            }
        }
        private void SpremiBiljesku()
        {
            string name = lbDirektoriji.SelectedItem.ToString();
            string biljeska = "";
            biljeska = tbBiljeske.ToString();
            using (StreamWriter SW = new StreamWriter($"{name}.txt"))
            {
                SW.Write(biljeska);
            }

        }

        private void btnDeleteNote_Click(object sender, System.EventArgs e)
        {
            
            if (File.Exists($"{lbDirektoriji.SelectedItem.ToString()}.txt"))
            {
                File.Delete($"{lbDirektoriji.SelectedItem.ToString()}.txt");
            }
             else MessageBox.Show("Zapis pod tim imenom ne postoji", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        
    }

}
