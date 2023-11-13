using System;
using System.Collections.Generic;
using System.Linq;
using MathLib;
using System.Text;
using System.Threading.Tasks;

namespace MathForGames2025
{
    internal class ProjectileSpawner : Actor
    {
        private Actor _owner;
        private float _projectileSpeed;
        private string _projectileSpritePath;


        public ProjectileSpawner(Actor owner, Vector2 position, float projectileSpeed, string projectileSpritePath) : base("", position)
        {
            _owner = owner;
            Parent = _owner;
            _projectileSpeed = projectileSpeed;
            _projectileSpritePath = projectileSpritePath;

        }

        public void SpawnProjectile()
        {
            Bullets bullet = new Bullets(_projectileSpritePath, GlobalPosition, _owner, Facing*_projectileSpeed);
            Engine.AddActorToScene(bullet);
        }


    }
}
