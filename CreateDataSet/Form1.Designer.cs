namespace CreateDataSet
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
            Janus.Windows.GridEX.GridEXLayout grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grid = new Janus.Windows.GridEX.GridEX();
            this.btnCreate = new Janus.Windows.EditControls.UIButton();
            this.btnClear = new Janus.Windows.EditControls.UIButton();
            this.txtReturn = new System.Windows.Forms.RichTextBox();
            this.txtAddNewAndValue = new System.Windows.Forms.RichTextBox();
            this.btnName = new Janus.Windows.EditControls.UIButton();
            this.btnValue = new Janus.Windows.EditControls.UIButton();
            this.btnInsert = new Janus.Windows.EditControls.UIButton();
            this.btnUpdate = new Janus.Windows.EditControls.UIButton();
            this.txtStore = new System.Windows.Forms.RichTextBox();
            this.txtParamName = new System.Windows.Forms.RichTextBox();
            this.txtParamValue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetDataByCondition = new Janus.Windows.EditControls.UIButton();
            this.btnSaveData2 = new Janus.Windows.EditControls.UIButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            grid_DesignTimeLayout.LayoutString = resources.GetString("grid_DesignTimeLayout.LayoutString");
            this.grid.DesignTimeLayout = grid_DesignTimeLayout;
            this.grid.Dock = System.Windows.Forms.DockStyle.Top;
            this.grid.KeepRowSettings = true;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.NewRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grid.Size = new System.Drawing.Size(1251, 181);
            this.grid.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreate.Location = new System.Drawing.Point(1083, 482);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Tao";
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(1164, 483);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            // 
            // txtReturn
            // 
            this.txtReturn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtReturn.Location = new System.Drawing.Point(0, 542);
            this.txtReturn.Name = "txtReturn";
            this.txtReturn.Size = new System.Drawing.Size(1251, 207);
            this.txtReturn.TabIndex = 3;
            this.txtReturn.Text = "";
            // 
            // txtAddNewAndValue
            // 
            this.txtAddNewAndValue.Location = new System.Drawing.Point(0, 188);
            this.txtAddNewAndValue.Name = "txtAddNewAndValue";
            this.txtAddNewAndValue.Size = new System.Drawing.Size(394, 181);
            this.txtAddNewAndValue.TabIndex = 4;
            this.txtAddNewAndValue.Text = "";
            // 
            // btnName
            // 
            this.btnName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnName.Location = new System.Drawing.Point(933, 482);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(65, 23);
            this.btnName.TabIndex = 5;
            this.btnName.Text = "Add name";
            // 
            // btnValue
            // 
            this.btnValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValue.Location = new System.Drawing.Point(1005, 482);
            this.btnValue.Name = "btnValue";
            this.btnValue.Size = new System.Drawing.Size(72, 23);
            this.btnValue.TabIndex = 6;
            this.btnValue.Text = "Add value";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.Location = new System.Drawing.Point(1083, 511);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(1164, 512);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            // 
            // txtStore
            // 
            this.txtStore.Location = new System.Drawing.Point(483, 218);
            this.txtStore.Name = "txtStore";
            this.txtStore.Size = new System.Drawing.Size(604, 45);
            this.txtStore.TabIndex = 9;
            this.txtStore.Text = "";
            // 
            // txtParamName
            // 
            this.txtParamName.Location = new System.Drawing.Point(483, 269);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(604, 79);
            this.txtParamName.TabIndex = 10;
            this.txtParamName.Text = "";
            // 
            // txtParamValue
            // 
            this.txtParamValue.Location = new System.Drawing.Point(483, 354);
            this.txtParamValue.Name = "txtParamValue";
            this.txtParamValue.Size = new System.Drawing.Size(604, 79);
            this.txtParamValue.TabIndex = 11;
            this.txtParamValue.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 231);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "store";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "paramname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "paramvalue";
            // 
            // btnGetDataByCondition
            // 
            this.btnGetDataByCondition.Location = new System.Drawing.Point(1137, 227);
            this.btnGetDataByCondition.Name = "btnGetDataByCondition";
            this.btnGetDataByCondition.Size = new System.Drawing.Size(102, 45);
            this.btnGetDataByCondition.TabIndex = 15;
            this.btnGetDataByCondition.Text = "Create GetdataByCondition";
            // 
            // btnSaveData2
            // 
            this.btnSaveData2.Location = new System.Drawing.Point(1137, 279);
            this.btnSaveData2.Name = "btnSaveData2";
            this.btnSaveData2.Size = new System.Drawing.Size(102, 45);
            this.btnSaveData2.TabIndex = 16;
            this.btnSaveData2.Text = "SaveData2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "class";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(483, 187);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(604, 25);
            this.txtClass.TabIndex = 17;
            this.txtClass.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 749);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.btnSaveData2);
            this.Controls.Add(this.btnGetDataByCondition);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtParamValue);
            this.Controls.Add(this.txtParamName);
            this.Controls.Add(this.txtStore);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnValue);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.txtAddNewAndValue);
            this.Controls.Add(this.txtReturn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.GridEX.GridEX grid;
        private Janus.Windows.EditControls.UIButton btnCreate;
        private Janus.Windows.EditControls.UIButton btnClear;
        private System.Windows.Forms.RichTextBox txtReturn;
        private System.Windows.Forms.RichTextBox txtAddNewAndValue;
        private Janus.Windows.EditControls.UIButton btnName;
        private Janus.Windows.EditControls.UIButton btnValue;
        private Janus.Windows.EditControls.UIButton btnInsert;
        private Janus.Windows.EditControls.UIButton btnUpdate;
        private System.Windows.Forms.RichTextBox txtStore;
        private System.Windows.Forms.RichTextBox txtParamName;
        private System.Windows.Forms.RichTextBox txtParamValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIButton btnGetDataByCondition;
        private Janus.Windows.EditControls.UIButton btnSaveData2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtClass;
    }
}

