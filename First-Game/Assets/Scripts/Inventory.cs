using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int InventorySize = 100;

    private List<Items> m_items;
    private int m_realSize;
    private bool m_overload;

    public int Size
    {
        get
        {
            return m_realSize;
        }
    }

    public bool Overload
    {
        get
        {
            return m_overload;
        }
    }
    
    public List<Items> Items
    {
        get
        {
            return m_items;
        }
    }

    Inventory() 
    {
        m_items = new List<Items>();
        m_realSize = 0;
        m_overload = false;
    }

    ~Inventory()
    {
        m_items.Clear();
    }

    public void AddItem(Items item)
    {
        if(m_realSize < InventorySize)
        {
            m_items.Add(item);
            ++m_realSize;
        }
        else
        {
            m_overload = true;
        }
    }

    public void DeleteItem(string name)
    {
        for(int i=0;i<m_realSize;++i)
        {
            if (m_items[i].Name == name)
            {
                m_items.RemoveAt(i);
            }
        }
    }
}
