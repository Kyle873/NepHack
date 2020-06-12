namespace NepHack
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl                        = new System.Windows.Forms.TabControl();
            this.ItemsTabPage                      = new System.Windows.Forms.TabPage();
            this.ItemView                          = new System.Windows.Forms.DataGridView();
            this.IndexColumn                       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDColumn                          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn                        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityColumn                    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlagsColumn                       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipTabPage                      = new System.Windows.Forms.TabPage();
            this.EquipPropertyGrid                 = new System.Windows.Forms.PropertyGrid();
            this.EquipListBox                      = new System.Windows.Forms.ListBox();
            this.EquipContextMenu                  = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.EquipAddNewItemMenuItem           = new System.Windows.Forms.ToolStripMenuItem();
            this.EquipCountLabel                   = new System.Windows.Forms.Label();
            this.MiscTabPage                       = new System.Windows.Forms.TabPage();
            this.MiscGroupBox                      = new System.Windows.Forms.GroupBox();
            this.SetMoneyButton                    = new System.Windows.Forms.Button();
            this.MoneyNumericUpDown                = new System.Windows.Forms.NumericUpDown();
            this.SetRankButton                     = new System.Windows.Forms.Button();
            this.RankNumericUpDown                 = new System.Windows.Forms.NumericUpDown();
            this.HacksGroupBox                     = new System.Windows.Forms.GroupBox();
            this.CompleteAllChallengesButton       = new System.Windows.Forms.Button();
            this.GiveAllItemsButton                = new System.Windows.Forms.Button();
            this.ItemHacksButton                   = new System.Windows.Forms.Button();
            this.CharacterGroupBox                 = new System.Windows.Forms.GroupBox();
            this.SetEXPButton                      = new System.Windows.Forms.Button();
            this.AddEXPEditBox                     = new System.Windows.Forms.TextBox();
            this.AddEXPButton                      = new System.Windows.Forms.Button();
            this.InfinitePPCheckBox                = new System.Windows.Forms.CheckBox();
            this.InfiniteAPCheckBox                = new System.Windows.Forms.CheckBox();
            this.InfiniteSPCheckBox                = new System.Windows.Forms.CheckBox();
            this.InfiniteHPCheckBox                = new System.Windows.Forms.CheckBox();
            this.ScoutsGroupBox                    = new System.Windows.Forms.GroupBox();
            this.ScoutInstantReturnsCheckBox       = new System.Windows.Forms.CheckBox();
            this.NeplunkerGroupBox                 = new System.Windows.Forms.GroupBox();
            this.NeplunkerInfiniteLivesCheckbox    = new System.Windows.Forms.CheckBox();
            this.NeplunkerInfiniteMedicineCheckBox = new System.Windows.Forms.CheckBox();
            this.NeplunkerInfiniteStaminaCheckBox  = new System.Windows.Forms.CheckBox();
            this.RefreshButton                     = new System.Windows.Forms.Button();
            this.StatusStrip                       = new System.Windows.Forms.StatusStrip();
            this.AddressLabel                      = new System.Windows.Forms.ToolStripStatusLabel();
            this.MoneyLabel                        = new System.Windows.Forms.ToolStripStatusLabel();
            this.RankLabel                         = new System.Windows.Forms.ToolStripStatusLabel();
            this.SyncButton                        = new System.Windows.Forms.Button();
            this.flowLayoutPanel1                  = new System.Windows.Forms.FlowLayoutPanel();
            this.DictionaryButton                  = new System.Windows.Forms.Button();
            this.FrozenTimer                       = new System.Windows.Forms.Timer(this.components);
            this.TabControl.SuspendLayout();
            this.ItemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ItemView)).BeginInit();
            this.EquipTabPage.SuspendLayout();
            this.EquipContextMenu.SuspendLayout();
            this.MiscTabPage.SuspendLayout();
            this.MiscGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankNumericUpDown)).BeginInit();
            this.HacksGroupBox.SuspendLayout();
            this.CharacterGroupBox.SuspendLayout();
            this.ScoutsGroupBox.SuspendLayout();
            this.NeplunkerGroupBox.SuspendLayout();
            this.StatusStrip.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();

            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsTabPage);
            this.TabControl.Controls.Add(this.EquipTabPage);
            this.TabControl.Controls.Add(this.MiscTabPage);
            this.TabControl.Dock          = System.Windows.Forms.DockStyle.Top;
            this.TabControl.Location      = new System.Drawing.Point(0, 0);
            this.TabControl.Name          = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size          = new System.Drawing.Size(615, 352);
            this.TabControl.TabIndex      = 0;

            // 
            // ItemsTabPage
            // 
            this.ItemsTabPage.Controls.Add(this.ItemView);
            this.ItemsTabPage.Location                = new System.Drawing.Point(4, 22);
            this.ItemsTabPage.Name                    = "ItemsTabPage";
            this.ItemsTabPage.Padding                 = new System.Windows.Forms.Padding(3);
            this.ItemsTabPage.Size                    = new System.Drawing.Size(607, 326);
            this.ItemsTabPage.TabIndex                = 0;
            this.ItemsTabPage.Text                    = "Items";
            this.ItemsTabPage.UseVisualStyleBackColor = true;

            // 
            // ItemView
            // 
            this.ItemView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[]
            {
                this.IndexColumn,
                this.IDColumn,
                this.NameColumn,
                this.QuantityColumn,
                this.FlagsColumn
            });

            this.ItemView.Dock     =  System.Windows.Forms.DockStyle.Fill;
            this.ItemView.Location =  new System.Drawing.Point(3, 3);
            this.ItemView.Name     =  "ItemView";
            this.ItemView.Size     =  new System.Drawing.Size(601, 320);
            this.ItemView.TabIndex =  0;
            this.ItemView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemView_RowEnter);

            // 
            // IndexColumn
            // 
            this.IndexColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IndexColumn.HeaderText   = "Index";
            this.IndexColumn.Name         = "IndexColumn";
            this.IndexColumn.ReadOnly     = true;

            // 
            // IDColumn
            // 
            this.IDColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IDColumn.HeaderText   = "ID";
            this.IDColumn.Name         = "IDColumn";

            // 
            // NameColumn
            // 
            this.NameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NameColumn.HeaderText   = "Name";
            this.NameColumn.Name         = "NameColumn";
            this.NameColumn.ReadOnly     = true;

            // 
            // QuantityColumn
            // 
            this.QuantityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.QuantityColumn.HeaderText   = "Quantity";
            this.QuantityColumn.Name         = "QuantityColumn";

            // 
            // FlagsColumn
            // 
            this.FlagsColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FlagsColumn.HeaderText   = "Flags";
            this.FlagsColumn.Name         = "FlagsColumn";
            this.FlagsColumn.SortMode     = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;

            // 
            // EquipTabPage
            // 
            this.EquipTabPage.Controls.Add(this.EquipPropertyGrid);
            this.EquipTabPage.Controls.Add(this.EquipListBox);
            this.EquipTabPage.Controls.Add(this.EquipCountLabel);
            this.EquipTabPage.Location                = new System.Drawing.Point(4, 22);
            this.EquipTabPage.Name                    = "EquipTabPage";
            this.EquipTabPage.Padding                 = new System.Windows.Forms.Padding(3);
            this.EquipTabPage.Size                    = new System.Drawing.Size(607, 326);
            this.EquipTabPage.TabIndex                = 1;
            this.EquipTabPage.Text                    = "Equipment";
            this.EquipTabPage.UseVisualStyleBackColor = true;

            // 
            // EquipPropertyGrid
            // 
            this.EquipPropertyGrid.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.EquipPropertyGrid.LineColor = System.Drawing.SystemColors.ControlDarkDark;
            this.EquipPropertyGrid.Location  = new System.Drawing.Point(224, 16);
            this.EquipPropertyGrid.Name      = "EquipPropertyGrid";
            this.EquipPropertyGrid.Size      = new System.Drawing.Size(380, 307);
            this.EquipPropertyGrid.TabIndex  = 8;

            // 
            // EquipListBox
            // 
            this.EquipListBox.ContextMenuStrip     =  this.EquipContextMenu;
            this.EquipListBox.Dock                 =  System.Windows.Forms.DockStyle.Left;
            this.EquipListBox.FormattingEnabled    =  true;
            this.EquipListBox.Location             =  new System.Drawing.Point(3, 16);
            this.EquipListBox.Name                 =  "EquipListBox";
            this.EquipListBox.Size                 =  new System.Drawing.Size(221, 307);
            this.EquipListBox.TabIndex             =  1;
            this.EquipListBox.SelectedIndexChanged += new System.EventHandler(this.EquipmentListBox_SelectedIndexChanged);

            // 
            // EquipContextMenu
            // 
            this.EquipContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.EquipAddNewItemMenuItem
            });

            this.EquipContextMenu.Name = "EquipContextMenu";
            this.EquipContextMenu.Size = new System.Drawing.Size(151, 26);

            // 
            // EquipAddNewItemMenuItem
            // 
            this.EquipAddNewItemMenuItem.Name  =  "EquipAddNewItemMenuItem";
            this.EquipAddNewItemMenuItem.Size  =  new System.Drawing.Size(150, 22);
            this.EquipAddNewItemMenuItem.Text  =  "Add New Item";
            this.EquipAddNewItemMenuItem.Click += new System.EventHandler(this.EquipAddNewItemMenuItem_Click);

            // 
            // EquipCountLabel
            // 
            this.EquipCountLabel.AutoSize = true;
            this.EquipCountLabel.Dock     = System.Windows.Forms.DockStyle.Top;
            this.EquipCountLabel.Location = new System.Drawing.Point(3, 3);
            this.EquipCountLabel.Name     = "EquipCountLabel";
            this.EquipCountLabel.Size     = new System.Drawing.Size(32, 13);
            this.EquipCountLabel.TabIndex = 0;
            this.EquipCountLabel.Text     = "Items";

            // 
            // MiscTabPage
            // 
            this.MiscTabPage.Controls.Add(this.MiscGroupBox);
            this.MiscTabPage.Controls.Add(this.HacksGroupBox);
            this.MiscTabPage.Controls.Add(this.CharacterGroupBox);
            this.MiscTabPage.Controls.Add(this.ScoutsGroupBox);
            this.MiscTabPage.Controls.Add(this.NeplunkerGroupBox);
            this.MiscTabPage.Location                = new System.Drawing.Point(4, 22);
            this.MiscTabPage.Name                    = "MiscTabPage";
            this.MiscTabPage.Padding                 = new System.Windows.Forms.Padding(3);
            this.MiscTabPage.Size                    = new System.Drawing.Size(607, 326);
            this.MiscTabPage.TabIndex                = 2;
            this.MiscTabPage.Text                    = "Misc";
            this.MiscTabPage.UseVisualStyleBackColor = true;

            // 
            // MiscGroupBox
            // 
            this.MiscGroupBox.Controls.Add(this.SetMoneyButton);
            this.MiscGroupBox.Controls.Add(this.SetRankButton);
            this.MiscGroupBox.Controls.Add(this.RankNumericUpDown);
            this.MiscGroupBox.Controls.Add(this.MoneyNumericUpDown);
            this.MiscGroupBox.Location = new System.Drawing.Point(274, 124);
            this.MiscGroupBox.Name     = "MiscGroupBox";
            this.MiscGroupBox.Size     = new System.Drawing.Size(325, 109);
            this.MiscGroupBox.TabIndex = 10;
            this.MiscGroupBox.TabStop  = false;
            this.MiscGroupBox.Text     = "Misc";

            // 
            // SetMoneyButton
            // 
            this.SetMoneyButton.Location                =  new System.Drawing.Point(138, 42);
            this.SetMoneyButton.Name                    =  "SetMoneyButton";
            this.SetMoneyButton.Size                    =  new System.Drawing.Size(126, 23);
            this.SetMoneyButton.TabIndex                =  3;
            this.SetMoneyButton.Text                    =  "Set Money";
            this.SetMoneyButton.UseVisualStyleBackColor =  true;
            this.SetMoneyButton.Click                   += new System.EventHandler(this.SetMoneyButton_Click);

            // 
            // MoneyNumericUpDown
            // 
            this.MoneyNumericUpDown.Location = new System.Drawing.Point(138, 16);
            this.MoneyNumericUpDown.Maximum = new decimal(new int[]
            {
                999999999,
                0,
                0,
                0
            });

            this.MoneyNumericUpDown.Name     = "MoneyNumericUpDown";
            this.MoneyNumericUpDown.Size     = new System.Drawing.Size(126, 20);
            this.MoneyNumericUpDown.TabIndex = 2;
            this.MoneyNumericUpDown.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });

            // 
            // SetRankButton
            // 
            this.SetRankButton.Location                =  new System.Drawing.Point(6, 42);
            this.SetRankButton.Name                    =  "SetRankButton";
            this.SetRankButton.Size                    =  new System.Drawing.Size(126, 23);
            this.SetRankButton.TabIndex                =  1;
            this.SetRankButton.Text                    =  "Set Rank";
            this.SetRankButton.UseVisualStyleBackColor =  true;
            this.SetRankButton.Click                   += new System.EventHandler(this.SetRankButton_Click);

            // 
            // RankNumericUpDown
            // 
            this.RankNumericUpDown.Location = new System.Drawing.Point(6, 16);
            this.RankNumericUpDown.Maximum = new decimal(new int[]
            {
                99999,
                0,
                0,
                0
            });

            this.RankNumericUpDown.Minimum = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });

            this.RankNumericUpDown.Name     = "RankNumericUpDown";
            this.RankNumericUpDown.Size     = new System.Drawing.Size(126, 20);
            this.RankNumericUpDown.TabIndex = 0;
            this.RankNumericUpDown.Value = new decimal(new int[]
            {
                1,
                0,
                0,
                0
            });

            // 
            // HacksGroupBox
            // 
            this.HacksGroupBox.Controls.Add(this.CompleteAllChallengesButton);
            this.HacksGroupBox.Controls.Add(this.GiveAllItemsButton);
            this.HacksGroupBox.Controls.Add(this.ItemHacksButton);
            this.HacksGroupBox.Location = new System.Drawing.Point(3, 124);
            this.HacksGroupBox.Name     = "HacksGroupBox";
            this.HacksGroupBox.Size     = new System.Drawing.Size(265, 109);
            this.HacksGroupBox.TabIndex = 6;
            this.HacksGroupBox.TabStop  = false;
            this.HacksGroupBox.Text     = "Hacks";

            // 
            // CompleteAllChallengesButton
            // 
            this.CompleteAllChallengesButton.Location                =  new System.Drawing.Point(7, 74);
            this.CompleteAllChallengesButton.Name                    =  "CompleteAllChallengesButton";
            this.CompleteAllChallengesButton.Size                    =  new System.Drawing.Size(253, 23);
            this.CompleteAllChallengesButton.TabIndex                =  9;
            this.CompleteAllChallengesButton.Text                    =  "Complete All Challenges";
            this.CompleteAllChallengesButton.UseVisualStyleBackColor =  true;
            this.CompleteAllChallengesButton.Click                   += new System.EventHandler(this.CompleteAllChallengesButton_Click);

            // 
            // GiveAllItemsButton
            // 
            this.GiveAllItemsButton.Location                =  new System.Drawing.Point(7, 16);
            this.GiveAllItemsButton.Name                    =  "GiveAllItemsButton";
            this.GiveAllItemsButton.Size                    =  new System.Drawing.Size(253, 23);
            this.GiveAllItemsButton.TabIndex                =  8;
            this.GiveAllItemsButton.Text                    =  "Give All Items";
            this.GiveAllItemsButton.UseVisualStyleBackColor =  true;
            this.GiveAllItemsButton.Click                   += new System.EventHandler(this.GiveAllItemsButton_Click);

            // 
            // ItemHacksButton
            // 
            this.ItemHacksButton.Location                =  new System.Drawing.Point(7, 45);
            this.ItemHacksButton.Name                    =  "ItemHacksButton";
            this.ItemHacksButton.Size                    =  new System.Drawing.Size(253, 23);
            this.ItemHacksButton.TabIndex                =  7;
            this.ItemHacksButton.Text                    =  "Apply Item Hacks";
            this.ItemHacksButton.UseVisualStyleBackColor =  true;
            this.ItemHacksButton.Click                   += new System.EventHandler(this.ItemHacksButton_Click);

            // 
            // CharacterGroupBox
            // 
            this.CharacterGroupBox.Controls.Add(this.SetEXPButton);
            this.CharacterGroupBox.Controls.Add(this.AddEXPEditBox);
            this.CharacterGroupBox.Controls.Add(this.AddEXPButton);
            this.CharacterGroupBox.Controls.Add(this.InfinitePPCheckBox);
            this.CharacterGroupBox.Controls.Add(this.InfiniteAPCheckBox);
            this.CharacterGroupBox.Controls.Add(this.InfiniteSPCheckBox);
            this.CharacterGroupBox.Controls.Add(this.InfiniteHPCheckBox);
            this.CharacterGroupBox.Location = new System.Drawing.Point(3, 6);
            this.CharacterGroupBox.Name     = "CharacterGroupBox";
            this.CharacterGroupBox.Size     = new System.Drawing.Size(265, 113);
            this.CharacterGroupBox.TabIndex = 5;
            this.CharacterGroupBox.TabStop  = false;
            this.CharacterGroupBox.Text     = "Characters";

            // 
            // SetEXPButton
            // 
            this.SetEXPButton.Location                =  new System.Drawing.Point(87, 74);
            this.SetEXPButton.Name                    =  "SetEXPButton";
            this.SetEXPButton.Size                    =  new System.Drawing.Size(173, 23);
            this.SetEXPButton.TabIndex                =  8;
            this.SetEXPButton.Text                    =  "Set EXP";
            this.SetEXPButton.UseVisualStyleBackColor =  true;
            this.SetEXPButton.Click                   += new System.EventHandler(this.SetEXPButton_Click);

            // 
            // AddEXPEditBox
            // 
            this.AddEXPEditBox.Location = new System.Drawing.Point(87, 19);
            this.AddEXPEditBox.Name     = "AddEXPEditBox";
            this.AddEXPEditBox.Size     = new System.Drawing.Size(172, 20);
            this.AddEXPEditBox.TabIndex = 7;
            this.AddEXPEditBox.Text     = "0";

            // 
            // AddEXPButton
            // 
            this.AddEXPButton.Location                =  new System.Drawing.Point(86, 45);
            this.AddEXPButton.Name                    =  "AddEXPButton";
            this.AddEXPButton.Size                    =  new System.Drawing.Size(173, 23);
            this.AddEXPButton.TabIndex                =  6;
            this.AddEXPButton.Text                    =  "Add EXP";
            this.AddEXPButton.UseVisualStyleBackColor =  true;
            this.AddEXPButton.Click                   += new System.EventHandler(this.AddEXPButton_Click);

            // 
            // InfinitePPCheckBox
            // 
            this.InfinitePPCheckBox.AutoSize                = true;
            this.InfinitePPCheckBox.Location                = new System.Drawing.Point(7, 88);
            this.InfinitePPCheckBox.Name                    = "InfinitePPCheckBox";
            this.InfinitePPCheckBox.Size                    = new System.Drawing.Size(74, 17);
            this.InfinitePPCheckBox.TabIndex                = 3;
            this.InfinitePPCheckBox.Text                    = "Infinite PP";
            this.InfinitePPCheckBox.UseVisualStyleBackColor = true;

            // 
            // InfiniteAPCheckBox
            // 
            this.InfiniteAPCheckBox.AutoSize                = true;
            this.InfiniteAPCheckBox.Location                = new System.Drawing.Point(7, 65);
            this.InfiniteAPCheckBox.Name                    = "InfiniteAPCheckBox";
            this.InfiniteAPCheckBox.Size                    = new System.Drawing.Size(74, 17);
            this.InfiniteAPCheckBox.TabIndex                = 2;
            this.InfiniteAPCheckBox.Text                    = "Infinite AP";
            this.InfiniteAPCheckBox.UseVisualStyleBackColor = true;

            // 
            // InfiniteSPCheckBox
            // 
            this.InfiniteSPCheckBox.AutoSize                = true;
            this.InfiniteSPCheckBox.Location                = new System.Drawing.Point(6, 42);
            this.InfiniteSPCheckBox.Name                    = "InfiniteSPCheckBox";
            this.InfiniteSPCheckBox.Size                    = new System.Drawing.Size(74, 17);
            this.InfiniteSPCheckBox.TabIndex                = 1;
            this.InfiniteSPCheckBox.Text                    = "Infinite SP";
            this.InfiniteSPCheckBox.UseVisualStyleBackColor = true;

            // 
            // InfiniteHPCheckBox
            // 
            this.InfiniteHPCheckBox.AutoSize                = true;
            this.InfiniteHPCheckBox.Location                = new System.Drawing.Point(6, 19);
            this.InfiniteHPCheckBox.Name                    = "InfiniteHPCheckBox";
            this.InfiniteHPCheckBox.Size                    = new System.Drawing.Size(75, 17);
            this.InfiniteHPCheckBox.TabIndex                = 0;
            this.InfiniteHPCheckBox.Text                    = "Infinite HP";
            this.InfiniteHPCheckBox.UseVisualStyleBackColor = true;

            // 
            // ScoutsGroupBox
            // 
            this.ScoutsGroupBox.Controls.Add(this.ScoutInstantReturnsCheckBox);
            this.ScoutsGroupBox.Location = new System.Drawing.Point(274, 6);
            this.ScoutsGroupBox.Name     = "ScoutsGroupBox";
            this.ScoutsGroupBox.Size     = new System.Drawing.Size(138, 113);
            this.ScoutsGroupBox.TabIndex = 4;
            this.ScoutsGroupBox.TabStop  = false;
            this.ScoutsGroupBox.Text     = "Scouts";

            // 
            // ScoutInstantReturnsCheckBox
            // 
            this.ScoutInstantReturnsCheckBox.AutoSize                = true;
            this.ScoutInstantReturnsCheckBox.Location                = new System.Drawing.Point(6, 19);
            this.ScoutInstantReturnsCheckBox.Name                    = "ScoutInstantReturnsCheckBox";
            this.ScoutInstantReturnsCheckBox.Size                    = new System.Drawing.Size(98, 17);
            this.ScoutInstantReturnsCheckBox.TabIndex                = 3;
            this.ScoutInstantReturnsCheckBox.Text                    = "Instant Returns";
            this.ScoutInstantReturnsCheckBox.UseVisualStyleBackColor = true;

            // 
            // NeplunkerGroupBox
            // 
            this.NeplunkerGroupBox.Controls.Add(this.NeplunkerInfiniteLivesCheckbox);
            this.NeplunkerGroupBox.Controls.Add(this.NeplunkerInfiniteMedicineCheckBox);
            this.NeplunkerGroupBox.Controls.Add(this.NeplunkerInfiniteStaminaCheckBox);
            this.NeplunkerGroupBox.Location = new System.Drawing.Point(418, 6);
            this.NeplunkerGroupBox.Name     = "NeplunkerGroupBox";
            this.NeplunkerGroupBox.Size     = new System.Drawing.Size(181, 113);
            this.NeplunkerGroupBox.TabIndex = 3;
            this.NeplunkerGroupBox.TabStop  = false;
            this.NeplunkerGroupBox.Text     = "Neplunker";

            // 
            // NeplunkerInfiniteLivesCheckbox
            // 
            this.NeplunkerInfiniteLivesCheckbox.AutoSize                = true;
            this.NeplunkerInfiniteLivesCheckbox.Location                = new System.Drawing.Point(6, 19);
            this.NeplunkerInfiniteLivesCheckbox.Name                    = "NeplunkerInfiniteLivesCheckbox";
            this.NeplunkerInfiniteLivesCheckbox.Size                    = new System.Drawing.Size(85, 17);
            this.NeplunkerInfiniteLivesCheckbox.TabIndex                = 0;
            this.NeplunkerInfiniteLivesCheckbox.Text                    = "Infinite Lives";
            this.NeplunkerInfiniteLivesCheckbox.UseVisualStyleBackColor = true;

            // 
            // NeplunkerInfiniteMedicineCheckBox
            // 
            this.NeplunkerInfiniteMedicineCheckBox.AutoSize                = true;
            this.NeplunkerInfiniteMedicineCheckBox.Location                = new System.Drawing.Point(6, 65);
            this.NeplunkerInfiniteMedicineCheckBox.Name                    = "NeplunkerInfiniteMedicineCheckBox";
            this.NeplunkerInfiniteMedicineCheckBox.Size                    = new System.Drawing.Size(103, 17);
            this.NeplunkerInfiniteMedicineCheckBox.TabIndex                = 2;
            this.NeplunkerInfiniteMedicineCheckBox.Text                    = "Infinite Medicine";
            this.NeplunkerInfiniteMedicineCheckBox.UseVisualStyleBackColor = true;

            // 
            // NeplunkerInfiniteStaminaCheckBox
            // 
            this.NeplunkerInfiniteStaminaCheckBox.AutoSize                = true;
            this.NeplunkerInfiniteStaminaCheckBox.Location                = new System.Drawing.Point(6, 42);
            this.NeplunkerInfiniteStaminaCheckBox.Name                    = "NeplunkerInfiniteStaminaCheckBox";
            this.NeplunkerInfiniteStaminaCheckBox.Size                    = new System.Drawing.Size(98, 17);
            this.NeplunkerInfiniteStaminaCheckBox.TabIndex                = 1;
            this.NeplunkerInfiniteStaminaCheckBox.Text                    = "Infinite Stamina";
            this.NeplunkerInfiniteStaminaCheckBox.UseVisualStyleBackColor = true;

            // 
            // RefreshButton
            // 
            this.RefreshButton.Location                =  new System.Drawing.Point(3, 3);
            this.RefreshButton.Name                    =  "RefreshButton";
            this.RefreshButton.Size                    =  new System.Drawing.Size(187, 23);
            this.RefreshButton.TabIndex                =  2;
            this.RefreshButton.Text                    =  "&Refresh";
            this.RefreshButton.UseVisualStyleBackColor =  true;
            this.RefreshButton.Click                   += new System.EventHandler(this.RefreshButton_Click);

            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[]
            {
                this.AddressLabel,
                this.MoneyLabel,
                this.RankLabel
            });

            this.StatusStrip.Location = new System.Drawing.Point(0, 384);
            this.StatusStrip.Name     = "StatusStrip";
            this.StatusStrip.Size     = new System.Drawing.Size(615, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text     = "statusStrip1";

            // 
            // AddressLabel
            // 
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(49, 17);
            this.AddressLabel.Text = "Address";

            // 
            // MoneyLabel
            // 
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(44, 17);
            this.MoneyLabel.Text = "Money";

            // 
            // RankLabel
            // 
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(33, 17);
            this.RankLabel.Text = "Rank";

            // 
            // SyncButton
            // 
            this.SyncButton.Enabled                 =  false;
            this.SyncButton.Location                =  new System.Drawing.Point(196, 3);
            this.SyncButton.Name                    =  "SyncButton";
            this.SyncButton.Size                    =  new System.Drawing.Size(187, 23);
            this.SyncButton.TabIndex                =  3;
            this.SyncButton.Text                    =  "&Sync";
            this.SyncButton.UseVisualStyleBackColor =  true;
            this.SyncButton.Click                   += new System.EventHandler(this.SyncButton_Click);

            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.RefreshButton);
            this.flowLayoutPanel1.Controls.Add(this.SyncButton);
            this.flowLayoutPanel1.Controls.Add(this.DictionaryButton);
            this.flowLayoutPanel1.Dock     = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 355);
            this.flowLayoutPanel1.Name     = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size     = new System.Drawing.Size(615, 29);
            this.flowLayoutPanel1.TabIndex = 4;

            // 
            // DictionaryButton
            // 
            this.DictionaryButton.Location                =  new System.Drawing.Point(389, 3);
            this.DictionaryButton.Name                    =  "DictionaryButton";
            this.DictionaryButton.Size                    =  new System.Drawing.Size(222, 23);
            this.DictionaryButton.TabIndex                =  4;
            this.DictionaryButton.Text                    =  "&Dictionary";
            this.DictionaryButton.UseVisualStyleBackColor =  true;
            this.DictionaryButton.Click                   += new System.EventHandler(this.DictionaryButton_Click);

            // 
            // FrozenTimer
            // 
            this.FrozenTimer.Enabled  =  true;
            this.FrozenTimer.Interval =  10;
            this.FrozenTimer.Tick     += new System.EventHandler(this.FrozenTimer_Tick);

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize          = new System.Drawing.Size(615, 406);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon            = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox     = false;
            this.Name            = "MainForm";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "NepHack";
            this.TabControl.ResumeLayout(false);
            this.ItemsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ItemView)).EndInit();
            this.EquipTabPage.ResumeLayout(false);
            this.EquipTabPage.PerformLayout();
            this.EquipContextMenu.ResumeLayout(false);
            this.MiscTabPage.ResumeLayout(false);
            this.MiscGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoneyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RankNumericUpDown)).EndInit();
            this.HacksGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.ResumeLayout(false);
            this.CharacterGroupBox.PerformLayout();
            this.ScoutsGroupBox.ResumeLayout(false);
            this.ScoutsGroupBox.PerformLayout();
            this.NeplunkerGroupBox.ResumeLayout(false);
            this.NeplunkerGroupBox.PerformLayout();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button AddEXPButton;
        private System.Windows.Forms.TextBox AddEXPEditBox;
        private System.Windows.Forms.ToolStripStatusLabel AddressLabel;
        private System.Windows.Forms.GroupBox CharacterGroupBox;
        private System.Windows.Forms.Button CompleteAllChallengesButton;
        private System.Windows.Forms.Button DictionaryButton;
        private System.Windows.Forms.ToolStripMenuItem EquipAddNewItemMenuItem;
        private System.Windows.Forms.ContextMenuStrip EquipContextMenu;
        private System.Windows.Forms.Label EquipCountLabel;
        private System.Windows.Forms.ListBox EquipListBox;
        private System.Windows.Forms.PropertyGrid EquipPropertyGrid;
        private System.Windows.Forms.TabPage EquipTabPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn FlagsColumn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer FrozenTimer;
        private System.Windows.Forms.Button GiveAllItemsButton;
        private System.Windows.Forms.GroupBox HacksGroupBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IndexColumn;
        private System.Windows.Forms.CheckBox InfiniteAPCheckBox;
        private System.Windows.Forms.CheckBox InfiniteHPCheckBox;
        private System.Windows.Forms.CheckBox InfinitePPCheckBox;
        private System.Windows.Forms.CheckBox InfiniteSPCheckBox;
        private System.Windows.Forms.Button ItemHacksButton;
        private System.Windows.Forms.TabPage ItemsTabPage;
        private System.Windows.Forms.DataGridView ItemView;
        private System.Windows.Forms.GroupBox MiscGroupBox;
        private System.Windows.Forms.TabPage MiscTabPage;
        private System.Windows.Forms.ToolStripStatusLabel MoneyLabel;
        private System.Windows.Forms.NumericUpDown MoneyNumericUpDown;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.GroupBox NeplunkerGroupBox;
        private System.Windows.Forms.CheckBox NeplunkerInfiniteLivesCheckbox;
        private System.Windows.Forms.CheckBox NeplunkerInfiniteMedicineCheckBox;
        private System.Windows.Forms.CheckBox NeplunkerInfiniteStaminaCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityColumn;
        private System.Windows.Forms.ToolStripStatusLabel RankLabel;
        private System.Windows.Forms.NumericUpDown RankNumericUpDown;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.CheckBox ScoutInstantReturnsCheckBox;
        private System.Windows.Forms.GroupBox ScoutsGroupBox;
        private System.Windows.Forms.Button SetEXPButton;
        private System.Windows.Forms.Button SetMoneyButton;
        private System.Windows.Forms.Button SetRankButton;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.Button SyncButton;
        private System.Windows.Forms.TabControl TabControl;

        #endregion
    }
}

