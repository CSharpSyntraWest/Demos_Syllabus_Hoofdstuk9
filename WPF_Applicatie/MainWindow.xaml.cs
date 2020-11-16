using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Applicatie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            foreach (Bankrekening b in _bank)
                BankrekeningenComboBox.Items.Add(b.IbanNummer);
            ToonUittreksels();
        }

        private Bankrekening[] _bank = { new Bankrekening() { IbanNummer = "BE123456789" },
                                         new Bankrekening() { IbanNummer = "NL23456789012" },
                                         new Bankrekening() { IbanNummer = "LU3456789012345" } };

        private void ToonUittreksels()
        {
            UittrekselsListBox.Items.Clear();
            foreach (Bankrekening b in _bank) UittrekselsListBox.Items.Add(b.Uittreksel());
        }

        private void VoerUitButton_Click(object sender, RoutedEventArgs e)
        {
            if (UittrekselsListBox.SelectedIndex != -1)
            {
                Bankrekening b = _bank[UittrekselsListBox.SelectedIndex];
                decimal bedrag = decimal.Parse(BedragTextBox.Text);
                if (StortRadioButton.IsChecked == true) b.Stort(bedrag);
                else if (HaalAfRadioButton.IsChecked == true) b.HaalAf(bedrag);
                else if (BankrekeningenComboBox.SelectedIndex != -1)
                {
                    Bankrekening doel = _bank[BankrekeningenComboBox.SelectedIndex];
                    b.SchrijfOver(bedrag, doel);
                }
                ToonUittreksels();
            }
        }
    }
}


