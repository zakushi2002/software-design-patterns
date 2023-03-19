namespace FactoryMethod
{
    partial class FormDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDemo));
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRandomCreate = new System.Windows.Forms.Button();
            this.pictureBoxCreate = new System.Windows.Forms.PictureBox();
            this.pictureBoxCreateRadom = new System.Windows.Forms.PictureBox();
            this.comboBoxSelect = new System.Windows.Forms.ComboBox();
            this.labelCreate = new System.Windows.Forms.Label();
            this.labelRandom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreateRadom)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.buttonCreate, "buttonCreate");
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRandomCreate
            // 
            resources.ApplyResources(this.buttonRandomCreate, "buttonRandomCreate");
            this.buttonRandomCreate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRandomCreate.Name = "buttonRandomCreate";
            this.buttonRandomCreate.UseVisualStyleBackColor = true;
            this.buttonRandomCreate.Click += new System.EventHandler(this.buttonRandomCreate_Click);
            // 
            // pictureBoxCreate
            // 
            resources.ApplyResources(this.pictureBoxCreate, "pictureBoxCreate");
            this.pictureBoxCreate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCreate.Name = "pictureBoxCreate";
            this.pictureBoxCreate.TabStop = false;
            // 
            // pictureBoxCreateRadom
            // 
            resources.ApplyResources(this.pictureBoxCreateRadom, "pictureBoxCreateRadom");
            this.pictureBoxCreateRadom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCreateRadom.Name = "pictureBoxCreateRadom";
            this.pictureBoxCreateRadom.TabStop = false;
            // 
            // comboBoxSelect
            // 
            this.comboBoxSelect.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("comboBoxSelect.AutoCompleteCustomSource"),
            resources.GetString("comboBoxSelect.AutoCompleteCustomSource1"),
            resources.GetString("comboBoxSelect.AutoCompleteCustomSource2")});
            resources.ApplyResources(this.comboBoxSelect, "comboBoxSelect");
            this.comboBoxSelect.FormattingEnabled = true;
            this.comboBoxSelect.Items.AddRange(new object[] {
            resources.GetString("comboBoxSelect.Items"),
            resources.GetString("comboBoxSelect.Items1"),
            resources.GetString("comboBoxSelect.Items2")});
            this.comboBoxSelect.Name = "comboBoxSelect";
            // 
            // labelCreate
            // 
            resources.ApplyResources(this.labelCreate, "labelCreate");
            this.labelCreate.Name = "labelCreate";
            // 
            // labelRandom
            // 
            resources.ApplyResources(this.labelRandom, "labelRandom");
            this.labelRandom.Name = "labelRandom";
            // 
            // FormDemo
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelRandom);
            this.Controls.Add(this.labelCreate);
            this.Controls.Add(this.comboBoxSelect);
            this.Controls.Add(this.pictureBoxCreateRadom);
            this.Controls.Add(this.pictureBoxCreate);
            this.Controls.Add(this.buttonRandomCreate);
            this.Controls.Add(this.buttonCreate);
            this.Name = "FormDemo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCreateRadom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonRandomCreate;
        private System.Windows.Forms.PictureBox pictureBoxCreate;
        private System.Windows.Forms.PictureBox pictureBoxCreateRadom;
        private System.Windows.Forms.ComboBox comboBoxSelect;
        private System.Windows.Forms.Label labelCreate;
        private System.Windows.Forms.Label labelRandom;
    }
}

