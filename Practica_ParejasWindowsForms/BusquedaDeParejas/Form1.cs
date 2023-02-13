using BusquedaDeParejas.Idiomas;
using BusquedaDeParejas.Properties;
using System.ComponentModel;
using System.Globalization;

namespace BusquedaDeParejas
{
    public partial class Form1 : Form
    {
        int tiempo = 0;
        String dificultad;

        //Inicializamos todas las imágenes
        Image bulldog;
        Image caniche;
        Image dalmata;
        Image golden;
        Image labrador;
        Image pomerania;
        Image russel;
        Image teckel;

        //Variables para las imagenes pulsadas:

        bool primera_imagen = false;
        bool segunda_imagen = false;

        int primer_pb = 0;
        int segundo_pb = 0;

        BindingList<Jugador> ranking = new BindingList<Jugador>();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbIdiomas.SelectedText = "ESPAÑOL";

            //Asignamos valor a todas las imagenes:

            bulldog = Resources.bulldog;
            caniche = Resources.caniche;    
            dalmata = Resources.dalmata;    
            golden = Resources.golden;
            labrador = Resources.labrador;
            pomerania = Resources.pomerania;
            russel = Resources.russel;
            teckel = Resources.teckel;

            dataGridView_Ranking.DataSource = ranking;
          
        }




        
        private void btFacil_Click(object sender, EventArgs e)
        {
            dificultad = "FACIL";

            if (tbJugador.Text == ""){

                MessageBox.Show("Tiene que completar el nombre");

            }else{
                tiempo = 61;
                Timer.Enabled = true;
                Timer.Start();
            }
        }

        private void btMedio_Click(object sender, EventArgs e)
        {
            dificultad = "MEDIO";

            if (tbJugador.Text == ""){

                MessageBox.Show("Tiene que completar el nombre");

            }else{

                tiempo = 46;
                Timer.Enabled = true;
                Timer.Start();               
            }
        }

