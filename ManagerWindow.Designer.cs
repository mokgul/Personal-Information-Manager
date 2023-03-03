namespace Personal_Information
{
    partial class ManagerWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Items = new ListBox();
            DomainBox = new TextBox();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            addItemToolStripMenuItem = new ToolStripMenuItem();
            removeItemToolStripMenuItem = new ToolStripMenuItem();
            updateItemToolStripMenuItem = new ToolStripMenuItem();
            domainToolStripMenuItem = new ToolStripMenuItem();
            usernameToolStripMenuItem = new ToolStripMenuItem();
            passwordToolStripMenuItem = new ToolStripMenuItem();
            filterToolStripMenuItem = new ToolStripMenuItem();
            byDomainToolStripMenuItem = new ToolStripMenuItem();
            byUsernameToolStripMenuItem = new ToolStripMenuItem();
            byPasswordToolStripMenuItem = new ToolStripMenuItem();
            refreshToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // Items
            // 
            Items.FormattingEnabled = true;
            Items.ItemHeight = 15;
            Items.Location = new Point(47, 39);
            Items.Name = "Items";
            Items.Size = new Size(446, 304);
            Items.TabIndex = 2;
            // 
            // DomainBox
            // 
            DomainBox.Location = new Point(501, 48);
            DomainBox.Name = "DomainBox";
            DomainBox.Size = new Size(270, 23);
            DomainBox.TabIndex = 3;
            // 
            // UsernameBox
            // 
            UsernameBox.Location = new Point(501, 146);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.Size = new Size(201, 23);
            UsernameBox.TabIndex = 4;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(503, 246);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.Size = new Size(199, 23);
            PasswordBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(503, 28);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 6;
            label1.Text = "Domain:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 126);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 6;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(503, 226);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Password:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addItemToolStripMenuItem, removeItemToolStripMenuItem, updateItemToolStripMenuItem, filterToolStripMenuItem, refreshToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(783, 24);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // addItemToolStripMenuItem
            // 
            addItemToolStripMenuItem.Name = "addItemToolStripMenuItem";
            addItemToolStripMenuItem.Size = new Size(68, 20);
            addItemToolStripMenuItem.Text = "Add Item";
            addItemToolStripMenuItem.Click += addItemToolStripMenuItem_Click;
            // 
            // removeItemToolStripMenuItem
            // 
            removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            removeItemToolStripMenuItem.Size = new Size(89, 20);
            removeItemToolStripMenuItem.Text = "Remove Item";
            removeItemToolStripMenuItem.Click += removeItemToolStripMenuItem_Click;
            // 
            // updateItemToolStripMenuItem
            // 
            updateItemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { domainToolStripMenuItem, usernameToolStripMenuItem, passwordToolStripMenuItem });
            updateItemToolStripMenuItem.Name = "updateItemToolStripMenuItem";
            updateItemToolStripMenuItem.Size = new Size(84, 20);
            updateItemToolStripMenuItem.Text = "Update Item";
            // 
            // domainToolStripMenuItem
            // 
            domainToolStripMenuItem.Name = "domainToolStripMenuItem";
            domainToolStripMenuItem.Size = new Size(127, 22);
            domainToolStripMenuItem.Text = "Domain";
            domainToolStripMenuItem.Click += domainToolStripMenuItem_Click;
            // 
            // usernameToolStripMenuItem
            // 
            usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            usernameToolStripMenuItem.Size = new Size(127, 22);
            usernameToolStripMenuItem.Text = "Username";
            usernameToolStripMenuItem.Click += usernameToolStripMenuItem_Click;
            // 
            // passwordToolStripMenuItem
            // 
            passwordToolStripMenuItem.Name = "passwordToolStripMenuItem";
            passwordToolStripMenuItem.Size = new Size(127, 22);
            passwordToolStripMenuItem.Text = "Password";
            passwordToolStripMenuItem.Click += passwordToolStripMenuItem_Click;
            // 
            // filterToolStripMenuItem
            // 
            filterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { byDomainToolStripMenuItem, byUsernameToolStripMenuItem, byPasswordToolStripMenuItem });
            filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            filterToolStripMenuItem.Size = new Size(84, 20);
            filterToolStripMenuItem.Text = "Filter";
            // 
            // byDomainToolStripMenuItem
            // 
            byDomainToolStripMenuItem.Name = "byDomainToolStripMenuItem";
            byDomainToolStripMenuItem.Size = new Size(127, 22);
            byDomainToolStripMenuItem.Text = "By Domain";
            byDomainToolStripMenuItem.Click += byDomainToolStripMenuItem_Click;
            // 
            // byUsernameToolStripMenuItem
            // 
            byUsernameToolStripMenuItem.Name = "byUsernameToolStripMenuItem";
            byUsernameToolStripMenuItem.Size = new Size(127, 22);
            byUsernameToolStripMenuItem.Text = "By Username";
            byUsernameToolStripMenuItem.Click += byUsernameToolStripMenuItem_Click;
            // 
            // byPasswordToolStripMenuItem
            byPasswordToolStripMenuItem.Name = "byPasswordToolStripMenuItem";
            byPasswordToolStripMenuItem.Size = new Size(127, 22);
            byPasswordToolStripMenuItem.Text = "By Password";
            byPasswordToolStripMenuItem.Click += byPasswordToolStripMenuItem_Click;
            //
            //refreshToolStripMenuItem
            refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            refreshToolStripMenuItem.Size = new Size(84, 20);
            refreshToolStripMenuItem.Text = "Refresh";
            refreshToolStripMenuItem.Click += refreshToolStripMenuItem_Click;
            //
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PasswordBox);
            Controls.Add(UsernameBox);
            Controls.Add(DomainBox);
            Controls.Add(Items);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox Items;
        private TextBox DomainBox;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addItemToolStripMenuItem;
        private ToolStripMenuItem removeItemToolStripMenuItem;
        private ToolStripMenuItem updateItemToolStripMenuItem;
        private ToolStripMenuItem domainToolStripMenuItem;
        private ToolStripMenuItem usernameToolStripMenuItem;
        private ToolStripMenuItem passwordToolStripMenuItem;
        private ToolStripMenuItem filterToolStripMenuItem;
        private ToolStripMenuItem byDomainToolStripMenuItem;
        private ToolStripMenuItem byUsernameToolStripMenuItem;
        private ToolStripMenuItem byPasswordToolStripMenuItem;
        private ToolStripMenuItem refreshToolStripMenuItem;

    }
}