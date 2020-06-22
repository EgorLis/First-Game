using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ItemTypes
{
    NONE = 0,
    WEAPON = 1,
    FOOD = 2,
    QUEST_ITEMS = 3,
    OTHER = 4
}

public enum WeaponTypes
{
    Melee = 1,
    Distance 
}


public class Items : MonoBehaviour
{
    
    private int m_count;
    private ItemTypes m_type;
    private static string m_name;
    public int Count
    {
        get
        {
            return m_count;
        }
        set
        {
            m_count = value;
        }
    }

    public ItemTypes Type
    {
        get
        {
            return m_type;
        }
        set
        {
            m_type = value;
        }
    }

    public string Name
    {
        get
        {
            return m_name;
        }
        set
        {
            m_name = value;
        }
    }
    public Items()
    {
        m_count = 0;
        m_type = ItemTypes.NONE;
        m_name = "";
    }
    
}

public class ball:Items
{
    public ball() 
    {
        Count = 1;
        Type = ItemTypes.OTHER;
        Name = "ball";
    }


}
