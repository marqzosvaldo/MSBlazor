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
                    ShowChanged?.Invoke(this.show);
                }
            }
        }

        [Parameter]
        public RenderFragment ChildContent { get; set; }

        [Parameter]
        public Action<bool> ShowChanged { get; set; }

        public void Dismiss() => Show = false;

    }
}