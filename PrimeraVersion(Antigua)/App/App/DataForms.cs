using Google.Protobuf.WellKnownTypes;
using System;

namespace App
{
    public static class DataForms
    {
        public static int incorrectasEstacionamientoE;
        public static int incorrectasEstacionamientoL;
        public static int incorrectasComedorE;
        public static int incorrectasComedorL;
        public static int incorrectasBarraE;
        public static int incorrectasBarraL;
        public static int incorrectasTortillasE;
        public static int incorrectasTortillasL;
        public static int incorrectasServiciosE;
        public static int incorrectasServiciosL;
        public static int incorrectasPlanchasE;
        public static int incorrectasPlanchasL;
        public static int incorrectasAreaLozaE;
        public static int incorrectasAreaLozaL;
        public static int incorrectasBañosE;
        public static int incorrectasBañosL;
        public static int incorrectasJuegosE;
        public static int incorrectasJuegosL;
        public static int incorrectasPersonalPlanchas;
        public static int incorrectasPersonalLoza;
        public static int incorrectasPersonaAseo;
        public static int incorrectasPersonalTortilla;
        public static int incorrectasPersonalBarra;
        public static int incorrectasPersonalMesas;
        public static int incorrectasPersonalServicios;
        public static int incorrectasDocumentos;
        public static int incorrectasCaja;
        public static int incorrectasAlmacen;
        public static int incorrectasAmbiente;

        public static bool uno = false;
        public static bool dos = false;
        public static bool tres = false;
        public static bool cuatro = false;
        public static bool cinco = false;


        public static DateTime hora;
        public static DateTime fecha;
        public static string sucursal;
        public static string encargado;
        public static string auditor;

        public static string[] estacionamientoEstructura = new string[30];
        public static string[] estacionamientoLimpieza = new string[30];

        public static string[] comedorEstructura = new string[35];
        public static string[] comedorLimpieza = new string[35];

        public static string[] barraEstructura = new string[130];
        public static string[] barraLimpieza = new string[30];

        public static string[] tortillasEstructura = new string[35];
        public static string[] tortillasLimpieza = new string[35];

        public static string[] serviciosEstructura = new string[35];
        public static string[] serviciosLimpieza = new string[35];

        public static string[] planchasEstructura = new string[35];
        public static string[] planchasLimpieza = new string[35];

        public static string[] areaLozaEstructura = new string[35];
        public static string[] areaLozaLimpieza = new string[35];

        public static string[] bañosEstructura = new string[35];
        public static string[] bañosLimpieza = new string[35];

        public static string[] juegosEstructura = new string[35];
        public static string[] juegosLimpieza = new string[30];

        public static string[] personalPlanchas = new string[35];
        public static string[] personalLoza = new string[35];

        public static string[] personaAseo = new string[35];
        public static string[] personalTortilla = new string[35];

        public static string[] personalBarra = new string[35];
        public static string[] personalMesas = new string[35];

        public static string[] personalServicios = new string[9];
        public static string[] documentos = new string[6];

        public static string[] caja = new string[35];
        public static string[] almacen = new string[35];

        public static string[] ambiente = new string[35];

        public static string[] calificacionProovedores = new string[11];
        public static int[] herramienta = new int[6];

        public static bool checkBaños;
        public static bool checkPersonal;
        public static bool checkCocina;
        public static bool checkComedor;
        public static bool checkGerente;

        public static int traposCocina;
        public static int traposMesas;
        public static int traposBanios;
        public static int traposCaja;

        public static string[] sabor = new string[6];
        public static string[] temperatura = new string[6];
        public static int cloracion;

        public static string observacionGas = "Sin Observacion";
        public static string observacionFumigacion = "Sin Observacion";
        public static string observacionTrampa = "Sin Observacion";
        public static string observacionFilete = "Sin Observacion";
        public static string observacionMasa = "Sin Observacion";
        public static string observacionPostres = "Sin Observacion";
        public static string observacionRefresco = "Sin Observacion";
        public static string observacionCerveza = "Sin Observacion";
        public static string observacionAlmacen = "Sin Observacion";
        public static string observacionBasura = "Sin Observacion";
        public static string observacionMantenimiento = "Sin Observacion";


