using Godot;
using System;

namespace GodotGameTools
{
    public partial class PlayerMover : RigidBody3D
    {
        private const int MoveForce = 2;
        private Vector3 moveDirection = Vector3.Zero;

        public override void _Input(InputEvent @event)
        {

            if (@event.IsActionPressed("moveFwd"))
            {
                AddForce(-Vector3.Left * MoveForce);
            }

            if (@event.IsActionPressed("moveBack"))
            {
                AddForce(Vector3.Left * MoveForce);
            }

            if (@event.IsActionPressed("moveRight"))
            {
                AddForce(Vector3.Back * MoveForce);
            }

            if (@event.IsActionPressed("moveLeft"))
            {
                AddForce(Vector3.Forward * MoveForce);
            }
            
            if (@event.IsActionReleased("moveFwd") || @event.IsActionReleased("moveBack") ||
                @event.IsActionReleased("moveRight") || @event.IsActionReleased("moveLeft"))
            {
                moveDirection = Vector3.Zero;
            }

        }

        public override void _PhysicsProcess(double delta)
        {
            ApplyForce(moveDirection);
        }

        private void AddForce(Vector3 direction)
        {
            moveDirection += direction;
        }
    }
}

