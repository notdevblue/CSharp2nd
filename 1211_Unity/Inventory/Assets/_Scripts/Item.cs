using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemInfo
{
    public string UID = string.Empty; // 고유아이디
    public int Type { get; set; } // 카테고리
    public string Name { get; set; } // 이름
    public int Grade { get; set; } // 등급
    public int Level { get; set; } // 레벨
    public string Prefab{ get; set; } // 스프라이트 이름
}

public class Item : MonoBehaviour
{
    public Text name_txt;
    public Text level_txt;
    public Text grade_txt;
    public Image icon_img;
    public Button ok_btn;

    public ItemInfo iteminfo = new ItemInfo();
    public Action<string> callback;

    public void Setup(string _uid, ItemInfo _itemInfo, Action<string> _act)
    {
        iteminfo.UID = _uid;
        iteminfo.Name = _itemInfo.Name;
        iteminfo.Grade = _itemInfo.Grade;
        iteminfo.Level = _itemInfo.Level;
        iteminfo.Prefab = _itemInfo.Prefab;
        callback = _act;
        ok_btn.onClick.AddListener(OnClick);

        Display();
    }

    public void Display()
    {
        name_txt.text = iteminfo.Name;
        icon_img.sprite = Resources.Load<Sprite>(iteminfo.Prefab);
    }

    void OnClick()
    {
        callback(iteminfo.UID);
    }




}
