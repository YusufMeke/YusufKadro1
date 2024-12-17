namespace WinFormsAppKadroMuhendisligi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Geni� kadro tan�m�
            List<string> kaleciler = new List<string> { "Fernando Muslera", "Okan Kocuk" };
            List<string> defans = new List<string> { "Victor Nelsson", "Abd�lkerim Bardakc�", "Sacha Boey", "Angelino", "Kaan Ayhan" };
            List<string> ortasaha = new List<string> { "Lucas Torreira", "Sergio Oliveira", "Kerem Akt�rko�lu", "Dries Mertens", "Bar�� Alper Y�lmaz", "Fredrik Midtsj�" };
            List<string> forvet = new List<string> { "Mauro Icardi", "Cedric Bakambu", "Halil Dervi�o�lu", "Yunus Akg�n" };

            // Formasyon listesi
            List<string> formasyonlar = new List<string> { "4-4-2", "4-3-3", "3-5-2", "4-2-3-1" };

            // ComboBox'lara oyuncular� ekleme
            comboBoxKaleciler.Items.AddRange(kaleciler.ToArray());
            comboBoxDefans.Items.AddRange(defans.ToArray());
            comboBoxOrtaSaha.Items.AddRange(ortasaha.ToArray());
            comboBoxForvet.Items.AddRange(forvet.ToArray());

            // Formasyon ComboBox'�na formasyonlar� ekleme
            comboBoxFormasyon.Items.AddRange(formasyonlar.ToArray());

            comboBoxFormasyon.SelectedIndexChanged += ComboBoxFormasyon_SelectedIndexChanged;
        }

        private void buttonKadroyaEkle_Click(object sender, EventArgs e)
        {
            if (listBoxMacKadrosu.Items.Count < 11)
            {
                if (comboBoxKaleciler.SelectedItem != null)
                {
                    listBoxMacKadrosu.Items.Add($"Kaleci: {comboBoxKaleciler.SelectedItem}");
                    comboBoxKaleciler.Items.Remove(comboBoxKaleciler.SelectedItem);
                }
                else if (comboBoxDefans.SelectedItem != null)
                {
                    listBoxMacKadrosu.Items.Add($"Defans: {comboBoxDefans.SelectedItem}");
                    comboBoxDefans.Items.Remove(comboBoxDefans.SelectedItem);
                }
                else if (comboBoxOrtaSaha.SelectedItem != null)
                {
                    listBoxMacKadrosu.Items.Add($"Orta Saha: {comboBoxOrtaSaha.SelectedItem}");
                    comboBoxOrtaSaha.Items.Remove(comboBoxOrtaSaha.SelectedItem);
                }
                else if (comboBoxForvet.SelectedItem != null)
                {
                    listBoxMacKadrosu.Items.Add($"Forvet: {comboBoxForvet.SelectedItem}");
                    comboBoxForvet.Items.Remove(comboBoxForvet.SelectedItem);
                }
                else
                {
                    MessageBox.Show("L�tfen bir oyuncu se�in!");
                }
            }
            else
            {
                MessageBox.Show("Ma� kadrosunda maksimum 11 oyuncu olabilir!");
            }
        }

        private void buttonKadrodanCikar_Click(object sender, EventArgs e)
        {
            if (listBoxMacKadrosu.SelectedIndex != -1)
            {
                listBoxMacKadrosu.Items.RemoveAt(listBoxMacKadrosu.SelectedIndex);
            }
            else
            {
                MessageBox.Show("L�tfen ��kar�lacak bir oyuncu se�in!");
            }
        }

        private void buttonKadroyuTemizle_Click(object sender, EventArgs e)
        {
            listBoxMacKadrosu.Items.Clear();
        }

        private void ComboBoxFormasyon_SelectedIndexChanged(object sender, EventArgs e)
        {
            string secilenFormasyon = comboBoxFormasyon.SelectedItem.ToString();
            MessageBox.Show($"Se�ilen Formasyon: {secilenFormasyon}");
        }
    }
}
