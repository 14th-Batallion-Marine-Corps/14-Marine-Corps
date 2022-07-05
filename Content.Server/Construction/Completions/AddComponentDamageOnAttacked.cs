using Content.Server.Damage.Components;
using Content.Shared.Construction;
using Content.Shared.Damage;
using Content.Shared.Damage.Prototypes;
using JetBrains.Annotations;
using Robust.Shared.Prototypes;

namespace Content.Server.Construction.Completions
{
    [UsedImplicitly]
    [DataDefinition]
    public sealed class AddComponentDamageOnAttacked : IGraphAction
    {
        [DataField("ignoreResistances")]
        [ViewVariables(VVAccess.ReadWrite)]
        public bool IgnoreResistances = false;

        [DataField("damage", required: true)]
        [ViewVariables(VVAccess.ReadWrite)]
        public DamageSpecifier Damage { get; } = default!;

        public void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager)
        {
            var component = entityManager.AddComponent<DamageOnAttackedComponent>(uid);
            component.Damage = Damage;
            component.IgnoreResistances = IgnoreResistances;
        }
    }
}


