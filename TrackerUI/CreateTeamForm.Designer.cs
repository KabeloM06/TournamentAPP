namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.cellValue = new System.Windows.Forms.TextBox();
            this.cellLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.surnameValue = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedMemberButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(12, 112);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(358, 35);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(12, 72);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(157, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMemberButton
            // 
            this.addMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.addMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.addMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMemberButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addMemberButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.addMemberButton.Location = new System.Drawing.Point(49, 269);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(233, 56);
            this.addMemberButton.TabIndex = 19;
            this.addMemberButton.Text = "Add Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(12, 215);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(358, 38);
            this.selectTeamMemberDropdown.TabIndex = 18;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(12, 164);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(263, 37);
            this.selectTeamMemberLabel.TabIndex = 17;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.cellValue);
            this.groupBox1.Controls.Add(this.cellLabel);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.surnameValue);
            this.groupBox1.Controls.Add(this.surnameLabel);
            this.groupBox1.Controls.Add(this.firstNameValue);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.groupBox1.Location = new System.Drawing.Point(13, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 277);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.createMemberButton.Location = new System.Drawing.Point(63, 220);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(218, 42);
            this.createMemberButton.TabIndex = 20;
            this.createMemberButton.Text = "Create Member";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // cellValue
            // 
            this.cellValue.Location = new System.Drawing.Point(124, 176);
            this.cellValue.Name = "cellValue";
            this.cellValue.Size = new System.Drawing.Size(217, 39);
            this.cellValue.TabIndex = 16;
            // 
            // cellLabel
            // 
            this.cellLabel.AutoSize = true;
            this.cellLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cellLabel.Location = new System.Drawing.Point(5, 180);
            this.cellLabel.Name = "cellLabel";
            this.cellLabel.Size = new System.Drawing.Size(47, 30);
            this.cellLabel.TabIndex = 15;
            this.cellLabel.Text = "Cell";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(124, 131);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(217, 39);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.emailLabel.Location = new System.Drawing.Point(5, 135);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // surnameValue
            // 
            this.surnameValue.Location = new System.Drawing.Point(124, 86);
            this.surnameValue.Name = "surnameValue";
            this.surnameValue.Size = new System.Drawing.Size(217, 39);
            this.surnameValue.TabIndex = 12;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.surnameLabel.Location = new System.Drawing.Point(5, 90);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(95, 30);
            this.surnameLabel.TabIndex = 11;
            this.surnameLabel.Text = "Surname";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(124, 41);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(217, 39);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(5, 45);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(113, 30);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(393, 109);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(295, 512);
            this.teamMembersListBox.TabIndex = 21;
            // 
            // deleteSelectedMemberButton
            // 
            this.deleteSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.deleteSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.deleteSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deleteSelectedMemberButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.deleteSelectedMemberButton.Location = new System.Drawing.Point(711, 328);
            this.deleteSelectedMemberButton.Name = "deleteSelectedMemberButton";
            this.deleteSelectedMemberButton.Size = new System.Drawing.Size(122, 75);
            this.deleteSelectedMemberButton.TabIndex = 22;
            this.deleteSelectedMemberButton.Text = "Delete Selected";
            this.deleteSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createTeamButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.createTeamButton.Location = new System.Drawing.Point(276, 633);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(306, 70);
            this.createTeamButton.TabIndex = 25;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 715);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "CreateTeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox teamNameValue;
        private Label teamNameLabel;
        private Label headerLabel;
        private Button addMemberButton;
        private ComboBox selectTeamMemberDropdown;
        private Label selectTeamMemberLabel;
        private GroupBox groupBox1;
        private Button createMemberButton;
        private TextBox cellValue;
        private Label cellLabel;
        private TextBox emailValue;
        private Label emailLabel;
        private TextBox surnameValue;
        private Label surnameLabel;
        private TextBox firstNameValue;
        private Label firstNameLabel;
        private ListBox teamMembersListBox;
        private Button deleteSelectedMemberButton;
        private Button createTeamButton;
    }
}