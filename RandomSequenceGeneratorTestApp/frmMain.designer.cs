namespace RandomSequenceGeneratorTestApp
{
  partial class frmMain
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
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.nudSequenceLength = new System.Windows.Forms.NumericUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.nudSequenceStart = new System.Windows.Forms.NumericUpDown();
      this.label2 = new System.Windows.Forms.Label();
      this.btnGenerate = new System.Windows.Forms.Button();
      this.btnCopy = new System.Windows.Forms.Button();
      this.tabControl = new System.Windows.Forms.TabControl();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.cmbLatinCase = new System.Windows.Forms.ComboBox();
      this.cmbCyrillicCase = new System.Windows.Forms.ComboBox();
      this.chkCyrillicChars = new System.Windows.Forms.CheckBox();
      this.chkCustom = new System.Windows.Forms.CheckBox();
      this.chkSpecial = new System.Windows.Forms.CheckBox();
      this.chkPunctuations = new System.Windows.Forms.CheckBox();
      this.chkNumbers = new System.Windows.Forms.CheckBox();
      this.txtCustomChars = new System.Windows.Forms.TextBox();
      this.chkLatinChars = new System.Windows.Forms.CheckBox();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.btnSplitInput = new System.Windows.Forms.Button();
      this.btnDeleteSelected = new System.Windows.Forms.Button();
      this.dgvItems = new System.Windows.Forms.DataGridView();
      this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnClearItems = new System.Windows.Forms.Button();
      this.txtInputSeparator = new System.Windows.Forms.TextBox();
      this.nudWeightSelected = new System.Windows.Forms.NumericUpDown();
      this.txtItemSelected = new System.Windows.Forms.TextBox();
      this.nudInputWeight = new System.Windows.Forms.NumericUpDown();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.btnClearSeed = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.txtSeed = new System.Windows.Forms.TextBox();
      this.btnGetRandomSeed = new System.Windows.Forms.Button();
      this.chkAdvancedItems = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.nudSequenceLength)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSequenceStart)).BeginInit();
      this.tabControl.SuspendLayout();
      this.tabPage1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudWeightSelected)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudInputWeight)).BeginInit();
      this.SuspendLayout();
      // 
      // txtOutput
      // 
      this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtOutput.BackColor = System.Drawing.SystemColors.Window;
      this.txtOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txtOutput.Location = new System.Drawing.Point(12, 12);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ReadOnly = true;
      this.txtOutput.Size = new System.Drawing.Size(351, 281);
      this.txtOutput.TabIndex = 0;
      // 
      // nudSequenceLength
      // 
      this.nudSequenceLength.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.nudSequenceLength.Location = new System.Drawing.Point(56, 300);
      this.nudSequenceLength.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.nudSequenceLength.Name = "nudSequenceLength";
      this.nudSequenceLength.Size = new System.Drawing.Size(50, 20);
      this.nudSequenceLength.TabIndex = 17;
      this.nudSequenceLength.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
      this.nudSequenceLength.ValueChanged += new System.EventHandler(this.nudLength_ValueChanged);
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 302);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(43, 13);
      this.label1.TabIndex = 9;
      this.label1.Text = "Length:";
      // 
      // nudSequenceStart
      // 
      this.nudSequenceStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.nudSequenceStart.Location = new System.Drawing.Point(173, 300);
      this.nudSequenceStart.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.nudSequenceStart.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudSequenceStart.Name = "nudSequenceStart";
      this.nudSequenceStart.Size = new System.Drawing.Size(50, 20);
      this.nudSequenceStart.TabIndex = 18;
      this.nudSequenceStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudSequenceStart.ValueChanged += new System.EventHandler(this.nudSkipPasses_ValueChanged);
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(117, 302);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(55, 13);
      this.label2.TabIndex = 16;
      this.label2.Text = "Start from:";
      // 
      // btnGenerate
      // 
      this.btnGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGenerate.Location = new System.Drawing.Point(481, 296);
      this.btnGenerate.Name = "btnGenerate";
      this.btnGenerate.Size = new System.Drawing.Size(75, 23);
      this.btnGenerate.TabIndex = 20;
      this.btnGenerate.Text = "Generate";
      this.btnGenerate.UseVisualStyleBackColor = true;
      this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
      // 
      // btnCopy
      // 
      this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCopy.Location = new System.Drawing.Point(376, 297);
      this.btnCopy.Name = "btnCopy";
      this.btnCopy.Size = new System.Drawing.Size(75, 23);
      this.btnCopy.TabIndex = 19;
      this.btnCopy.Text = "Copy";
      this.btnCopy.UseVisualStyleBackColor = true;
      this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
      // 
      // tabControl
      // 
      this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl.Controls.Add(this.tabPage1);
      this.tabControl.Controls.Add(this.tabPage2);
      this.tabControl.Location = new System.Drawing.Point(366, 12);
      this.tabControl.Name = "tabControl";
      this.tabControl.SelectedIndex = 0;
      this.tabControl.Size = new System.Drawing.Size(200, 280);
      this.tabControl.TabIndex = 21;
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.cmbLatinCase);
      this.tabPage1.Controls.Add(this.cmbCyrillicCase);
      this.tabPage1.Controls.Add(this.chkCyrillicChars);
      this.tabPage1.Controls.Add(this.chkCustom);
      this.tabPage1.Controls.Add(this.chkSpecial);
      this.tabPage1.Controls.Add(this.chkPunctuations);
      this.tabPage1.Controls.Add(this.chkNumbers);
      this.tabPage1.Controls.Add(this.txtCustomChars);
      this.tabPage1.Controls.Add(this.chkLatinChars);
      this.tabPage1.Location = new System.Drawing.Point(4, 22);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage1.Size = new System.Drawing.Size(192, 254);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "Simple";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // cmbLatinCase
      // 
      this.cmbLatinCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLatinCase.FormattingEnabled = true;
      this.cmbLatinCase.Location = new System.Drawing.Point(120, 4);
      this.cmbLatinCase.Name = "cmbLatinCase";
      this.cmbLatinCase.Size = new System.Drawing.Size(65, 21);
      this.cmbLatinCase.TabIndex = 11;
      this.cmbLatinCase.SelectedIndexChanged += new System.EventHandler(this.cmbLatinCase_SelectedIndexChanged);
      // 
      // cmbCyrillicCase
      // 
      this.cmbCyrillicCase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCyrillicCase.FormattingEnabled = true;
      this.cmbCyrillicCase.Location = new System.Drawing.Point(120, 27);
      this.cmbCyrillicCase.Name = "cmbCyrillicCase";
      this.cmbCyrillicCase.Size = new System.Drawing.Size(65, 21);
      this.cmbCyrillicCase.TabIndex = 13;
      this.cmbCyrillicCase.SelectedIndexChanged += new System.EventHandler(this.cmbCyrillicCase_SelectedIndexChanged);
      // 
      // chkCyrillicChars
      // 
      this.chkCyrillicChars.AutoSize = true;
      this.chkCyrillicChars.Location = new System.Drawing.Point(6, 29);
      this.chkCyrillicChars.Name = "chkCyrillicChars";
      this.chkCyrillicChars.Size = new System.Drawing.Size(108, 17);
      this.chkCyrillicChars.TabIndex = 12;
      this.chkCyrillicChars.Text = "Cyrillic characters";
      this.chkCyrillicChars.UseVisualStyleBackColor = true;
      this.chkCyrillicChars.CheckedChanged += new System.EventHandler(this.chkCyrillicChars_CheckedChanged);
      // 
      // chkCustom
      // 
      this.chkCustom.AutoSize = true;
      this.chkCustom.Location = new System.Drawing.Point(6, 121);
      this.chkCustom.Name = "chkCustom";
      this.chkCustom.Size = new System.Drawing.Size(117, 17);
      this.chkCustom.TabIndex = 17;
      this.chkCustom.Text = "Custom characters:";
      this.chkCustom.UseVisualStyleBackColor = true;
      this.chkCustom.CheckedChanged += new System.EventHandler(this.chkCustom_CheckedChanged);
      // 
      // chkSpecial
      // 
      this.chkSpecial.AutoSize = true;
      this.chkSpecial.Location = new System.Drawing.Point(6, 98);
      this.chkSpecial.Name = "chkSpecial";
      this.chkSpecial.Size = new System.Drawing.Size(114, 17);
      this.chkSpecial.TabIndex = 16;
      this.chkSpecial.Text = "Special characters";
      this.chkSpecial.UseVisualStyleBackColor = true;
      this.chkSpecial.CheckedChanged += new System.EventHandler(this.chkCustom_CheckedChanged);
      // 
      // chkPunctuations
      // 
      this.chkPunctuations.AutoSize = true;
      this.chkPunctuations.Location = new System.Drawing.Point(6, 75);
      this.chkPunctuations.Name = "chkPunctuations";
      this.chkPunctuations.Size = new System.Drawing.Size(83, 17);
      this.chkPunctuations.TabIndex = 15;
      this.chkPunctuations.Text = "Punctuation";
      this.chkPunctuations.UseVisualStyleBackColor = true;
      this.chkPunctuations.CheckedChanged += new System.EventHandler(this.chkPunctuations_CheckedChanged);
      // 
      // chkNumbers
      // 
      this.chkNumbers.AutoSize = true;
      this.chkNumbers.Location = new System.Drawing.Point(6, 52);
      this.chkNumbers.Name = "chkNumbers";
      this.chkNumbers.Size = new System.Drawing.Size(68, 17);
      this.chkNumbers.TabIndex = 14;
      this.chkNumbers.Text = "Numbers";
      this.chkNumbers.UseVisualStyleBackColor = true;
      this.chkNumbers.CheckedChanged += new System.EventHandler(this.chkNumbers_CheckedChanged);
      // 
      // txtCustomChars
      // 
      this.txtCustomChars.Location = new System.Drawing.Point(5, 144);
      this.txtCustomChars.Name = "txtCustomChars";
      this.txtCustomChars.Size = new System.Drawing.Size(180, 20);
      this.txtCustomChars.TabIndex = 18;
      this.txtCustomChars.TextChanged += new System.EventHandler(this.txtCustomChars_TextChanged);
      // 
      // chkLatinChars
      // 
      this.chkLatinChars.AutoSize = true;
      this.chkLatinChars.Checked = true;
      this.chkLatinChars.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkLatinChars.Location = new System.Drawing.Point(6, 6);
      this.chkLatinChars.Name = "chkLatinChars";
      this.chkLatinChars.Size = new System.Drawing.Size(102, 17);
      this.chkLatinChars.TabIndex = 10;
      this.chkLatinChars.Text = "Latin characters";
      this.chkLatinChars.UseVisualStyleBackColor = true;
      this.chkLatinChars.CheckedChanged += new System.EventHandler(this.chkLatinChars_CheckedChanged);
      // 
      // tabPage2
      // 
      this.tabPage2.Controls.Add(this.chkAdvancedItems);
      this.tabPage2.Controls.Add(this.label5);
      this.tabPage2.Controls.Add(this.label4);
      this.tabPage2.Controls.Add(this.btnSplitInput);
      this.tabPage2.Controls.Add(this.btnDeleteSelected);
      this.tabPage2.Controls.Add(this.dgvItems);
      this.tabPage2.Controls.Add(this.btnClearItems);
      this.tabPage2.Controls.Add(this.txtInputSeparator);
      this.tabPage2.Controls.Add(this.nudWeightSelected);
      this.tabPage2.Controls.Add(this.txtItemSelected);
      this.tabPage2.Controls.Add(this.nudInputWeight);
      this.tabPage2.Controls.Add(this.txtInput);
      this.tabPage2.Location = new System.Drawing.Point(4, 22);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage2.Size = new System.Drawing.Size(192, 254);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Advanced";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(102, 55);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(44, 13);
      this.label5.TabIndex = 14;
      this.label5.Text = "Weight:";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(6, 55);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(56, 13);
      this.label4.TabIndex = 13;
      this.label4.Text = "Separator:";
      // 
      // btnSplitInput
      // 
      this.btnSplitInput.Location = new System.Drawing.Point(143, 27);
      this.btnSplitInput.Name = "btnSplitInput";
      this.btnSplitInput.Size = new System.Drawing.Size(43, 23);
      this.btnSplitInput.TabIndex = 12;
      this.btnSplitInput.Text = "Parse";
      this.btnSplitInput.UseVisualStyleBackColor = true;
      this.btnSplitInput.Click += new System.EventHandler(this.btnSplitInput_Click);
      // 
      // btnDeleteSelected
      // 
      this.btnDeleteSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnDeleteSelected.Location = new System.Drawing.Point(147, 194);
      this.btnDeleteSelected.Name = "btnDeleteSelected";
      this.btnDeleteSelected.Size = new System.Drawing.Size(39, 23);
      this.btnDeleteSelected.TabIndex = 11;
      this.btnDeleteSelected.Text = "Del";
      this.btnDeleteSelected.UseVisualStyleBackColor = true;
      this.btnDeleteSelected.Click += new System.EventHandler(this.btnDeleteSelected_Click);
      // 
      // dgvItems
      // 
      this.dgvItems.AllowUserToAddRows = false;
      this.dgvItems.AllowUserToDeleteRows = false;
      this.dgvItems.AllowUserToResizeRows = false;
      this.dgvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dgvItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.index,
            this.item,
            this.weight});
      this.dgvItems.Location = new System.Drawing.Point(6, 79);
      this.dgvItems.MultiSelect = false;
      this.dgvItems.Name = "dgvItems";
      this.dgvItems.ReadOnly = true;
      this.dgvItems.RowHeadersVisible = false;
      this.dgvItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgvItems.Size = new System.Drawing.Size(180, 111);
      this.dgvItems.TabIndex = 10;
      this.dgvItems.SelectionChanged += new System.EventHandler(this.dgvItems_SelectionChanged);
      // 
      // index
      // 
      this.index.HeaderText = "";
      this.index.Name = "index";
      this.index.ReadOnly = true;
      this.index.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.index.Visible = false;
      // 
      // item
      // 
      this.item.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.item.FillWeight = 50F;
      this.item.HeaderText = "Item";
      this.item.Name = "item";
      this.item.ReadOnly = true;
      this.item.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // weight
      // 
      this.weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.weight.FillWeight = 50F;
      this.weight.HeaderText = "Weight";
      this.weight.Name = "weight";
      this.weight.ReadOnly = true;
      this.weight.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      // 
      // btnClearItems
      // 
      this.btnClearItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnClearItems.Location = new System.Drawing.Point(6, 223);
      this.btnClearItems.Name = "btnClearItems";
      this.btnClearItems.Size = new System.Drawing.Size(180, 23);
      this.btnClearItems.TabIndex = 9;
      this.btnClearItems.Text = "Clear item list";
      this.btnClearItems.UseVisualStyleBackColor = true;
      this.btnClearItems.Click += new System.EventHandler(this.btnClearItems_Click);
      // 
      // txtInputSeparator
      // 
      this.txtInputSeparator.Location = new System.Drawing.Point(63, 52);
      this.txtInputSeparator.Name = "txtInputSeparator";
      this.txtInputSeparator.Size = new System.Drawing.Size(33, 20);
      this.txtInputSeparator.TabIndex = 6;
      // 
      // nudWeightSelected
      // 
      this.nudWeightSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.nudWeightSelected.Location = new System.Drawing.Point(102, 196);
      this.nudWeightSelected.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudWeightSelected.Name = "nudWeightSelected";
      this.nudWeightSelected.Size = new System.Drawing.Size(39, 20);
      this.nudWeightSelected.TabIndex = 5;
      this.nudWeightSelected.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudWeightSelected.ValueChanged += new System.EventHandler(this.nudWeightSelected_ValueChanged);
      // 
      // txtItemSelected
      // 
      this.txtItemSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txtItemSelected.Location = new System.Drawing.Point(6, 196);
      this.txtItemSelected.Name = "txtItemSelected";
      this.txtItemSelected.Size = new System.Drawing.Size(90, 20);
      this.txtItemSelected.TabIndex = 4;
      this.txtItemSelected.TextChanged += new System.EventHandler(this.txtItemSelected_TextChanged);
      // 
      // nudInputWeight
      // 
      this.nudInputWeight.Location = new System.Drawing.Point(147, 53);
      this.nudInputWeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudInputWeight.Name = "nudInputWeight";
      this.nudInputWeight.Size = new System.Drawing.Size(39, 20);
      this.nudInputWeight.TabIndex = 2;
      this.nudInputWeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // txtInput
      // 
      this.txtInput.Location = new System.Drawing.Point(6, 29);
      this.txtInput.Multiline = true;
      this.txtInput.Name = "txtInput";
      this.txtInput.Size = new System.Drawing.Size(133, 20);
      this.txtInput.TabIndex = 0;
      // 
      // btnClearSeed
      // 
      this.btnClearSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnClearSeed.Location = new System.Drawing.Point(340, 297);
      this.btnClearSeed.Name = "btnClearSeed";
      this.btnClearSeed.Size = new System.Drawing.Size(23, 23);
      this.btnClearSeed.TabIndex = 25;
      this.btnClearSeed.Text = "X";
      this.btnClearSeed.UseVisualStyleBackColor = true;
      this.btnClearSeed.Click += new System.EventHandler(this.btnClearSeed_Click);
      // 
      // label3
      // 
      this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(234, 302);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 24;
      this.label3.Text = "Seed:";
      // 
      // txtSeed
      // 
      this.txtSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txtSeed.Location = new System.Drawing.Point(270, 299);
      this.txtSeed.Name = "txtSeed";
      this.txtSeed.Size = new System.Drawing.Size(45, 20);
      this.txtSeed.TabIndex = 23;
      // 
      // btnGetRandomSeed
      // 
      this.btnGetRandomSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.btnGetRandomSeed.Location = new System.Drawing.Point(317, 297);
      this.btnGetRandomSeed.Name = "btnGetRandomSeed";
      this.btnGetRandomSeed.Size = new System.Drawing.Size(23, 23);
      this.btnGetRandomSeed.TabIndex = 26;
      this.btnGetRandomSeed.Text = "?";
      this.btnGetRandomSeed.UseVisualStyleBackColor = true;
      this.btnGetRandomSeed.Click += new System.EventHandler(this.btnGetRandomSeed_Click);
      // 
      // chkAdvancedItems
      // 
      this.chkAdvancedItems.AutoSize = true;
      this.chkAdvancedItems.Location = new System.Drawing.Point(6, 6);
      this.chkAdvancedItems.Name = "chkAdvancedItems";
      this.chkAdvancedItems.Size = new System.Drawing.Size(102, 17);
      this.chkAdvancedItems.TabIndex = 15;
      this.chkAdvancedItems.Text = "Advanced items";
      this.chkAdvancedItems.UseVisualStyleBackColor = true;
      this.chkAdvancedItems.CheckedChanged += new System.EventHandler(this.chkAdvancedItems_CheckedChanged);
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(563, 332);
      this.Controls.Add(this.btnGetRandomSeed);
      this.Controls.Add(this.btnClearSeed);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtSeed);
      this.Controls.Add(this.tabControl);
      this.Controls.Add(this.btnCopy);
      this.Controls.Add(this.btnGenerate);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.nudSequenceStart);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.nudSequenceLength);
      this.Controls.Add(this.txtOutput);
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Random sequence generator";
      ((System.ComponentModel.ISupportInitialize)(this.nudSequenceLength)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudSequenceStart)).EndInit();
      this.tabControl.ResumeLayout(false);
      this.tabPage1.ResumeLayout(false);
      this.tabPage1.PerformLayout();
      this.tabPage2.ResumeLayout(false);
      this.tabPage2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudWeightSelected)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudInputWeight)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.NumericUpDown nudSequenceLength;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.NumericUpDown nudSequenceStart;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnGenerate;
    private System.Windows.Forms.Button btnCopy;
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.ComboBox cmbLatinCase;
    private System.Windows.Forms.ComboBox cmbCyrillicCase;
    private System.Windows.Forms.CheckBox chkCyrillicChars;
    private System.Windows.Forms.CheckBox chkCustom;
    private System.Windows.Forms.CheckBox chkSpecial;
    private System.Windows.Forms.CheckBox chkPunctuations;
    private System.Windows.Forms.CheckBox chkNumbers;
    private System.Windows.Forms.TextBox txtCustomChars;
    private System.Windows.Forms.CheckBox chkLatinChars;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.TextBox txtInputSeparator;
    private System.Windows.Forms.NumericUpDown nudWeightSelected;
    private System.Windows.Forms.TextBox txtItemSelected;
    private System.Windows.Forms.NumericUpDown nudInputWeight;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.Button btnClearSeed;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtSeed;
    private System.Windows.Forms.Button btnClearItems;
    private System.Windows.Forms.Button btnGetRandomSeed;
    private System.Windows.Forms.DataGridView dgvItems;
    private System.Windows.Forms.DataGridViewTextBoxColumn index;
    private System.Windows.Forms.DataGridViewTextBoxColumn item;
    private System.Windows.Forms.DataGridViewTextBoxColumn weight;
    private System.Windows.Forms.Button btnDeleteSelected;
    private System.Windows.Forms.Button btnSplitInput;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.CheckBox chkAdvancedItems;
  }
}

