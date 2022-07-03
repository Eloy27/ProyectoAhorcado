using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Media;

namespace ProyectoAhorcado
{
    public partial class ventanaJuego : Form
    {
        ArrayList palabras = new ArrayList();
        ArrayList palabrasUsadas = new ArrayList();
        char[] guiones = null;
        String palabraAdivinar = "";
        public static int contLetras, y = 0, x = 0, fallos = 0, puntos = 0, puntos1 = 0, puntos2 = 0, palabrasAcertadas = 0, palabrasAcertadas1 = 0, palabrasAcertadas2 = 0, ronda = 1, rondas = 0;
        public static bool cambio = false;
        SoundPlayer musicaDuda = new SoundPlayer();
       

        public ventanaJuego()
        {
            InitializeComponent();
            ronda = 1;
            labelCategoria.Text += " " + ventanaInicio.categoria;
            labelNombre.Text += ventanaInicio.nombre;
            equisPB.Parent = bordesPB;
            botonPulsadoPB.Parent = bordesPB;
            minimizarPB.Parent = bordesPB;
            minimizarPulsadoPB.Parent = bordesPB;
            reiniciarValores();
            comprueboJugadores();
            rondas = palabras.Count;
            labelRonda.Text = "Ronda: " + ronda + "/" +rondas;
            this.Cursor = new Cursor("puntero.cur");
            musicaDuda.SoundLocation = "duda.wav";
            musicaDuda.PlayLooping();
        }
        public void comprueboJugadores()
        {
            if (ventanaInicio.unJugador)
            {
                labelNombre.Text = "Nombre: " + ventanaInicio.nombre;
            }

            if (!ventanaInicio.unJugador)
            {
                labelNombre.Text = "Turno de: " + ventanaInicio.nombre;
                labelPuntos2.Visible = true;
            }
        }

        public void cargarPalabra(String categoria)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("categorias.xml");
            foreach (XmlNode n1 in doc.DocumentElement.ChildNodes)
            {
                if (n1.Name == categoria)
                {
                    foreach (XmlNode n2 in n1.ChildNodes)
                    {
                        foreach (XmlNode n3 in n2.ChildNodes)
                        {
                            palabras.Add(n3.Value);
                            palabrasUsadas.Add("");
                        }
                    }
                }
            }
        }

