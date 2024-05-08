using Godot;
using System;
using GodotGameTools;

namespace GodotGameTools
{
    public partial class HitCounter : Node, IHitCounter
    {
        private byte hitCount;
        private Control window;
        private RigidBody3D player;

        public override void _Ready()
        {
            window = GetNode<Control>("/root/Node3D/WinMessage");
            player = GetNode<RigidBody3D>("/root/Node3D/player/RigidBody3D");
        }

        public void RegisterHit()
        {
            hitCount++;
            if (hitCount != 4) return;
            player.Freeze = true;
            window.Visible = true;
        }
    }
}
