using Shared.Structs;
using GameOffsets;
using Shared.Interfaces;
using SharpDX;

namespace PoEMemory.Components
{
    public class Positioned : Component
    {
        private CachedValue<PositionedComponentOffsets> _cachedValue;
        public PositionedComponentOffsets PositionedStruct => _cachedValue.Value;

        public Positioned() => _cachedValue = new FrameCache<PositionedComponentOffsets>(() => M.Read<PositionedComponentOffsets>(Address));


        public long OwnerAddress => PositionedStruct.OwnerAddress;
        public int GridX => PositionedStruct.GridX;
        public int GridY => PositionedStruct.GridY;
        public Vector2 GridPos => new Vector2(GridX, GridY);
        public Vector2i GridPosI => new Vector2i(GridX, GridY);
        public Vector2 WorldPos => PositionedStruct.WorldPosition;
        public Vector2 GridPosition => PositionedStruct.GridPosition;
        public float Rotation => PositionedStruct.Rotation;
        public float WorldX => PositionedStruct.WorldX;
        public float WorldY => PositionedStruct.WorldY;
        public float RotationDeg => Rotation * (180 / MathUtil.Pi);
        public byte Reaction => PositionedStruct.Reaction;
    }
}