        public void muestroGuiones()
        {
            int cont = 0;
            Boolean posible = false;
            labelGuiones.Text = "";
            Random rnd = new Random();
            int num = 0;
            while (!posible)
            {
                posible = true;
                num = rnd.Next(0, palabras.Count);
                for (int i = 0; i < palabras.Count; i++)
                {
                    if (palabras[num].ToString().Equals(palabrasUsadas[i].ToString()))
                    {
                        posible = false;
                        cont++;
                    }
                }
                if (cont == palabrasUsadas.Count)
                {
                    posible = true;
                    MessageBox.Show("¡¡Lista de palabras completada!!" , "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarEstadisticas();
                }
            }

            palabraAdivinar = palabras[num].ToString();
            palabrasUsadas.Add(palabraAdivinar);

            guiones = new char[palabraAdivinar.Length];
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {
                if (!palabraAdivinar[i].ToString().Equals(" "))
                {
                    guiones[i] = '_';
                }
            }
            actualizoLabel();
        }

        private void letra_Click(object sender, EventArgs e)
        {
            cambio = !cambio;
            if ((y > 0 && y < 20) || (y > 20 && y < 24) || (y > 24 && y < 27) || (y > 27 && y < 32) || (y > 32 && y < 36))
            {
                MessageBox.Show("Espera para poder introducir letra", "Cuidado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                char letra = ((Label)sender).Name.ToString()[5];
                sustituyoLetra(letra, sender, e);
                actualizoLabel();
                if (comprobarVictoria())
                {

                   
                    if (ventanaInicio.unJugador)
                    {
                        MessageBox.Show("Palabra Acertada", "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        puntos += 10;
                        labelPuntos.Text = "Puntos: " + puntos;
                    }
                    palabrasAcertadas++;
                   

                    if (!ventanaInicio.unJugador)
                    {
                        if (cambio)
                        {
                            MessageBox.Show("Acertaste la palabra "+ventanaInicio.nombre, "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            palabrasAcertadas1++;
                            puntos1 += 10;
                            labelPuntos.Text = "Puntos: " + puntos1;
                        }
                        else
                        {
                            MessageBox.Show("Acertaste la palabra " + ventanaInicio.nombre2, "Enhorabuena", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            palabrasAcertadas2++;
                            puntos2 += 10;
                            labelPuntos2.Text = "Puntos 2: " + puntos2;
                        }
                    }
                    reiniciarValores();

                    ronda++;
                    labelRonda.Text = "Ronda: " + ronda + "/" + rondas;
                }
            }

            if (!ventanaInicio.unJugador)
            {

                if (cambio)
                    labelNombre.Text = "Turno de: " + ventanaInicio.nombre2;
                else
                    labelNombre.Text = "Turno de: " + ventanaInicio.nombre;
            }
        }

        public void actualizoLabel()
        {
            labelGuiones.Text = "";
            for (int i = 0; i < guiones.Length; i++)
            {
                if (palabraAdivinar[i].ToString().Equals(" "))
                {
                    labelGuiones.Text += "   ";
                }
                else
                    labelGuiones.Text += guiones[i] + " ";
            }
        }

        public void reiniciarValores()
        {
            cargarPalabra(ventanaInicio.categoria);
            muestroGuiones();
            letraW.Enabled = true;
            letraS.Enabled = true;
            letraQ.Enabled = true;
            letraA.Enabled = true;
            letraZ.Enabled = true;
            letraX.Enabled = true;
            letraC.Enabled = true;
            letraV.Enabled = true;
            letraB.Enabled = true;
            letraN.Enabled = true;
            letraM.Enabled = true;
            letraD.Enabled = true;
            letraF.Enabled = true;
            letraG.Enabled = true;
            letraH.Enabled = true;
            letraJ.Enabled = true;
            letraK.Enabled = true;
            letraL.Enabled = true;
            letraÑ.Enabled = true;
            letraP.Enabled = true;
            letraO.Enabled = true;
            letraI.Enabled = true;
            letraU.Enabled = true;
            letraY.Enabled = true;
            letraT.Enabled = true;
            letraR.Enabled = true;
            letraE.Enabled = true;
            labelResolver.Enabled = true;
            resolverTB.Text = "";
        }

        public bool comprobarVictoria()
        {
            contLetras = 0;
            Boolean victoria = false;
            for (int i = 0; i < guiones.Length; i++)
            {
                if (guiones[i] != '_')
                {
                    contLetras++;
                }
            }
            if (contLetras == palabraAdivinar.Length)
            {
                victoria = true;
            }
            return victoria;
        }

        public void mostrarEstadisticas()
        {
            this.Close();
            ventanaEstadisticas ve = new ventanaEstadisticas();
            ve.Show();
        }


        public void sustituyoLetra(char letra, object sender, EventArgs e)
        {
            Boolean existe = false;
            for (int i = 0; i < palabraAdivinar.Length; i++)
            {

                if (palabraAdivinar[i].ToString().ToUpper() == letra.ToString().ToUpper())
                {
                    guiones[i] = letra;
                    if (ventanaInicio.unJugador)
                    {
                        puntos += 2;
                        labelPuntos.Text = "Puntos: " + puntos;
                    }
                    existe = true;
                    if (!ventanaInicio.unJugador)
                    {
                        if (cambio)
                        {
                            puntos1 += 2;
                            labelPuntos.Text = "Puntos: " + puntos1;
                        }
                        else
                        {
                            puntos2 += 2;
                            labelPuntos2.Text = "Puntos 2: " + puntos2;
                        }
                    }
                }

            }
            if (!existe)
            {
                if (ventanaInicio.unJugador)
                {
                    puntos -= 1;
                    labelPuntos.Text = "Puntos: " + puntos;
                }


                if (!ventanaInicio.unJugador)
                {
                    if (cambio)
                    {
                        puntos1 -= 1;
                        labelPuntos.Text = "Puntos: " + puntos1;
                    }
                    else
                    {
                        puntos2 -= 1;
                        labelPuntos2.Text = "Puntos 2: " + puntos2;
                    }
                }
                avanzarDibujo();
            }

             ((Label)sender).Enabled = false;
        }

        public void avanzarDibujo()
        {
            temporizador.Start();
            temporizador.Interval = 100;

            if (fallos == 4)
            {
                labelGuiones.Text = "";
                labelGuiones.Text = palabraAdivinar.ToString();

                if (!ventanaInicio.unJugador)
                    MessageBox.Show("Perdisteis, la palabra era: " + palabraAdivinar.ToString(), "Ooooh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Perdiste, la palabra era: " + palabraAdivinar.ToString(), "Ooooh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mostrarEstadisticas();
            }
        }

        private void letra_MouseEnter(object sender, EventArgs e)
        {
                 this.Cursor = new Cursor("punteroSeñalar.cur");
                ((Label)sender).ForeColor = Color.Black;  
        }

        private void letra_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("puntero.cur");
            ((Label)sender).ForeColor = Color.White;
        }

        private void labelResolver_Click(object sender, EventArgs e)
        {
            resolverTB.Visible = true;
            Boolean acertada = false;
            if (!resolverTB.Text.ToString().Equals(""))
            {
                labelResolver.Enabled = false;
                if (resolverTB.Text.ToString().Length == palabraAdivinar.Length)
                {
                    for (int i = 0; i < resolverTB.Text.ToString().Length; i++)
                    {

                        if (resolverTB.Text[i].ToString().ToUpper().Equals(palabraAdivinar[i].ToString().ToUpper()))
                        {
                            acertada = true;
                        }
                        else
                        {
                            acertada = false;
                            i = palabraAdivinar.Length - 1;
                        }
                    }
                }
                cambio = !cambio;
                if (acertada)
                {

                   
                    if (ventanaInicio.unJugador)
                    {

                        MessageBox.Show("Wow, toma 15 puntos", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        puntos += 15;
                        labelPuntos.Text = "Puntos: " + puntos;
                    }

                    palabrasAcertadas++;
                    

                    if (!ventanaInicio.unJugador)
                    {
                        if (cambio)
                        {
                            MessageBox.Show("Wow, "+ventanaInicio.nombre+" toma 15 puntos", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            palabrasAcertadas1++;
                            puntos1 += 15;
                            labelPuntos.Text = "Puntos: " + puntos1;
                        }
                        else
                        {
                            MessageBox.Show("Wow, " + ventanaInicio.nombre2 + " toma 15 puntos", "¡Enhorabuena!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            palabrasAcertadas2++;
                            puntos2 += 15;
                            labelPuntos2.Text = "Puntos 2: " + puntos2;
                        }
                    }
                    reiniciarValores();
                    ronda++;
                    labelRonda.Text = "Ronda: " + ronda + "/"+rondas;
                    
                }
                else
                {
                    MessageBox.Show("Prueba otra vez", "¡OOOHH!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    resolverTB.Text = "";
                    labelResolver.Enabled = true;
                    if (ventanaInicio.unJugador)
                    {
                        puntos -= 5;
                        labelPuntos.Text = "Puntos: " + puntos;
                    }
                    if (!ventanaInicio.unJugador)
                    {
                        if (cambio)
                        {
                            puntos1 -= 5;
                            labelPuntos.Text = "Puntos: " + puntos1;
                        }
                        else
                        {
                            puntos2 -= 5;
                            labelPuntos2.Text = "Puntos 2: " + puntos2;
                        }
                    }
                    avanzarDibujo();
                }

                if (!ventanaInicio.unJugador)
                {

                    if (cambio)
                        labelNombre.Text = "Turno de: " + ventanaInicio.nombre2;
                    else
                        labelNombre.Text = "Turno de: " + ventanaInicio.nombre;
                }
            }
            else
                MessageBox.Show("Introduce tu palabra", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void resolverTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                labelResolver_Click(sender, e);
            }
        }

        private void ventanaJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                botonSalir_Click(sender, e);
            }

        }

        private void botonSalir_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = new Cursor("punteroSeñalar.cur");
            botonSalir.ForeColor = Color.Black;
        }

            private void temporizador_Tick(object sender, EventArgs e)
        {
            y = y + 1;
            switch (fallos)
            {

                case 0:
                    switch (y)
                    {
                        case 1:
                            imagenAhorcado.Image = Image.FromFile("1.png");
                            break;
                        case 2:
                            imagenAhorcado.Image = Image.FromFile("2.png");
                            break;
                        case 3:
                            imagenAhorcado.Image = Image.FromFile("3.png");
                            break;
                        case 4:
                            imagenAhorcado.Image = Image.FromFile("4.png");
                            break;
                        case 5:
                            imagenAhorcado.Image = Image.FromFile("5.png");
                            break;
                        case 6:
                            imagenAhorcado.Image = Image.FromFile("6.png");
                            break;
                        case 7:
                            imagenAhorcado.Image = Image.FromFile("7.png");
                            break;
                        case 8:
                            imagenAhorcado.Image = Image.FromFile("8.png");
                            break;
                        case 9:
                            imagenAhorcado.Image = Image.FromFile("9.png");
                            break;
                        case 10:
                            imagenAhorcado.Image = Image.FromFile("10.png");
                            break;
                        case 11:
                            imagenAhorcado.Image = Image.FromFile("11.png");
                            break;
                        case 12:
                            imagenAhorcado.Image = Image.FromFile("12.png");
                            break;
                        case 13:
                            imagenAhorcado.Image = Image.FromFile("13.png");
                            break;
                        case 14:
                            imagenAhorcado.Image = Image.FromFile("14.png");
                            break;
                        case 15:
                            imagenAhorcado.Image = Image.FromFile("15.png");
                            break;
                        case 16:
                            imagenAhorcado.Image = Image.FromFile("16.png");
                            break;
                        case 17:
                            imagenAhorcado.Image = Image.FromFile("17.png");
                            break;
                        case 18:
                            imagenAhorcado.Image = Image.FromFile("18.png");
                            break;
                        case 19:
                            imagenAhorcado.Image = Image.FromFile("19.png");
                            break;
                        case 20:
                            imagenAhorcado.Image = Image.FromFile("20.png");
                            fallos++;
                            temporizador.Stop();
                            break;

                    }
                    break;
                case 1:
                    switch (y)
                    {
                        case 21:
                            imagenAhorcado.Image = Image.FromFile("21.png");
                            break;
                        case 22:
                            imagenAhorcado.Image = Image.FromFile("22.png");
                            break;
                        case 23:
                            imagenAhorcado.Image = Image.FromFile("23.png");
                            break;
                        case 24:
                            imagenAhorcado.Image = Image.FromFile("24.png");
                            fallos++;
                            temporizador.Stop();
                            break;
                    }
                    break;
                case 2:
                    switch (y)
                    {
                        case 25:
                            imagenAhorcado.Image = Image.FromFile("25.png");
                            break;
                        case 26:
                            imagenAhorcado.Image = Image.FromFile("26.png");
                            break;
                        case 27:
                            imagenAhorcado.Image = Image.FromFile("27.png");
                            fallos++;
                            temporizador.Stop();
                            break;
                    }
                    break;
                case 3:
                    switch (y)
                    {
                        case 28:
                            imagenAhorcado.Image = Image.FromFile("28.png");
                            break;
                        case 29:
                            imagenAhorcado.Image = Image.FromFile("29.png");
                            break;
                        case 30:
                            imagenAhorcado.Image = Image.FromFile("30.png");
                            break;
                        case 31:
                            imagenAhorcado.Image = Image.FromFile("31.png");
                            break;
                        case 32:
                            imagenAhorcado.Image = Image.FromFile("32.png");
                            fallos++;
                            temporizador.Stop();
                            break;
                    }
                    break;
                case 4:
                    switch (y)
                    {
                        case 33:
                            imagenAhorcado.Image = Image.FromFile("33.png");
                            break;
                        case 34:
                            imagenAhorcado.Image = Image.FromFile("34.png");
                            break;
                        case 35:
                            imagenAhorcado.Image = Image.FromFile("35.png");
                            break;
                        case 36:
                            imagenAhorcado.Image = Image.FromFile("36.png");
                            fallos++;
                            temporizador.Stop();
                            break;
                    }
                    break;
            }

        }

        private void botonSalir_MouseLeave(object sender, EventArgs e)
        {

            this.Cursor = new Cursor("puntero.cur");
            botonSalir.ForeColor = Color.White;
        }

        public void botonSalir_Click(object sender, EventArgs e)
        {
            rondas = 0;
            puntos = 0;
            puntos1 = 0;
            puntos2 = 0;
            palabrasAcertadas = 0;
            palabrasAcertadas1 = 0;
            palabrasAcertadas2 = 0;
            ronda = 1;
            cambio = false;
            fallos = 0;
            y = 0;          
            ventanaInicio vi = new ventanaInicio();
            ventanaInicio.categoria = "";
            ventanaInicio.nombre = "";
            ventanaInicio.nombre2 = "";
            vi.Show();
            this.Close();
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
            botonSalir_Click(sender, e);
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
    }
}
