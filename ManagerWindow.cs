using System.Drawing.Printing;
using Personal_Information;


namespace Personal_Information

{
    public partial class ManagerWindow : Form
    {
        private readonly AccessInformation _information;

        public ManagerWindow(AccessInformation info)
        {
            _information = info;
            InitializeComponent();
            PopulateList();
        }

        private void PopulateList()
        {
            foreach (var item in _information.Credentials)
                Items.Items.Add(item.ToString());
        }
        //Add Item
        private void addItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DomainBox.Text.ToString() == ""
               || UsernameBox.Text.ToString() == ""
               || PasswordBox.Text.ToString() == "") { return; }
            string domain = DomainBox.Text.ToString();
            string username = UsernameBox.Text.ToString();
            string password = PasswordBox.Text.ToString();

            _information.AddCredential(new Credential(domain, username, password));
            RefreshListBox();
        }
        //Remove Item
        private void removeItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null) return;
            var item = Items.SelectedItem;
            Items.Items.Remove(item);
            var credential = GetCredential(item);
            _information.DeleteCredential(credential!);
        }
        //Update Domain
        private void domainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null)
            {
                RefreshListBox();
                return;
            }
            var item = Items.SelectedItem;

            if (DomainBox.Text.ToString() != "")
            {
                var credential = GetCredential(item);
                _information.UpdateDomain(credential, DomainBox.Text);
            }
            RefreshListBox();
        }
        //Update Username
        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null)
            {
                RefreshListBox();
                return;
            }
            var item = Items.SelectedItem;

            if (UsernameBox.Text.ToString() != "")
            {
                var credential = GetCredential(item);
                _information.UpdateUsername(credential, UsernameBox.Text);
            }
            RefreshListBox();
        }
        //Update Password
        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Items.SelectedItem == null)
            {
                RefreshListBox();
                return;
            }
            var item = Items.SelectedItem;

            if (PasswordBox.Text.ToString() != "")
            {
                var credential = GetCredential(item);
                _information.UpdatePassword(credential, PasswordBox.Text);
            }

            RefreshListBox();
        }

        private void byDomainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DomainBox.Text.ToString() != "")
            {
                Items.Items.Clear();
                foreach (var item in _information.Credentials)
                    if (item.Domain == DomainBox.Text)
                        Items.Items.Add(item);
            }
        }

        private void byUsernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text.ToString() != "")
            {
                Items.Items.Clear();
                foreach (var item in _information.Credentials)
                    if (item.Username == UsernameBox.Text)
                        Items.Items.Add(item);
            }
        }

        private void byPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text.ToString() != "")
            {
                Items.Items.Clear();
                foreach (var item in _information.Credentials)
                    if (item.Password == PasswordBox.Text)
                        Items.Items.Add(item);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e) => RefreshListBox();
        private Credential? GetCredential(object item)
        => _information.Credentials.FirstOrDefault(c =>
            item.ToString()!.Contains(c.Domain) &&
            item.ToString()!.Contains(c.Username) &&
            item.ToString()!.Contains(c.Password));

        private void RefreshListBox()
        {
            DomainBox.Clear();
            UsernameBox.Clear();
            PasswordBox.Clear();
            Items.Items.Clear(); PopulateList();
        }
    }
}