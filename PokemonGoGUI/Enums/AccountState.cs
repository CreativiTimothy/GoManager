﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGoGUI.Enums
{
    public enum AccountState
    {
        Good,
        PermAccountBan,
        PokemonBanOrPokestopBanTemp,
        PokemonBanAndPokestopBanTemp,
        PokestopBanTemp,
        PokemonBanTemp,
        NotVerified
    }
}
