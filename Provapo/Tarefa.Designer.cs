namespace Provapo
{
    partial class Tarefa
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tx_computador = new TextBox();
            tx_cliente = new TextBox();
            button1 = new Button();
            button2 = new Button();
            box_servico = new ComboBox();
            lb_diferentes = new Label();
            box_pagamento = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 105);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 0;
            label1.Text = "Computador";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(273, 142);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(273, 190);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Serviço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 232);
            label4.Name = "label4";
            label4.Size = new Size(110, 15);
            label4.TabIndex = 3;
            label4.Text = "Tipo de pagamento";
            // 
            // tx_computador
            // 
            tx_computador.Location = new Point(392, 103);
            tx_computador.Name = "tx_computador";
            tx_computador.Size = new Size(102, 23);
            tx_computador.TabIndex = 4;
            // 
            // tx_cliente
            // 
            tx_cliente.Location = new Point(394, 147);
            tx_cliente.Name = "tx_cliente";
            tx_cliente.Size = new Size(100, 23);
            tx_cliente.TabIndex = 5;
            tx_cliente.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(290, 312);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(418, 312);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // box_servico
            // 
            box_servico.FormattingEnabled = true;
            box_servico.Items.AddRange(new object[] { "Formatação", "Limpeza", "Troca de peças" });
            box_servico.Location = new Point(392, 190);
            box_servico.Name = "box_servico";
            box_servico.Size = new Size(102, 23);
            box_servico.TabIndex = 10;
            box_servico.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // lb_diferentes
            // 
            lb_diferentes.AutoSize = true;
            lb_diferentes.Location = new Point(310, 280);
            lb_diferentes.Name = "lb_diferentes";
            lb_diferentes.Size = new Size(59, 15);
            lb_diferentes.TabIndex = 11;
            lb_diferentes.Text = "Valor final";
            lb_diferentes.Click += label5_Click;
            // 
            // box_pagamento
            // 
            box_pagamento.FormattingEnabled = true;
            box_pagamento.Items.AddRange(new object[] { "Dinheiro", "Pix", "Cartao" });
            box_pagamento.Location = new Point(391, 232);
            box_pagamento.Name = "box_pagamento";
            box_pagamento.Size = new Size(102, 23);
            box_pagamento.TabIndex = 12;
            // 
            // Tarefa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(box_pagamento);
            Controls.Add(lb_diferentes);
            Controls.Add(box_servico);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tx_cliente);
            Controls.Add(tx_computador);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tarefa";
            Text = "Tarefa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tx_computador;
        private TextBox tx_cliente;
        private TextBox tx_servico;
        private Button button1;
        private Button button2;
        private ComboBox box_servico;
        private Label lb_diferentes;
        private ComboBox box_pagamento;
    }
}