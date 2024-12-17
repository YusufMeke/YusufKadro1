namespace WinFormsAppKadroMuhendisligi
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            comboBoxFormasyon = new ComboBox();
            listBoxMacKadrosu = new ListBox();
            buttonKadroyaEkle = new Button();
            buttonKadrodanCikar = new Button();
            buttonKadroyuTemizle = new Button();
            comboBoxKaleciler = new ComboBox();
            comboBoxDefans = new ComboBox();
            comboBoxOrtaSaha = new ComboBox();
            comboBoxForvet = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(221, 38);
            label1.Name = "label1";
            label1.Size = new Size(412, 45);
            label1.TabIndex = 0;
            label1.Text = "GALATASARAY 2024-2025";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 185);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Formasyon Seçiniz :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(579, 137);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 1;
            label3.Text = "Maç kadrosu";
            // 
            // comboBoxFormasyon
            // 
            comboBoxFormasyon.FormattingEnabled = true;
            comboBoxFormasyon.Location = new Point(150, 182);
            comboBoxFormasyon.Margin = new Padding(3, 2, 3, 2);
            comboBoxFormasyon.Name = "comboBoxFormasyon";
            comboBoxFormasyon.Size = new Size(133, 23);
            comboBoxFormasyon.TabIndex = 2;
            // 
            // listBoxMacKadrosu
            // 
            listBoxMacKadrosu.FormattingEnabled = true;
            listBoxMacKadrosu.ItemHeight = 15;
            listBoxMacKadrosu.Location = new Point(507, 177);
            listBoxMacKadrosu.Margin = new Padding(3, 2, 3, 2);
            listBoxMacKadrosu.Name = "listBoxMacKadrosu";
            listBoxMacKadrosu.Size = new Size(241, 244);
            listBoxMacKadrosu.TabIndex = 3;
            // 
            // buttonKadroyaEkle
            // 
            buttonKadroyaEkle.Location = new Point(392, 174);
            buttonKadroyaEkle.Margin = new Padding(3, 2, 3, 2);
            buttonKadroyaEkle.Name = "buttonKadroyaEkle";
            buttonKadroyaEkle.Size = new Size(89, 80);
            buttonKadroyaEkle.TabIndex = 4;
            buttonKadroyaEkle.Text = "Maç Kadrosuna Ekle";
            buttonKadroyaEkle.UseVisualStyleBackColor = true;
            buttonKadroyaEkle.Click += buttonKadroyaEkle_Click;
            // 
            // buttonKadrodanCikar
            // 
            buttonKadrodanCikar.Location = new Point(392, 258);
            buttonKadrodanCikar.Margin = new Padding(3, 2, 3, 2);
            buttonKadrodanCikar.Name = "buttonKadrodanCikar";
            buttonKadrodanCikar.Size = new Size(89, 80);
            buttonKadrodanCikar.TabIndex = 4;
            buttonKadrodanCikar.Text = "Kadrodan Çıkar";
            buttonKadrodanCikar.UseVisualStyleBackColor = true;
            buttonKadrodanCikar.Click += buttonKadrodanCikar_Click;
            // 
            // buttonKadroyuTemizle
            // 
            buttonKadroyuTemizle.Location = new Point(392, 342);
            buttonKadroyuTemizle.Margin = new Padding(3, 2, 3, 2);
            buttonKadroyuTemizle.Name = "buttonKadroyuTemizle";
            buttonKadroyuTemizle.Size = new Size(89, 80);
            buttonKadroyuTemizle.TabIndex = 4;
            buttonKadroyuTemizle.Text = "Kadroyu Temizle";
            buttonKadroyuTemizle.UseVisualStyleBackColor = true;
            buttonKadroyuTemizle.Click += buttonKadroyuTemizle_Click;
            // 
            // comboBoxKaleciler
            // 
            comboBoxKaleciler.FormattingEnabled = true;
            comboBoxKaleciler.Location = new Point(12, 288);
            comboBoxKaleciler.Margin = new Padding(3, 2, 3, 2);
            comboBoxKaleciler.Name = "comboBoxKaleciler";
            comboBoxKaleciler.Size = new Size(133, 23);
            comboBoxKaleciler.TabIndex = 2;
            // 
            // comboBoxDefans
            // 
            comboBoxDefans.FormattingEnabled = true;
            comboBoxDefans.Location = new Point(221, 288);
            comboBoxDefans.Margin = new Padding(3, 2, 3, 2);
            comboBoxDefans.Name = "comboBoxDefans";
            comboBoxDefans.Size = new Size(133, 23);
            comboBoxDefans.TabIndex = 2;
            // 
            // comboBoxOrtaSaha
            // 
            comboBoxOrtaSaha.FormattingEnabled = true;
            comboBoxOrtaSaha.Location = new Point(12, 398);
            comboBoxOrtaSaha.Margin = new Padding(3, 2, 3, 2);
            comboBoxOrtaSaha.Name = "comboBoxOrtaSaha";
            comboBoxOrtaSaha.Size = new Size(133, 23);
            comboBoxOrtaSaha.TabIndex = 2;
            // 
            // comboBoxForvet
            // 
            comboBoxForvet.FormattingEnabled = true;
            comboBoxForvet.Location = new Point(221, 399);
            comboBoxForvet.Margin = new Padding(3, 2, 3, 2);
            comboBoxForvet.Name = "comboBoxForvet";
            comboBoxForvet.Size = new Size(133, 23);
            comboBoxForvet.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 258);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 1;
            label4.Text = "Kaleciler";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(264, 258);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 1;
            label5.Text = "Defans";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(264, 364);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 1;
            label6.Text = "Forvet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(50, 364);
            label8.Name = "label8";
            label8.Size = new Size(54, 15);
            label8.TabIndex = 1;
            label8.Text = "Ortasaha";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 581);
            Controls.Add(buttonKadroyuTemizle);
            Controls.Add(buttonKadrodanCikar);
            Controls.Add(buttonKadroyaEkle);
            Controls.Add(listBoxMacKadrosu);
            Controls.Add(comboBoxForvet);
            Controls.Add(comboBoxOrtaSaha);
            Controls.Add(comboBoxDefans);
            Controls.Add(comboBoxKaleciler);
            Controls.Add(comboBoxFormasyon);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxFormasyon;
        private ListBox listBoxMacKadrosu;
        private Button buttonKadroyaEkle;
        private Button buttonKadrodanCikar;
        private Button buttonKadroyuTemizle;
        private ComboBox comboBoxKaleciler;
        private ComboBox comboBoxDefans;
        private ComboBox comboBoxOrtaSaha;
        private ComboBox comboBoxForvet;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
    }
}
