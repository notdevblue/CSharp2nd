using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject ItemPrefab;
    public GameObject root;

    public List<Item> ItemList = new List<Item>();
    public List<ItemInfo> DisplayItemList = new List<ItemInfo>(); // 보여줄 아이템 목록

    public Button btnSortLevel;
    public Button btnSortName;

    private void Start()
    {
        btnSortLevel.onClick.AddListener(() => Sort(0));
        btnSortName.onClick.AddListener(() => Sort(1));

        DisplayItemList.Add(new ItemInfo() { Type = 1, Name = "Bag", Grade = 2, Level = 1, Prefab = "itemicon/bag" });
        DisplayItemList.Add(new ItemInfo() { Type = 2, Name = "Axe", Grade = 2, Level = 1, Prefab = "itemicon/axe" });
        DisplayItemList.Add(new ItemInfo() { Type = 1, Name = "Apple", Grade = 2, Level = 1, Prefab = "itemicon/apple" });
        DisplayItemList.Add(new ItemInfo() { Type = 1, Name = "Boots", Grade = 2, Level = 1, Prefab = "itemicon/boots" });
    }

    void Refresh()
    {
        RemoveAll();
        foreach(var item in DisplayItemList)
        {
            AddItem(item);
        }
    }

    void RemoveAll()
    {
        ItemList.RemoveAll(a => a != null);
        DeleteRootChilds();
    }

    void DeleteRootChilds()
    {
        var child = root.GetComponentsInChildren<Item>();
        foreach(var iter in child) {
            if(iter != this.transform) Destroy(iter.gameObject);
        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) {
            AddItem(new ItemInfo() { Type = 1, Name = "Bag", Grade = 2, Level = 1, Prefab = "itemicon/bag" });
            AddItem(new ItemInfo() { Type = 1, Name = "Apple", Grade = 1, Level = 1, Prefab = "itemicon/apple" });
            AddItem(new ItemInfo() { Type = 2, Name = "Axe", Grade = 1, Level = 3, Prefab = "itemicon/axe" });
        }
    }

    Item AddItem(ItemInfo itemInfo)
    {
        GameObject go = Instantiate(ItemPrefab);
        go.transform.SetParent(root.transform);

        Item item = go.GetComponent<Item>();
        item.Setup(Guid.NewGuid().ToString(), itemInfo, Callback);

        ItemList.Add(item);
        return item;
    }

    void Callback(string uid)
    {
        Item item = FindItem(uid);
        RemoveItem(item);
    }

    void RemoveItem(Item item)
    {
        ItemList.Remove(item);
        Destroy(item.gameObject);
    }

    Item FindItem(string _uid)
    {
        Item item = ItemList.Find(a => a.iteminfo.UID == _uid);
        return item;
    }


    void Sort(int m)
    {
        if (m == 0) ItemList.Sort(CompareLevel);
        if (m == 1) ItemList.Sort(CompareName);
    }

    public int CompareLevel(object x, object y)
    {
        Item a = x as Item;
        Item b = y as Item;

        return a.iteminfo.Level.CompareTo(b.iteminfo.Level);
    }

    public int CompareName(object x, object y)
    {
        Item a = x as Item;
        Item b = y as Item;

        return a.iteminfo.Name.CompareTo(b.iteminfo.Name);
    }


}
