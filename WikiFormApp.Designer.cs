namespace FormApp
{
    partial class WikiFormApp
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxStructure = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ListBoxArray = new System.Windows.Forms.ListBox();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonClearArray = new System.Windows.Forms.Button();
            this.ButtonSort = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(67, 58);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "ADD";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(167, 58);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(75, 23);
            this.ButtonUpdate.TabIndex = 1;
            this.ButtonUpdate.Text = "UPDATE";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(265, 57);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "DELETE";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(70, 123);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(270, 20);
            this.TextBoxName.TabIndex = 3;
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(70, 158);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(270, 20);
            this.TextBoxCategory.TabIndex = 4;
            // 
            // TextBoxStructure
            // 
            this.TextBoxStructure.Location = new System.Drawing.Point(70, 192);
            this.TextBoxStructure.Name = "TextBoxStructure";
            this.TextBoxStructure.Size = new System.Drawing.Size(270, 20);
            this.TextBoxStructure.TabIndex = 5;         
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(70, 232);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(270, 103);
            this.TextBoxDefinition.TabIndex = 6;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(396, 56);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(173, 20);
            this.TextBoxSearch.TabIndex = 7;
            this.toolTip1.SetToolTip(this.TextBoxSearch, "Double click to reset SEARCH");
            this.TextBoxSearch.DoubleClick += new System.EventHandler(this.TextBoxSearch_DoubleClick);
            // 
            // ListBoxArray
            // 
            this.ListBoxArray.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxArray.FormattingEnabled = true;
            this.ListBoxArray.ItemHeight = 14;
            this.ListBoxArray.Location = new System.Drawing.Point(396, 123);
            this.ListBoxArray.Name = "ListBoxArray";
            this.ListBoxArray.Size = new System.Drawing.Size(254, 200);
            this.ListBoxArray.TabIndex = 8;
            this.ListBoxArray.SelectedIndexChanged += new System.EventHandler(this.ListBoxArray_SelectedIndexChanged);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(575, 56);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 9;
            this.ButtonSearch.Text = "SEARCH";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(396, 352);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 10;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(477, 352);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClearArray
            // 
            this.ButtonClearArray.Location = new System.Drawing.Point(575, 352);
            this.ButtonClearArray.Name = "ButtonClearArray";
            this.ButtonClearArray.Size = new System.Drawing.Size(75, 23);
            this.ButtonClearArray.TabIndex = 12;
            this.ButtonClearArray.Text = "Clear Array";
            this.ButtonClearArray.UseVisualStyleBackColor = true;
            this.ButtonClearArray.Click += new System.EventHandler(this.ButtonClearArray_Click);
            // 
            // ButtonSort
            // 
            this.ButtonSort.Location = new System.Drawing.Point(396, 86);
            this.ButtonSort.Name = "ButtonSort";
            this.ButtonSort.Size = new System.Drawing.Size(92, 23);
            this.ButtonSort.TabIndex = 13;
            this.ButtonSort.Text = "SORT Name";
            this.ButtonSort.UseVisualStyleBackColor = true;
            this.ButtonSort.Click += new System.EventHandler(this.ButtonSort_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(70, 352);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 23);
            this.ButtonClear.TabIndex = 14;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Structure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Definition";
            // 
            // WikiFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 400);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonSort);
            this.Controls.Add(this.ButtonClearArray);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ListBoxArray);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxStructure);
            this.Controls.Add(this.TextBoxCategory);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.TextBoxSearch);
            this.Name = "WikiFormApp";
            this.Text = "Wiki - Data Structure";
            this.Load += new System.EventHandler(this.WikiFormApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.TextBox TextBoxCategory;
        private System.Windows.Forms.TextBox TextBoxStructure;
        private System.Windows.Forms.TextBox TextBoxDefinition;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.ListBox ListBoxArray;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonClearArray;
        private System.Windows.Forms.Button ButtonSort;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

