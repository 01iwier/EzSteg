namespace EzSteg {
    public partial class EzSteg : Form {
        private Boolean useSelectedFile = false;
        public EzSteg() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void btnFileSelect_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select Message File";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Start directory
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    string selectedFilePath = openFileDialog.FileName;
                    tbMessagePath.Text = selectedFilePath;
                    useSelectedFile = true;
                } else {
                    MessageBox.Show("No file was selected.", "File Selection Canceled");
                }
            }

        }

        private void rtbMessage_TextChanged(object sender, EventArgs e) {
            useSelectedFile = false;
        }

        private void btnCoverSelect_Click(object sender, EventArgs e) {

        }

        private void btnOutputSelect_Click(object sender, EventArgs e) {

        }
    }
}
