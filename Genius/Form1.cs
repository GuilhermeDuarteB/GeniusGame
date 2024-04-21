using System.Media;
using System.Threading;


namespace Genius
{
    public partial class Form1 : Form
    {
        List<string> sequenciaCores= new List<string>();
        List<string> sequenciaPlayer = new List<string>();
        int listaIndex, pontos;
        const float brilho = 0.7f;
        string atualCor;
        string[] cores = { "R", "G", "B", "Y" };
        bool podeJogar;
        Random rdn = new Random();
        SoundPlayer[] audios = { new SoundPlayer(Properties.Resources.beep_01) ,
            new SoundPlayer(Properties.Resources.beep_02), new SoundPlayer (Properties.Resources
           .beep_03),new SoundPlayer(Properties.Resources.beep_04) };


        public Form1()
        {
            InitializeComponent();
        }
        private void MostrarCor(PictureBox pic, Color corClara, Color corEscura, SoundPlayer som)
        {
            pic.BackColor = corClara; som.Play(); Application.DoEvents(); Thread.Sleep(900); pic.BackColor = corEscura;
        }
        private void ProcurarCor(string tagPic)
        {
            foreach (var corEncontrada in Controls.OfType<PictureBox>()){
                if (corEncontrada.Tag.ToString() == tagPic)
                {
                    string tag = corEncontrada.Tag.ToString();
                    Color piscar = ControlPaint.Light(corEncontrada.BackColor, brilho);
                    SoundPlayer som = tag == "R" ? audios[0] : (tag == "G" ? audios[1] : 
                        (tag == "B" ? audios[2] : audios[3]));
                    MostrarCor(corEncontrada, piscar, corEncontrada.BackColor, som);
                }
            }
        }
        private void SortearCor()
        {
            atualCor = cores[rdn.Next(0, cores.Length)];
            sequenciaCores.Add(atualCor);
           
            foreach (var cor in sequenciaCores)
            {
                Application.DoEvents(); Thread.Sleep(300);
                ProcurarCor(cor);
            }
            podeJogar = true;
        }

        private void Clique (object sender, EventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            if (podeJogar)
            {
                podeJogar = false;
                atualCor = pb.Tag.ToString();
                sequenciaPlayer.Add(atualCor);
                ProcurarCor(atualCor);

                if (sequenciaPlayer[listaIndex] == sequenciaCores[listaIndex]) {

                    pontos++; TxtPontos.Text = "Pontos:" + pontos.ToString(); listaIndex++; Check();
                } else
                {
                    MessageBox.Show("Sequência Incorreta! Perdeste!");
                }
            }

        }

        private void Check()
        {
            if (listaIndex == sequenciaCores.Count) {
            
            listaIndex= 0; sequenciaPlayer.Clear(); SortearCor();
            } else
            {
                podeJogar = true;
            }
        }
        private void Menu (object sender, EventArgs e)
        {
            ToolStripMenuItem menu = (ToolStripMenuItem)sender;

            switch (menu.Text)
            {
                case "Iniciar": pontos = 0; TxtPontos.Text = "Pontos"; sequenciaPlayer.Clear();
                    sequenciaCores.Clear(); podeJogar = false; listaIndex= 0; SortearCor();
                    break ;
                case "Sobre": string info = "Nome do Jogo: Genius \n Desenvolvedor: Guilherme Branco";
                    MessageBox.Show(info); break ;
                case "Sair": Application.Exit(); break ;
            }
        }
    }
}