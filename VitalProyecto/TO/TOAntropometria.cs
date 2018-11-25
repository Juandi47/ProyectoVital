using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO
{
    public class TOAntropometria
    {


        public string Cedula { set; get; }
        public decimal Talla { set; get; }
        public decimal PesoIdeal { set; get; }
        public decimal Edad { set; get; }
        public decimal PMB { set; get; }
        public decimal Peso { set; get; }
        public decimal PesoMaxTeoria { set; get; }
        public decimal IMC { set; get; }
        public decimal PorcGrasaAnalizador { set; get; }
        public decimal PorcGr_Bascula { set; get; }
        public decimal GB_BI { set; get; }
        public decimal GB_BD { set; get; }
        public decimal GB_PI { set; get; }
        public decimal GB_PD { set; get; }
        public decimal GB_Tronco { set; get; }
        public decimal AguaCorporal { set; get; }
        public decimal MasaOsea { set; get; }
        public decimal Complexión { set; get; }
        public decimal EdadMetabolica { set; get; }
        public decimal Cintura { set; get; }
        public decimal Abdomen { set; get; }
        public decimal Cadera { set; get; }
        public string Muslo { set; get; }
        public decimal CBM { set; get; }
        public decimal CircunfMunneca { set; get; }
        public decimal PorcentGViceral { set; get; }
        public decimal PorcentMusculo { set; get; }
        public decimal PM_BI { set; get; }
        public decimal PM_PD { set; get; }
        public decimal PM_BD { set; get; }
        public decimal PM_PI { set; get; }
        public decimal PM_Tronco { set; get; }
        public string Observaciones { set; get; }
        public decimal GEB { set; get; }
        public decimal GET { set; get; }
        public decimal CHOPorc { set; get; }
        public decimal CHOGram { set; get; }
        public decimal CHO_kcal { set; get; }
        public decimal ProteinaPorc { set; get; }
        public decimal ProteinaGram { set; get; }
        public decimal Proteinakcal { set; get; }
        public decimal GrasaPorc { set; get; }
        public decimal GrasaGram { set; get; }
        public decimal Grasakcal { set; get; }

        public TOAntropometria(string cedula, decimal talla, decimal pesoIdeal, decimal edad, decimal pMB, decimal peso, decimal pesoMaxTeoria, decimal iMC, decimal porcGrasaAnalizador, decimal porcGr_Bascula, decimal gB_BI, decimal gB_BD, decimal gB_PI, decimal gB_PD, decimal gB_Tronco, decimal aguaCorporal, decimal masaOsea, decimal complexión, decimal edadMetabolica, decimal cintura, decimal abdomen, decimal cadera, string muslo, decimal cBM, decimal circunfMunneca, decimal porcentGViceral, decimal porcentMusculo, decimal pM_BI, decimal pM_PD, decimal pM_BD, decimal pM_PI, decimal pM_Tronco, string observaciones, decimal gEB, decimal gET, decimal cHOPorc, decimal cHOGram, decimal cHO_kcal, decimal proteinaPorc, decimal proteinaGram, decimal proteinakcal, decimal grasaPorc, decimal grasaGram, decimal grasakcal)
        {
            Cedula = cedula;
            Talla = talla;
            PesoIdeal = pesoIdeal;
            Edad = edad;
            PMB = pMB;
            Peso = peso;
            PesoMaxTeoria = pesoMaxTeoria;
            IMC = iMC;
            PorcGrasaAnalizador = porcGrasaAnalizador;
            PorcGr_Bascula = porcGr_Bascula;
            GB_BI = gB_BI;
            GB_BD = gB_BD;
            GB_PI = gB_PI;
            GB_PD = gB_PD;
            GB_Tronco = gB_Tronco;
            AguaCorporal = aguaCorporal;
            MasaOsea = masaOsea;
            Complexión = complexión;
            EdadMetabolica = edadMetabolica;
            Cintura = cintura;
            Abdomen = abdomen;
            Cadera = cadera;
            Muslo = muslo;
            CBM = cBM;
            CircunfMunneca = circunfMunneca;
            PorcentGViceral = porcentGViceral;
            PorcentMusculo = porcentMusculo;
            PM_BI = pM_BI;
            PM_PD = pM_PD;
            PM_BD = pM_BD;
            PM_PI = pM_PI;
            PM_Tronco = pM_Tronco;
            Observaciones = observaciones;
            GEB = gEB;
            GET = gET;
            CHOPorc = cHOPorc;
            CHOGram = cHOGram;
            CHO_kcal = cHO_kcal;
            ProteinaPorc = proteinaPorc;
            ProteinaGram = proteinaGram;
            Proteinakcal = proteinakcal;
            GrasaPorc = grasaPorc;
            GrasaGram = grasaGram;
            Grasakcal = grasakcal;
        }
        public TOAntropometria() { }

    }
}
