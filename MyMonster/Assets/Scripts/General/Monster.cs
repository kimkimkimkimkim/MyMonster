﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Monster
{
    //キャラクター固有の情報 CharacterDataはScriptableObjectを継承
	public int No; //図鑑番号
	public int uniqueID; //固有ID
	public int level; //レベル
	public int exp; //現在のレベルになってから獲得した経験値
}