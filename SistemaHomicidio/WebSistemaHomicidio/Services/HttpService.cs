using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WebSistemaHomicidio.Interfaces;
using WebSistemaHomicidio.ViewModels.Usuario;

namespace WebSistemaHomicidio.Services
{
    public class HttpService : IHttpService
    {
        private readonly HttpClient httpClient;
        private readonly NavigationManager navigationManager;
        private readonly ILocalStorageService localStorage;

        public HttpService(HttpClient httpClient, NavigationManager navigationManager, ILocalStorageService localStorage)
        {
            this.httpClient = httpClient;
            this.navigationManager = navigationManager;
            this.localStorage = localStorage;;
        }

        public async Task<T> Get<T>(string uri)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, uri);
            return await SendRequest<T>(request);
        }

        public async Task<T> Post<T>(string uri, object value)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, "https://localhost:44343/api/Usuarios/login")
            {
                Content = new StringContent(JsonSerializer.Serialize(value), Encoding.UTF8, "application/json")
            };
            return await SendRequest<T>(request);
        }

        private async Task<T> SendRequest<T>(HttpRequestMessage request)
        {
            //Adiciona o header jwt auth se o usuário estiver conectado e a solicitação for para o URL da API
            var usuario = await localStorage.GetItemAsync<ExibirUsuario>("usuario");
            if (usuario != null)
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", usuario.Token);

            var response = await httpClient.SendAsync(request);

            // Auto logout no caso de Status 401
            if(response.StatusCode == HttpStatusCode.Unauthorized)
            {
                navigationManager.NavigateTo("logout");
                return default;
            }

            // Lança exceção na resposta de erro
            if (!response.IsSuccessStatusCode)
            {
                var error = await response.Content.ReadFromJsonAsync<Dictionary<string, string>>();
                throw new Exception(error["message"]);
            }

            return await response.Content.ReadFromJsonAsync<T>();
        }
    }
}
