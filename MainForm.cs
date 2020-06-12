using System;
using System.Windows.Forms;

using NepHack.Properties;

namespace NepHack
{
    public partial class MainForm : Form
    {
        public MainForm()
            => InitializeComponent();

        void RefreshButton_Click(object sender, EventArgs e)
        {
            RefreshItems();
            RefreshEquipment();

            SyncButton.Enabled = true;
        }

        void SyncButton_Click(object sender, EventArgs e)
        {
            SyncItems();
            SyncEquipment();

            RefreshEquipment();
        }

        void DictionaryButton_Click(object sender, EventArgs e)
            => new DictionaryForm().Show();

        void ItemView_RowEnter(object sender, DataGridViewCellEventArgs e)
            => AddressLabel.Text = "Address: " + (Program.ItemPointer.BaseAddress + Item.GetOffset(e.RowIndex)).ToString("X");

        void EquipmentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddressLabel.Text = "Address: " + (Program.EquipPointer.BaseAddress + EquipItem.GetOffset(EquipListBox.SelectedIndex)).ToString("X");

            EquipPropertyGrid.SelectedObject = Program.EquipItems[EquipListBox.SelectedIndex];
        }

        void EquipAddNewItemMenuItem_Click(object sender, EventArgs e)
        {
            int total = Program.EquipPointer.Read<int>();

            Program.EquipPointer.Write(total + 1);

            RefreshEquipment();
        }

