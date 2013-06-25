using System.Drawing;
using System.Windows.Forms;

namespace Peulot_Heshbon.Code
{
    public partial class ChooseFont : Form
    {
        public ChooseFont()
        {
            InitializeComponent();

            comboBox1.Items.AddRange(Files.PreferrenceFile.fonts);
            foreach (int i in Files.PreferrenceFile.sizes)
                comboBox2.Items.Add(i.ToString());
            comboBox1.SelectedIndex = Files.PreferrenceFile.font;
            comboBox2.SelectedIndex = Files.PreferrenceFile.font_size;

            this.RightToLeft = Languages.ChosenLanguage.dir;
            this.Icon = new Icon(Properties.Resources.App_Icon, new Size(32, 32));
            this.RightToLeftLayout = Languages.ChosenLanguage.dirLayout;
            this.Font = Code.Files.PreferrenceFile.GetReadyFont;
            Text = Languages.ChosenLanguage.form_ChangeFont["title"];
            lb_font.Text = Languages.ChosenLanguage.form_ChangeFont["lb_font"];
            lb_text.Text = Languages.ChosenLanguage.form_ChangeFont["lb_text"];
            lb_size.Text = Languages.ChosenLanguage.form_ChangeFont["lb_size"];
            bt_ok.Text = Languages.ChosenLanguage.Default["send"];

            bt_ok.Click += delegate
            {
                Files.PreferrenceFile.font = comboBox1.SelectedIndex;
                Files.PreferrenceFile.font_size = comboBox2.SelectedIndex;
                Code.Files.PreferrenceFile.Update();
                this.Close();
            };
        }
    }
}