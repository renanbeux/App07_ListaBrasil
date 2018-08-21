using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App07_ListaBrasil.Modelo;
using Newtonsoft.Json;

namespace App07_ListaBrasil.Servico
{
    public class Servico
    {
        private static string UrlEstado = "https://servicodados.ibge.gov.br/api/v1/localidades/estados";
        private static string UrlMunicipio = "https://servicodados.ibge.gov.br/api/v1/localidades/estados/{0}/municipios";

        public static List<Estado> GetEstados()
        {
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(UrlEstado);

            return JsonConvert.DeserializeObject<List<Estado>>(conteudo);
        }

        public static List<Municipio> GetMunicipio(int estado)
        {
            string NewUrl = string.Format(UrlMunicipio, estado);
            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(NewUrl);

            return JsonConvert.DeserializeObject<List<Municipio>>(conteudo);
        }
    }
}
