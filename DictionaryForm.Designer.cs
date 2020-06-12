namespace NepHack
{
    partial class DictionaryForm
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
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DataView = new System.Windows.Forms.TreeView();
            this.DescriptionBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Items.AddRange(new object[] {
            "Item",
            "Parameter",
            "Trait"});
            this.CategoryComboBox.Location = new System.Drawing.Point(0, 0);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(627, 21);
            this.CategoryComboBox.TabIndex = 0;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // DataView
            // 
            this.DataView.Location = new System.Drawing.Point(0, 27);
            this.DataView.Name = "DataView";
            this.DataView.Size = new System.Drawing.Size(267, 406);
            this.DataView.TabIndex = 1;
            this.DataView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.DataView_AfterSelect);
            // 
            // DescriptionBox
            // 
            this.DescriptionBox.Location = new System.Drawing.Point(273, 27);
            this.DescriptionBox.Name = "DescriptionBox";
            this.DescriptionBox.ReadOnly = true;
            this.DescriptionBox.Size = new System.Drawing.Size(354, 406);
            this.DescriptionBox.TabIndex = 2;
            this.DescriptionBox.Text = "";
            // 
            // DictionaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 436);
            this.Controls.Add(this.DescriptionBox);
            this.Controls.Add(this.DataView);
            this.Controls.Add(this.CategoryComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DictionaryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dictionary";
            this.Load += new System.EventHandler(this.DictionaryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TreeView DataView;
        private System.Windows.Forms.RichTextBox DescriptionBox;
    }
}