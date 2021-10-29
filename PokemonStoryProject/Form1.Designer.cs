namespace PokemonStoryProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.option1Label = new System.Windows.Forms.Label();
            this.option2Label = new System.Windows.Forms.Label();
            this.option3Label = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.imageBox = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // option1Label
            // 
            this.option1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option1Label.ForeColor = System.Drawing.Color.Cyan;
            this.option1Label.Location = new System.Drawing.Point(131, 492);
            this.option1Label.Name = "option1Label";
            this.option1Label.Size = new System.Drawing.Size(537, 42);
            this.option1Label.TabIndex = 0;
            this.option1Label.Text = "option1Label";
            // 
            // option2Label
            // 
            this.option2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option2Label.ForeColor = System.Drawing.Color.LawnGreen;
            this.option2Label.Location = new System.Drawing.Point(131, 557);
            this.option2Label.Name = "option2Label";
            this.option2Label.Size = new System.Drawing.Size(537, 42);
            this.option2Label.TabIndex = 1;
            this.option2Label.Text = "option2Label";
            // 
            // option3Label
            // 
            this.option3Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.option3Label.ForeColor = System.Drawing.Color.Red;
            this.option3Label.Location = new System.Drawing.Point(131, 628);
            this.option3Label.Name = "option3Label";
            this.option3Label.Size = new System.Drawing.Size(537, 42);
            this.option3Label.TabIndex = 2;
            this.option3Label.Text = "option3Label";
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Orange;
            this.outputLabel.Location = new System.Drawing.Point(27, 22);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(722, 68);
            this.outputLabel.TabIndex = 7;
            this.outputLabel.Text = "outputLabel";
            // 
            // imageBox
            // 
            this.imageBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageBox.Image = global::PokemonStoryProject.Properties.Resources.Starter_Selection2;
            this.imageBox.Location = new System.Drawing.Point(32, 92);
            this.imageBox.Name = "imageBox";
            this.imageBox.Size = new System.Drawing.Size(716, 375);
            this.imageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox.TabIndex = 8;
            this.imageBox.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::PokemonStoryProject.Properties.Resources.Button_Image;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(32, 617);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 57);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::PokemonStoryProject.Properties.Resources.Button_Image;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(32, 550);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 57);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = global::PokemonStoryProject.Properties.Resources.Button_Image;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(32, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 61);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(778, 686);
            this.Controls.Add(this.imageBox);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.option3Label);
            this.Controls.Add(this.option2Label);
            this.Controls.Add(this.option1Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pokemon Journey";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label option1Label;
        private System.Windows.Forms.Label option2Label;
        private System.Windows.Forms.Label option3Label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.PictureBox imageBox;
    }
}

