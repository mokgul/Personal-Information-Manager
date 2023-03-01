using Personal_Information;

namespace Personal_Information

{
    public partial class Form1 : Form
    {
        private readonly AcccessInformation _information;
        private string? _inputBoxText;
        public Form1(AcccessInformation info)
        {
            _information = info;
            InitializeComponent();
            PopulateList();



        }

        public void PopulateList()
        {
            foreach (var item in _information.Credentials)
                Items.Items.Add(item.ToString());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string[] data = _inputBoxText.Split();
            _information.Credentials.Add(new Credential(data[0], data[1], data[2]));
            Items.Items.Clear();
            PopulateList();
            InputBox.Clear();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            _inputBoxText = InputBox.Text;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var item = Items.SelectedItem;
            Items.Items.Remove(item);
            var credential = _information.Credentials.FirstOrDefault(c =>
                item.ToString()!.Contains(c.Domain) &&
                item.ToString()!.Contains(c.Username) &&
                item.ToString()!.Contains(c.Password));
            _information.DeleteCredential(credential!);
        }
    }
}