using Terraria.ID;
using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Tremor.NPCs {

public class PyramidRider : ModNPC
{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyramid Rider");
			Main.npcFrameCount[npc.type] = 6;
		}
 
    public override void SetDefaults()
    {
        npc.lifeMax = 116;
        npc.damage = 20;
        npc.defense = 10;
        npc.knockBackResist = 0.6f;
        npc.width = 76;
        npc.height = 38;
        animationType = 508;
        npc.aiStyle = 26;
        npc.npcSlots = 0.5f;
        npc.HitSound = SoundID.NPCHit1;
        npc.value = Item.buyPrice(0, 0, 5, 0);
    }

    public override void HitEffect(int hitDirection, double damage)
    {
        if(npc.life <= 0)
        {
            for(int k = 0; k < 20; k++)
            {
                Dust.NewDust(npc.position, npc.width, npc.height, 18, 2.5f * (float)hitDirection, -2.5f, 0, default(Color), 0.7f);
            }
NPC.NewNPC((int)npc.position.X, (int)npc.position.Y + 55, 508);
NPC.NewNPC((int)npc.position.X - 22, (int)npc.position.Y + 55, mod.NPCType("PyramidHead"));
        }
}

    public override void NPCLoot()
    {
        if (Main.netMode != 1)
        {
            int centerX = (int)(npc.position.X + (float)(npc.width / 2)) / 16;
            int centerY = (int)(npc.position.Y + (float)(npc.height / 2)) / 16;
            int halfLength = npc.width / 2 / 16 + 1;
        }
    }

    public override void ScaleExpertStats(int numPlayers, float bossLifeScale)
    {
        npc.lifeMax = (int)(npc.lifeMax * 1);
        npc.damage = (int)(npc.damage * 1);
    }

    public override float SpawnChance(NPCSpawnInfo spawnInfo)
    {
        int x = spawnInfo.spawnTileX;
        int y = spawnInfo.spawnTileY;
        int tile = (int)Main.tile[x, y].type;
        return (Tremor.NormalSpawn(spawnInfo) && Tremor.NoZoneAllowWater(spawnInfo)) &&  spawnInfo.player.ZoneDesert && NPC.downedBoss1 && !Main.dayTime && y < Main.worldSurface ? 0.03f : 0f;
    }
}}