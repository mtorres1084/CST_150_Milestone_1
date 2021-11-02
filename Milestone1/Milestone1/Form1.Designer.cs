namespace Milestone1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.peanutButterTextBox = new System.Windows.Forms.TextBox();
            this.caramelTextBox = new System.Windows.Forms.TextBox();
            this.coffeeTextBox = new System.Windows.Forms.TextBox();
            this.cherryTextBox = new System.Windows.Forms.TextBox();
            this.chocolateTextBox = new System.Windows.Forms.TextBox();
            this.vanillaTextBox = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.addInventoryButton = new System.Windows.Forms.Button();
            this.removeInventoryButton = new System.Windows.Forms.Button();
            this.restockInventoryButton = new System.Windows.Forms.Button();
            this.searchInventoryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vanilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choclate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cherry";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 126);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Coffee";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Caramel";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Peanut Butter";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // peanutButterTextBox
            // 
            this.peanutButterTextBox.Location = new System.Drawing.Point(136, 186);
            this.peanutButterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.peanutButterTextBox.Name = "peanutButterTextBox";
            this.peanutButterTextBox.Size = new System.Drawing.Size(132, 22);
            this.peanutButterTextBox.TabIndex = 6;
            // 
            // caramelTextBox
            // 
            this.caramelTextBox.Location = new System.Drawing.Point(136, 154);
            this.caramelTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caramelTextBox.Name = "caramelTextBox";
            this.caramelTextBox.Size = new System.Drawing.Size(132, 22);
            this.caramelTextBox.TabIndex = 7;
            // 
            // coffeeTextBox
            // 
            this.coffeeTextBox.Location = new System.Drawing.Point(136, 122);
            this.coffeeTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.coffeeTextBox.Name = "coffeeTextBox";
            this.coffeeTextBox.Size = new System.Drawing.Size(132, 22);
            this.coffeeTextBox.TabIndex = 8;
            // 
            // cherryTextBox
            // 
            this.cherryTextBox.Location = new System.Drawing.Point(136, 87);
            this.cherryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cherryTextBox.Name = "cherryTextBox";
            this.cherryTextBox.Size = new System.Drawing.Size(132, 22);
            this.cherryTextBox.TabIndex = 9;
            // 
            // chocolateTextBox
            // 
            this.chocolateTextBox.Location = new System.Drawing.Point(136, 58);
            this.chocolateTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chocolateTextBox.Name = "chocolateTextBox";
            this.chocolateTextBox.Size = new System.Drawing.Size(132, 22);
            this.chocolateTextBox.TabIndex = 10;
            // 
            // vanillaTextBox
            // 
            this.vanillaTextBox.Location = new System.Drawing.Point(136, 26);
            this.vanillaTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vanillaTextBox.Name = "vanillaTextBox";
            this.vanillaTextBox.Size = new System.Drawing.Size(132, 22);
            this.vanillaTextBox.TabIndex = 11;
            // 
            // textBox7
            // 
            this.textBox7.AllowDrop = true;
            this.textBox7.Location = new System.Drawing.Point(341, 26);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox7.Size = new System.Drawing.Size(327, 184);
            this.textBox7.TabIndex = 12;
            this.textBox7.Text = "You have the following in current inventory:";
            // 
            // addInventoryButton
            // 
            this.addInventoryButton.Location = new System.Drawing.Point(16, 239);
            this.addInventoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addInventoryButton.Name = "addInventoryButton";
            this.addInventoryButton.Size = new System.Drawing.Size(125, 150);
            this.addInventoryButton.TabIndex = 13;
            this.addInventoryButton.Text = "Add to inventory";
            this.addInventoryButton.UseVisualStyleBackColor = true;
            // 
            // removeInventoryButton
            // 
            this.removeInventoryButton.Location = new System.Drawing.Point(149, 239);
            this.removeInventoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeInventoryButton.Name = "removeInventoryButton";
            this.removeInventoryButton.Size = new System.Drawing.Size(124, 150);
            this.removeInventoryButton.TabIndex = 14;
            this.removeInventoryButton.Text = "Remove from inventory";
            this.removeInventoryButton.UseVisualStyleBackColor = true;
            // 
            // restockInventoryButton
            // 
            this.restockInventoryButton.Location = new System.Drawing.Point(281, 239);
            this.restockInventoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.restockInventoryButton.Name = "restockInventoryButton";
            this.restockInventoryButton.Size = new System.Drawing.Size(124, 150);
            this.restockInventoryButton.TabIndex = 15;
            this.restockInventoryButton.Text = "Restock into inventory";
            this.restockInventoryButton.UseVisualStyleBackColor = true;
            this.restockInventoryButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // searchInventoryButton
            // 
            this.searchInventoryButton.Location = new System.Drawing.Point(413, 239);
            this.searchInventoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchInventoryButton.Name = "searchInventoryButton";
            this.searchInventoryButton.Size = new System.Drawing.Size(124, 150);
            this.searchInventoryButton.TabIndex = 16;
            this.searchInventoryButton.Text = "Search inventory";
            this.searchInventoryButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(545, 239);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(124, 150);
            this.exitButton.TabIndex = 17;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 425);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.searchInventoryButton);
            this.Controls.Add(this.restockInventoryButton);
            this.Controls.Add(this.removeInventoryButton);
            this.Controls.Add(this.addInventoryButton);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.vanillaTextBox);
            this.Controls.Add(this.chocolateTextBox);
            this.Controls.Add(this.cherryTextBox);
            this.Controls.Add(this.coffeeTextBox);
            this.Controls.Add(this.caramelTextBox);
            this.Controls.Add(this.peanutButterTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Inventory Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox peanutButterTextBox;
        private System.Windows.Forms.TextBox caramelTextBox;
        private System.Windows.Forms.TextBox coffeeTextBox;
        private System.Windows.Forms.TextBox cherryTextBox;
        private System.Windows.Forms.TextBox chocolateTextBox;
        private System.Windows.Forms.TextBox vanillaTextBox;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button addInventoryButton;
        private System.Windows.Forms.Button removeInventoryButton;
        private System.Windows.Forms.Button restockInventoryButton;
        private System.Windows.Forms.Button searchInventoryButton;
        private System.Windows.Forms.Button exitButton;
    }
}

