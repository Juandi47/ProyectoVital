using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOSegAntropometria
    {
        public TOSegAntropometria() { }
        public TOSegAntropometria(decimal talla, decimal pesoIdeal, decimal edad, decimal pMB, DateTime fecha_SA, decimal peso, decimal iMC, decimal porcGrasaAnalizador, decimal porcGr_Bascula, decimal gB_BI, decimal gB_BD, decimal gB_PI, decimal gB_PD, decimal gB_Tronco, decimal porcentGViceral, decimal porcentMusculo, decimal pM_BI, decimal pM_PD, decimal pM_BD, decimal pM_PI, decimal pM_Tronco, decimal aguaCorporal, decimal masaOsea, decimal complexión, decimal edadMetabolica, decimal cintura, decimal abdomen, decimal cadera, string muslo, decimal brazo, string observaciones)
        {
            Talla = talla;
            PesoIdeal = pesoIdeal;
            Edad = edad;
            PMB = pMB;
            Fecha_SA = fecha_SA;
            Peso = peso;
            IMC = iMC;
            PorcGrasaAnalizador = porcGrasaAnalizador;
            PorcGr_Bascula = porcGr_Bascula;
            GB_BI = gB_BI;
            GB_BD = gB_BD;
            GB_PI = gB_PI;
            GB_PD = gB_PD;
            GB_Tronco = gB_Tronco;
            PorcentGViceral = porcentGViceral;
            PorcentMusculo = porcentMusculo;
            PM_BI = pM_BI;
            PM_PD = pM_PD;
            PM_BD = pM_BD;
            PM_PI = pM_PI;
            PM_Tronco = pM_Tronco;
            AguaCorporal = aguaCorporal;
            MasaOsea = masaOsea;
            Complexión = complexión;
            EdadMetabolica = edadMetabolica;
            Cintura = cintura;
            Abdomen = abdomen;
            Cadera = cadera;
            Muslo = muslo;
            Brazo = brazo;
            Observaciones = observaciones;
        }

        public TOSegAntropometria(int id_SegAntrop, int seguimiento, decimal talla, decimal pesoIdeal, decimal edad, decimal pMB, DateTime fecha_SA, decimal peso, decimal iMC, decimal porcGrasaAnalizador, decimal porcGr_Bascula, decimal gB_BI, decimal gB_BD, decimal gB_PI, decimal gB_PD, decimal gB_Tronco, decimal porcentGViceral, decimal porcentMusculo, decimal pM_BI, decimal pM_PD, decimal pM_BD, decimal pM_PI, decimal pM_Tronco, decimal aguaCorporal, decimal masaOsea, decimal complexión, decimal edadMetabolica, decimal cintura, decimal abdomen, decimal cadera, string muslo, decimal brazo, string observaciones)
        {
            this.id_SegAntrop = id_SegAntrop;
            Seguimiento = seguimiento;
            Talla = talla;
            PesoIdeal = pesoIdeal;
            Edad = edad;
            PMB = pMB;
            Fecha_SA = fecha_SA;
            Peso = peso;
            IMC = iMC;
            PorcGrasaAnalizador = porcGrasaAnalizador;
            PorcGr_Bascula = porcGr_Bascula;
            GB_BI = gB_BI;
            GB_BD = gB_BD;
            GB_PI = gB_PI;
            GB_PD = gB_PD;
            GB_Tronco = gB_Tronco;
            PorcentGViceral = porcentGViceral;
            PorcentMusculo = porcentMusculo;
            PM_BI = pM_BI;
            PM_PD = pM_PD;
            PM_BD = pM_BD;
            PM_PI = pM_PI;
            PM_Tronco = pM_Tronco;
            AguaCorporal = aguaCorporal;
            MasaOsea = masaOsea;
            Complexión = complexión;
            EdadMetabolica = edadMetabolica;
            Cintura = cintura;
            Abdomen = abdomen;
            Cadera = cadera;
            Muslo = muslo;
            Brazo = brazo;
            Observaciones = observaciones;
        }

        public int id_SegAntrop { set; get; }
        public int Seguimiento { set; get; }
        public decimal Talla { set; get; }
        public decimal PesoIdeal { set; get; }
        public decimal Edad { set; get; }
        public decimal PMB { set; get; }
        public DateTime Fecha_SA { set; get; }
        public decimal Peso { set; get; }
        public decimal IMC { set; get; }
        public decimal PorcGrasaAnalizador { set; get; }
        public decimal PorcGr_Bascula { set; get; }
        public decimal GB_BI { set; get; }
        public decimal GB_BD { set; get; }
        public decimal GB_PI { set; get; }
        public decimal GB_PD { set; get; }
        public decimal GB_Tronco { set; get; }
        public decimal PorcentGViceral { set; get; }//
        public decimal PorcentMusculo { set; get; }
        public decimal PM_BI { set; get; }
        public decimal PM_PD { set; get; }
        public decimal PM_BD { set; get; }
        public decimal PM_PI { set; get; }
        public decimal PM_Tronco { set; get; }
        public decimal AguaCorporal { set; get; }
        public decimal MasaOsea { set; get; }
        public decimal Complexión { set; get; }
        public decimal EdadMetabolica { set; get; }
        public decimal Cintura { set; get; }
        public decimal Abdomen { set; get; }
        public decimal Cadera { set; get; }
        public string Muslo { set; get; }
        public decimal Brazo { set; get; }
        public string Observaciones { set; get; }

    }
}
