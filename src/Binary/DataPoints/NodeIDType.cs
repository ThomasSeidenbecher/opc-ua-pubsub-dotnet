﻿// Copyright 2020 Siemens AG
// SPDX-License-Identifier: MIT

namespace Binary.DataPoints
{
    public enum NodeIDType
    {
        TimeSeries              = 0,
        Event                   = 1,
        File                    = 2,
        BuildInDataType         = 3,
        GroupDataTypeTimeSeries = 4,
        None                    = -1
    }
}