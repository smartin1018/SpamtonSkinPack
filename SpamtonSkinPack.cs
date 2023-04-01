using KitchenData;
using KitchenLib.Customs;
using KitchenLib.Utils;
using KitchenPlayerModelLib;
using UnityEngine;

namespace KitchenSpamton
{
    public class SpamtonPlayerModel : CustomPlayerModel
    {
        public override string UniqueNameID => "SpamtonPlayerModel";
        public override GameObject Prefab => (GameObject)Mod.Bundle.LoadAsset("assets/mod/spamton.prefab");

        public override Mesh Mesh => Prefab.GetComponentInChildren<SkinnedMeshRenderer>().sharedMesh;
        
        private Material SpamtonBody => CustomMaterials.GetCustomMaterial("Spamton Black");
        
        private Material SpamtonPinkGlass => CustomMaterials.GetCustomMaterial("Spamton Pink Glass");
        
        private Material SpamtonYellowGlass => CustomMaterials.GetCustomMaterial("Spamton Yellow Glass");

        public override Material[] Materials => new Material[]
        {
            null, SpamtonYellowGlass, SpamtonPinkGlass, SpamtonBody
        };
    }
}