using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using RandomSequenceGenerator;

namespace RandomSequenceGeneratorTestApp
{
  public partial class frmMain : Form
  {
    RandomSequenceGenerator<string> generator;

    bool update;

    string[] latinLower;
    string[] latinUpper;
    string[] cyrillicLower;
    string[] cyrillicUpper;
    string[] numbers;
    string[] punctuation;
    string[] special;
    
    List<string> itemsAdvanced;
    List<int> weightsAdvanced;

    public frmMain()
    {
      InitializeComponent();

      cmbLatinCase.Items.Add("Upper");
      cmbLatinCase.Items.Add("Lower");
      cmbLatinCase.Items.Add("Mix");
      cmbLatinCase.SelectedIndex = 0;

      cmbCyrillicCase.Items.Add("Upper");
      cmbCyrillicCase.Items.Add("Lower");
      cmbCyrillicCase.Items.Add("Mix");
      cmbCyrillicCase.SelectedIndex = 0;

      generator = new RandomSequenceGenerator<string>();

      latinLower = SplitByLength("abcdefghijklmnopqrstuvwxyz");
      latinUpper = SplitByLength("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
      cyrillicLower = SplitByLength("абвгдеёжзийклмнопрстуфхцчшщъыьэюя");
      cyrillicUpper = SplitByLength("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
      numbers = SplitByLength("0123456789");
      punctuation = SplitByLength(".,:;!?");
      special = SplitByLength("\"'~@#$%^&*()_+|-=\\{}[]<>/");

      itemsAdvanced = new List<string>();
      weightsAdvanced = new List<int>();
    }

    #region[simple]

    private void chkLatinChars_CheckedChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void chkCyrillicChars_CheckedChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void chkNumbers_CheckedChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void chkPunctuations_CheckedChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void chkSpecial_CheckedChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void chkCustom_CheckedChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void cmbLatinCase_SelectedIndexChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void cmbCyrillicCase_SelectedIndexChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private void txtCustomChars_TextChanged(object sender, EventArgs e)
    {
      update = true;
    }

    private string[] SplitByLength(string input, int length = 1)
    {
      if (input == null || length < 1)
      {
        return new string[0];
      }

      string[] result;
      bool unevenRest;

      if (input.Length % length > 0)
      {
        unevenRest = true;
        result = new string[input.Length / length + 1];
      }
      else
      {
        unevenRest = false;
        result = new string[input.Length / length];
      }

      int currentPosition = 0;
      int i;
      for (i = 0; i < result.Length; i++)
      {
        result[i] = input.Substring(currentPosition, length);
        currentPosition += length;
      }

      if (unevenRest)
      {
        result[i] = input.Substring(currentPosition);
      }

      return result;
    }

    #endregion

    #region[advanced]

    private void btnSplitInput_Click(object sender, EventArgs e)
    {
      string[] newInput;
      int weight = (int)nudInputWeight.Value;

      if (txtInput.Text.Length > 0 && weight > 0)
      {
        if (txtInputSeparator.Text.Length > 0)
        {
          newInput = txtInput.Text.Split(new string[] { txtInputSeparator.Text }, StringSplitOptions.None);
        }
        else
        {
          newInput = new string[] { txtInput.Text };
        }

        for (int i = 0; i < newInput.Length; i++)
        {
          itemsAdvanced.Add(newInput[i]);
          weightsAdvanced.Add(weight);
        }

        update = true;
        UpdateItemsTable();
      }
    }

    private void dgvItems_SelectionChanged(object sender, EventArgs e)
    {
      if (dgvItems.SelectedRows.Count > 0)
      {
        int index = GetIndexSelected();

        txtItemSelected.Text = itemsAdvanced[index];
        nudWeightSelected.Value = weightsAdvanced[index];
      }
    }

    private void txtItemSelected_TextChanged(object sender, EventArgs e)
    {
      if (dgvItems.SelectedRows.Count > 0)
      {
        int index = GetIndexSelected();

        itemsAdvanced[index] = txtItemSelected.Text;
        dgvItems.SelectedRows[0].Cells[1].Value = txtItemSelected.Text;

        update = true;
      }
    }

    private void nudWeightSelected_ValueChanged(object sender, EventArgs e)
    {
      if (dgvItems.SelectedRows.Count > 0)
      {
        int index = GetIndexSelected();

        weightsAdvanced[index] = (int)nudWeightSelected.Value;
        dgvItems.SelectedRows[0].Cells[2].Value = (int)nudWeightSelected.Value;

        update = true;
      }
    }

    private void btnDeleteSelected_Click(object sender, EventArgs e)
    {
      if (dgvItems.SelectedRows.Count > 0)
      {
        int index = GetIndexSelected();

        itemsAdvanced.RemoveAt(index);
        weightsAdvanced.RemoveAt(index);

        update = true;
        UpdateItemsTable();
      }
    }

    private void btnClearItems_Click(object sender, EventArgs e)
    {
      itemsAdvanced.Clear();
      weightsAdvanced.Clear();

      UpdateItemsTable();
      update = true;
    }

    private int GetIndexSelected()
    {
      return (int)dgvItems.SelectedRows[0].Cells[0].Value;
    }

    private void UpdateItemsTable()
    {
      int selected = -1;

      if (dgvItems.SelectedRows.Count > 0)
      {
        selected = dgvItems.SelectedRows[0].Index;
      }

      dgvItems.ClearSelection();
      dgvItems.Rows.Clear();

      for (int i = 0; i < itemsAdvanced.Count; i++)
      {
        dgvItems.Rows.Add(i, itemsAdvanced[i], weightsAdvanced[i]);
      }

      if (selected >= 0 && dgvItems.Rows.Count > selected)
      {
        dgvItems.Rows[selected].Selected = true;
      }
    }

    #endregion

    #region[generation]

    private void nudSkipPasses_ValueChanged(object sender, EventArgs e)
    {
      Generate();
    }

    private void nudLength_ValueChanged(object sender, EventArgs e)
    {
      Generate();
    }

    private void btnGetRandomSeed_Click(object sender, EventArgs e)
    {
      txtSeed.Text = new Random((int)System.DateTime.Now.ToBinary()).Next(1, 99999).ToString();
    }

    private void btnClearSeed_Click(object sender, EventArgs e)
    {
      txtSeed.Text = string.Empty;
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
      Generate();
    }

    private void btnCopy_Click(object sender, EventArgs e)
    {
      if (txtOutput.Text.Length > 0)
      {
        Clipboard.SetText(txtOutput.Text);
        SystemSounds.Exclamation.Play();
      }
    }

    private void UpdateItems()
    {
      generator.Clear();

      if (chkLatinChars.Checked)
      {
        switch (cmbLatinCase.SelectedIndex)
        {
          case 0: generator.Add(latinUpper); break;
          case 1: generator.Add(latinLower); break;
          case 2: { generator.Add(latinUpper); generator.Add(latinLower); } break;
        }
      }

      if (chkCyrillicChars.Checked)
      {
        switch (cmbCyrillicCase.SelectedIndex)
        {
          case 0: generator.Add(cyrillicUpper); break;
          case 1: generator.Add(cyrillicLower); break;
          case 2: { generator.Add(cyrillicUpper); generator.Add(cyrillicLower); } break;
        }
      }

      if (chkNumbers.Checked)
      {
        generator.Add(numbers);
      }

      if (chkPunctuations.Checked)
      {
        generator.Add(punctuation);
      }

      if (chkSpecial.Checked)
      {
        generator.Add(special);
      }

      if (chkCustom.Checked && txtCustomChars.Text.Length > 0)
      {
        generator.Add(SplitByLength(txtCustomChars.Text));
      }

      update = false;

      for (int i = 0; i < itemsAdvanced.Count; i++)
      {
        generator.Add(itemsAdvanced[i], weightsAdvanced[i]);
      }

      update = false;
    }

    private void Generate()
    {
      if (update || update)
      {
        UpdateItems();
      }

      if (txtSeed.Text.Length == 0)
      {
        generator.NewSeed();
      }
      else
      {
        int seed = txtSeed.Text.GetHashCode();
        if (seed != generator.Seed)
        {
          generator.NewSeed(seed);
        }
        generator.JumpToItem((int)nudSequenceStart.Value - 1);
      }

      if (generator.ItemsCount > 0)
      {
        string[] result = generator.NextSequence((int)nudSequenceLength.Value);

        txtOutput.Text = string.Join("", result);
      }
      else
      {
        MessageBox.Show("There is no items to select from!");
      }
    }

    #endregion
  }
}
