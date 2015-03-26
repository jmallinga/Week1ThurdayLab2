using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1ThurdayLab2
{
    public class LearningSkills
    {
        public enum StudentRank
        {
            beginner,
            grasshopper,
            journeyman,
            rockstar,
            ninja,
            jedi,
        }
        public StudentRank StudentLevel
        {
            get { return LevelIncrease; }
        }

        private StudentRank StudentLevel

















        static void Main(string[] args)
        {
        }
    }
}


//namespace ClassDemo
//{
//    public class IceSkate
//    {
//        public enum Sharpness
//        {
//            ReallyDull,
//            Dull,
//            Medium,
//            PrettySharp,
//            ReallySharp
//        }
//        public Sharpness BladeQuality
//        {
//            get { return bladeSharpness; }
//            // set { bladeSharpness = value;  }
//        }
//        private Sharpness bladeSharpness;

//        public string Material
//        {
//            get;
//            private set;
//        }

//        public IceSkate(string material)
//        {
//            this.Material = material;
//            bladeSharpness = Sharpness.ReallySharp;
//        }

//        public void StopAndSpraySnow()
//        {
//            this.bladeSharpness = Sharpness.Medium;
//        }
//    }

//    public class Examples
//    {
//        public void Example()
//        {
//            var skate = new IceSkate("leather");
//            // skate.BladeQuality = IceSkate.Sharpness.Medium;