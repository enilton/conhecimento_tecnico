using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace IEL_Application.Data
{
    public class EnderecoService
    {     

        private EnderecoService()
        {
        
        }

        public static EnderecoService GetServiceInstance()
        {
            return new EnderecoService();
        }

        public async Task<List<Estado>> GetEstados()
        {         
            List<Estado> Estados = new List<Estado>();

            using (var client = new HttpClient())
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                client.BaseAddress = new Uri(configuration.GetSection("IBGE_BaseURL").Value.ToString());
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage Res = await client.GetAsync("estados");
                
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    Estados = JsonConvert.DeserializeObject<List<Estado>>(response);
                }
                
            }

            return Estados;

        }

        public async Task<List<Municipio>> GetMuniciopiosPorEstado(string idEstado)
        {
            List<Municipio> Municipios = new List<Municipio>();

            using (var client = new HttpClient())
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                client.BaseAddress = new Uri(configuration.GetSection("IBGE_BaseURL").Value.ToString());
                client.DefaultRequestHeaders.Clear();
                HttpResponseMessage Res = await client.GetAsync("estados/" + idEstado + "/municipios");

                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result;
                    Municipios = JsonConvert.DeserializeObject<List<Municipio>>(response);
                }

            }

            return Municipios;

        }

        public async Task<RetornoCep> GetEnderecoPorCEP(string cep)
        {

           
            RetornoCep RetornoCep = new RetornoCep();

            if (cep != null)
            {
                using (var client = new HttpClient())
                {
                    var configuration = new ConfigurationBuilder()
                        .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .Build();

                    client.BaseAddress = new Uri(configuration.GetSection("VIACEP_BaseURL").Value.ToString());
                    client.DefaultRequestHeaders.Clear();
                    HttpResponseMessage Res = await client.GetAsync(cep.Replace("-", "") + "/json");

                    if (Res.IsSuccessStatusCode)
                    {
                        var response = Res.Content.ReadAsStringAsync().Result;
                        RetornoCep = JsonConvert.DeserializeObject<RetornoCep>(response);
                    }

                }
            }

            return RetornoCep;
        }

        public class Estado
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public string Sigla { get; set; }
        }

        public class Municipio
        {
            public int Id { get; set; }
            public string Nome { get; set; }
        }

        public class RetornoCep
        {
            public string Logradouro { get; set; }
        }


    }
}