        private void btDificil_Click(object sender, EventArgs e){

            dificultad = "DIFÍCIL";


            if (tbJugador.Text == ""){

                MessageBox.Show("Tiene que completar el nombre");

            } else{
                tiempo = 31;
                Timer.Enabled = true;
                Timer.Start();
                
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {

            tiempo--;

            this.lbTimer.Text = tiempo.ToString();
            lbSegundos.Visible = true;

            if (tiempo == 0)
            {

                Timer.Enabled = false;
                Timer.Stop();
                MessageBox.Show(Idiomas.recurso.String4);
                ranking.Add(new Jugador { NOMBRE = tbJugador.Text, DIFICULTAD = dificultad });

            }

            

        }

        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            elegirIdioma();
        }

        

        private void elegirIdioma()
        {
            if (cbIdiomas.SelectedIndex == 0)
            {
                cbIdiomas.SelectedText = "ESPAÑOL";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-ES");

            }
            else
            {
                cbIdiomas.SelectedText = "INGLÉS";
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                
            }

            lbIdioma.Text = recurso.lbIdioma;
            lbJugador.Text = recurso.lbJugador;
            lbDificultad.Text = recurso.lbDificultad;
            lbSegundos.Text = recurso.lbSegundos;


            btFacil.Text = recurso.btFacil;
            btMedio.Text = recurso.btMedio;
            btDificil.Text = recurso.btDificil;
            btSalir.Text = recurso.btSalir;

            cbIdiomas.Text = recurso.cbIngles;
            cbIdiomas.Items.Clear();
            cbIdiomas.Items.Add(recurso.cbEspañol);
            cbIdiomas.Items.Add(recurso.cbIngles);
        }














        private void pbImagen_1_Click_1(object sender, EventArgs e)
        {
            if (controlErrores()){

            
                resetearImagenes();

                pbImagen_1.Image = Resources.bulldog;

                if (!primera_imagen)
                {

                    primer_pb = 1;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 1;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }



        }




        private void pbImagen_2_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_2.Image = Resources.bulldog;

                if (!primera_imagen)
                {

                    primer_pb = 2;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 2;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_3_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_3.Image = Resources.caniche;

                if (!primera_imagen)
                {

                    primer_pb = 3;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 3;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_4_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_4.Image = Resources.caniche;

                if (!primera_imagen)
                {

                    primer_pb = 4;
                    primera_imagen = true;

                }
                else
                {
                    segundo_pb = 4;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }
        }

        private void pbImagen_5_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_5.Image = Resources.dalmata;

                if (!primera_imagen)
                {

                    primer_pb = 5;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 5;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_6_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_6.Image = Resources.dalmata;

                if (!primera_imagen)
                {

                    primer_pb = 6;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 6;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }
        }

        private void pbImagen_7_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_7.Image = Resources.golden;

                if (!primera_imagen)
                {

                    primer_pb = 7;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 7;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_8_Click_1(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_8.Image = Resources.golden;

                if (!primera_imagen)
                {

                    primer_pb = 8;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 8;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_9_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_9.Image = Resources.labrador;

                if (!primera_imagen)
                {

                    primer_pb = 9;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 9;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }
        private void pbImagen_10_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_10.Image = Resources.labrador;

                if (!primera_imagen)
                {

                    primer_pb = 10;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 10;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_11_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_11.Image = Resources.pomerania;

                if (!primera_imagen)
                {

                    primer_pb = 11;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 11;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_12_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_12.Image = Resources.pomerania;

                if (!primera_imagen)
                {

                    primer_pb = 12;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 12;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }
        private void pbImagen_13_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_13.Image = Resources.russel;

                if (!primera_imagen)
                {

                    primer_pb = 13;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 13;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }
        }


        private void pbImagen_14_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_14.Image = Resources.russel;

                if (!primera_imagen)
                {

                    primer_pb = 14;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 14;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }


        }
        private void pbImagen_15_Click(object sender, EventArgs e)
        {
            if (controlErrores())
            {


                resetearImagenes();

                pbImagen_15.Image = Resources.teckel;

                if (!primera_imagen)
                {

                    primer_pb = 15;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 15;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }

        }

        private void pbImagen_16_Click(object sender, EventArgs e)
        {

            if (controlErrores())
            {


                resetearImagenes();
                pbImagen_16.Image = Resources.teckel;

                if (!primera_imagen)
                {

                    primer_pb = 16;
                    primera_imagen = true;

                }
                else
                {

                    segundo_pb = 16;
                    segunda_imagen = true;
                }

                comprobarPictureBox();
            }


        }




        void comprobarPictureBox ()
        {

            if (primer_pb == 1 && segundo_pb == 2 || segundo_pb == 1 && primer_pb == 2){

                pbImagen_1.Enabled = false;
                pbImagen_2.Enabled = false;
                

            }else if (primer_pb == 3 && segundo_pb == 4 || segundo_pb == 3 && primer_pb == 4){

                pbImagen_3.Enabled = false;
                pbImagen_4.Enabled = false;
                

            }
            else if (primer_pb == 5 && segundo_pb == 6 || segundo_pb == 5 && primer_pb == 6){

                pbImagen_5.Enabled = false;
                pbImagen_6.Enabled = false;
               

            }
            else if (primer_pb == 7 && segundo_pb == 8 || segundo_pb == 7 && primer_pb == 8){

                pbImagen_7.Enabled = false;
                pbImagen_8.Enabled = false;
              

            }
            else if (primer_pb == 9 && segundo_pb == 10 || segundo_pb == 9 && primer_pb == 10){

                pbImagen_9.Enabled = false;
                pbImagen_10.Enabled = false;
               

            }
            else if (primer_pb == 11 && segundo_pb == 12 || segundo_pb == 11 && primer_pb == 12){

                pbImagen_11.Enabled = false;
                pbImagen_12.Enabled = false;
                

            }
            else if (primer_pb == 13 && segundo_pb == 14 || segundo_pb == 13 && primer_pb == 14){

                pbImagen_13.Enabled = false;
                pbImagen_14.Enabled = false;

            }
            else if (primer_pb == 15 && segundo_pb == 16 || segundo_pb == 15 && primer_pb == 16){

                pbImagen_15.Enabled = false;
                pbImagen_16.Enabled = false;

            }
            else
            {

            
                if (primer_pb != 0 && segundo_pb != 0)
                {
                    primer_pb = 0;
                    segundo_pb = 0;
                }

            }

            if (pbImagen_1.Enabled==false && pbImagen_2.Enabled == false && pbImagen_3.Enabled == false && pbImagen_4.Enabled == false && pbImagen_5.Enabled == false &&
                pbImagen_6.Enabled == false && pbImagen_7.Enabled == false && pbImagen_8.Enabled == false && pbImagen_9.Enabled == false &&
                pbImagen_10.Enabled == false && pbImagen_11.Enabled == false && pbImagen_12.Enabled == false && pbImagen_13.Enabled == false &&
                pbImagen_14.Enabled == false && pbImagen_15.Enabled == false && pbImagen_16.Enabled == false )
            {
                Timer.Stop();
                MessageBox.Show(Idiomas.recurso.String3);
                ranking.Add(new Jugador { NOMBRE = tbJugador.Text, DIFICULTAD = dificultad }); 
            }

       
            }

       private void resetearImagenes()
        {
                if (primer_pb == 0 && segundo_pb == 0)
            {
                primera_imagen = false;
                segunda_imagen = false;

                if (pbImagen_1.Enabled == true)
                {

                    pbImagen_1.Image = Resources.interrogante;

                }
                if (pbImagen_2.Enabled == true)
                {

                    pbImagen_2.Image = Resources.interrogante;

                }
                if (pbImagen_3.Enabled == true)
                {

                    pbImagen_3.Image = Resources.interrogante;

                }
                if (pbImagen_4.Enabled == true)
                {

                    pbImagen_4.Image = Resources.interrogante;

                }
                if (pbImagen_5.Enabled == true)
                {

                    pbImagen_5.Image = Resources.interrogante;

                }
                if (pbImagen_6.Enabled == true)
                {

                    pbImagen_6.Image = Resources.interrogante;

                }
                if (pbImagen_7.Enabled == true)
                {

                    pbImagen_7.Image = Resources.interrogante;

                }
                if (pbImagen_8.Enabled == true)
                {

                    pbImagen_8.Image = Resources.interrogante;

                }
                if (pbImagen_9.Enabled == true)
                {

                    pbImagen_9.Image = Resources.interrogante;

                }
                if (pbImagen_10.Enabled == true)
                {

                    pbImagen_10.Image = Resources.interrogante;

                }
                if (pbImagen_11.Enabled == true)
                {

                    pbImagen_11.Image = Resources.interrogante;

                }
                if (pbImagen_12.Enabled == true)
                {

                    pbImagen_12.Image = Resources.interrogante;

                }
                if (pbImagen_13.Enabled == true)
                {

                    pbImagen_13.Image = Resources.interrogante;

                }
                if (pbImagen_14.Enabled == true)
                {

                    pbImagen_14.Image = Resources.interrogante;

                }
                if (pbImagen_15.Enabled == true)
                {

                    pbImagen_15.Image = Resources.interrogante;

                }
                if (pbImagen_16.Enabled == true)
                {

                    pbImagen_16.Image = Resources.interrogante;
                }
            }


        }



        private bool controlErrores()
        {
            if (tbJugador.Text == "")
            {
                MessageBox.Show(Idiomas.recurso.String1);

                return false;
            }
            if (Timer.Enabled == false)
            {

                MessageBox.Show(Idiomas.recurso.String2);

                return false;
            }
            return true;
        }










        private void lbSegundos_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }


        private void pbImagen_1_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_8_Click(object sender, EventArgs e)
        {



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbJugador_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView_Ranking_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}



