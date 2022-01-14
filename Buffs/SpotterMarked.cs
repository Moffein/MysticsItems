using RoR2;
using UnityEngine;
using Mono.Cecil.Cil;
using MonoMod.Cil;
using MysticsRisky2Utils;
using MysticsRisky2Utils.BaseAssetTypes;

namespace MysticsItems.Buffs
{
    public class SpotterMarked : BaseBuff
    {
        public override void OnLoad() {
            buffDef.name = "MysticsItems_SpotterMarked";
            buffDef.buffColor = new Color32(214, 58, 58, 255);
            buffDef.isDebuff = true;
            buffDef.iconSprite = Main.AssetBundle.LoadAsset<Sprite>("Assets/Buffs/SpotterMarked.png");

            Items.Spotter.buffDef = buffDef;

            GenericGameEvents.BeforeTakeDamage += (damageInfo, attackerInfo, victimInfo) =>
            {
                if (victimInfo.body.HasBuff(buffDef)) damageInfo.crit = true;
            };

            Overlays.CreateOverlay(Main.AssetBundle.LoadAsset<Material>("Assets/Items/Spotter/matSpotterMarked.mat"), delegate (CharacterModel model)
            {
                return model.body.HasBuff(buffDef);
            });
        }
    }
}
