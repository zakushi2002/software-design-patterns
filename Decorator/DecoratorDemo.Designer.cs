namespace Decorator
{
    partial class DecoratorDemo
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
            this.checkBoxShrimp = new System.Windows.Forms.CheckBox();
            this.checkBoxSquid = new System.Windows.Forms.CheckBox();
            this.checkBoxTomato = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanelDecorator = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxMurshroom = new System.Windows.Forms.CheckBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTitlePresentation = new System.Windows.Forms.Label();
            this.pictureBoxIngredient = new System.Windows.Forms.PictureBox();
            this.pictureBoxPizza = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelDecorator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngredient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxShrimp
            // 
            this.checkBoxShrimp.AutoSize = true;
            this.checkBoxShrimp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxShrimp.Location = new System.Drawing.Point(3, 3);
            this.checkBoxShrimp.Name = "checkBoxShrimp";
            this.checkBoxShrimp.Size = new System.Drawing.Size(230, 27);
            this.checkBoxShrimp.TabIndex = 3;
            this.checkBoxShrimp.Text = "Shrimp - 20000 vnd";
            this.checkBoxShrimp.UseVisualStyleBackColor = true;
            this.checkBoxShrimp.CheckStateChanged += new System.EventHandler(this.checkBoxShrimp_CheckStateChanged);
            // 
            // checkBoxSquid
            // 
            this.checkBoxSquid.AutoSize = true;
            this.checkBoxSquid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxSquid.Location = new System.Drawing.Point(3, 36);
            this.checkBoxSquid.Name = "checkBoxSquid";
            this.checkBoxSquid.Size = new System.Drawing.Size(219, 27);
            this.checkBoxSquid.TabIndex = 6;
            this.checkBoxSquid.Text = "Squid - 20000 vnd";
            this.checkBoxSquid.UseVisualStyleBackColor = true;
            this.checkBoxSquid.CheckStateChanged += new System.EventHandler(this.checkBoxSquid_CheckStateChanged);
            // 
            // checkBoxTomato
            // 
            this.checkBoxTomato.AutoSize = true;
            this.checkBoxTomato.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxTomato.Location = new System.Drawing.Point(3, 69);
            this.checkBoxTomato.Name = "checkBoxTomato";
            this.checkBoxTomato.Size = new System.Drawing.Size(219, 27);
            this.checkBoxTomato.TabIndex = 8;
            this.checkBoxTomato.Text = "Tomato - 5000 vnd";
            this.checkBoxTomato.UseVisualStyleBackColor = true;
            this.checkBoxTomato.CheckStateChanged += new System.EventHandler(this.checkBoxTomato_CheckStateChanged);
            // 
            // flowLayoutPanelDecorator
            // 
            this.flowLayoutPanelDecorator.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelDecorator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanelDecorator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanelDecorator.Controls.Add(this.checkBoxShrimp);
            this.flowLayoutPanelDecorator.Controls.Add(this.checkBoxSquid);
            this.flowLayoutPanelDecorator.Controls.Add(this.checkBoxTomato);
            this.flowLayoutPanelDecorator.Controls.Add(this.checkBoxMurshroom);
            this.flowLayoutPanelDecorator.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelDecorator.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanelDecorator.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanelDecorator.Location = new System.Drawing.Point(115, 390);
            this.flowLayoutPanelDecorator.Name = "flowLayoutPanelDecorator";
            this.flowLayoutPanelDecorator.Size = new System.Drawing.Size(300, 138);
            this.flowLayoutPanelDecorator.TabIndex = 10;
            // 
            // checkBoxMurshroom
            // 
            this.checkBoxMurshroom.AutoSize = true;
            this.checkBoxMurshroom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkBoxMurshroom.Location = new System.Drawing.Point(3, 102);
            this.checkBoxMurshroom.Name = "checkBoxMurshroom";
            this.checkBoxMurshroom.Size = new System.Drawing.Size(263, 27);
            this.checkBoxMurshroom.TabIndex = 9;
            this.checkBoxMurshroom.Text = "Murshroom - 10000 vnd";
            this.checkBoxMurshroom.UseVisualStyleBackColor = true;
            this.checkBoxMurshroom.CheckStateChanged += new System.EventHandler(this.checkBoxMurshroom_CheckStateChanged);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCreate.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(115, 534);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(628, 52);
            this.buttonCreate.TabIndex = 12;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.BackColor = System.Drawing.Color.White;
            this.labelPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPrice.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Red;
            this.labelPrice.Location = new System.Drawing.Point(440, 390);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(300, 29);
            this.labelPrice.TabIndex = 19;
            this.labelPrice.Text = "Price: 49000 vnd";
            // 
            // labelTitlePresentation
            // 
            this.labelTitlePresentation.BackColor = System.Drawing.Color.White;
            this.labelTitlePresentation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTitlePresentation.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitlePresentation.ForeColor = System.Drawing.Color.Black;
            this.labelTitlePresentation.Location = new System.Drawing.Point(115, 25);
            this.labelTitlePresentation.Name = "labelTitlePresentation";
            this.labelTitlePresentation.Size = new System.Drawing.Size(625, 55);
            this.labelTitlePresentation.TabIndex = 20;
            this.labelTitlePresentation.Text = "GROUP 07 - DEMO DECORATOR";
            this.labelTitlePresentation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxIngredient
            // 
            this.pictureBoxIngredient.BackColor = System.Drawing.Color.White;
            this.pictureBoxIngredient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxIngredient.Image = global::Decorator.Properties.Resources.question;
            this.pictureBoxIngredient.InitialImage = global::Decorator.Properties.Resources.question;
            this.pictureBoxIngredient.Location = new System.Drawing.Point(115, 83);
            this.pictureBoxIngredient.Name = "pictureBoxIngredient";
            this.pictureBoxIngredient.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxIngredient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIngredient.TabIndex = 13;
            this.pictureBoxIngredient.TabStop = false;
            this.pictureBoxIngredient.WaitOnLoad = true;
            // 
            // pictureBoxPizza
            // 
            this.pictureBoxPizza.BackColor = System.Drawing.Color.White;
            this.pictureBoxPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPizza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPizza.Image = global::Decorator.Properties.Resources.pizza;
            this.pictureBoxPizza.InitialImage = null;
            this.pictureBoxPizza.Location = new System.Drawing.Point(440, 83);
            this.pictureBoxPizza.Name = "pictureBoxPizza";
            this.pictureBoxPizza.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPizza.TabIndex = 11;
            this.pictureBoxPizza.TabStop = false;
            // 
            // DecoratorDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(892, 602);
            this.Controls.Add(this.labelTitlePresentation);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.pictureBoxIngredient);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.flowLayoutPanelDecorator);
            this.Controls.Add(this.pictureBoxPizza);
            this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DecoratorDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Decorator Demo";
            this.flowLayoutPanelDecorator.ResumeLayout(false);
            this.flowLayoutPanelDecorator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIngredient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBoxShrimp;
        private System.Windows.Forms.CheckBox checkBoxSquid;
        private System.Windows.Forms.CheckBox checkBoxTomato;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDecorator;
        private System.Windows.Forms.CheckBox checkBoxMurshroom;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.PictureBox pictureBoxIngredient;
        private System.Windows.Forms.PictureBox pictureBoxPizza;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTitlePresentation;
    }
}

