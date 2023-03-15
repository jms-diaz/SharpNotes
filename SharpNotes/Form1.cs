using System.Data;

namespace SharpNotes
{
    public partial class Form1 : Form
    {
        DataTable notes = new DataTable();
        bool editing = false;

        public Form1()
        {
            InitializeComponent();
            allNotes.DataSource = notes;
            notes.Columns.Add("Title");
            notes.Columns.Add("Description");

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (editing)
            {
                notes.Rows[allNotes.CurrentCell.RowIndex]["Title"] = titleTxt.Text;
                notes.Rows[allNotes.CurrentCell.RowIndex]["Description"] = descriptionTxt.Text;
            }
            else
            {
                notes.Rows.Add(titleTxt.Text, descriptionTxt.Text);
            }

            titleTxt.Text = "";
            descriptionTxt.Text = "";
            editing = false;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                notes.Rows[allNotes.CurrentCell.RowIndex].Delete();
            }
            catch (Exception err)
            {
                MessageBox.Show("Please select a note.", "Delete Note");
            }

        }

        private void allNotes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            titleTxt.Text = notes.Rows[allNotes.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTxt.Text = notes.Rows[allNotes.CurrentCell.RowIndex].ItemArray[1].ToString();
            editing = true;
        }
    }
}