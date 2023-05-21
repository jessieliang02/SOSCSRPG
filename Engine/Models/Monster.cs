using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
        public string ImageName { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; private set; }

        public Monster(string name, string imageName,
            int maximumHitPoints, int currentHitPoints,
            int rewardExperiencePoints, int gold, 
            int minimumDamage, int maximumDamage) : base(name, maximumHitPoints, currentHitPoints, gold)
        {
            ImageName = string.Format("pack://application:,,,/Engine;component/Images/Monsters/{0}", imageName);
            RewardExperiencePoints = rewardExperiencePoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
        }
    }
}