        public static void LimpiarDatos()
        {
            // Limpiar variables de tipo string
            hora = DateTime.MinValue;
            fecha = DateTime.MinValue;
            sucursal = "";
            encargado = "";
            auditor = "";

            // Limpiar variables de tipo int
            cloracion = 0;

            // Limpiar arreglos de tipo string
            for (int i = 0; i < estacionamientoEstructura.Length; i++)
            {
                estacionamientoEstructura[i] = "";
            }
            for (int i = 0; i < estacionamientoLimpieza.Length; i++)
            {
                estacionamientoLimpieza[i] = "";
            }

            for (int i = 0; i < comedorEstructura.Length; i++)
            {
                comedorEstructura[i] = "";
            }
            for (int i = 0; i < comedorLimpieza.Length; i++)
            {
                comedorLimpieza[i] = "";
            }

            for (int i = 0; i < barraEstructura.Length; i++)
            {
                barraEstructura[i] = "";
            }
            for (int i = 0; i < barraLimpieza.Length; i++)
            {
                barraLimpieza[i] = "";
            }

            for (int i = 0; i < tortillasEstructura.Length; i++)
            {
                tortillasEstructura[i] = "";
            }
            for (int i = 0; i < tortillasLimpieza.Length; i++)
            {
                tortillasLimpieza[i] = "";
            }

            for (int i = 0; i < serviciosEstructura.Length; i++)
            {
                serviciosEstructura[i] = "";
            }
            for (int i = 0; i < serviciosLimpieza.Length; i++)
            {
                serviciosLimpieza[i] = "";
            }

            for (int i = 0; i < planchasEstructura.Length; i++)
            {
                planchasEstructura[i] = "";
            }
            for (int i = 0; i < planchasLimpieza.Length; i++)
            {
                planchasLimpieza[i] = "";
            }

            for (int i = 0; i < areaLozaEstructura.Length; i++)
            {
                areaLozaEstructura[i] = "";
            }
            for (int i = 0; i < areaLozaLimpieza.Length; i++)
            {
                areaLozaLimpieza[i] = "";
            }

            for (int i = 0; i < bañosEstructura.Length; i++)
            {
                bañosEstructura[i] = "";
            }
            for (int i = 0; i < bañosLimpieza.Length; i++)
            {
                bañosLimpieza[i] = "";
            }

            for (int i = 0; i < juegosEstructura.Length; i++)
            {
                juegosEstructura[i] = "";
            }
            for (int i = 0; i < juegosLimpieza.Length; i++)
            {
                juegosLimpieza[i] = "";
            }

            for (int i = 0; i < personalPlanchas.Length; i++)
            {
                personalPlanchas[i] = "";
            }
            for (int i = 0; i < personalLoza.Length; i++)
            {
                personalLoza[i] = "";
            }

            for (int i = 0; i < personaAseo.Length; i++)
            {
                personaAseo[i] = "";
            }
            for (int i = 0; i < personalTortilla.Length; i++)
            {
                personalTortilla[i] = "";
            }

            for (int i = 0; i < personalBarra.Length; i++)
            {
                personalBarra[i] = "";
            }
            for (int i = 0; i < personalMesas.Length; i++)
            {
                personalMesas[i] = "";
            }

            for (int i = 0; i < personalServicios.Length; i++)
            {
                personalServicios[i] = "";
            }
            for (int i = 0; i < documentos.Length; i++)
            {
                documentos[i] = "";
            }

            for (int i = 0; i < caja.Length; i++)
            {
                caja[i] = "";
            }
            for (int i = 0; i < almacen.Length; i++)
            {
                almacen[i] = "";
            }

            for (int i = 0; i < ambiente.Length; i++)
            {
                ambiente[i] = "";
            }

            for (int i = 0; i < calificacionProovedores.Length; i++)
            {
                calificacionProovedores[i] = "";
            }
            for (int i = 0; i < herramienta.Length; i++)
            {
                herramienta[i] = 0;
            }

            for (int i = 0; i < sabor.Length; i++)
            {
                sabor[i] = "";
            }
            for (int i = 0; i < temperatura.Length; i++)
            {
                temperatura[i] = "";
            }

            //Limpiar observaciones
            observacionGas = "Sin Observacion";
            observacionFumigacion = "Sin Observacion";
            observacionTrampa = "Sin Observacion";
            observacionFilete = "Sin Observacion";
            observacionMasa = "Sin Observacion";
            observacionPostres = "Sin Observacion";
            observacionRefresco = "Sin Observacion";
            observacionCerveza = "Sin Observacion";
            observacionAlmacen = "Sin Observacion";
            observacionBasura = "Sin Observacion";
            observacionMantenimiento = "Sin Observacion";
        }

