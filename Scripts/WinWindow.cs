using Godot;
using System;

namespace GodotGameTools
{
    public partial class WinWindow : VSplitContainer
    {
        // Called when the node enters the scene tree for the first time.
        public override void _Ready()
        {
            var exitButton = GetNode<Button>("ColorRect/CenterContainer2/Button");
            exitButton.Pressed += () =>
            {
                GetTree().Quit();
            };
        }
    }
}
