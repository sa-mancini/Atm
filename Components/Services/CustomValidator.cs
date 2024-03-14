using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace FormApp.Services;

public class CustomValidator : ComponentBase {
    [CascadingParameter]
    private EditContext myContext { get; set; }

    protected override void OnParametersSet() {
        myContext.Validate();
    }
}