using System.Net.Http;
using System.Windows.Forms;

namespace ScriptSharp.ScriptEditor
{
    public partial class ScriptEditor : Form
    {
        public ScriptEditor()
        {
            InitializeComponent();
        }
        
        private void CodeEdit_KeyDown(object sender, KeyEventArgs e)
        {
            if (CodeEdit.SelectedText.Length > 0 && e.KeyCode == Keys.Enter && e.Alt)
            {
                const string baseAddress = "http://localhost:9000/";
                using (var client = new HttpClient())
                {
                    var response = client.PostAsJsonAsync(baseAddress + "api/code", CodeEdit.SelectedText).Result;
                }
            }
        }
    }
}
