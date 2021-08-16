using System;
using System.Windows.Forms;
using Cison.BoxView;

namespace DemoCisonBoxView {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            LoadEvents();
        }
        private void LoadEvents() {
            this.buttonDark.Click += ButtonDark_Click;
            this.buttonLight.Click += ButtonLigh_Click;
        }
        private void ButtonLigh_Click(object sender, EventArgs e) {
            BoxViewFactory.Show(IconBox.Erro, "Erro ao cadastrar", ThemeBox.Light, BoxViewBorderStyle.Single);
            BoxViewFactory.Show(IconBox.Success, "Cadastro feito com sucesso", ThemeBox.Light, BoxViewBorderStyle.None);
        }
        private void ButtonDark_Click(object sender, EventArgs e) {
            BoxViewFactory.Show(IconBox.Erro, ThemeBox.Dark, BoxViewBorderStyle.None);
            BoxViewFactory.Show(IconBox.Success, ThemeBox.Dark, BoxViewBorderStyle.Single);
        }
    }
}