        void AddEXPButton_Click(object sender, EventArgs e)
        {
            long         amount = -1;
            DialogResult result = DialogResult.Yes;

            long.TryParse(AddEXPEditBox.Text, out amount);

            if (amount == -1)
            {
                MessageBox.Show("Invalid amount!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            result = MessageBox.Show(Resources.EXPMessageString, "Max Levels", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
                for (int i = 0; i < Program.MaxCharacters; i++)
                    if (sender is bool set && set)
                        Program.CharacterPointer.Write(Character.GetOffset(i) + 8, amount);
                    else
                        Program.CharacterPointer.Write(Character.GetOffset(i) + 8, Program.CharacterPointer.Read<long>(Character.GetOffset(i) + 8) + amount);
        }

        void SetEXPButton_Click(object sender, EventArgs e)
            => AddEXPButton_Click(true, null);

        void GiveAllItemsButton_Click(object sender, EventArgs e)
        {
            int index = 0;

            foreach (ItemDef def in Data.ItemDefs)
            {
                IDRange range    = Data.ItemIDRanges.Find(r => def.ID >= r.StartID && def.ID <= r.EndID);
                ushort  quantity = 0;

                if (range.Name == "Story Items")
                    continue;

                if (def.Name == "Pocket Service Card")
                    quantity = 1;

                Program.ItemPointer.Write(Item.GetOffset(index),     def.ID);
                Program.ItemPointer.Write(Item.GetOffset(index) + 2, 1);
                Program.ItemPointer.Write(Item.GetOffset(index) + 4, quantity);

                index++;
            }

            // DLC Pocket Expansions
            for (int i = 490; i <= 499; i++)
            {
                Program.ItemPointer.Write(Item.GetOffset(index),     i);
                Program.ItemPointer.Write(Item.GetOffset(index) + 2, 1);
                Program.ItemPointer.Write(Item.GetOffset(index) + 4, 1);

                index++;
            }

            Program.ItemPointer.Write(Item.GetOffset(-1) + 4, index + 1);
        }

        void ItemHacksButton_Click(object sender, EventArgs e)
        {
            const int PlanPrice = 1000;
            const int DiscPrice = 5000;
            const int FlagPrice = 10000;

            DialogResult result = MessageBox.Show(Resources.ItemHackDescriptionString, "Item Hack", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                for (int i = 0; i < Program.MaxItemDataSize; i++)
                {
                    ushort  id        = Program.ItemDataPointer.Read<ushort>(ItemInfo.GetOffset(i));
                    int     buyPrice  = Program.ItemDataPointer.Read<int>(ItemInfo.GetOffset(i) + 38);
                    int     sellPrice = Program.ItemDataPointer.Read<int>(ItemInfo.GetOffset(i) + 42);
                    IDRange range     = GetItemIDRange(id);

                    if (sellPrice > 0 && buyPrice <= 0)
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 38, sellPrice * 10);

                    if (range.Name.Contains("Plan"))
                    {
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 38, PlanPrice);
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 42, PlanPrice / 2);
                    }
                    else if (range.Name.Contains("Disc"))
                    {
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 38, DiscPrice);
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 42, DiscPrice / 2);
                    }
                    else if (range.Name.Contains("Flag"))
                    {
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 38, FlagPrice);
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 42, FlagPrice / 2);
                    }
                    else if (range.Name.Contains("Base Equipment"))
                    {
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 38, 0);
                        Program.ItemDataPointer.Write(ItemInfo.GetOffset(i) + 42, 0);
                    }
                }

                for (int i = 0; i < Program.MaxItems; i++)
                {
                    ushort id = Program.ItemPointer.Read<ushort>(Item.GetOffset(i));

                    foreach (IDRange range in Data.ItemIDRanges)
                        if (id >= range.StartID || id <= range.EndID)
                        {
                            ushort flags = Program.ItemPointer.Read<ushort>(Item.GetOffset(i) + 2);

                            if ((flags & 4) == 0)
                                flags |= 4;

                            Program.ItemPointer.Write(Item.GetOffset(i) + 2, flags);
                        }
                }
            }
        }

        void CompleteAllChallengesButton_Click(object sender, EventArgs e)
        {
            int[] max =
            {
                18000,
                144000,
                500,
                15360,
                5120,
                10240,
                5120,
                5120,
                5120,
                72,
                25600,
                2560000,
                1536000,
                256000,
                100
            };

            for (int i = 0; i < Program.MaxCharacters; i++)
            for (int j = 0; j < max.Length; j++)
            {
                int  offset = Challenge.GetOffset(i) + j * 8;
                long value  = Program.ChallengePointer.Read<long>(offset);

                Program.ChallengePointer.Write(offset, value + max[j]);
            }
        }

        void SetRankButton_Click(object sender, EventArgs e)
            => Program.MiscPointer.Write(0, (int)RankNumericUpDown.Value);

        void SetMoneyButton_Click(object sender, EventArgs e)
            => Program.MiscPointer.Write(12, (int)MoneyNumericUpDown.Value);

        void FrozenTimer_Tick(object sender, EventArgs e)
        {
            ValidateControls();

            if (InfiniteHPCheckBox.Checked)
                for (int i = 0; i < Program.MaxCharacters; i++)
                    Program.CharacterPointer.Write(Character.GetOffset(i), Program.CharacterPointer.Read<long>(Program.CharacterCalcOffset + Character.GetCalcOffset(i)));

            if (InfiniteSPCheckBox.Checked)
                for (int i = 0; i < Program.MaxCharacters; i++)
                    Program.CharacterPointer.Write(Character.GetOffset(i) + 16, Program.CharacterPointer.Read<int>(Program.CharacterCalcOffset + Character.GetCalcOffset(i) + 8));

            if (InfiniteAPCheckBox.Checked)
                for (int i = 0; i < Program.MaxCharacters; i++)
                    Program.CharacterPointer.Write(Character.GetOffset(i) + 20, Program.CharacterPointer.Read<int>(Program.CharacterCalcOffset + Character.GetCalcOffset(i) + 16));

            if (InfinitePPCheckBox.Checked)
                for (int i = 0; i < Program.MaxCharacters; i++)
                    Program.CharacterPointer.Write(Character.GetOffset(i) + 24, 9);

            if (ScoutInstantReturnsCheckBox.Checked)
                for (int i = 0; i < Program.MaxScouts; i++)
                    Program.ScoutPointer.Write(Scout.GetOffset(i) + 12, 0);

            if (NeplunkerInfiniteLivesCheckbox.Checked)
                Program.NeplunkerPointer.Write(0, 99999);

            if (NeplunkerInfiniteStaminaCheckBox.Checked)
                Program.NeplunkerPointer.Write(4, 300f);

            if (NeplunkerInfiniteMedicineCheckBox.Checked)
                Program.NeplunkerPointer.Write(8, 100f);

            RankLabel.Text  = "Rank: "  + Program.MiscPointer.Read<int>();
            MoneyLabel.Text = "Money: " + Program.MiscPointer.Read<int>(12);
        }

        void ValidateControls()
        {
            NeplunkerInfiniteLivesCheckbox.Enabled    = State.InNeplunker();
            NeplunkerInfiniteStaminaCheckBox.Enabled  = State.InNeplunker();
            NeplunkerInfiniteMedicineCheckBox.Enabled = State.InNeplunker();

            if (!State.InNeplunker())
            {
                NeplunkerInfiniteLivesCheckbox.Checked    = false;
                NeplunkerInfiniteStaminaCheckBox.Checked  = false;
                NeplunkerInfiniteMedicineCheckBox.Checked = false;
            }
        }

        void RefreshItems()
        {
            SuspendLayout();

            ItemView.Rows.Clear();
            ItemView.ClearSelection();

            for (int i = 0; i < Program.MaxItems; i++)
            {
                ushort id       = Program.ItemPointer.Read<ushort>(Item.GetOffset(i));
                ushort flags    = Program.ItemPointer.Read<ushort>(Item.GetOffset(i) + 2);
                int    quantity = Program.ItemPointer.Read<int>(Item.GetOffset(i)    + 4);

                ItemView.Rows.Add(i + 1, id, Data.GetItemName(id), quantity, flags);
            }

            ResumeLayout();
        }

        void RefreshEquipment()
        {
            int total = Program.EquipPointer.Read<int>();

            SuspendLayout();

            EquipListBox.Items.Clear();
            EquipListBox.ClearSelected();

            for (int i = 0; i < total; i++)
            {
                Program.EquipItems[i].Read(i);
                EquipListBox.Items.Add(Program.EquipItems[i]);
            }

            EquipCountLabel.Text = "Items: " + total;

            ResumeLayout();
        }

        void SyncItems()
        {
            for (int i = 0; i < Program.MaxItems; i++)
            {
                ushort id       = ushort.Parse(ItemView.Rows[i].Cells[1].Value.ToString());
                ushort flags    = ushort.Parse(ItemView.Rows[i].Cells[4].Value.ToString());
                int    quantity = int.Parse(ItemView.Rows[i].Cells[3].Value.ToString());

                Program.ItemPointer.Write(Item.GetOffset(i),     id);
                Program.ItemPointer.Write(Item.GetOffset(i) + 2, flags);
                Program.ItemPointer.Write(Item.GetOffset(i) + 4, quantity);
            }

            RefreshItems();
        }

        void SyncEquipment()
        {
            int total = Program.EquipPointer.Read<int>();

            for (int i = 0; i < total; i++)
                Program.EquipItems[i].Write();
        }

        IDRange GetItemIDRange(ushort id)
        {
            foreach (IDRange range in Data.ItemIDRanges)
                if (id >= range.StartID && id <= range.EndID)
                    return range;

            return null;
        }

        bool HaveItem(ushort id)
        {
            for (int i = 0; i < Program.MaxItems; i++)
                if (Program.ItemPointer.Read<ushort>(Item.GetOffset(i)) == id)
                    return true;

            return false;
        }
    }
}
