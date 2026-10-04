namespace cassaEordini
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
            comboBoxProd = new ComboBox();
            listBoxArticoli = new ListBox();
            label1 = new Label();
            labelPrezzo = new Label();
            selezioneQ = new NumericUpDown();
            label2 = new Label();
            buttonAggiungi = new Button();
            buttonRimuovi = new Button();
            label3 = new Label();
            labelTot = new Label();
            buttonEmetti = new Button();
            ((System.ComponentModel.ISupportInitialize)selezioneQ).BeginInit();
            SuspendLayout();
            // 
            // comboBoxProd
            // 
            comboBoxProd.FormattingEnabled = true;
            comboBoxProd.Items.AddRange(new object[] { "Caffè Espresso", "Cornetto Crema", "Succo Frutta" });
            comboBoxProd.Location = new Point(93, 58);
            comboBoxProd.Name = "comboBoxProd";
            comboBoxProd.Size = new Size(159, 28);
            comboBoxProd.TabIndex = 0;
            comboBoxProd.Text = "Seleziona prodotti";
            comboBoxProd.SelectedIndexChanged += comboBoxProd_SelectedIndexChanged_1;
            // 
            // listBoxArticoli
            // 
            listBoxArticoli.FormattingEnabled = true;
            listBoxArticoli.Location = new Point(413, 58);
            listBoxArticoli.Name = "listBoxArticoli";
            listBoxArticoli.Size = new Size(303, 264);
            listBoxArticoli.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 148);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 2;
            label1.Text = "Prezzo: ";
            // 
            // labelPrezzo
            // 
            labelPrezzo.AutoSize = true;
            labelPrezzo.Location = new Point(123, 146);
            labelPrezzo.Name = "labelPrezzo";
            labelPrezzo.Size = new Size(0, 20);
            labelPrezzo.TabIndex = 3;
            // 
            // selezioneQ
            // 
            selezioneQ.Location = new Point(252, 146);
            selezioneQ.Name = "selezioneQ";
            selezioneQ.Size = new Size(45, 27);
            selezioneQ.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(177, 148);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Quantità:";
            // 
            // buttonAggiungi
            // 
            buttonAggiungi.Location = new Point(103, 234);
            buttonAggiungi.Name = "buttonAggiungi";
            buttonAggiungi.Size = new Size(140, 73);
            buttonAggiungi.TabIndex = 6;
            buttonAggiungi.Text = "Aggungi voce +";
            buttonAggiungi.UseVisualStyleBackColor = true;
            buttonAggiungi.Click += buttonAggiungi_Click;
            // 
            // buttonRimuovi
            // 
            buttonRimuovi.Location = new Point(122, 328);
            buttonRimuovi.Name = "buttonRimuovi";
            buttonRimuovi.Size = new Size(94, 29);
            buttonRimuovi.TabIndex = 7;
            buttonRimuovi.Text = "Rimuovi selezionato -";
            buttonRimuovi.UseVisualStyleBackColor = true;
            buttonRimuovi.Click += buttonRimuovi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 376);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 8;
            label3.Text = "Totale:";
            // 
            // labelTot
            // 
            labelTot.AutoSize = true;
            labelTot.Location = new Point(472, 376);
            labelTot.Name = "labelTot";
            labelTot.Size = new Size(0, 20);
            labelTot.TabIndex = 9;
            // 
            // buttonEmetti
            // 
            buttonEmetti.Location = new Point(576, 358);
            buttonEmetti.Name = "buttonEmetti";
            buttonEmetti.Size = new Size(140, 56);
            buttonEmetti.TabIndex = 10;
            buttonEmetti.Text = "Emetti Scontrino";
            buttonEmetti.UseVisualStyleBackColor = true;
            buttonEmetti.Click += buttonEmetti_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonEmetti);
            Controls.Add(labelTot);
            Controls.Add(label3);
            Controls.Add(buttonRimuovi);
            Controls.Add(buttonAggiungi);
            Controls.Add(label2);
            Controls.Add(selezioneQ);
            Controls.Add(labelPrezzo);
            Controls.Add(label1);
            Controls.Add(listBoxArticoli);
            Controls.Add(comboBoxProd);
            Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)selezioneQ).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxProd;
        private ListBox listBoxArticoli;
        private Label label1;
        private Label labelPrezzo;
        private NumericUpDown selezioneQ;
        private Label label2;
        private Button buttonAggiungi;
        private Button buttonRimuovi;
        private Label label3;
        private Label labelTot;
        private Button buttonEmetti;
    }
}
