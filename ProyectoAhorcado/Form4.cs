using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;

namespace ProyectoAhorcado
{

    public partial class ventanaDatos : Form
    {
        protected List<Jugador> listaJugadores = new List<Jugador>();
        private OleDbConnection miConexion; // Declaración de la conexión con la BD
        private OleDbCommand Comando; // Declaración del comando con sentencias SQL
        private OleDbDataReader Lector; // Declaración del lector de datos  
        public ventanaDatos()
        {
            InitializeComponent();
            equisPB.Parent = bordesPB;
            botonPulsadoPB.Parent = bordesPB;
            minimizarPB.Parent = bordesPB;
            minimizarPulsadoPB.Parent = bordesPB;
            this.Cursor = new Cursor("puntero.cur");
            SoundPlayer entretenida = new SoundPlayer();
            entretenida.SoundLocation = "entretenida.wav";
            entretenida.PlayLooping();
        }

        private void ventanaDatos_Load(object sender, System.EventArgs e)
        {
            // Declaración de la cadena de conexión
            string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";

            miConexion = new OleDbConnection(strCadenaConexion); // Crear la conexión con la BD
            string Consulta = "SELECT * FROM estadisticasAhorcado"; // Declaración de la consulta
            Comando = new OleDbCommand(Consulta, miConexion); // Declaración del comando de consulta en la conexión con la BD
            miConexion.Open(); // Abrir la BD
            Lector = Comando.ExecuteReader(); // Ejecutar el comando lector de datos
            while (Lector.Read())
            {
                tablaDatos.Rows.Add(Lector.GetString(1), Lector.GetInt32(2), Lector.GetInt32(3), Lector.GetInt32(4));
                Jugador jugador = new Jugador(Lector.GetString(1), Lector.GetInt32(2), Lector.GetInt32(3), Lector.GetInt32(4));
                listaJugadores.Add(jugador);
            }
            Lector.Close(); // Cerrar el lector de datos
            Lector = null;
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
            labelMenu_Click(sender, e);
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

        private void labelMenu_Click(object sender, EventArgs e)
        {
            ventanaJuego.rondas = 0;
            ventanaJuego.puntos = 0;
            ventanaJuego.puntos1 = 0;
            ventanaJuego.puntos2 = 0;
            ventanaJuego.palabrasAcertadas = 0;
            ventanaJuego.palabrasAcertadas1 = 0;
            ventanaJuego.palabrasAcertadas2 = 0;
            ventanaJuego.ronda = 1;
            ventanaJuego.cambio = false;
            ventanaJuego.fallos = 0;
            ventanaJuego.y = 0;
            this.Close();
            ventanaInicio vi = new ventanaInicio();
            ventanaInicio.categoria = "";
            ventanaInicio.nombre = "";
            ventanaInicio.nombre2 = "";
            vi.Show();

        }

        private void labelMenu_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
            labelMenu.ForeColor = Color.Black;
        }

        private void labelMenu_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            labelMenu.ForeColor = Color.White;
        }

        private void buscarTB_TextChanged(object sender, EventArgs e)
        {
            if (buscarTB.Text.ToString().Equals(""))
            {
                tablaDatos.Rows.Clear();
                listaJugadores.Clear();
                ventanaDatos_Load(sender, e);
            }
            else
            {
                tablaDatos.Rows.Clear();
                // Declaración de la cadena de conexión
                string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";

                miConexion = new OleDbConnection(strCadenaConexion); // Crear la conexión con la BD
                string Consulta = "SELECT * FROM estadisticasAhorcado WHERE nombre LIKE '" + buscarTB.Text.ToString() + "%'"; // Declaración de la consulta
                Comando = new OleDbCommand(Consulta, miConexion); // Declaración del comando de consulta en la conexión con la BD
                miConexion.Open(); // Abrir la BD
                Lector = Comando.ExecuteReader(); // Ejecutar el comando lector de datos
                while (Lector.Read())
                {
                    tablaDatos.Rows.Add(Lector.GetString(1), Lector.GetInt32(2), Lector.GetInt32(3), Lector.GetInt32(4));
                }
                Lector.Close(); // Cerrar el lector de datos
                Lector = null;
            }
        }
    }

    public class Jugador
    {
        protected String nombre;
        int puntos, pAcertadas, ronda;

        public Jugador(String nombre, int puntos, int pAcertadas, int ronda)
        {
            this.nombre = nombre;
            this.puntos = puntos;
            this.pAcertadas = pAcertadas;
            this.ronda = ronda;
        }

        public String getNombre()
        {
            return this.nombre;
        }

        public int getPuntos()
        {
            return this.puntos;
        }

        public int getpAcertadas()
        {
            return this.pAcertadas;
        }

        public int getRonda()
        {
            return this.ronda;
        }

        public void setNombre(String nombre)
        {
            this.nombre = nombre;
        }

        public void setPuntos(int puntos)
        {
            this.puntos = puntos;
        }

        public void setpAcertadas(int pAcertadas)
        {
            this.pAcertadas = pAcertadas;
        }

        public void setRonda(int ronda)
        {
            this.ronda = ronda;
        }
    }
}
