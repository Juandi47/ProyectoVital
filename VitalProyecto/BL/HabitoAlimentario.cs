using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class HabitoAlimentario
    {
        public string Cedula { set; get; }
        public int ComidaDiaria { set; get; }
        public int ComidaHorasDia { set; get; }
        public int AfueraExpress { set; get; }
        public string ComidaFuera { set; get; }
        public string AzucarBebida { set; get; }
        public string ComidaElaboradCon { set; get; }
        public decimal AguaDiaria { set; get; }
        public int Aderezos { set; get; }
        public int Fruta { set; get; }
        public int Verdura { set; get; }
        public int Leche { set; get; }
        public int Huevo { set; get; }
        public int Yogurt { set; get; }
        public int Carne { set; get; }
        public int Queso { set; get; }
        public int Aguacate { set; get; }
        public int Semillas { set; get; }

        public HabitoAlimentario(string cedula, int comidaDiaria, int comidaHorasDia, int afueraExpress, string comidaFuera, string azucarBebida, string comidaElaboradCon, decimal aguaDiaria, int aderezos, int fruta, int verdura, int leche, int huevo, int yogurt, int carne, int queso, int aguacate, int semillas)
        {
            Cedula = cedula;
            ComidaDiaria = comidaDiaria;
            ComidaHorasDia = comidaHorasDia;
            AfueraExpress = afueraExpress;
            ComidaFuera = comidaFuera;
            AzucarBebida = azucarBebida;
            ComidaElaboradCon = comidaElaboradCon;
            AguaDiaria = aguaDiaria;
            Aderezos = aderezos;
            Fruta = fruta;
            Verdura = verdura;
            Leche = leche;
            Huevo = huevo;
            Yogurt = yogurt;
            Carne = carne;
            Queso = queso;
            Aguacate = aguacate;
            Semillas = semillas;
        }

        public HabitoAlimentario() { }


    }
}
