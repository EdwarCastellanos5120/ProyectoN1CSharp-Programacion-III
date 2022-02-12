using Newtonsoft.Json;

namespace ProyectoN1
{
    public partial class Form1 : Form
    {
        //Variable Global
        String[,] equipos;



        public Form1()
        {
            //Lineas De Codigo Encargadas de Subir la Info
            String path = "C:\\Tareas\\ProyectoN1\\Resultados.json";
            String descarga = File.ReadAllText(path);
            equipos = JsonConvert.DeserializeObject<String[,]>(descarga);
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < equipos.GetLength(0); i++)
            { combo1.Items.Add(equipos[i, 1]); combo2.Items.Add(equipos[i, 1] ); }
            btnInicio.Enabled = false;
          
        }

        
    }
}