namespace InterfacePassagem
{
    partial class Form2
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
            button1 = new Button();
            label1 = new Label();
            Filtro = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(45, 87);
            button1.Name = "button1";
            button1.Size = new Size(174, 30);
            button1.TabIndex = 0;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 31);
            label1.Name = "label1";
            label1.Size = new Size(194, 20);
            label1.TabIndex = 1;
            label1.Text = "Digite Nome ou CPF Cliente";
            // 
            // Filtro
            // 
            Filtro.BackColor = Color.DarkGray;
            Filtro.Location = new Point(45, 54);
            Filtro.Name = "Filtro";
            Filtro.Size = new Size(174, 27);
            Filtro.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 140);
            Controls.Add(Filtro);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Excluir";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox Filtro;
    }
}