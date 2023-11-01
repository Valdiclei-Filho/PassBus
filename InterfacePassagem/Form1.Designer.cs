namespace InterfacePassagem
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
            nome_Cliente = new TextBox();
            idade_Cliente = new TextBox();
            cpf_Cliente = new TextBox();
            Confirmar = new Button();
            label1 = new Label();
            horario_Chegada = new TextBox();
            horario_Partida = new TextBox();
            Destino = new TextBox();
            Valor = new TextBox();
            forma_Pagamento = new TextBox();
            Poltrona = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            Excluir = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // nome_Cliente
            // 
            nome_Cliente.Location = new Point(80, 56);
            nome_Cliente.Name = "nome_Cliente";
            nome_Cliente.Size = new Size(125, 27);
            nome_Cliente.TabIndex = 0;
            nome_Cliente.TextChanged += textBox1_TextChanged;
            // 
            // idade_Cliente
            // 
            idade_Cliente.Location = new Point(80, 89);
            idade_Cliente.Name = "idade_Cliente";
            idade_Cliente.Size = new Size(125, 27);
            idade_Cliente.TabIndex = 1;
            // 
            // cpf_Cliente
            // 
            cpf_Cliente.Location = new Point(80, 122);
            cpf_Cliente.Name = "cpf_Cliente";
            cpf_Cliente.Size = new Size(125, 27);
            cpf_Cliente.TabIndex = 2;
            // 
            // Confirmar
            // 
            Confirmar.Location = new Point(24, 172);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(693, 29);
            Confirmar.TabIndex = 3;
            Confirmar.Text = "Confirmar";
            Confirmar.UseVisualStyleBackColor = true;
            Confirmar.Click += Confirmar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(117, 33);
            label1.Name = "label1";
            label1.Size = new Size(55, 20);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            label1.Click += label1_Click;
            // 
            // horario_Chegada
            // 
            horario_Chegada.Location = new Point(365, 125);
            horario_Chegada.Name = "horario_Chegada";
            horario_Chegada.Size = new Size(125, 27);
            horario_Chegada.TabIndex = 7;
            // 
            // horario_Partida
            // 
            horario_Partida.Location = new Point(365, 92);
            horario_Partida.Name = "horario_Partida";
            horario_Partida.Size = new Size(125, 27);
            horario_Partida.TabIndex = 6;
            // 
            // Destino
            // 
            Destino.BackColor = SystemColors.Window;
            Destino.Location = new Point(365, 59);
            Destino.Name = "Destino";
            Destino.Size = new Size(125, 27);
            Destino.TabIndex = 5;
            // 
            // Valor
            // 
            Valor.Location = new Point(592, 125);
            Valor.Name = "Valor";
            Valor.Size = new Size(125, 27);
            Valor.TabIndex = 10;
            // 
            // forma_Pagamento
            // 
            forma_Pagamento.Location = new Point(592, 92);
            forma_Pagamento.Name = "forma_Pagamento";
            forma_Pagamento.Size = new Size(125, 27);
            forma_Pagamento.TabIndex = 9;
            // 
            // Poltrona
            // 
            Poltrona.Location = new Point(592, 59);
            Poltrona.Name = "Poltrona";
            Poltrona.Size = new Size(125, 27);
            Poltrona.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 59);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 11;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 92);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 12;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 125);
            label4.Name = "label4";
            label4.Size = new Size(33, 20);
            label4.TabIndex = 13;
            label4.Text = "CPF";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(497, 20);
            label5.Name = "label5";
            label5.Size = new Size(74, 20);
            label5.TabIndex = 14;
            label5.Text = "Passagem";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(299, 66);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 15;
            label6.Text = "Destino";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 95);
            label7.Name = "label7";
            label7.Size = new Size(110, 20);
            label7.TabIndex = 16;
            label7.Text = "Horario Partida";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(236, 125);
            label8.Name = "label8";
            label8.Size = new Size(123, 20);
            label8.TabIndex = 17;
            label8.Text = "Horario Chegada";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(536, 125);
            label9.Name = "label9";
            label9.Size = new Size(43, 20);
            label9.TabIndex = 20;
            label9.Text = "Valor";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(502, 92);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 19;
            label10.Text = "Pagamento";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(522, 63);
            label11.Name = "label11";
            label11.Size = new Size(64, 20);
            label11.TabIndex = 18;
            label11.Text = "Poltrona";
            // 
            // Excluir
            // 
            Excluir.Location = new Point(24, 207);
            Excluir.Name = "Excluir";
            Excluir.Size = new Size(693, 29);
            Excluir.TabIndex = 21;
            Excluir.Text = "Excluir";
            Excluir.UseVisualStyleBackColor = true;
            Excluir.Click += Excluir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(24, 242);
            button1.Name = "button1";
            button1.Size = new Size(693, 29);
            button1.TabIndex = 22;
            button1.Text = "Alterar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(24, 277);
            button2.Name = "button2";
            button2.Size = new Size(693, 29);
            button2.TabIndex = 23;
            button2.Text = "Apresentar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 333);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Excluir);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Valor);
            Controls.Add(forma_Pagamento);
            Controls.Add(Poltrona);
            Controls.Add(horario_Chegada);
            Controls.Add(horario_Partida);
            Controls.Add(Destino);
            Controls.Add(label1);
            Controls.Add(Confirmar);
            Controls.Add(cpf_Cliente);
            Controls.Add(idade_Cliente);
            Controls.Add(nome_Cliente);
            Name = "Form1";
            Text = "Inserir Passagem";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nome_Cliente;
        private TextBox idade_Cliente;
        private TextBox cpf_Cliente;
        private Button Confirmar;
        private Label label1;
        private TextBox horario_Chegada;
        private TextBox horario_Partida;
        private TextBox Destino;
        private TextBox Valor;
        private TextBox forma_Pagamento;
        private TextBox Poltrona;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button Excluir;
        private Button button1;
        private Button button2;
    }
}