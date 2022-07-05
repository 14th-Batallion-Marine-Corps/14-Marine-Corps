using Content.Server.Damage.Components;
using Content.Shared.Construction;
using JetBrains.Annotations;

namespace Content.Server.Construction.Completions
{
    [UsedImplicitly]
    [DataDefinition]
    public sealed class RemoveComponentDamageOnAttacked : IGraphAction
    {
        public void PerformAction(EntityUid uid, EntityUid? userUid, IEntityManager entityManager)
        {
            entityManager.RemoveComponent<DamageOnAttackedComponent>(uid);
        }

    }

}

