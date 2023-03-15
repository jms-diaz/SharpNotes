namespace SharpNotes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            titleLbl = new Label();
            label1 = new Label();
            titleTxt = new TextBox();
            descriptionTxt = new RichTextBox();
            saveBtn = new Button();
            allNotes = new DataGridView();
            deleteBtn = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)allNotes).BeginInit();
            SuspendLayout();
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Open Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            titleLbl.Location = new Point(261, 19);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(54, 26);
            titleLbl.TabIndex = 0;
            titleLbl.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Open Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(261, 90);
            label1.Name = "label1";
            label1.Size = new Size(121, 26);
            label1.TabIndex = 1;
            label1.Text = "Description";
            // 
            // titleTxt
            // 
            titleTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            titleTxt.Location = new Point(269, 52);
            titleTxt.Name = "titleTxt";
            titleTxt.Size = new Size(464, 29);
            titleTxt.TabIndex = 2;
            // 
            // descriptionTxt
            // 
            descriptionTxt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            descriptionTxt.Location = new Point(269, 123);
            descriptionTxt.Name = "descriptionTxt";
            descriptionTxt.Size = new Size(464, 365);
            descriptionTxt.TabIndex = 3;
            descriptionTxt.Text = "";
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(658, 505);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 4;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // allNotes
            // 
            allNotes.AllowUserToDeleteRows = false;
            allNotes.BackgroundColor = SystemColors.ControlLightLight;
            allNotes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allNotes.Location = new Point(12, 52);
            allNotes.Name = "allNotes";
            allNotes.ReadOnly = true;
            allNotes.RowTemplate.Height = 25;
            allNotes.Size = new Size(240, 476);
            allNotes.TabIndex = 5;
            allNotes.CellContentDoubleClick += allNotes_CellContentDoubleClick;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(269, 505);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 23);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Open Sans", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(9, 19);
            label2.Name = "label2";
            label2.Size = new Size(97, 26);
            label2.TabIndex = 7;
            label2.Text = "All Notes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(752, 561);
            Controls.Add(label2);
            Controls.Add(deleteBtn);
            Controls.Add(allNotes);
            Controls.Add(saveBtn);
            Controls.Add(descriptionTxt);
            Controls.Add(titleTxt);
            Controls.Add(label1);
            Controls.Add(titleLbl);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SharpNotes";
            ((System.ComponentModel.ISupportInitialize)allNotes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLbl;
        private Label label1;
        private TextBox titleTxt;
        private RichTextBox descriptionTxt;
        private Button saveBtn;
        private DataGridView allNotes;
        private Button deleteBtn;
        private Label label2;
    }
}