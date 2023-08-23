namespace Loja_de_Eletronicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.LightSteelBlue;
            button1.Location = new Point(81, 148);
            button1.Name = "button1";
            button1.Size = new Size(131, 72);
            button1.TabIndex = 0;
            button1.Text = "CADASTRAR \r\nPRODUTO";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.LightSteelBlue;
            button2.Location = new Point(251, 148);
            button2.Name = "button2";
            button2.Size = new Size(131, 72);
            button2.TabIndex = 1;
            button2.Text = "EXCLUIR \r\nPRODUTO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.LightSteelBlue;
            button3.Location = new Point(81, 272);
            button3.Name = "button3";
            button3.Size = new Size(131, 73);
            button3.TabIndex = 2;
            button3.Text = "VISUALIZAR\r\nESTOQUE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackgroundImage = (Image)resources.GetObject("button4.BackgroundImage");
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.LightSteelBlue;
            button4.Location = new Point(251, 272);
            button4.Name = "button4";
            button4.Size = new Size(131, 73);
            button4.TabIndex = 3;
            button4.Text = "REALIZAR\r\nVENDA";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Elephant", 15.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(81, 88);
            label1.Name = "label1";
            label1.Size = new Size(301, 41);
            label1.TabIndex = 4;
            label1.Text = "Loja de Etrônicos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Elephant", 9.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(187, 62);
            label2.Name = "label2";
            label2.Size = new Size(86, 26);
            label2.TabIndex = 5;
            label2.Text = "MENU";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(466, 497);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Menu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
    }
}