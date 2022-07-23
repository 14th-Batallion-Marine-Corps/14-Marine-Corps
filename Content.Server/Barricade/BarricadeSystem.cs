using Robust.Client.GameObjects;
using Content.Shared.Doors.Components;
using Content.Shared.Barricade;
using Content.Client.Damage;
using DrawDepth = Content.Shared.DrawDepth.DrawDepth;

namespace Content.Client.Barricade;

public sealed class BarricadeSystem : VisualizerSystem<BarricadeVisualsComponent>
{
    protected override void OnAppearanceChange(EntityUid uid, BarricadeVisualsComponent component, ref AppearanceChangeEvent args)
    {
        if (args.Sprite == null)
            return;


        if(args.Component.TryGetData(BarricadeVisuals.HasRazorwire, out bool hasRazorwire))
        {
            args.Sprite.LayerSetVisible(BarricadeVisualLayers.Razorwire, hasRazorwire);
        }
        var barricadeDirection = Direction.South;
        if (TryComp(uid, out TransformComponent? transform))
        {
            barricadeDirection = transform.LocalRotation.GetDir();
        }
        var barricadeOpen = args.Component.TryGetData(DoorVisuals.State, out DoorState isOpen) && isOpen == DoorState.Open;
        if(TryComp(uid, out DoorComponent? doorComp)){
            args.Sprite.DrawDepth = barricadeOpen ? (int) DrawDepth.Objects : (barricadeDirection == Direction.South) ? (int) DrawDepth.Doors : (int) DrawDepth.Objects;
            args.Sprite.LayerSetVisible(BarricadeVisualLayers.Base, barricadeOpen ? false : true);
            args.Sprite.LayerSetVisible(BarricadeVisualLayers.Closed, barricadeOpen ? true : false);
        }
        else
        {
            args.Sprite.DrawDepth = (barricadeDirection == Direction.South) ? (int) DrawDepth.Doors : (int) DrawDepth.Objects;
        }
        args.Sprite.LayerSetState(BarricadeVisualLayers.Razorwire, barricadeOpen ? component.RazorwireClosedState : component.RazorwireOpenState);
    }

}

public enum BarricadeVisualLayers
{
    Base,
    Closed,
    Razorwire
}
