﻿﻿/*
 * Copyright (C) 2012-2013 Arctium Emulation <http://arctium.org>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

namespace Connection_Patcher.Patterns
{
    class Windows
    {
        public static class x86
        {
            public static byte[] Send  = { 0x8B, 0x00, 0x00, 0x8B, 0x00, 0x81, 0x00, 0x48, 0x01 };
            public static byte[] Email = { 0x00, 0x00, 0x74, 0x00, 0x33, 0x00, 0x00, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x75 };
            public static byte[] User  = { 0x40, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x85, 0xC0, 0x75 };
            public static byte[] RaF   = { 0xE8, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x74, 0x00, 0x8D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0xFF, 0xB5, 0x00, 0x00, 0x00, 0x00, 0x8D };
            public static byte[] Rcv   = { 0x01, 0x0F, 0x85, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x75, 0x14, 0x8B, 0x8B, 0x50, 0x45, 0x00, 0x00, 0xFF, 0x75, 0x10, 0x53, 0xFF, 0x75, 0x08, 0x6A, 0x17 };
        }

        public static class x64
        {
            public static byte[] Send  = { 0x8B, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x8B, 0x00, 0x00, 0x14, 0x08, 0x00, 0x00, 0x00, 0x00, 0x04, 0x75 };
            public static byte[] Email = { 0x74, 0x00, 0x00, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x74, 0x00, 0x00, 0x00, 0x00, 0xFF, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01 };
            public static byte[] User  = { 0x40, 0x00, 0x00, 0x00, 0x48, 0x8B, 0xCF, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x48, 0x85, 0xC0, 0x75, 0x00, 0x48, 0x8D };
            public static byte[] RaF   = { 0xE8, 0x00, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x74, 0x00, 0x48, 0x8D, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0xE8, 0x00, 0x00, 0x00, 0x00, 0x8B };
            public static byte[] Rcv   = { 0x01, 0x0F, 0x85, 0x4F, 0xFD, 0xFF, 0xFF, 0x49, 0x8B, 0x8D, 0x68, 0x85, 0x00, 0x00, 0x4D, 0x8B, 0xCD, 0x4C, 0x8B, 0xC6, 0xBA, 0x17, 0x00, 0x00, 0x00, 0x44, 0x89, 0x7C, 0x24, 0x28, 0x4C, 0x89, 0x74, 0x24, 0x20 };
        }
    }
}