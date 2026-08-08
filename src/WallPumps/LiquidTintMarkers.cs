namespace WallPumps
{
    /// <summary>
    /// Marker components used to recognise this mod's two liquid buildings from
    /// inside Harmony postfixes on ConduitConsumer / ConduitDispenser / BuildingComplete.
    ///
    /// Those postfixes run for every conduit building in the colony, so the test has to
    /// be allocation free. The obvious alternative - comparing gameObject.name against a
    /// literal - is not: Unity's Object.name getter marshals a fresh managed string on
    /// every call, which meant garbage proportional to the colony's plumbing count on
    /// every conduit tick.
    ///
    /// A tag or prefab-ID comparison would also work, but the gas and liquid variants of
    /// these buildings are configured with an identical component set, so an explicit
    /// marker is the least surprising way to tell them apart.
    /// </summary>
    public class LiquidWallVentTint : KMonoBehaviour
    {
    }

    /// <inheritdoc cref="LiquidWallVentTint"/>
    public class LiquidWallPumpTint : KMonoBehaviour
    {
    }
}
