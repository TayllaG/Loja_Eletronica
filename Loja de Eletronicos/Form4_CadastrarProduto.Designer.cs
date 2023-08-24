namespace Loja_de_Eletronicos
{
    partial class Form4_CadastrarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4_CadastrarProduto));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_qtd = new TextBox();
            txt_nome = new TextBox();
            txt_id = new TextBox();
            txt_df = new MaskedTextBox();
            txt_valor = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightSteelBlue;
            label1.Location = new Point(126, 56);
            label1.Name = "label1";
            label1.Size = new Size(219, 24);
            label1.TabIndex = 0;
            label1.Text = "cadastrar produto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LightSteelBlue;
            label2.Location = new Point(64, 165);
            label2.Name = "label2";
            label2.Size = new Size(35, 21);
            label2.TabIndex = 1;
            label2.Text = "id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.LightSteelBlue;
            label3.Location = new Point(64, 112);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 2;
            label3.Text = "nome:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.LightSteelBlue;
            label4.Location = new Point(64, 264);
            label4.Name = "label4";
            label4.Size = new Size(72, 21);
            label4.TabIndex = 3;
            label4.Text = "valor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.LightSteelBlue;
            label5.Location = new Point(64, 212);
            label5.Name = "label5";
            label5.Size = new Size(202, 21);
            label5.TabIndex = 4;
            label5.Text = "data de fabricação:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.LightSteelBlue;
            label6.Location = new Point(201, 165);
            label6.Name = "label6";
            label6.Size = new Size(115, 21);
            label6.TabIndex = 5;
            label6.Text = "quatidade:";
            // 
            // txt_qtd
            // 
            txt_qtd.BackColor = SystemColors.InactiveCaption;
            txt_qtd.BorderStyle = BorderStyle.FixedSingle;
            txt_qtd.Location = new Point(314, 158);
            txt_qtd.Name = "txt_qtd";
            txt_qtd.Size = new Size(81, 31);
            txt_qtd.TabIndex = 6;
            // 
            // txt_nome
            // 
            txt_nome.BackColor = SystemColors.InactiveCaption;
            txt_nome.BorderStyle = BorderStyle.FixedSingle;
            txt_nome.Location = new Point(126, 105);
            txt_nome.Name = "txt_nome";
            txt_nome.Size = new Size(269, 31);
            txt_nome.TabIndex = 7;
            txt_nome.TextChanged += textBox2_TextChanged;
            // 
            // txt_id
            // 
            txt_id.BackColor = SystemColors.InactiveCaption;
            txt_id.BorderStyle = BorderStyle.FixedSingle;
            txt_id.Location = new Point(98, 158);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(97, 31);
            txt_id.TabIndex = 8;
            // 
            // txt_df
            // 
            txt_df.BackColor = SystemColors.InactiveCaption;
            txt_df.BorderStyle = BorderStyle.FixedSingle;
            txt_df.Location = new Point(272, 205);
            txt_df.Mask = "00/00/0000";
            txt_df.Name = "txt_df";
            txt_df.Size = new Size(123, 31);
            txt_df.TabIndex = 9;
            txt_df.ValidatingType = typeof(DateTime);
            // 
            // txt_valor
            // 
            txt_valor.BackColor = SystemColors.InactiveCaption;
            txt_valor.BorderStyle = BorderStyle.FixedSingle;
            txt_valor.Location = new Point(139, 257);
            txt_valor.Name = "txt_valor";
            txt_valor.Size = new Size(256, 31);
            txt_valor.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(98, 322);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 11;
            button1.Text = "salvar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(272, 322);
            button2.Name = "button2";
            button2.Size = new Size(112, 57);
            button2.TabIndex = 12;
            button2.Text = "voltar \r\nmenu";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Salmon;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(98, 362);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "cancelar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // Form4_CadastrarProduto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(463, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txt_valor);
            Controls.Add(txt_df);
            Controls.Add(txt_id);
            Controls.Add(txt_nome);
            Controls.Add(txt_qtd);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form4_CadastrarProduto";
            Text = "Form4_CadastrarProduto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_qtd;
        private TextBox txt_nome;
        private TextBox txt_id;
        private MaskedTextBox txt_df;
        private TextBox txt_valor;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}