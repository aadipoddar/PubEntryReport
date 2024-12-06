namespace PubEntryReport
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			insertButton = new Button();
			nameTextBox = new TextBox();
			numberTextBox = new TextBox();
			nameLabel = new Label();
			numberLabel = new Label();
			personListBox = new ListBox();
			getDataButton = new Button();
			updateButton = new Button();
			deleteButton = new Button();
			SuspendLayout();
			// 
			// insertButton
			// 
			insertButton.Location = new Point(845, 205);
			insertButton.Name = "insertButton";
			insertButton.Size = new Size(128, 45);
			insertButton.TabIndex = 0;
			insertButton.Text = "Insert";
			insertButton.UseVisualStyleBackColor = true;
			insertButton.Click += insertButton_Click;
			// 
			// nameTextBox
			// 
			nameTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			nameTextBox.Location = new Point(899, 89);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(385, 39);
			nameTextBox.TabIndex = 1;
			// 
			// numberTextBox
			// 
			numberTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
			numberTextBox.Location = new Point(899, 151);
			numberTextBox.Name = "numberTextBox";
			numberTextBox.Size = new Size(385, 39);
			numberTextBox.TabIndex = 2;
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Font = new Font("Segoe UI", 18F);
			nameLabel.Location = new Point(792, 92);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new Size(78, 32);
			nameLabel.TabIndex = 3;
			nameLabel.Text = "Name";
			// 
			// numberLabel
			// 
			numberLabel.AutoSize = true;
			numberLabel.Font = new Font("Segoe UI", 18F);
			numberLabel.Location = new Point(792, 154);
			numberLabel.Name = "numberLabel";
			numberLabel.Size = new Size(102, 32);
			numberLabel.TabIndex = 4;
			numberLabel.Text = "Number";
			// 
			// personListBox
			// 
			personListBox.FormattingEnabled = true;
			personListBox.ItemHeight = 15;
			personListBox.Location = new Point(12, 12);
			personListBox.Name = "personListBox";
			personListBox.Size = new Size(757, 739);
			personListBox.TabIndex = 6;
			personListBox.SelectedIndexChanged += personListBox_SelectedIndexChanged;
			// 
			// getDataButton
			// 
			getDataButton.Location = new Point(845, 266);
			getDataButton.Name = "getDataButton";
			getDataButton.Size = new Size(128, 45);
			getDataButton.TabIndex = 7;
			getDataButton.Text = "Get Data";
			getDataButton.UseVisualStyleBackColor = true;
			getDataButton.Click += getDataButton_Click;
			// 
			// updateButton
			// 
			updateButton.Location = new Point(1002, 205);
			updateButton.Name = "updateButton";
			updateButton.Size = new Size(128, 45);
			updateButton.TabIndex = 8;
			updateButton.Text = "Update";
			updateButton.UseVisualStyleBackColor = true;
			updateButton.Click += updateButton_Click;
			// 
			// deleteButton
			// 
			deleteButton.Location = new Point(1156, 205);
			deleteButton.Name = "deleteButton";
			deleteButton.Size = new Size(128, 45);
			deleteButton.TabIndex = 9;
			deleteButton.Text = "Delete";
			deleteButton.UseVisualStyleBackColor = true;
			deleteButton.Click += deleteButton_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1528, 787);
			Controls.Add(deleteButton);
			Controls.Add(updateButton);
			Controls.Add(getDataButton);
			Controls.Add(personListBox);
			Controls.Add(numberLabel);
			Controls.Add(nameLabel);
			Controls.Add(numberTextBox);
			Controls.Add(nameTextBox);
			Controls.Add(insertButton);
			Name = "MainForm";
			Text = "MainForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button insertButton;
		private TextBox nameTextBox;
		private TextBox numberTextBox;
		private Label nameLabel;
		private Label numberLabel;
		private ListBox personListBox;
		private Button getDataButton;
		private Button updateButton;
		private Button deleteButton;
	}
}