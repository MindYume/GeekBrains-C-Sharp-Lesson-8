namespace Homework
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEdit = new System.Windows.Forms.ToolStripDropDownButton();
            this.menuBtnNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBtnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.checkTrue = new System.Windows.Forms.CheckBox();
            this.textFieldQuestion = new System.Windows.Forms.TextBox();
            this.numericQuestionNumber = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFileName = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuestionNumber)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnAbout,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEdit
            // 
            this.btnEdit.AccessibleName = "";
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnNew,
            this.menuBtnOpen,
            this.menuBtnSave,
            this.toolStripSeparator1,
            this.menuBtnExit});
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 22);
            this.btnEdit.Tag = "";
            this.btnEdit.Text = "Edit";
            // 
            // menuBtnNew
            // 
            this.menuBtnNew.Name = "menuBtnNew";
            this.menuBtnNew.Size = new System.Drawing.Size(180, 22);
            this.menuBtnNew.Text = "New";
            this.menuBtnNew.Click += new System.EventHandler(this.menuBtnNew_Click);
            // 
            // menuBtnOpen
            // 
            this.menuBtnOpen.Name = "menuBtnOpen";
            this.menuBtnOpen.Size = new System.Drawing.Size(180, 22);
            this.menuBtnOpen.Text = "Open";
            this.menuBtnOpen.Click += new System.EventHandler(this.menuBtnOpen_Click);
            // 
            // menuBtnSave
            // 
            this.menuBtnSave.Name = "menuBtnSave";
            this.menuBtnSave.Size = new System.Drawing.Size(180, 22);
            this.menuBtnSave.Text = "Save";
            this.menuBtnSave.Click += new System.EventHandler(this.menuBtnSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // menuBtnExit
            // 
            this.menuBtnExit.Name = "menuBtnExit";
            this.menuBtnExit.Size = new System.Drawing.Size(180, 22);
            this.menuBtnExit.Text = "Exit";
            this.menuBtnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.ForestGreen;
            this.panel1.Controls.Add(this.numericQuestionNumber);
            this.panel1.Controls.Add(this.checkTrue);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 48);
            this.panel1.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(93, 13);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // checkTrue
            // 
            this.checkTrue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkTrue.AutoSize = true;
            this.checkTrue.Location = new System.Drawing.Point(738, 13);
            this.checkTrue.Name = "checkTrue";
            this.checkTrue.Size = new System.Drawing.Size(48, 17);
            this.checkTrue.TabIndex = 3;
            this.checkTrue.Text = "True";
            this.checkTrue.UseVisualStyleBackColor = true;
            this.checkTrue.Click += new System.EventHandler(this.checkTrue_Click);
            // 
            // textFieldQuestion
            // 
            this.textFieldQuestion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textFieldQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFieldQuestion.Location = new System.Drawing.Point(0, 44);
            this.textFieldQuestion.Multiline = true;
            this.textFieldQuestion.Name = "textFieldQuestion";
            this.textFieldQuestion.Size = new System.Drawing.Size(800, 358);
            this.textFieldQuestion.TabIndex = 2;
            this.textFieldQuestion.TextChanged += new System.EventHandler(this.textFieldQuestion_TextChanged);
            // 
            // numericQuestionNumber
            // 
            this.numericQuestionNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericQuestionNumber.Location = new System.Drawing.Point(667, 13);
            this.numericQuestionNumber.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericQuestionNumber.Name = "numericQuestionNumber";
            this.numericQuestionNumber.Size = new System.Drawing.Size(65, 20);
            this.numericQuestionNumber.TabIndex = 4;
            this.numericQuestionNumber.ValueChanged += new System.EventHandler(this.numericQuestionNumber_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.ForestGreen;
            this.panel2.Controls.Add(this.labelFileName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 18);
            this.panel2.TabIndex = 3;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFileName.Location = new System.Drawing.Point(0, 0);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(105, 16);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "No file loaded";
            // 
            // btnAbout
            // 
            this.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(86, 22);
            this.btnAbout.Text = "О программе";
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(115, 22);
            this.toolStripButton1.Text = "Свойства DateTime";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textFieldQuestion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Homework";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuestionNumber)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnEdit;
        private System.Windows.Forms.ToolStripMenuItem menuBtnNew;
        private System.Windows.Forms.ToolStripMenuItem menuBtnOpen;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menuBtnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox checkTrue;
        private System.Windows.Forms.TextBox textFieldQuestion;
        private System.Windows.Forms.NumericUpDown numericQuestionNumber;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.ToolStripButton btnAbout;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

