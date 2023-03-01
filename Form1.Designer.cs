namespace Personal_Information
{
    partial class Form1
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
            AddButton = new Button();
            RemoveButton = new Button();
            Items = new ListBox();
            InputBox = new TextBox();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(356, 57);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(104, 39);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add Item";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(356, 125);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(104, 40);
            RemoveButton.TabIndex = 1;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // Items
            // 
            Items.FormattingEnabled = true;
            Items.ItemHeight = 15;
            Items.Location = new Point(47, 39);
            Items.Name = "Items";
            Items.Size = new Size(237, 334);
            Items.TabIndex = 2;
            // 
            // InputBox
            // 
            InputBox.Location = new Point(47, 395);
            InputBox.Name = "InputBox";
            InputBox.Size = new Size(237, 23);
            InputBox.TabIndex = 3;
            InputBox.TextChanged += InputBox_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 450);
            Controls.Add(InputBox);
            Controls.Add(Items);
            Controls.Add(RemoveButton);
            Controls.Add(AddButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Button RemoveButton;
        private ListBox Items;
        private TextBox InputBox;
    }
}