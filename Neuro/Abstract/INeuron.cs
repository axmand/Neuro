﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuro.Abstract
{
    public interface INeuron
    {
    }

    public interface IActivationNeuron : INeuron
    {

    }

    /// <summary>
    /// recurrentNeuron
    /// </summary>
    public interface IRecurrentNeuron: INeuron
    {

    }

}