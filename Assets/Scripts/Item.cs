﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Item{

    [XmlAttribute("name")]
    public string name;

    [XmlElement("Damage")]
    public float damamge;

    [XmlElement("Durability")]
    public float durability;
}
