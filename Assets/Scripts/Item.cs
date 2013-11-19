﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour
{
	public Type type;
	public string itemName;
	public int cost;
	
	public enum Type {
		consumable,
		upgrade
	}
}