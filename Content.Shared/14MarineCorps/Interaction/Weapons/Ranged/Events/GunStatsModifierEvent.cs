namespace Content.Shared.Weapons.Ranged.Events;


[ByRefEvent]
public struct GunStatsModifierEvent
    {
        public Angle MinAngle = Angle.Zero;
        public Angle MaxAngle = Angle.Zero;

        public Angle AngleIncrease = Angle.Zero;

        public Angle AngleDecay = Angle.Zero;

        public GunStatsModifierEvent(Angle minAngle, Angle maxAngle, Angle angleIncrease, Angle angleDecay){
            MinAngle = minAngle;
            MaxAngle = maxAngle;
            AngleIncrease = angleIncrease;
            AngleDecay = angleDecay;
        }

    }
