﻿//******************************************************************************************************
//  time_package.cs - Gbtc
//
//  Copyright © 2020, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may not use this
//  file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  06/30/2020 - J. Ritchie Carroll
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using System.Threading;
using Timer = System.Timers.Timer;
using static go.builtin;

namespace go
{
    public static class time_package
    {
        public struct Time {
            public DateTime DateTime;
        }

        public static Time Now() => new Time { DateTime = DateTime.Now };

        public static int Weekday(this in Time time) => (int)time.DateTime.DayOfWeek;

        public static Time UTC(this in Time time) => new Time { DateTime = time.DateTime.ToUniversalTime() };

        public const int Sunday = 0;
        public const int Monday = 1;
        public const int Tuesday = 2;
        public const int Wednesday = 3;
        public const int Thursday = 4;
        public const int Friday = 5;
        public const int Saturday = 6;

        private class ChannelTimer
        {
            private readonly channel<Time> m_notify;
            private readonly Timer m_timer;

            public ChannelTimer(long ticks, bool autoReset)
            {
                m_notify = make_channel<Time>();
                m_timer = new Timer
                {
                    Interval = ticks / (double)TimeSpan.TicksPerMillisecond,
                    AutoReset = autoReset
                };
                m_timer.Elapsed += (_, e) => m_notify.Send(Now());
            }

            public channel<Time> Channel
            {
                get
                {
                    m_timer.Start();
                    return m_notify;
                }
            }
        }

        public const long Millisecond = TimeSpan.TicksPerMillisecond;

        public const long Second = TimeSpan.TicksPerSecond;

        public static void Sleep(long ticks) => Thread.Sleep((int)(ticks / TimeSpan.TicksPerMillisecond));

        public static channel<Time> Tick(long ticks) => new ChannelTimer(ticks, true).Channel;

        public static channel<Time> After(long ticks) => new ChannelTimer(ticks, false).Channel;
    }
}