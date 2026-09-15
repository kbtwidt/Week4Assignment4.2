namespace Week4Assignment4._2
{
    partial class TeacherForm
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
            StudentDataGrid = new DataGridView();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExport = new Button();
            lblName = new Label();
            lblSID = new Label();
            lblGPA = new Label();
            txtSID = new TextBox();
            txtName = new TextBox();
            txtGPA = new TextBox();
            btnAddSubmit = new Button();
            btnDeleteSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)StudentDataGrid).BeginInit();
            SuspendLayout();
            // 
            // StudentDataGrid
            // 
            StudentDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDataGrid.Location = new Point(652, 12);
            StudentDataGrid.Margin = new Padding(4, 3, 4, 3);
            StudentDataGrid.Name = "StudentDataGrid";
            StudentDataGrid.RowHeadersWidth = 62;
            StudentDataGrid.Size = new Size(580, 376);
            StudentDataGrid.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(38, 24);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(280, 33);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Student";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(342, 24);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 33);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(188, 72);
            btnExport.Margin = new Padding(4, 3, 4, 3);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(280, 33);
            btnExport.TabIndex = 3;
            btnExport.Text = "Top of Class";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Lucida Fax", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(122, 216);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(110, 34);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // lblSID
            // 
            lblSID.AutoSize = true;
            lblSID.Font = new Font("Lucida Fax", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSID.Location = new Point(48, 168);
            lblSID.Margin = new Padding(4, 0, 4, 0);
            lblSID.Name = "lblSID";
            lblSID.Size = new Size(184, 34);
            lblSID.TabIndex = 5;
            lblSID.Text = "Student ID:";
            // 
            // lblGPA
            // 
            lblGPA.AutoSize = true;
            lblGPA.Font = new Font("Lucida Fax", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGPA.Location = new Point(150, 264);
            lblGPA.Margin = new Padding(4, 0, 4, 0);
            lblGPA.Name = "lblGPA";
            lblGPA.Size = new Size(84, 34);
            lblGPA.TabIndex = 6;
            lblGPA.Text = "GPA:";
            // 
            // txtSID
            // 
            txtSID.Location = new Point(239, 168);
            txtSID.Name = "txtSID";
            txtSID.Size = new Size(314, 31);
            txtSID.TabIndex = 7;
            txtSID.Validating += txtSID_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(239, 216);
            txtName.Name = "txtName";
            txtName.Size = new Size(314, 31);
            txtName.TabIndex = 8;
            // 
            // txtGPA
            // 
            txtGPA.Location = new Point(239, 264);
            txtGPA.Name = "txtGPA";
            txtGPA.Size = new Size(314, 31);
            txtGPA.TabIndex = 9;
            // 
            // btnAddSubmit
            // 
            btnAddSubmit.Location = new Point(239, 301);
            btnAddSubmit.Name = "btnAddSubmit";
            btnAddSubmit.Size = new Size(112, 34);
            btnAddSubmit.TabIndex = 10;
            btnAddSubmit.Text = "Add";
            btnAddSubmit.UseVisualStyleBackColor = true;
            btnAddSubmit.Click += btnAddSubmit_Click;
            // 
            // btnDeleteSubmit
            // 
            btnDeleteSubmit.Location = new Point(441, 301);
            btnDeleteSubmit.Name = "btnDeleteSubmit";
            btnDeleteSubmit.Size = new Size(112, 34);
            btnDeleteSubmit.TabIndex = 11;
            btnDeleteSubmit.Text = "Delete";
            btnDeleteSubmit.UseVisualStyleBackColor = true;
            btnDeleteSubmit.Click += btnDeleteSubmit_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(13F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1245, 416);
            Controls.Add(btnDeleteSubmit);
            Controls.Add(btnAddSubmit);
            Controls.Add(txtGPA);
            Controls.Add(txtName);
            Controls.Add(txtSID);
            Controls.Add(lblGPA);
            Controls.Add(lblSID);
            Controls.Add(lblName);
            Controls.Add(btnExport);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(StudentDataGrid);
            Font = new Font("Lucida Fax", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "TeacherForm";
            Text = "Teacher Form";
            Load += TeacherForm_Load;
            ((System.ComponentModel.ISupportInitialize)StudentDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView StudentDataGrid;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExport;
        private Label lblName;
        private Label lblSID;
        private Label lblGPA;
        private TextBox txtSID;
        private TextBox txtName;
        private TextBox txtGPA;
        private Button btnAddSubmit;
        private Button btnDeleteSubmit;
    }
}