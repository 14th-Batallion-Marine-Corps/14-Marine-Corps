namespace Content.Server.Wieldable.Components
{
    [RegisterComponent, Access(typeof(WieldableSystem))]
    public sealed class MovementSpeedModifierOnWieldComponent : Component
    {
        [DataField("walkModifier", required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public float WalkModifier = 1.0f;

        [DataField("sprintModifier", required: true)] [ViewVariables(VVAccess.ReadWrite)]
        public float SprintModifier = 1.0f;
    }
}
