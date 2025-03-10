using System;
using Server.Network;
using Server.Items;

namespace Server.Items
{
	[FlipableAttribute( 0x13B9, 0x13Ba )]
	public class VikingSword : BaseSword
	{
		public override WeaponAbility PrimaryAbility{ get{ return WeaponAbility.CrushingBlow; } }
		public override WeaponAbility SecondaryAbility{ get{ return WeaponAbility.ParalyzingBlow; } }

		/*public override int AosStrengthReq{ get{ return 40; } }
		public override int AosMinDamage{ get{ return 15; } }
		public override int AosMaxDamage{ get{ return 17; } }
		public override int AosSpeed{ get{ return 28; } }
		public override float MlSpeed{ get{ return 3.75f; } }

		public override int OldStrengthReq{ get{ return 40; } }
		public override int OldMinDamage{ get{ return 6; } }
		public override int OldMaxDamage{ get{ return 34; } }
		public override int OldSpeed{ get{ return 30; } }*/
		
		public override int InitMinHits{ get{ return 31; }}
		public override int InitMaxHits{ get{ return 100; }}
		
		public override int DefHitSound{ get{ return 0x237; } }
		public override int DefMissSound{ get{ return 0x23A; } }
		
		
		public override int uotMinMinDamage{ get{return 1;}}
		public override int uotMinMaxDamage{ get{return 2;}}
				
		public override int uotMaxMinDamage{ get{return 1;}}
		public override int uotMaxMaxDamage{ get{return 2;}}
		
		[CommandProperty(AccessLevel.Counselor, AccessLevel.GameMaster)]
		public override float uotSpeed{ get{return 1f; }}
		
		
		[Constructable]
		public VikingSword(int level) : base( 0x13B9 ){
			Weight = 6.0;
			uotLevel = level;
		}
		
		[Constructable]
		public VikingSword() : base( 0x13B9 ){
			Weight = 6.0;
			uotLevel = 0;
		}

		public VikingSword( Serial serial ) : base( serial )
		{
		}

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );

			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}