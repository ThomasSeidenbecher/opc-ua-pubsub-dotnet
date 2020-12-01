﻿// Copyright 2020 Siemens AG
// SPDX-License-Identifier: MIT

using Binary;

namespace opc.ua.pubsub.dotnet.simulation.Excel.Model
{
    public class MetaConfig
    {
        public ConfigurationVersion ConfigurationVersion { get; set; }
        public string               MetaDataDescription  { get; set; }
        public string               MetaDataName         { get; set; }
    }
}