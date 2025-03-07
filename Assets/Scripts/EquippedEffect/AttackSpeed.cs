using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CreatorKitCode;

public class AttackSpeed : EquipmentItem.EquippedEffect
{


     CharacterData m_Owner;
     EquipmentItem m_FeetSlot;

     public void Init(CharacterData owner)
        {
            m_Owner = owner;
        }

     public void InitShoes(EquipmentItem shoes, CharacterData data)
        {
            m_FeetSlot = shoes;
        }

     public override void Equipped(CharacterData user)
     {
          user.m_AttackCoolDown = user.m_AttackCoolDown - 5;
     }
     
     public override void Removed(CharacterData user)
     {
          user.m_AttackCoolDown = user.m_AttackCoolDown + 5;
     }
}
