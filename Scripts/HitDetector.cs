using Godot;
using System;

namespace GodotGameTools
{
    public partial class HitDetector : RigidBody3D
    {
        private Transform3D transform;
        private IHitCounter hitCounter;

        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
            transform = Transform;
            hitCounter = GetNode<IHitCounter>("../../hit counter");
            ContactMonitor = true;
            MaxContactsReported = 1;
            BodyEntered += node =>
            {
                GD.Print("something hit me!");
                if(node.HasMeta("tag") && node.GetMeta("tag").AsString() == "level") return;
                GD.Print("Hit!");
                hitCounter.RegisterHit();
                QueueFree();
            };
        }
    }
}