        public static string[] areas = {"estacionamientoEstructura",
                                        "estacionamientoLimpieza",
                                        "comedorEstructura",
                                        "comedorLimpieza",
                                        "barraEstructura",
                                        "barraLimpieza",
                                        "tortillasEstructura",
                                        "tortillasLimpieza",
                                        "serviciosEstructura",
                                        "serviciosLimpieza",
                                        "planchasEstructura",
                                        "planchasLimpieza",
                                        "areaLozaEstructura",
                                        "areaLozaLimpieza",
                                        "bañosEstructura",
                                        "bañosLimpieza",
                                        "juegosEstructura",
                                        "juegosLimpieza",
                                        "personalPlanchas",
                                        "personalLoza",
                                        "personaAseo",
                                        "personalTortilla",
                                        "personalBarra",
                                        "personalMesas",
                                        "personalServicios",
                                        "documentos",
                                        "caja",
                                        "almacen",
                                        "ambiente",
                                        "calificacionProovedores",
                                        "existenciaHerramienta",
                                        "sabor",
                                        "temperatura"
        };
        public static void Contador()
        {
            // Reiniciar los contadores
            incorrectasEstacionamientoE = 0;
            incorrectasEstacionamientoL = 0;
            incorrectasComedorE = 0;
            incorrectasComedorL = 0;
            incorrectasBarraE = 0;
            incorrectasBarraL = 0;
            incorrectasTortillasE = 0;
            incorrectasTortillasL = 0;
            incorrectasServiciosE = 0;
            incorrectasServiciosL = 0;
            incorrectasPlanchasE = 0;
            incorrectasPlanchasL = 0;
            incorrectasAreaLozaE = 0;
            incorrectasAreaLozaL = 0;
            incorrectasBañosE = 0;
            incorrectasBañosL = 0;
            incorrectasJuegosE = 0;
            incorrectasJuegosL = 0;
            incorrectasPersonalPlanchas = 0;
            incorrectasPersonalLoza = 0;
            incorrectasPersonaAseo = 0;
            incorrectasPersonalTortilla = 0;
            incorrectasPersonalBarra = 0;
            incorrectasPersonalMesas = 0;
            incorrectasPersonalServicios = 0;
            incorrectasDocumentos = 0;
            incorrectasCaja = 0;
            incorrectasAlmacen = 0;
            incorrectasAmbiente = 0;

            // Contar 'N' en estacionamientoEstructura
            for (int i = 0; i < estacionamientoEstructura.Length; i++)
            {
                if (estacionamientoEstructura[i] == "0")
                {
                    incorrectasEstacionamientoE++;
                }
            }

            // Contar 'N' en estacionamientoLimpieza
            for (int i = 0; i < estacionamientoLimpieza.Length; i++)
            {
                if (estacionamientoLimpieza[i] == "0")
                {
                    incorrectasEstacionamientoL++;
                }
            }

            // Contar 'N' en comedorEstructura
            for (int i = 0; i < comedorEstructura.Length; i++)
            {
                if (comedorEstructura[i] == "0")
                {
                    incorrectasComedorE++;
                }
            }

            // Contar 'N' en comedorLimpieza
            for (int i = 0; i < comedorLimpieza.Length; i++)
            {
                if (comedorLimpieza[i] == "0")
                {
                    incorrectasComedorL++;
                }
            }

            // Contar 'N' en barraEstructura
            for (int i = 0; i < barraEstructura.Length; i++)
            {
                if (barraEstructura[i] == "0")
                {
                    incorrectasBarraE++;
                }
            }

            // Contar 'N' en barraLimpieza
            for (int i = 0; i < barraLimpieza.Length; i++)
            {
                if (barraLimpieza[i] == "0")
                {
                    incorrectasBarraL++;
                }
            }

            // Contar 'N' en tortillasEstructura
            for (int i = 0; i < tortillasEstructura.Length; i++)
            {
                if (tortillasEstructura[i] == "0")
                {
                    incorrectasTortillasE++;
                }
            }

            // Contar 'N' en tortillasLimpieza
            for (int i = 0; i < tortillasLimpieza.Length; i++)
            {
                if (tortillasLimpieza[i] == "0")
                {
                    incorrectasTortillasL++;
                }
            }

            // Contar 'N' en serviciosEstructura
            for (int i = 0; i < serviciosEstructura.Length; i++)
            {
                if (serviciosEstructura[i] == "0")
                {
                    incorrectasServiciosE++;
                }
            }

            // Contar 'N' en serviciosLimpieza
            for (int i = 0; i < serviciosLimpieza.Length; i++)
            {
                if (serviciosLimpieza[i] == "0")
                {
                    incorrectasServiciosL++;
                }
            }

            // Contar 'N' en planchasEstructura
            for (int i = 0; i < planchasEstructura.Length; i++)
            {
                if (planchasEstructura[i] == "0")
                {
                    incorrectasPlanchasE++;
                }
            }

            // Contar 'N' en planchasLimpieza
            for (int i = 0; i < planchasLimpieza.Length; i++)
            {
                if (planchasLimpieza[i] == "0")
                {
                    incorrectasPlanchasL++;
                }
            }

            // Contar 'N' en areaLozaEstructura
            for (int i = 0; i < areaLozaEstructura.Length; i++)
            {
                if (areaLozaEstructura[i] == "0")
                {
                    incorrectasAreaLozaE++;
                }
            }

            // Contar 'N' en areaLozaLimpieza
            for (int i = 0; i < areaLozaLimpieza.Length; i++)
            {
                if (areaLozaLimpieza[i] == "0")
                {
                    incorrectasAreaLozaL++;
                }
            }

            // Contar 'N' en bañosEstructura
            for (int i = 0; i < bañosEstructura.Length; i++)
            {
                if (bañosEstructura[i] == "0")
                {
                    incorrectasBañosE++;
                }
            }

            // Contar 'N' en bañosLimpieza
            for (int i = 0; i < bañosLimpieza.Length; i++)
            {
                if (bañosLimpieza[i] == "0")
                {
                    incorrectasBañosL++;
                }
            }

            // Contar 'N' en juegosEstructura
            for (int i = 0; i < juegosEstructura.Length; i++)
            {
                if (juegosEstructura[i] == "0")
                {
                    incorrectasJuegosE++;
                }
            }

            // Contar 'N' en juegosLimpieza
            for (int i = 0; i < juegosLimpieza.Length; i++)
            {
                if (juegosLimpieza[i] == "0")
                {
                    incorrectasJuegosL++;
                }
            }

            // Contar 'N' en personalPlanchas
            for (int i = 0; i < personalPlanchas.Length; i++)
            {
                if (personalPlanchas[i] == "0")
                {
                    incorrectasPersonalPlanchas++;
                }
            }

            // Contar 'N' en personalLoza
            for (int i = 0; i < personalLoza.Length; i++)
            {
                if (personalLoza[i] == "0")
                {
                    incorrectasPersonalLoza++;
                }
            }

            // Contar 'N' en personaAseo
            for (int i = 0; i < personaAseo.Length; i++)
            {
                if (personaAseo[i] == "0")
                {
                    incorrectasPersonaAseo++;
                }
            }

            // Contar 'N' en personalTortilla
            for (int i = 0; i < personalTortilla.Length; i++)
            {
                if (personalTortilla[i] == "0")
                {
                    incorrectasPersonalTortilla++;
                }
            }

            // Contar 'N' en personalBarra
            for (int i = 0; i < personalBarra.Length; i++)
            {
                if (personalBarra[i] == "0")
                {
                    incorrectasPersonalBarra++;
                }
            }

            // Contar 'N' en personalMesas
            for (int i = 0; i < personalMesas.Length; i++)
            {
                if (personalMesas[i] == "0")
                {
                    incorrectasPersonalMesas++;
                }
            }

            // Contar 'N' en personalServicios
            for (int i = 0; i < personalServicios.Length; i++)
            {
                if (personalServicios[i] == "0")
                {
                    incorrectasPersonalServicios++;
                }
            }

            // Contar 'N' en documentos
            for (int i = 0; i < documentos.Length; i++)
            {
                if (documentos[i] == "0")
                {
                    incorrectasDocumentos++;
                }
            }

            // Contar 'N' en caja
            for (int i = 0; i < caja.Length; i++)
            {
                if (caja[i] == "0")
                {
                    incorrectasCaja++;
                }
            }

            // Contar 'N' en almacen
            for (int i = 0; i < almacen.Length; i++)
            {
                if (almacen[i] == "0")
                {
                    incorrectasAlmacen++;
                }
            }

            // Contar 'N' en ambiente
            for (int i = 0; i < ambiente.Length; i++)
            {
                if (ambiente[i] == "0")
                {
                    incorrectasAmbiente++;
                }
            }
        }

    }

}

