namespace ScienceAcademy.UI
{
    partial class frmMain
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
            dgvMembers = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnGetById = new Button();
            label1 = new Label();
            label2 = new Label();
            dgvAwards = new DataGridView();
            label3 = new Label();
            dgvUniversities = new DataGridView();
            cmbEntitySelect = new ComboBox();
            label4 = new Label();
            dgvResult = new DataGridView();
            txtId = new TextBox();
            txtDeleteId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAwards).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUniversities).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            SuspendLayout();
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(26, 57);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.RowHeadersWidth = 51;
            dgvMembers.Size = new Size(394, 565);
            dgvMembers.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(378, 641);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(478, 641);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(722, 642);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetById
            // 
            btnGetById.Location = new Point(970, 642);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(94, 29);
            btnGetById.TabIndex = 4;
            btnGetById.Text = "Get By Id";
            btnGetById.UseVisualStyleBackColor = true;
            btnGetById.Click += btnGetById_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(186, 34);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 5;
            label1.Text = "Members";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(629, 34);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 7;
            label2.Text = "Awards";
            // 
            // dgvAwards
            // 
            dgvAwards.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAwards.Location = new Point(469, 57);
            dgvAwards.Name = "dgvAwards";
            dgvAwards.RowHeadersWidth = 51;
            dgvAwards.Size = new Size(394, 565);
            dgvAwards.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1070, 34);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 9;
            label3.Text = "Universities";
            // 
            // dgvUniversities
            // 
            dgvUniversities.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUniversities.Location = new Point(910, 57);
            dgvUniversities.Name = "dgvUniversities";
            dgvUniversities.RowHeadersWidth = 51;
            dgvUniversities.Size = new Size(394, 392);
            dgvUniversities.TabIndex = 8;
            // 
            // cmbEntitySelect
            // 
            cmbEntitySelect.FormattingEnabled = true;
            cmbEntitySelect.Location = new Point(221, 642);
            cmbEntitySelect.Name = "cmbEntitySelect";
            cmbEntitySelect.Size = new Size(151, 28);
            cmbEntitySelect.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1084, 466);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 11;
            label4.Text = "Result";
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new Point(910, 498);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.Size = new Size(394, 124);
            dgvResult.TabIndex = 12;
            // 
            // txtId
            // 
            txtId.Location = new Point(839, 644);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 13;
            // 
            // txtDeleteId
            // 
            txtDeleteId.Location = new Point(591, 644);
            txtDeleteId.Name = "txtDeleteId";
            txtDeleteId.Size = new Size(125, 27);
            txtDeleteId.TabIndex = 14;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1332, 691);
            Controls.Add(txtDeleteId);
            Controls.Add(txtId);
            Controls.Add(dgvResult);
            Controls.Add(label4);
            Controls.Add(cmbEntitySelect);
            Controls.Add(label3);
            Controls.Add(dgvUniversities);
            Controls.Add(label2);
            Controls.Add(dgvAwards);
            Controls.Add(label1);
            Controls.Add(btnGetById);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvMembers);
            Name = "frmMain";
            Text = "Form1";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAwards).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUniversities).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMembers;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnGetById;
        private Label label1;
        private Label label2;
        private DataGridView dgvAwards;
        private Label label3;
        private DataGridView dgvUniversities;
        private ComboBox cmbEntitySelect;
        private Label label4;
        private DataGridView dgvResult;
        private TextBox txtId;
        private TextBox txtDeleteId;
    }
}
