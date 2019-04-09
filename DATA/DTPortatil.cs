using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA
{
    public class DTPortatil
    {
        private int id;
        private int marca;
        private int modelo;
        private String tipo;
        private int memoryVideoGB;
        private DateTime lanzamiento;
        private int pantalla;
        private String sistOp;
        private int procesador;
        private int ram;
        private int camara;
        private int cantidad_usb;
        private int bateria;

        public int Id { get => id; set => id = value; }
        public int Marca { get => marca; set => marca = value; }
        public int Modelo { get => modelo; set => modelo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int MemoryVideoGB { get => memoryVideoGB; set => memoryVideoGB = value; }
        public DateTime Lanzamiento { get => lanzamiento; set => lanzamiento = value; }
        public int Pantalla { get => pantalla; set => pantalla = value; }
        public string SistOp { get => sistOp; set => sistOp = value; }
        public int Procesador { get => procesador; set => procesador = value; }
        public int Ram { get => ram; set => ram = value; }
        public int Camara { get => camara; set => camara = value; }
        public int Cantidad_usb { get => cantidad_usb; set => cantidad_usb = value; }
        public int Bateria { get => bateria; set => bateria = value; }
    }
}
