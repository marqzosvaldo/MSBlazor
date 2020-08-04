using System;
using Microsoft.AspNetCore.Components;

namespace MSBlazor.Client.Shared {
    partial class DismissableAlert {
        private bool show;
        [Parameter]
        public bool Show {
            get => this.show;
            set {
                if (value != this.show) {
                    this.show = value;
                    ShowChanged.InvokeAsync(this.show);
                }
            }
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public EventCallback<bool> ShowChanged { get; set; }

        public void Dismiss() => Show = false;

    }
}