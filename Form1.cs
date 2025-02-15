using System.Diagnostics;
using System.IO;
using DiscUtils.Iso9660;

namespace ISO_maker
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

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = iso.Text;
            string path = Folder.Text;
            string identifier = Identifier.Text;

            if (identifier == "")
            {

                MessageBox.Show("The identifier for the ISO when mounted is Invalid, Please enter a vald identifier and try again", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error );

            }

            else if (!Directory.Exists(path))
            {

                MessageBox.Show("The data to add to the iso does not exist.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {

                Iso(data, path, identifier);
                MessageBox.Show("The iso has been made!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                iso.Text = string.Empty;
                Folder.Text = string.Empty;
                Identifier.Text = string.Empty;
            }

        }

        static void Iso(string iso, string path, string volumename)
        {

            CDBuilder builder = new CDBuilder();
            builder.UseJoliet = true;
            builder.VolumeIdentifier = volumename;
            
            foreach (var file in Directory.GetFiles(path, "*", SearchOption.AllDirectories))
            {
                
                string relativepath = Path.GetRelativePath(path, file);
                builder.AddFile(relativepath, file);

            }
            
            builder.Build(iso);
            
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
