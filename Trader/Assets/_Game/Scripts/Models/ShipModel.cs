﻿using UnityEngine;
using System.Collections;
using NeuralNetwork;
using CodeControl;

public class ShipModel: Model {

    public string name;

    public StructureType type = StructureType.Ship;
    public ModelRef<CreatureModel> owner;
    public ModelRef<CreatureModel> worker;

    public Vector3 position;

    public int capacity;
    internal int index = 0;
    public float speed;
    public float rotateSpeed = 1f;

    public float money = 1000;
    public float runningCost = .1f;

    public Items item = new Items("Nothing", 0);

    public Items fuel = new Items("Fuel", 100);
    public float fuelEfficiency = 5;
    public int fuelCapacity = 100;

}