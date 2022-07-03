using System;
using System.Data.OleDb;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace ProyectoAhorcado
{
    public partial class ventanaEstadisticas : Form
    {
        OleDbConnection miConexion = null;
        Boolean existe = false, existe2 = false;
        public ventanaEstadisticas()
        {
            InitializeComponent();
            insertarDatos();
            existe = false;
            existe2 = false;
            equisPB.Parent = bordesPB;
            botonPulsadoPB.Parent = bordesPB;
            minimizarPB.Parent = bordesPB;
            minimizarPulsadoPB.Parent = bordesPB;
            this.Cursor = new Cursor("puntero.cur");


            if (!ventanaInicio.unJugador)
            {
                labelJugador.Visible = false;
                labellabelJugador.Visible = true;
                labelPuntos.Text = "Puntos: " + ventanaJuego.puntos1 + "        Puntos: " + ventanaJuego.puntos2;
                labelAcertadas.Text = "Palabras acertadas: " + ventanaJuego.palabrasAcertadas1 + "        Palabras acertadas: " + ventanaJuego.palabrasAcertadas2;
                labelJugador2.Visible = true;
                labelRonda.Text += ventanaJuego.ronda + "        Ronda: " + ventanaJuego.ronda;
                labellabelJugador.Text = ventanaInicio.nombre;
                labelJugador2.Text = ventanaInicio.nombre2;

                if (ventanaJuego.palabrasAcertadas1 > 0 || ventanaJuego.palabrasAcertadas2 > 0)
                {
                    SoundPlayer ganador = new SoundPlayer();
                    ganador.SoundLocation = "ganador.wav";
                    ganador.Play();
                }
                else
                {
                    SoundPlayer perdedor = new SoundPlayer();
                    perdedor.SoundLocation = "perdedor.wav";
                    perdedor.Play();
                }
            }
            else
            {
                labelJugador.Text += ventanaInicio.nombre;
                labelPuntos.Text += ventanaJuego.puntos;
                labelAcertadas.Text += ventanaJuego.palabrasAcertadas;
                labelRonda.Text += ventanaJuego.ronda;
                if (ventanaJuego.palabrasAcertadas > 0)
                {
                    SoundPlayer ganador = new SoundPlayer();
                    ganador.SoundLocation = "ganador.wav";
                    ganador.Play();
                }
                else
                {
                    SoundPlayer perdedor = new SoundPlayer();
                    perdedor.SoundLocation = "perdedor.wav";
                    perdedor.Play();
                }
            }
        }

        private void labelVolver_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
            labelVolver.ForeColor = Color.Black;
        }

        private void labelVolver_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            labelVolver.ForeColor = Color.White;
        }

        public void insertarDatos()
        {
            comprobarExiste();
            if (ventanaInicio.unJugador)
            {
                if (existe)
                {
                    string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = estadísticasAhorcado.accdb";
                    miConexion = new OleDbConnection(strCadenaConexion);
                    miConexion.Open();
                    string strActualizar = "UPDATE estadisticasAhorcado SET puntos = '" + ventanaJuego.puntos + "', pAcertadas = '" + ventanaJuego.palabrasAcertadas + "', ronda = '" + ventanaJuego.ronda + "' WHERE nombre LIKE '" + ventanaInicio.nombre + "'";
                    OleDbCommand miComando = new OleDbCommand(strActualizar, miConexion);
                    miComando.ExecuteNonQuery();
                }
                else
                {
                    string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";
                    miConexion = new OleDbConnection(strCadenaConexion);
                    miConexion.Open();
                    string strInsertar = "INSERT INTO estadisticasAhorcado (nombre, puntos, pAcertadas, ronda) VALUES ('" + ventanaInicio.nombre + "', '" + ventanaJuego.puntos + "', '" + ventanaJuego.palabrasAcertadas + "', '" + ventanaJuego.ronda + "')";
                    OleDbCommand miComando = new OleDbCommand(strInsertar, miConexion);
                    miComando.ExecuteNonQuery();
                }
            }
            else
            {
                if (existe && existe2)
                {
                    string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";
                    miConexion = new OleDbConnection(strCadenaConexion);
                    miConexion.Open();
                    string strActualizar = "UPDATE estadisticasAhorcado SET puntos = '" + ventanaJuego.puntos1 + "', pAcertadas = '" + ventanaJuego.palabrasAcertadas1 + "', ronda = '" + ventanaJuego.ronda + "' WHERE nombre LIKE '" + ventanaInicio.nombre + "'";
                    string strActualizar2 = "UPDATE estadisticasAhorcado SET puntos = '" + ventanaJuego.puntos2 + "', pAcertadas = '" + ventanaJuego.palabrasAcertadas2 + "', ronda = '" + ventanaJuego.ronda + "' WHERE nombre LIKE '" + ventanaInicio.nombre2 + "'";
                    OleDbCommand miComando = new OleDbCommand(strActualizar, miConexion);
                    miComando.ExecuteNonQuery();
                    miComando = new OleDbCommand(strActualizar2, miConexion);
                    miComando.ExecuteNonQuery();
                }
                else if (existe && !existe2)
                {
                    string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source = estadísticasAhorcado.accdb";
                    miConexion = new OleDbConnection(strCadenaConexion);
                    miConexion.Open();
                    string strActualizar = "UPDATE estadisticasAhorcado SET puntos = '" + ventanaJuego.puntos1 + "', pAcertadas = '" + ventanaJuego.palabrasAcertadas1 + "', ronda = '" + ventanaJuego.ronda + "' WHERE nombre LIKE '" + ventanaInicio.nombre + "'";
                    string strInsertar2 = "INSERT INTO estadisticasAhorcado (nombre, puntos, pAcertadas, ronda) VALUES ('" + ventanaInicio.nombre2 + "', '" + ventanaJuego.puntos2 + "', '" + ventanaJuego.palabrasAcertadas2 + "', '" + ventanaJuego.ronda + "')";
                    OleDbCommand miComando = new OleDbCommand(strActualizar, miConexion);
                    miComando.ExecuteNonQuery();
                    miComando = new OleDbCommand(strInsertar2, miConexion);
                    miComando.ExecuteNonQuery();
                }
                else if (!existe && existe2)
                {
                    string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";
                    miConexion = new OleDbConnection(strCadenaConexion);
                    miConexion.Open();
                    string strInsertar = "INSERT INTO estadisticasAhorcado (nombre, puntos, pAcertadas, ronda) VALUES ('" + ventanaInicio.nombre + "', '" + ventanaJuego.puntos1 + "', '" + ventanaJuego.palabrasAcertadas1 + "', '" + ventanaJuego.ronda + "')";
                    string strActualizar2 = "UPDATE estadisticasAhorcado SET puntos = '" + ventanaJuego.puntos2 + "', pAcertadas = '" + ventanaJuego.palabrasAcertadas2 + "', ronda = '" + ventanaJuego.ronda + "' WHERE nombre LIKE '" + ventanaInicio.nombre2 + "'";
                    OleDbCommand miComando = new OleDbCommand(strActualizar2, miConexion);
                    miComando.ExecuteNonQuery();
                    miComando = new OleDbCommand(strInsertar, miConexion);
                    miComando.ExecuteNonQuery();
                }
                else if (!existe && !existe2)
                {
                    string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";
                    miConexion = new OleDbConnection(strCadenaConexion);
                    miConexion.Open();
                    string strInsertar = "INSERT INTO estadisticasAhorcado (nombre, puntos, pAcertadas, ronda) VALUES ('" + ventanaInicio.nombre + "', '" + ventanaJuego.puntos1 + "', '" + ventanaJuego.palabrasAcertadas1 + "', '" + ventanaJuego.ronda + "')";
                    string strInsertar2 = "INSERT INTO estadisticasAhorcado (nombre, puntos, pAcertadas, ronda) VALUES ('" + ventanaInicio.nombre2 + "', '" + ventanaJuego.puntos2 + "', '" + ventanaJuego.palabrasAcertadas2 + "', '" + ventanaJuego.ronda + "')";
                    OleDbCommand miComando = new OleDbCommand(strInsertar, miConexion);
                    miComando.ExecuteNonQuery();
                    miComando = new OleDbCommand(strInsertar2, miConexion);
                    miComando.ExecuteNonQuery();
                }

            }
        }

        public void comprobarExiste()
        {
            OleDbDataReader Lector;
            string strCadenaConexion = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source= estadísticasAhorcado.accdb";
            miConexion = new OleDbConnection(strCadenaConexion);
            miConexion.Open();
            string strSelect = "SELECT nombre FROM estadisticasAhorcado";
            OleDbCommand miComando = new OleDbCommand(strSelect, miConexion);
            Lector = miComando.ExecuteReader(); // Ejecutar el comando lector de datos
            while (Lector.Read())
            {
                if (Lector.GetString(0).ToUpper().Equals(ventanaInicio.nombre.ToUpper()))
                {
                    existe = true;
                }

                if (Lector.GetString(0).ToUpper().Equals(ventanaInicio.nombre2.ToUpper()))
                {
                    existe2 = true;
                }
            }
            Lector.Close(); // Cerrar el lector de datos
            Lector = null;
        }

        private void labelVolver_Click(object sender, EventArgs e)
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
            labelVolver_Click(sender, e);
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

        private void labelVerEstadisticas_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
            labelVerEstadisticas.ForeColor = Color.Black;
        }

        private void labelVerEstadisticas_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            labelVerEstadisticas.ForeColor = Color.White;
        }

        private void labelVerEstadisticas_Click(object sender, EventArgs e)
        {
            this.Close();
            ventanaDatos vD = new ventanaDatos();
            vD.Show();
        }
    }
}
