namespace Content.Client.Barricade;

[RegisterComponent]
public sealed class BarricadeVisualsComponent : Component
{

    [DataField("razorwireOpenState", required: true)]
    public string RazorwireOpenState = default!;

    [DataField("razorwireClosedState", required: true)]
    public string RazorwireClosedState = default!;
}
