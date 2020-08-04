using System;
using System.Threading;
using Microsoft.AspNetCore.Components;

namespace MSBlazor.Client.Shared {
    public class Timer : ComponentBase {
        [Parameter]
        public double TimeInSeconds { get; set; }

        [Parameter]
        public Action Tick { get; set; }

        protected override void OnInitialized() {
            var timer = new System.Threading.Timer(
                callback: (_) =>{ InvokeAsync(() => Tick?.Invoke());this.StateHasChanged();}, state : null,
                dueTime : TimeSpan.FromSeconds(TimeInSeconds), period : Timeout.InfiniteTimeSpan);
        }
    }
}