/*using Unity.Entities;
using Unity.Transforms;
using Unity.Physics;
using Unity.Mathematics;
using Unity.Jobs;
using UnityEngine;

public partial class PlayerMovementSystem : SystemBase
{
    protected override void OnUpdate()
    {
        float deltaTime = Time.DeltaTime;

        Entities.ForEach((ref PhysicsVelocity velocity, in Rotation rotation, in PlayerInputData input) =>
        {
            float3 move = new float3(input.Horizontal, 0f, input.Vertical);
            float3 forward = math.forward(rotation.Value);
            float3 right = math.cross(forward, math.up());

            float3 desiredVelocity = math.normalize(move.x * right + move.z * forward) * input.Speed;
            velocity.Linear = desiredVelocity;

            if (math.lengthsq(move) > 0.01f)
                velocity.Angular = float3.zero; // Ensure angular velocity is zero when moving
        }).Schedule();
    }
}
*/