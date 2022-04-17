﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    public static readonly Player Instance = new Player();

    public string Name { get; private set; }
    public Team MyTeam { get; private set; }

    public int Balance = Instance.MyTeam.Balance.Money;

    public int Income = Instance.MyTeam.Incom;

    private Player() { }
}
