﻿// <copyright file="MMALStillPort.cs" company="Techyian">
// Copyright (c) Ian Auty. All rights reserved.
// Licensed under the MIT License. Please see LICENSE.txt for License info.
// </copyright>

using System;
using MMALSharp.Native;

namespace MMALSharp.Ports
{
    /// <summary>
    /// Represents a still image encoder/decoder port.
    /// </summary>
    public unsafe class MMALStillPort : MMALPortImpl
    {
        public MMALStillPort(MMAL_PORT_T* ptr, MMALComponentBase comp, PortType type, Guid guid)
            : base(ptr, comp, type, guid)
        {
        }

        public MMALStillPort(MMALPortImpl copyFrom)
            : base(copyFrom.Ptr, copyFrom.ComponentReference, copyFrom.PortType, copyFrom.Guid)
        {
        }
    }    
}
