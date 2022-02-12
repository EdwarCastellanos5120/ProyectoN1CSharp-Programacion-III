using Newtonsoft.Json;

namespace ProyectoN1
{
    public partial class Form1 : Form
    {
        //Variable Global
        String[,] equipos;

        //Encabezados de Columnas
        private int posicion = 0;
        private int nombreClub = 1;
        private int jugados = 2;
        private int puntos = 3;
        private int ganados=4;
        private int empates=5;
        private int perdidos=6;
        private int golesFavor=7;
        private int golesContra=8;
        private int diferenciaGoles =9;
        public Form1()
        {
            //Lineas De Codigo Encargadas de Subir la Info
            String path = "C:\\Tareas\\ProyectoN1\\Resultados.json";
            String descarga = File.ReadAllText(path);
            equipos = JsonConvert.DeserializeObject<String[,]>(descarga);
            InitializeComponent();
           
        }

        //Metodo Encargado de Cargar la Tabla
        public void CargarTabla(String[,] clubs)
        {
            for(int i = 0; i < clubs.GetLength(0); i++)
            {
               listBoxPosicion.Items.Add(clubs[i, posicion]);
               listBoxClub.Items.Add(clubs[i,nombreClub]);
               listBoxJugados.Items.Add(clubs[i,jugados]);
               listBoxPts.Items.Add(clubs[i,puntos]);
               listBoxGanados.Items.Add(clubs[i,ganados]);
               listBoxEmpates.Items.Add(clubs[i,empates]);
               listBoxPerdidos.Items.Add(clubs[i,perdidos]);
               listBoxGFavor.Items.Add(clubs[i, golesFavor]);
               listBoxGContra.Items.Add(clubs[i, golesContra]);
                listBoxDGoles.Items.Add(clubs[i,diferenciaGoles]);
            }
        }

        private void BtnCargarEquipos_Click(object sender, EventArgs e)
        {
            //Carga la Informacion de la Matriz en los Combobox
            for (int i = 0; i < equipos.GetLength(0); i++)
            { 
                combo1.Items.Add(equipos[i, nombreClub]); 
                combo2.Items.Add(equipos[i, nombreClub]); 
            }
            CargarTabla(equipos);
            //Muestra y Desactiva
            BtnCargarEquipos.Enabled = false;
            combo1.Enabled = true;
            combo2.Enabled = true;
            txtcombo1.Enabled = true;
            txtcombo2.Enabled = true;

        }

       
    }
}