using System.Drawing.Printing;
using Personal_Information;


namespace Personal_Information

{
    public partial class Form1 : Form
    {
        private readonly AccessInformation _information;

        public Form1(AccessInformation info)
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

        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DomainBox.Text.ToString() == ""
               || UsernameBox.Text.ToString() == ""
               || PasswordBox.Text.ToString() == "") { return; }
            string domain = DomainBox.Text.ToString();
            string username = UsernameBox.Text.ToString();
            string password = PasswordBox.Text.ToString();

            _information.Credentials.Add(new Credential(domain, username, password));
            RefreshListBox();
        }

        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null) return;
            var item = Items.SelectedItem;
            Items.Items.Remove(item);
            var credential = _information.Credentials.FirstOrDefault(c =>
                item.ToString()!.Contains(c.Domain) &&
                item.ToString()!.Contains(c.Username) &&
                item.ToString()!.Contains(c.Password));
            _information.DeleteCredential(credential!);
        }

        private void domainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null) return;
            var item = Items.SelectedItem;

            if (DomainBox.Text.ToString() != "")
            {
                var credential = _information.Credentials.FirstOrDefault(c =>
                    item.ToString()!.Contains(c.Domain) &&
                    item.ToString()!.Contains(c.Username) &&
                    item.ToString()!.Contains(c.Password));
                credential!.Domain = DomainBox.Text.ToString();
            }
            RefreshListBox();
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null) return;
            var item = Items.SelectedItem;

            if (UsernameBox.Text.ToString() != "")
            {
                var credential = _information.Credentials.FirstOrDefault(c =>
                    item.ToString()!.Contains(c.Domain) &&
                    item.ToString()!.Contains(c.Username) &&
                    item.ToString()!.Contains(c.Password));
                credential!.Username = UsernameBox.Text.ToString();
            }
            RefreshListBox();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null) return;
            var item = Items.SelectedItem;

            if (PasswordBox.Text.ToString() != "")
            {
                var credential = _information.Credentials.FirstOrDefault(c =>
                    item.ToString()!.Contains(c.Domain) &&
                    item.ToString()!.Contains(c.Username) &&
                    item.ToString()!.Contains(c.Password));
                credential!.Password = PasswordBox.Text.ToString();
            }

            RefreshListBox();
        }

        private void RefreshListBox()
        {
            DomainBox.Clear();
            UsernameBox.Clear();
            PasswordBox.Clear();
            Items.Items.Clear(); PopulateList();
        }
    }
}