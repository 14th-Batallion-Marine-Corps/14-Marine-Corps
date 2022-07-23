using Content.Server.Damage.Components;
using Content.Shared.Damage;
using Content.Shared.Weapons.Melee;

namespace Content.Server.Damage.Systems
{
    public class DamageOnAttackedSystem: EntitySystem
    {

        [Dependency] private readonly DamageableSystem _damageableSystem = default!;

        public override void Initialize()
        {
            base.Initialize();
            SubscribeLocalEvent<DamageOnAttackedComponent, AttackedEvent>(OnAttacked);
        }

        private void OnAttacked(EntityUid uid, DamageOnAttackedComponent component, AttackedEvent args)
        {
            _damageableSystem.TryChangeDamage(args.User, component.Damage, component.IgnoreResistances, false);
        }

    }
}


