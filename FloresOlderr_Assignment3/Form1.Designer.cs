namespace FloresOlderr_Assignment3
{
    partial class Form1
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
            this.ClassTypeSingleServerHeaderLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.SingleServerLabel = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.SingleServerComboBox = new System.Windows.Forms.ComboBox();
            this.PercentageHeaderLabel = new System.Windows.Forms.Label();
            this.ServerPercentageLabel = new System.Windows.Forms.Label();
            this.PercentageServerComboBox = new System.Windows.Forms.ComboBox();
            this.RoleTypesHeaderLabel = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.RoleTypesServerLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.RoleServerComboBox = new System.Windows.Forms.ComboBox();
            this.MinNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.MaxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.AllGuildsHeaderLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeComboBox = new System.Windows.Forms.ComboBox();
            this.AllPlayersHeaderLabel = new System.Windows.Forms.Label();
            this.PercentageMaxPlayersHeaderLabel = new System.Windows.Forms.Label();
            this.AllPlayersOfClassServerButton = new System.Windows.Forms.Button();
            this.PercentageRaceButton = new System.Windows.Forms.Button();
            this.RoleTypesButton = new System.Windows.Forms.Button();
            this.GuildsSingleTypeButton = new System.Windows.Forms.Button();
            this.PlayersWithoutRoleButton = new System.Windows.Forms.Button();
            this.MaxLevelPlayersButton = new System.Windows.Forms.Button();
            this.QueryHeaderLabel = new System.Windows.Forms.Label();
            this.ResultsListView = new System.Windows.Forms.ListView();
            this.TankRadioButton = new System.Windows.Forms.RadioButton();
            this.HealerRadioButton = new System.Windows.Forms.RadioButton();
            this.DamageRadioButton = new System.Windows.Forms.RadioButton();
            this.RadioButtonPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).BeginInit();
            this.RadioButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassTypeSingleServerHeaderLabel
            // 
            this.ClassTypeSingleServerHeaderLabel.AutoSize = true;
            this.ClassTypeSingleServerHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassTypeSingleServerHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassTypeSingleServerHeaderLabel.Location = new System.Drawing.Point(15, 9);
            this.ClassTypeSingleServerHeaderLabel.Name = "ClassTypeSingleServerHeaderLabel";
            this.ClassTypeSingleServerHeaderLabel.Size = new System.Drawing.Size(269, 17);
            this.ClassTypeSingleServerHeaderLabel.TabIndex = 0;
            this.ClassTypeSingleServerHeaderLabel.Text = "All Class Type From a Single Server";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassLabel.Location = new System.Drawing.Point(15, 40);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(32, 13);
            this.ClassLabel.TabIndex = 1;
            this.ClassLabel.Text = "Class";
            // 
            // SingleServerLabel
            // 
            this.SingleServerLabel.AutoSize = true;
            this.SingleServerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SingleServerLabel.Location = new System.Drawing.Point(167, 40);
            this.SingleServerLabel.Name = "SingleServerLabel";
            this.SingleServerLabel.Size = new System.Drawing.Size(38, 13);
            this.SingleServerLabel.TabIndex = 2;
            this.SingleServerLabel.Text = "Server";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(18, 57);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(121, 21);
            this.ClassComboBox.TabIndex = 3;
            // 
            // SingleServerComboBox
            // 
            this.SingleServerComboBox.FormattingEnabled = true;
            this.SingleServerComboBox.Location = new System.Drawing.Point(170, 56);
            this.SingleServerComboBox.Name = "SingleServerComboBox";
            this.SingleServerComboBox.Size = new System.Drawing.Size(121, 21);
            this.SingleServerComboBox.TabIndex = 4;
            // 
            // PercentageHeaderLabel
            // 
            this.PercentageHeaderLabel.AutoSize = true;
            this.PercentageHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PercentageHeaderLabel.Location = new System.Drawing.Point(15, 104);
            this.PercentageHeaderLabel.Name = "PercentageHeaderLabel";
            this.PercentageHeaderLabel.Size = new System.Drawing.Size(351, 17);
            this.PercentageHeaderLabel.TabIndex = 5;
            this.PercentageHeaderLabel.Text = "Percentage of Each Race From a Single Server";
            // 
            // ServerPercentageLabel
            // 
            this.ServerPercentageLabel.AutoSize = true;
            this.ServerPercentageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerPercentageLabel.Location = new System.Drawing.Point(170, 133);
            this.ServerPercentageLabel.Name = "ServerPercentageLabel";
            this.ServerPercentageLabel.Size = new System.Drawing.Size(38, 13);
            this.ServerPercentageLabel.TabIndex = 6;
            this.ServerPercentageLabel.Text = "Server";
            // 
            // PercentageServerComboBox
            // 
            this.PercentageServerComboBox.FormattingEnabled = true;
            this.PercentageServerComboBox.Location = new System.Drawing.Point(173, 149);
            this.PercentageServerComboBox.Name = "PercentageServerComboBox";
            this.PercentageServerComboBox.Size = new System.Drawing.Size(121, 21);
            this.PercentageServerComboBox.TabIndex = 7;
            // 
            // RoleTypesHeaderLabel
            // 
            this.RoleTypesHeaderLabel.AutoSize = true;
            this.RoleTypesHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleTypesHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoleTypesHeaderLabel.Location = new System.Drawing.Point(11, 196);
            this.RoleTypesHeaderLabel.Name = "RoleTypesHeaderLabel";
            this.RoleTypesHeaderLabel.Size = new System.Drawing.Size(427, 17);
            this.RoleTypesHeaderLabel.TabIndex = 8;
            this.RoleTypesHeaderLabel.Text = "All Role Types from a Single Server Within a Level Range";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoleLabel.Location = new System.Drawing.Point(15, 228);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(29, 13);
            this.RoleLabel.TabIndex = 9;
            this.RoleLabel.Text = "Role";
            // 
            // RoleTypesServerLabel
            // 
            this.RoleTypesServerLabel.AutoSize = true;
            this.RoleTypesServerLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RoleTypesServerLabel.Location = new System.Drawing.Point(170, 228);
            this.RoleTypesServerLabel.Name = "RoleTypesServerLabel";
            this.RoleTypesServerLabel.Size = new System.Drawing.Size(38, 13);
            this.RoleTypesServerLabel.TabIndex = 10;
            this.RoleTypesServerLabel.Text = "Server";
            // 
            // MinLabel
            // 
            this.MinLabel.AutoSize = true;
            this.MinLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MinLabel.Location = new System.Drawing.Point(15, 292);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(24, 13);
            this.MinLabel.TabIndex = 11;
            this.MinLabel.Text = "Min";
            // 
            // MaxLabel
            // 
            this.MaxLabel.AutoSize = true;
            this.MaxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MaxLabel.Location = new System.Drawing.Point(170, 292);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(27, 13);
            this.MaxLabel.TabIndex = 12;
            this.MaxLabel.Text = "Max";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(18, 245);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleComboBox.TabIndex = 13;
            // 
            // RoleServerComboBox
            // 
            this.RoleServerComboBox.FormattingEnabled = true;
            this.RoleServerComboBox.Location = new System.Drawing.Point(173, 245);
            this.RoleServerComboBox.Name = "RoleServerComboBox";
            this.RoleServerComboBox.Size = new System.Drawing.Size(121, 21);
            this.RoleServerComboBox.TabIndex = 14;
            // 
            // MinNumericUpDown
            // 
            this.MinNumericUpDown.Location = new System.Drawing.Point(18, 309);
            this.MinNumericUpDown.Name = "MinNumericUpDown";
            this.MinNumericUpDown.Size = new System.Drawing.Size(42, 20);
            this.MinNumericUpDown.TabIndex = 15;
            // 
            // MaxNumericUpDown
            // 
            this.MaxNumericUpDown.Location = new System.Drawing.Point(173, 309);
            this.MaxNumericUpDown.Name = "MaxNumericUpDown";
            this.MaxNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.MaxNumericUpDown.TabIndex = 16;
            // 
            // AllGuildsHeaderLabel
            // 
            this.AllGuildsHeaderLabel.AutoSize = true;
            this.AllGuildsHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllGuildsHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllGuildsHeaderLabel.Location = new System.Drawing.Point(11, 357);
            this.AllGuildsHeaderLabel.Name = "AllGuildsHeaderLabel";
            this.AllGuildsHeaderLabel.Size = new System.Drawing.Size(201, 17);
            this.AllGuildsHeaderLabel.TabIndex = 17;
            this.AllGuildsHeaderLabel.Text = "All Guilds of a Single Type";
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TypeLabel.Location = new System.Drawing.Point(18, 384);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(31, 13);
            this.TypeLabel.TabIndex = 18;
            this.TypeLabel.Text = "Type";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.FormattingEnabled = true;
            this.TypeComboBox.Location = new System.Drawing.Point(21, 401);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.TypeComboBox.TabIndex = 19;
            // 
            // AllPlayersHeaderLabel
            // 
            this.AllPlayersHeaderLabel.AutoSize = true;
            this.AllPlayersHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllPlayersHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AllPlayersHeaderLabel.Location = new System.Drawing.Point(11, 443);
            this.AllPlayersHeaderLabel.Name = "AllPlayersHeaderLabel";
            this.AllPlayersHeaderLabel.Size = new System.Drawing.Size(396, 17);
            this.AllPlayersHeaderLabel.TabIndex = 20;
            this.AllPlayersHeaderLabel.Text = "All Players Who Could Fill a Role But Presently Aren\'t";
            // 
            // PercentageMaxPlayersHeaderLabel
            // 
            this.PercentageMaxPlayersHeaderLabel.AutoSize = true;
            this.PercentageMaxPlayersHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PercentageMaxPlayersHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PercentageMaxPlayersHeaderLabel.Location = new System.Drawing.Point(11, 527);
            this.PercentageMaxPlayersHeaderLabel.Name = "PercentageMaxPlayersHeaderLabel";
            this.PercentageMaxPlayersHeaderLabel.Size = new System.Drawing.Size(337, 17);
            this.PercentageMaxPlayersHeaderLabel.TabIndex = 21;
            this.PercentageMaxPlayersHeaderLabel.Text = "Percentage of Max Level Players in all Guilds";
            // 
            // AllPlayersOfClassServerButton
            // 
            this.AllPlayersOfClassServerButton.Location = new System.Drawing.Point(346, 57);
            this.AllPlayersOfClassServerButton.Name = "AllPlayersOfClassServerButton";
            this.AllPlayersOfClassServerButton.Size = new System.Drawing.Size(92, 23);
            this.AllPlayersOfClassServerButton.TabIndex = 22;
            this.AllPlayersOfClassServerButton.Text = "Show Results";
            this.AllPlayersOfClassServerButton.UseVisualStyleBackColor = true;
            this.AllPlayersOfClassServerButton.Click += new System.EventHandler(this.AllPlayersOfClassServerButton_Click);
            // 
            // PercentageRaceButton
            // 
            this.PercentageRaceButton.Location = new System.Drawing.Point(345, 149);
            this.PercentageRaceButton.Name = "PercentageRaceButton";
            this.PercentageRaceButton.Size = new System.Drawing.Size(93, 23);
            this.PercentageRaceButton.TabIndex = 23;
            this.PercentageRaceButton.Text = "Show Results";
            this.PercentageRaceButton.UseVisualStyleBackColor = true;
            this.PercentageRaceButton.Click += new System.EventHandler(this.PercentageRaceButton_Click);
            // 
            // RoleTypesButton
            // 
            this.RoleTypesButton.Location = new System.Drawing.Point(346, 243);
            this.RoleTypesButton.Name = "RoleTypesButton";
            this.RoleTypesButton.Size = new System.Drawing.Size(93, 23);
            this.RoleTypesButton.TabIndex = 24;
            this.RoleTypesButton.Text = "Show Results";
            this.RoleTypesButton.UseVisualStyleBackColor = true;
            this.RoleTypesButton.Click += new System.EventHandler(this.RoleTypesButton_Click);
            // 
            // GuildsSingleTypeButton
            // 
            this.GuildsSingleTypeButton.Location = new System.Drawing.Point(345, 401);
            this.GuildsSingleTypeButton.Name = "GuildsSingleTypeButton";
            this.GuildsSingleTypeButton.Size = new System.Drawing.Size(93, 23);
            this.GuildsSingleTypeButton.TabIndex = 25;
            this.GuildsSingleTypeButton.Text = "Show Results";
            this.GuildsSingleTypeButton.UseVisualStyleBackColor = true;
            this.GuildsSingleTypeButton.Click += new System.EventHandler(this.GuildsSingleTypeButton_Click);
            // 
            // PlayersWithoutRoleButton
            // 
            this.PlayersWithoutRoleButton.Location = new System.Drawing.Point(346, 483);
            this.PlayersWithoutRoleButton.Name = "PlayersWithoutRoleButton";
            this.PlayersWithoutRoleButton.Size = new System.Drawing.Size(93, 23);
            this.PlayersWithoutRoleButton.TabIndex = 26;
            this.PlayersWithoutRoleButton.Text = "Show Results";
            this.PlayersWithoutRoleButton.UseVisualStyleBackColor = true;
            this.PlayersWithoutRoleButton.Click += new System.EventHandler(this.PlayersWithoutRoleButton_Click);
            // 
            // MaxLevelPlayersButton
            // 
            this.MaxLevelPlayersButton.Location = new System.Drawing.Point(346, 562);
            this.MaxLevelPlayersButton.Name = "MaxLevelPlayersButton";
            this.MaxLevelPlayersButton.Size = new System.Drawing.Size(93, 23);
            this.MaxLevelPlayersButton.TabIndex = 27;
            this.MaxLevelPlayersButton.Text = "Show Results";
            this.MaxLevelPlayersButton.UseVisualStyleBackColor = true;
            this.MaxLevelPlayersButton.Click += new System.EventHandler(this.MaxLevelPlayersButton_Click);
            // 
            // QueryHeaderLabel
            // 
            this.QueryHeaderLabel.AutoSize = true;
            this.QueryHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryHeaderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QueryHeaderLabel.Location = new System.Drawing.Point(601, 9);
            this.QueryHeaderLabel.Name = "QueryHeaderLabel";
            this.QueryHeaderLabel.Size = new System.Drawing.Size(52, 17);
            this.QueryHeaderLabel.TabIndex = 28;
            this.QueryHeaderLabel.Text = "Query";
            // 
            // ResultsListView
            // 
            this.ResultsListView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.ResultsListView.AutoArrange = false;
            this.ResultsListView.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultsListView.FullRowSelect = true;
            this.ResultsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ResultsListView.HideSelection = false;
            this.ResultsListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ResultsListView.LabelWrap = false;
            this.ResultsListView.Location = new System.Drawing.Point(453, 40);
            this.ResultsListView.Name = "ResultsListView";
            this.ResultsListView.Size = new System.Drawing.Size(905, 566);
            this.ResultsListView.TabIndex = 29;
            this.ResultsListView.UseCompatibleStateImageBehavior = false;
            this.ResultsListView.View = System.Windows.Forms.View.List;
            // 
            // TankRadioButton
            // 
            this.TankRadioButton.AutoSize = true;
            this.TankRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TankRadioButton.Location = new System.Drawing.Point(8, 21);
            this.TankRadioButton.Name = "TankRadioButton";
            this.TankRadioButton.Size = new System.Drawing.Size(50, 17);
            this.TankRadioButton.TabIndex = 0;
            this.TankRadioButton.TabStop = true;
            this.TankRadioButton.Text = "Tank";
            this.TankRadioButton.UseVisualStyleBackColor = true;
            // 
            // HealerRadioButton
            // 
            this.HealerRadioButton.AutoSize = true;
            this.HealerRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.HealerRadioButton.Location = new System.Drawing.Point(64, 23);
            this.HealerRadioButton.Name = "HealerRadioButton";
            this.HealerRadioButton.Size = new System.Drawing.Size(56, 17);
            this.HealerRadioButton.TabIndex = 1;
            this.HealerRadioButton.TabStop = true;
            this.HealerRadioButton.Text = "Healer";
            this.HealerRadioButton.UseVisualStyleBackColor = true;
            // 
            // DamageRadioButton
            // 
            this.DamageRadioButton.AutoSize = true;
            this.DamageRadioButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.DamageRadioButton.Location = new System.Drawing.Point(120, 23);
            this.DamageRadioButton.Name = "DamageRadioButton";
            this.DamageRadioButton.Size = new System.Drawing.Size(65, 17);
            this.DamageRadioButton.TabIndex = 2;
            this.DamageRadioButton.TabStop = true;
            this.DamageRadioButton.Text = "Damage";
            this.DamageRadioButton.UseVisualStyleBackColor = true;
            // 
            // RadioButtonPanel
            // 
            this.RadioButtonPanel.Controls.Add(this.DamageRadioButton);
            this.RadioButtonPanel.Controls.Add(this.TankRadioButton);
            this.RadioButtonPanel.Controls.Add(this.HealerRadioButton);
            this.RadioButtonPanel.Location = new System.Drawing.Point(19, 468);
            this.RadioButtonPanel.Name = "RadioButtonPanel";
            this.RadioButtonPanel.Size = new System.Drawing.Size(193, 56);
            this.RadioButtonPanel.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InfoText;
            this.ClientSize = new System.Drawing.Size(1370, 618);
            this.Controls.Add(this.RadioButtonPanel);
            this.Controls.Add(this.ResultsListView);
            this.Controls.Add(this.QueryHeaderLabel);
            this.Controls.Add(this.MaxLevelPlayersButton);
            this.Controls.Add(this.PlayersWithoutRoleButton);
            this.Controls.Add(this.GuildsSingleTypeButton);
            this.Controls.Add(this.RoleTypesButton);
            this.Controls.Add(this.PercentageRaceButton);
            this.Controls.Add(this.AllPlayersOfClassServerButton);
            this.Controls.Add(this.PercentageMaxPlayersHeaderLabel);
            this.Controls.Add(this.AllPlayersHeaderLabel);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AllGuildsHeaderLabel);
            this.Controls.Add(this.MaxNumericUpDown);
            this.Controls.Add(this.MinNumericUpDown);
            this.Controls.Add(this.RoleServerComboBox);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.MaxLabel);
            this.Controls.Add(this.MinLabel);
            this.Controls.Add(this.RoleTypesServerLabel);
            this.Controls.Add(this.RoleLabel);
            this.Controls.Add(this.RoleTypesHeaderLabel);
            this.Controls.Add(this.PercentageServerComboBox);
            this.Controls.Add(this.ServerPercentageLabel);
            this.Controls.Add(this.PercentageHeaderLabel);
            this.Controls.Add(this.SingleServerComboBox);
            this.Controls.Add(this.ClassComboBox);
            this.Controls.Add(this.SingleServerLabel);
            this.Controls.Add(this.ClassLabel);
            this.Controls.Add(this.ClassTypeSingleServerHeaderLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MinNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxNumericUpDown)).EndInit();
            this.RadioButtonPanel.ResumeLayout(false);
            this.RadioButtonPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClassTypeSingleServerHeaderLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label SingleServerLabel;
        private System.Windows.Forms.ComboBox ClassComboBox;
        private System.Windows.Forms.ComboBox SingleServerComboBox;
        private System.Windows.Forms.Label PercentageHeaderLabel;
        private System.Windows.Forms.Label ServerPercentageLabel;
        private System.Windows.Forms.ComboBox PercentageServerComboBox;
        private System.Windows.Forms.Label RoleTypesHeaderLabel;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label RoleTypesServerLabel;
        private System.Windows.Forms.Label MinLabel;
        private System.Windows.Forms.Label MaxLabel;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.ComboBox RoleServerComboBox;
        private System.Windows.Forms.NumericUpDown MinNumericUpDown;
        private System.Windows.Forms.NumericUpDown MaxNumericUpDown;
        private System.Windows.Forms.Label AllGuildsHeaderLabel;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeComboBox;
        private System.Windows.Forms.Label AllPlayersHeaderLabel;
        private System.Windows.Forms.Label PercentageMaxPlayersHeaderLabel;
        private System.Windows.Forms.Button AllPlayersOfClassServerButton;
        private System.Windows.Forms.Button PercentageRaceButton;
        private System.Windows.Forms.Button RoleTypesButton;
        private System.Windows.Forms.Button GuildsSingleTypeButton;
        private System.Windows.Forms.Button PlayersWithoutRoleButton;
        private System.Windows.Forms.Button MaxLevelPlayersButton;
        private System.Windows.Forms.Label QueryHeaderLabel;
        private System.Windows.Forms.ListView ResultsListView;
        private System.Windows.Forms.RadioButton DamageRadioButton;
        private System.Windows.Forms.RadioButton HealerRadioButton;
        private System.Windows.Forms.RadioButton TankRadioButton;
        private System.Windows.Forms.Panel RadioButtonPanel;
    }
}

