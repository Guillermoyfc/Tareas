using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tarea1._2
{
    public partial class FormularioWord : Form
    {
        public FormularioWord()
        {
            InitializeComponent();
        }

        //private void Button1_Click(object sender, EventArgs e)
        //{
        //    var objClaseWord = new WordClase();
        //    objClaseWord.WriteToWordDoc("Ejemplo.docx", rtbTextoWord.Text);

        //}

        private void BtnCrearWord_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            //se filtra el tipo de archivo para el nombre
            saveFileDialog.Filter = "Archivo word (*.docx)|*.docx|Todos los archivos (*.*)|*.*";
            //al dar click en guardar, se crea el archivo donde se indico en la ventana de seleccion de carpeta
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                var objClaseWord = new WordClase();
                objClaseWord.InsertTableInDoc(saveFileDialog.FileName, rtbTextoWord1.Text, rtbTextoWord2.Text);
            }
        }
    }
}
