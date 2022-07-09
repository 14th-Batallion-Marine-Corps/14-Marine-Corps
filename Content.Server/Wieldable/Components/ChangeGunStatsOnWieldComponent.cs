

namespace Content.Server.Wieldable.Components
{
    [RegisterComponent, Access(typeof(WieldableSystem))]
    public sealed class ChangeGunStatsOnWieldComponent : Component
    {
        [DataField("angleIncrease")]
        public Angle AngleIncrease = Angle.FromDegrees(0);

        [DataField("angleDecay")]
        public Angle AngleDecay = Angle.FromDegrees(0);

        [DataField("minAngle")]
        public Angle MinAngle = Angle.FromDegrees(0);

        [DataField("maxAngle")]
        public Angle MaxAngle = Angle.FromDegrees(0);
    }

}
