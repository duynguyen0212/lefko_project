
namespace lefko
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lefkoDataSet4 = new lefko.lefkoDataSet4();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new lefko.Database1DataSet();
            this.textMatrix = new System.Windows.Forms.TextBox();
            this.textPoids = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Excel = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.textEmp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tableTableAdapter = new lefko.Database1DataSetTableAdapters.TableTableAdapter();
            this.lefkoDataSet = new lefko.lefkoDataSet();
            this.table2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_2TableAdapter = new lefko.lefkoDataSetTableAdapters.Table_2TableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.lefkoDataSet2 = new lefko.lefkoDataSet2();
            this.table3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table_3TableAdapter = new lefko.lefkoDataSet2TableAdapters.Table_3TableAdapter();
            this.lefkoDataSet3 = new lefko.lefkoDataSet3();
            this.table3BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.table_3TableAdapter1 = new lefko.lefkoDataSet3TableAdapters.Table_3TableAdapter();
            this.tableTableAdapter1 = new lefko.lefkoDataSet4TableAdapters.TableTableAdapter();
            this.textLabel = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 34;
            this.dataGridView1.Location = new System.Drawing.Point(211, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(909, 646);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.lefkoDataSet4;
            // 
            // lefkoDataSet4
            // 
            this.lefkoDataSet4.DataSetName = "lefkoDataSet4";
            this.lefkoDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textMatrix
            // 
            this.textMatrix.Location = new System.Drawing.Point(12, 37);
            this.textMatrix.Name = "textMatrix";
            this.textMatrix.Size = new System.Drawing.Size(180, 20);
            this.textMatrix.TabIndex = 2;
            this.textMatrix.TextChanged += new System.EventHandler(this.textMatrix_TextChanged);
            this.textMatrix.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textMatrix_KeyDown);
            // 
            // textPoids
            // 
            this.textPoids.Location = new System.Drawing.Point(12, 255);
            this.textPoids.Name = "textPoids";
            this.textPoids.Size = new System.Drawing.Size(180, 20);
            this.textPoids.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datamatrix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Poids de pièce";
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Add.Location = new System.Drawing.Point(12, 304);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(180, 40);
            this.Add.TabIndex = 12;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Excel
            // 
            this.Excel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Excel.Location = new System.Drawing.Point(12, 370);
            this.Excel.Name = "Excel";
            this.Excel.Size = new System.Drawing.Size(180, 40);
            this.Excel.TabIndex = 13;
            this.Excel.Text = "Extract to Excel";
            this.Excel.UseVisualStyleBackColor = true;
            this.Excel.Click += new System.EventHandler(this.Excel_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.Location = new System.Drawing.Point(12, 595);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(180, 40);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // textEmp
            // 
            this.textEmp.Location = new System.Drawing.Point(12, 185);
            this.textEmp.Name = "textEmp";
            this.textEmp.Size = new System.Drawing.Size(180, 20);
            this.textEmp.TabIndex = 4;
            this.textEmp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textEmp_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Emplacement";
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // lefkoDataSet
            // 
            this.lefkoDataSet.DataSetName = "lefkoDataSet";
            this.lefkoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table2BindingSource
            // 
            this.table2BindingSource.DataMember = "Table_2";
            this.table2BindingSource.DataSource = this.lefkoDataSet;
            // 
            // table_2TableAdapter
            // 
            this.table_2TableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "Update to database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lefkoDataSet2
            // 
            this.lefkoDataSet2.DataSetName = "lefkoDataSet2";
            this.lefkoDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table3BindingSource
            // 
            this.table3BindingSource.DataMember = "Table_3";
            this.table3BindingSource.DataSource = this.lefkoDataSet2;
            // 
            // table_3TableAdapter
            // 
            this.table_3TableAdapter.ClearBeforeFill = true;
            // 
            // lefkoDataSet3
            // 
            this.lefkoDataSet3.DataSetName = "lefkoDataSet3";
            this.lefkoDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table3BindingSource1
            // 
            this.table3BindingSource1.DataMember = "Table_3";
            this.table3BindingSource1.DataSource = this.lefkoDataSet3;
            // 
            // table_3TableAdapter1
            // 
            this.table_3TableAdapter1.ClearBeforeFill = true;
            // 
            // tableTableAdapter1
            // 
            this.tableTableAdapter1.ClearBeforeFill = true;
            // 
            // textLabel
            // 
            this.textLabel.Location = new System.Drawing.Point(12, 109);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(180, 20);
            this.textLabel.TabIndex = 16;
            this.textLabel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textLabel_KeyDown);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(12, 82);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(74, 13);
            this.label.TabIndex = 17;
            this.label.Text = "Label de boite";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1123, 670);
            this.Controls.Add(this.label);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Excel);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textPoids);
            this.Controls.Add(this.textEmp);
            this.Controls.Add(this.textMatrix);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lefkoDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table3BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textMatrix;
        private System.Windows.Forms.TextBox textPoids;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Excel;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox textEmp;
        private System.Windows.Forms.Label label3;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private Database1DataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private lefkoDataSet lefkoDataSet;
        private System.Windows.Forms.BindingSource table2BindingSource;
        private lefkoDataSetTableAdapters.Table_2TableAdapter table_2TableAdapter;
        private System.Windows.Forms.Button button1;
        private lefkoDataSet2 lefkoDataSet2;
        private System.Windows.Forms.BindingSource table3BindingSource;
        private lefkoDataSet2TableAdapters.Table_3TableAdapter table_3TableAdapter;
        private lefkoDataSet3 lefkoDataSet3;
        private System.Windows.Forms.BindingSource table3BindingSource1;
        private lefkoDataSet3TableAdapters.Table_3TableAdapter table_3TableAdapter1;
        private lefkoDataSet4 lefkoDataSet4;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private lefkoDataSet4TableAdapters.TableTableAdapter tableTableAdapter1;
        private System.Windows.Forms.TextBox textLabel;
        private System.Windows.Forms.Label label;
    }
}

