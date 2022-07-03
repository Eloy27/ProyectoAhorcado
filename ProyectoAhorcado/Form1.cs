using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace ProyectoAhorcado
{
    public partial class ventanaInicio : Form
    {
        public static String categoria = "";
        public static String nombre = "";
        public static String nombre2 = "";
        public static bool unJugador = true;

        public ventanaInicio()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            equisPB.Parent = bordesPB;
            botonPulsadoPB.Parent = bordesPB;
            minimizarPB.Parent = bordesPB;
            minimizarPulsadoPB.Parent = bordesPB;
            cargarCombo();
            this.Cursor = new Cursor("puntero.cur");
            SoundPlayer entretenida = new SoundPlayer();
            entretenida.SoundLocation = "entretenida.wav";
            entretenida.PlayLooping();
        }

        private void botonJugar_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
            botonJugar.ForeColor = Color.Black;
        }

        private void botonJugar_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            botonJugar.ForeColor = Color.White;
        }

        private void botonSalir_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
            botonSalir.ForeColor = Color.Black;
        }

        private void botonSalir_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            botonSalir.ForeColor = Color.White;
        }

        private void botonJugar_Click(object sender, EventArgs e)
        {
            if (unJugadorRB.Checked)
            {
                if (nombre == "")
                    labelError.Text = "Debe introducir un nombre para jugar";
                else
                    labelError.Text = "";

                if (categoria == "")
                    labelError2.Text = "Debe introducir una categoría para jugar";
                else
                    labelError2.Text = "";
                if (nombre != "" && categoria != "")
                {
                    ventanaJuego juego = new ventanaJuego();
                    juego.Show();
                    this.Close();
                }
            }
            if (dosJugadorRB.Checked)
            {
                if (nombre == "")
                    labelError.Text = "Debe introducir un nombre para jugar";
                else
                    labelError.Text = "";

                if (categoria == "")
                    labelError2.Text = "Debe introducir una categoría para jugar";
                else
                    labelError2.Text = "";
                if (nombre2 == "")
                    labelError3.Text = "Debe introducir un nombre para el jugador 2";
                else
                    labelError3.Text = "";
                if (nombre == "" && nombre2 == "")
                {
                    labelError.Text = "Debe introducir un nombre para jugar";
                    labelError3.Text = "Debe introducir un nombre para el jugador 2";
                }
                else if (categoria == "" && nombre2 == "")
                {
                    labelError2.Text = "Debe introducir una categoría para jugar";
                    labelError3.Text = "Debe introducir un nombre para el jugador 2";
                }
                else if (nombre == "" && categoria == "")
                {
                    labelError.Text = "Debe introducir un nombre para jugar";
                    labelError2.Text = "Debe introducir una categoría para jugar";
                }

                if (nombre != "" && categoria != "" && nombre2 != "")
                {
                    if (nombre.Equals(nombre2))
                    {
                        labelError.Text = "Nombres iguales";
                        labelError3.Text = "Nombres iguales";
                    }
                    else
                    {
                        ventanaJuego juego = new ventanaJuego();
                        juego.Show();
                        this.Close();
                    }
                }
            }
        }

        public void cargarCombo()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("categorias.xml");

            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {
                palabrasCB.Items.Add(n1.Name);
            }
        }

        private void palabrasCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            labelError2.Text = "";
            categoria = palabrasCB.Text;
        }

        private void nombreTB_TextChanged(object sender, EventArgs e)
        {
            labelError.Text = "";
            nombre = nombreTB.Text;
        }

        private void nombre2TB_TextChanged(object sender, EventArgs e)
        {
            labelError3.Text = "";
            nombre2 = nombre2TB.Text;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void dosJugadorRB_CheckedChanged(object sender, EventArgs e)
        {
            labelNombre2.Visible = true;
            nombre2TB.Visible = true;
            unJugador = false;
        }

        private void unJugadorRB_CheckedChanged(object sender, EventArgs e)
        {
            labelNombre2.Visible = false;
            nombre2TB.Visible = false;
            labelError3.Text = "";
            unJugador = true;
        }

        private void palabrasCB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonJugar_Click(sender, e);
            }
        }

        private void nombre2TB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                botonJugar_Click(sender, e);
            }
        }

        private void equisPB_MouseEnter(object sender, EventArgs e)
        {
            equisPB.Visible = false;
            botonPulsadoPB.Visible = true;
        }

        private void botonPulsadoPB_MouseLeave(object sender, EventArgs e)
        {
            equisPB.Visible = true;
            botonPulsadoPB.Visible = false;
        }

        private void botonPulsadoPB_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void minimizarPB_MouseEnter(object sender, EventArgs e)
        {
            minimizarPB.Visible = false;
            minimizarPulsadoPB.Visible = true;
        }

        private void minimizarPulsadoPB_MouseLeave(object sender, EventArgs e)
        {
            minimizarPB.Visible = true;
            minimizarPulsadoPB.Visible = false;
        }

        private void minimizarPulsadoPB_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void palabrasCB_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
        }

        private void palabrasCB_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
        }

        private void unJugadorRB_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
        }

        private void dosJugadorRB_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
        }
    }
}
