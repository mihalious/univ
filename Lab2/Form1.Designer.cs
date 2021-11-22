
namespace Lab2
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
            this.ComboBoxName = new System.Windows.Forms.ComboBox();
            this.ComboBoxFaculty = new System.Windows.Forms.ComboBox();
            this.ComboBoxCathedra = new System.Windows.Forms.ComboBox();
            this.ComboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.ComboBoxProffecion = new System.Windows.Forms.ComboBox();
            this.ComboBoxOccupation = new System.Windows.Forms.ComboBox();
            this.RadioButtonSAX = new System.Windows.Forms.RadioButton();
            this.RadioButtonDOM = new System.Windows.Forms.RadioButton();
            this.RadioButtonLINQ = new System.Windows.Forms.RadioButton();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ToHtmlButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ComboBoxSection = new System.Windows.Forms.ComboBox();
            this.checkBoxName = new System.Windows.Forms.CheckBox();
            this.checkBoxFaculty = new System.Windows.Forms.CheckBox();
            this.checkBoxDepartment = new System.Windows.Forms.CheckBox();
            this.checkBoxSection = new System.Windows.Forms.CheckBox();
            this.checkBoxCathedra = new System.Windows.Forms.CheckBox();
            this.checkBoxProffecion = new System.Windows.Forms.CheckBox();
            this.checkBoxOccupation = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ComboBoxName
            // 
            this.ComboBoxName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxName.FormattingEnabled = true;
            this.ComboBoxName.Location = new System.Drawing.Point(184, 85);
            this.ComboBoxName.Name = "ComboBoxName";
            this.ComboBoxName.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxName.TabIndex = 6;
            this.ComboBoxName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxName_SelectedIndexChanged);
            // 
            // ComboBoxFaculty
            // 
            this.ComboBoxFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFaculty.FormattingEnabled = true;
            this.ComboBoxFaculty.Location = new System.Drawing.Point(184, 129);
            this.ComboBoxFaculty.Name = "ComboBoxFaculty";
            this.ComboBoxFaculty.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxFaculty.TabIndex = 7;
            this.ComboBoxFaculty.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFaculty_SelectedIndexChanged);
            // 
            // ComboBoxCathedra
            // 
            this.ComboBoxCathedra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxCathedra.FormattingEnabled = true;
            this.ComboBoxCathedra.Location = new System.Drawing.Point(184, 270);
            this.ComboBoxCathedra.Name = "ComboBoxCathedra";
            this.ComboBoxCathedra.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxCathedra.TabIndex = 8;
            this.ComboBoxCathedra.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCathedra_SelectedIndexChanged);
            // 
            // ComboBoxDepartment
            // 
            this.ComboBoxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDepartment.FormattingEnabled = true;
            this.ComboBoxDepartment.Location = new System.Drawing.Point(184, 177);
            this.ComboBoxDepartment.Name = "ComboBoxDepartment";
            this.ComboBoxDepartment.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxDepartment.TabIndex = 9;
            this.ComboBoxDepartment.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDepartment_SelectedIndexChanged);
            // 
            // ComboBoxProffecion
            // 
            this.ComboBoxProffecion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxProffecion.FormattingEnabled = true;
            this.ComboBoxProffecion.Location = new System.Drawing.Point(184, 313);
            this.ComboBoxProffecion.Name = "ComboBoxProffecion";
            this.ComboBoxProffecion.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxProffecion.TabIndex = 10;
            this.ComboBoxProffecion.SelectedIndexChanged += new System.EventHandler(this.ComboBoxProffecion_SelectedIndexChanged);
            // 
            // ComboBoxOccupation
            // 
            this.ComboBoxOccupation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxOccupation.FormattingEnabled = true;
            this.ComboBoxOccupation.Location = new System.Drawing.Point(184, 357);
            this.ComboBoxOccupation.Name = "ComboBoxOccupation";
            this.ComboBoxOccupation.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxOccupation.TabIndex = 11;
            this.ComboBoxOccupation.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOccupation_SelectedIndexChanged);
            // 
            // RadioButtonSAX
            // 
            this.RadioButtonSAX.AutoSize = true;
            this.RadioButtonSAX.Location = new System.Drawing.Point(408, 101);
            this.RadioButtonSAX.Name = "RadioButtonSAX";
            this.RadioButtonSAX.Size = new System.Drawing.Size(57, 24);
            this.RadioButtonSAX.TabIndex = 12;
            this.RadioButtonSAX.TabStop = true;
            this.RadioButtonSAX.Text = "SAX";
            this.RadioButtonSAX.UseVisualStyleBackColor = true;
            this.RadioButtonSAX.CheckedChanged += new System.EventHandler(this.RadioButtonSAX_CheckedChanged);
            // 
            // RadioButtonDOM
            // 
            this.RadioButtonDOM.AutoSize = true;
            this.RadioButtonDOM.Location = new System.Drawing.Point(504, 101);
            this.RadioButtonDOM.Name = "RadioButtonDOM";
            this.RadioButtonDOM.Size = new System.Drawing.Size(65, 24);
            this.RadioButtonDOM.TabIndex = 13;
            this.RadioButtonDOM.TabStop = true;
            this.RadioButtonDOM.Text = "DOM";
            this.RadioButtonDOM.UseVisualStyleBackColor = true;
            this.RadioButtonDOM.CheckedChanged += new System.EventHandler(this.RadioButtonDOM_CheckedChanged);
            // 
            // RadioButtonLINQ
            // 
            this.RadioButtonLINQ.AutoSize = true;
            this.RadioButtonLINQ.Location = new System.Drawing.Point(604, 101);
            this.RadioButtonLINQ.Name = "RadioButtonLINQ";
            this.RadioButtonLINQ.Size = new System.Drawing.Size(63, 24);
            this.RadioButtonLINQ.TabIndex = 14;
            this.RadioButtonLINQ.TabStop = true;
            this.RadioButtonLINQ.Text = "LINQ";
            this.RadioButtonLINQ.UseVisualStyleBackColor = true;
            this.RadioButtonLINQ.CheckedChanged += new System.EventHandler(this.RadioButtonLINQ_CheckedChanged);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(708, 31);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(392, 427);
            this.OutputTextBox.TabIndex = 15;
            this.OutputTextBox.Text = "";
            this.OutputTextBox.TextChanged += new System.EventHandler(this.OutputTextBox1_TextChanged);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(418, 177);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(107, 48);
            this.SearchButton.TabIndex = 16;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ToHtmlButton
            // 
            this.ToHtmlButton.Location = new System.Drawing.Point(570, 177);
            this.ToHtmlButton.Name = "ToHtmlButton";
            this.ToHtmlButton.Size = new System.Drawing.Size(107, 48);
            this.ToHtmlButton.TabIndex = 17;
            this.ToHtmlButton.Text = "Convert to HTML";
            this.ToHtmlButton.UseVisualStyleBackColor = true;
            this.ToHtmlButton.Click += new System.EventHandler(this.ToHtmlButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(570, 293);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(107, 48);
            this.ClearButton.TabIndex = 18;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ComboBoxSection
            // 
            this.ComboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxSection.FormattingEnabled = true;
            this.ComboBoxSection.Location = new System.Drawing.Point(184, 224);
            this.ComboBoxSection.Name = "ComboBoxSection";
            this.ComboBoxSection.Size = new System.Drawing.Size(186, 28);
            this.ComboBoxSection.TabIndex = 20;
            this.ComboBoxSection.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSection_SelectedIndexChanged);
            // 
            // checkBoxName
            // 
            this.checkBoxName.AutoSize = true;
            this.checkBoxName.Location = new System.Drawing.Point(42, 85);
            this.checkBoxName.Name = "checkBoxName";
            this.checkBoxName.Size = new System.Drawing.Size(71, 24);
            this.checkBoxName.TabIndex = 21;
            this.checkBoxName.Text = "Name";
            this.checkBoxName.UseVisualStyleBackColor = true;
            this.checkBoxName.CheckedChanged += new System.EventHandler(this.checkBoxName_CheckedChanged);
            // 
            // checkBoxFaculty
            // 
            this.checkBoxFaculty.AutoSize = true;
            this.checkBoxFaculty.Location = new System.Drawing.Point(42, 129);
            this.checkBoxFaculty.Name = "checkBoxFaculty";
            this.checkBoxFaculty.Size = new System.Drawing.Size(76, 24);
            this.checkBoxFaculty.TabIndex = 22;
            this.checkBoxFaculty.Text = "Faculty";
            this.checkBoxFaculty.UseVisualStyleBackColor = true;
            this.checkBoxFaculty.CheckedChanged += new System.EventHandler(this.checkBoxFaculty_CheckedChanged);
            // 
            // checkBoxDepartment
            // 
            this.checkBoxDepartment.AutoSize = true;
            this.checkBoxDepartment.Location = new System.Drawing.Point(42, 177);
            this.checkBoxDepartment.Name = "checkBoxDepartment";
            this.checkBoxDepartment.Size = new System.Drawing.Size(111, 24);
            this.checkBoxDepartment.TabIndex = 23;
            this.checkBoxDepartment.Text = "Department";
            this.checkBoxDepartment.UseVisualStyleBackColor = true;
            this.checkBoxDepartment.CheckedChanged += new System.EventHandler(this.checkBoxDepartment_CheckedChanged);
            // 
            // checkBoxSection
            // 
            this.checkBoxSection.AutoSize = true;
            this.checkBoxSection.Location = new System.Drawing.Point(42, 224);
            this.checkBoxSection.Name = "checkBoxSection";
            this.checkBoxSection.Size = new System.Drawing.Size(80, 24);
            this.checkBoxSection.TabIndex = 24;
            this.checkBoxSection.Text = "Section";
            this.checkBoxSection.UseVisualStyleBackColor = true;
            this.checkBoxSection.CheckedChanged += new System.EventHandler(this.checkBoxSection_CheckedChanged);
            // 
            // checkBoxCathedra
            // 
            this.checkBoxCathedra.AutoSize = true;
            this.checkBoxCathedra.Location = new System.Drawing.Point(42, 270);
            this.checkBoxCathedra.Name = "checkBoxCathedra";
            this.checkBoxCathedra.Size = new System.Drawing.Size(91, 24);
            this.checkBoxCathedra.TabIndex = 25;
            this.checkBoxCathedra.Text = "Cathedra";
            this.checkBoxCathedra.UseVisualStyleBackColor = true;
            this.checkBoxCathedra.CheckedChanged += new System.EventHandler(this.checkBoxCathedra_CheckedChanged);
            // 
            // checkBoxProffecion
            // 
            this.checkBoxProffecion.AutoSize = true;
            this.checkBoxProffecion.Location = new System.Drawing.Point(42, 313);
            this.checkBoxProffecion.Name = "checkBoxProffecion";
            this.checkBoxProffecion.Size = new System.Drawing.Size(99, 24);
            this.checkBoxProffecion.TabIndex = 26;
            this.checkBoxProffecion.Text = "Proffecion";
            this.checkBoxProffecion.UseVisualStyleBackColor = true;
            this.checkBoxProffecion.CheckedChanged += new System.EventHandler(this.checkBoxProffecion_CheckedChanged);
            // 
            // checkBoxOccupation
            // 
            this.checkBoxOccupation.AutoSize = true;
            this.checkBoxOccupation.Location = new System.Drawing.Point(42, 357);
            this.checkBoxOccupation.Name = "checkBoxOccupation";
            this.checkBoxOccupation.Size = new System.Drawing.Size(107, 24);
            this.checkBoxOccupation.TabIndex = 27;
            this.checkBoxOccupation.Text = "Occupation";
            this.checkBoxOccupation.UseVisualStyleBackColor = true;
            this.checkBoxOccupation.CheckedChanged += new System.EventHandler(this.checkBoxOccupation_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutProgramToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1112, 28);
            this.menuStrip1.TabIndex = 28;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.aboutProgramToolStripMenuItem.Text = "About Program";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(418, 293);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(107, 48);
            this.OpenFileButton.TabIndex = 29;
            this.OpenFileButton.Text = "Open File";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 470);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.checkBoxOccupation);
            this.Controls.Add(this.checkBoxProffecion);
            this.Controls.Add(this.checkBoxCathedra);
            this.Controls.Add(this.checkBoxSection);
            this.Controls.Add(this.checkBoxDepartment);
            this.Controls.Add(this.checkBoxFaculty);
            this.Controls.Add(this.checkBoxName);
            this.Controls.Add(this.ComboBoxSection);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ToHtmlButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.RadioButtonLINQ);
            this.Controls.Add(this.RadioButtonDOM);
            this.Controls.Add(this.RadioButtonSAX);
            this.Controls.Add(this.ComboBoxOccupation);
            this.Controls.Add(this.ComboBoxProffecion);
            this.Controls.Add(this.ComboBoxDepartment);
            this.Controls.Add(this.ComboBoxCathedra);
            this.Controls.Add(this.ComboBoxFaculty);
            this.Controls.Add(this.ComboBoxName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboBoxName;
        private System.Windows.Forms.ComboBox ComboBoxFaculty;
        private System.Windows.Forms.ComboBox ComboBoxCathedra;
        private System.Windows.Forms.ComboBox ComboBoxDepartment;
        private System.Windows.Forms.ComboBox ComboBoxProffecion;
        private System.Windows.Forms.ComboBox ComboBoxOccupation;
        private System.Windows.Forms.RadioButton RadioButtonSAX;
        private System.Windows.Forms.RadioButton RadioButtonDOM;
        private System.Windows.Forms.RadioButton RadioButtonLINQ;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button ToHtmlButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ComboBox ComboBoxSection;
        private System.Windows.Forms.CheckBox checkBoxName;
        private System.Windows.Forms.CheckBox checkBoxFaculty;
        private System.Windows.Forms.CheckBox checkBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxSection;
        private System.Windows.Forms.CheckBox checkBoxCathedra;
        private System.Windows.Forms.CheckBox checkBoxProffecion;
        private System.Windows.Forms.CheckBox checkBoxOccupation;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        private System.Windows.Forms.Button OpenFileButton;
    }
}

