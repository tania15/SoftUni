﻿using MilitaryElite.Enums;
using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }

    }
}
