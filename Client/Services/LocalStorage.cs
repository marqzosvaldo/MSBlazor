using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace MSBlazor.Client.Services {
    public class LocalStorage : ILocalStorage {

        private readonly IJSRuntime _jSRuntime;

        public LocalStorage(IJSRuntime jsRuntime) => _jSRuntime = jsRuntime;
        public async Task<T> GetProperty<T>(string propName) => await _jSRuntime.InvokeAsync<T>("blazorLocalStorage.get", propName);

        public async Task<object> SetProperty<T>(string propName, T value) => await _jSRuntime.InvokeAsync<object>("blazorLocalStorage.set", propName, value);

        public async Task<object> WatchAsync<T>(T instance) where T : class => await _jSRuntime.InvokeAsync<object>("blazorLocalStorage.watch", DotNetObjectReference.Create<T>(instance));
    }
}