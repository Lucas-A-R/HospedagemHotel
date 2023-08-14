namespace HotelSheraton
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
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            NomeCliente = new Label();
            QuartosList = new Label();
            listBox1 = new ListBox();
            Premium = new CheckBox();
            Adicionar = new Button();
            comboBox2 = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(140, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(369, 27);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(836, 11);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(420, 28);
            comboBox1.TabIndex = 1;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // NomeCliente
            // 
            NomeCliente.AutoSize = true;
            NomeCliente.Location = new Point(12, 15);
            NomeCliente.Name = "NomeCliente";
            NomeCliente.Size = new Size(122, 20);
            NomeCliente.TabIndex = 2;
            NomeCliente.Text = "Nome do Cliente";
            NomeCliente.Click += label1_Click;
            // 
            // QuartosList
            // 
            QuartosList.AutoSize = true;
            QuartosList.Location = new Point(689, 15);
            QuartosList.Name = "QuartosList";
            QuartosList.Size = new Size(141, 20);
            QuartosList.TabIndex = 3;
            QuartosList.Text = "Quartos Disponiveis";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(12, 120);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(1244, 384);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Premium
            // 
            Premium.AutoSize = true;
            Premium.Location = new Point(140, 45);
            Premium.Name = "Premium";
            Premium.Size = new Size(140, 24);
            Premium.TabIndex = 5;
            Premium.Text = "Cliente Premium";
            Premium.UseVisualStyleBackColor = true;
            Premium.CheckedChanged += Premium_CheckedChanged;
            // 
            // Adicionar
            // 
            Adicionar.Location = new Point(415, 85);
            Adicionar.Name = "Adicionar";
            Adicionar.Size = new Size(94, 29);
            Adicionar.TabIndex = 6;
            Adicionar.Text = "Adicionar";
            Adicionar.UseVisualStyleBackColor = true;
            Adicionar.Click += Adicionar_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(140, 521);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(369, 28);
            comboBox2.TabIndex = 7;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 524);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 8;
            label1.Text = "Produtos";
            label1.Click += label1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1358, 607);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(Adicionar);
            Controls.Add(Premium);
            Controls.Add(listBox1);
            Controls.Add(QuartosList);
            Controls.Add(NomeCliente);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label NomeCliente;
        private Label QuartosList;
        private ListBox listBox1;
        private CheckBox Premium;
        private Button Adicionar;
        private ComboBox comboBox2;
        private Label label1;
    }
}