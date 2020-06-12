using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NepHack
{
    public partial class DictionaryForm : Form
    {
        public DictionaryForm()
            => InitializeComponent();

        void DictionaryForm_Load(object sender, EventArgs e)
            => CategoryComboBox.SelectedIndex = 0;

        void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SuspendLayout();

            DataView.Nodes.Clear();
            DescriptionBox.Clear();

            switch (CategoryComboBox.SelectedIndex)
            {
                case 0: // Items
                    foreach (IDRange range in Data.ItemIDRanges.Where(range => DataView.Nodes.Find(range.Name, true).Length == 0))
                        DataView.Nodes.Add(range.Name);

                    foreach (ItemDef def in Data.ItemDefs)
                    {
                        bool found = false;

                        foreach (IDRange range in Data.ItemIDRanges.Where(range => def.ID >= range.StartID && def.ID <= range.EndID))
                        {
                            DataView.Nodes.Cast<TreeNode>().First(n => n.Text == range.Name).Nodes.Add($"{def.ID} - {def.Name}").Tag = def;

                            found = true;

                            break;
                        }

                        if (!found)
                            DataView.Nodes.Add($"{def.ID} - {def.Name}").Tag = def;
                    }

                    break;
                case 1: // Parameters
                    foreach (ParameterDef def in Data.ParamDefs)
                        DataView.Nodes.Add($"{def.ID} - {def.Name}").Tag = def;

                    break;
                case 2: // Traits
                    foreach (string category in Data.TraitCategories)
                        DataView.Nodes.Add(category);

                    foreach (TraitDef def in Data.TraitDefs)
                        DataView.Nodes.Cast<TreeNode>().First(n => n.Text == def.Category).Nodes.Add($"{def.ID} - {def.Name}").Tag = def;

                    break;
            }

            ResumeLayout();
        }

        void DataView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            StringBuilder data = new StringBuilder("\n\n");

            DescriptionBox.Text = (e.Node.Tag as Def)?.Description;

            if (e.Node.Tag is ItemDef def)
            {
                if (def.StackSize > 0)
                    data.AppendLine($"Stack Size: {def.StackSize}");

                if (def.BuyPrice > 0)
                    data.AppendLine($"Buy Price: {def.BuyPrice} Credits");

                if (def.SellPrice > 0)
                    data.AppendLine($"Sell Price: {def.SellPrice} Credits");

                DescriptionBox.Text += data;
            }
        }
    }
}
