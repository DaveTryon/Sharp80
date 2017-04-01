﻿/// Sharp 80 (c) Matthew Hamilton
/// Licensed Under GPL v3. See license.txt for details.

using System;

namespace Sharp80.TRS80
{
    public static partial class Resources
    {
        public static byte[] CharGenBase
        {
            get
            {
                return new byte[]
                    {0xED,0x5A,0x01,0x72,0xE3,0x30,0x08,0xB4,0xFE,0xFF,0xE9,0x9B,0xB6,0x56,0x0B,0x0B,0x11,0xC6,0x80,0x70,0xDA,0xDB,0xA9,0x6F,0x27,0xB6,0x1C,0x2D,0x08,0x01,0xCA,0xDC,0x71,0xBC,0x3F,0xC6,0x60,0x3C,0x3E,0xFF,0x18,0x1F,0x3F,0x3C,0x3E,0x40,0x18,0x9F,0xE3,0xFB,0x72,0x7C,0xBE,0xFE,0xCD,0x9C,0x0E,0x98,0x40,0x3A,0x9C,0x30,0x2E,0xCD,0x38,0x1D,0xFB,0xCD,0x28,0x16,0xDE,0xAF,0x10,0xCF,0x34,0xC9,0xC7,0x6A,0x48,0x5D,0xE5,0x72,0xFD,0x8A,0xFB,0x07,0x63,0xE3,0xF9,0xC0,0x0B,0x02,0x1E,0xAF,0x66,0x60,0xBC,0x7C,0xDD,0x34,0xB8,0x56,0x11,0xFA,0x1B,0x9F,0xCF,0x3C,0x33,0x74,0x7F,0x1B,0x17,0xBE,0x9F,0xAF,0x7F,0x8C,0xB9,0xF0,0x33,0x70,0xE1,0x1A,0x9C,0xCF,0xE1,0x93,0xE7,0x3B,0x2F,0xDE,0x3D,0x66,0x18,0x95,0xE9,0x07,0xE6,0x37,0xEE,0xEC,0x5B,0x6A,0x12,0xBA,0x27,0x5F,0x3E,0x9F,0x14,0xDD,0x2D,0xC7,0x1F,0x33,0x8E,0x66,0x5E,0x59,0xFA,0x7F,0xC3,0xFE,0x5D,0x2F,0x80,0x7A,0xE3,0x41,0xB0,0xB6,0x97,0xF2,0x9C,0x07,0x98,0xAC,0x6F,0x62,0xFB,0xD6,0xC6,0x0F,0xCB,0xD7,0x63,0x6E,0xE3,0xD7,0xDB,0x59,0xA4,0x7B,0x66,0x86,0xDC,0x12,0xE5,0xE1,0xB3,0xCE,0x9F,0x0F,0xAF,0x5F,0xF6,0xFE,0x7D,0x6F,0xFD,0x52,0x1F,0xE6,0x1B,0xA8,0x07,0xF0,0x05,0xF5,0x01,0x84,0x06,0x41,0x3C,0x3D,0xBD,0xFE,0xE2,0x96,0x83,0x04,0x2F,0xFD,0x69,0xD4,0xDF,0x19,0x57,0x3F,0xCB,0x41,0x27,0xC9,0x57,0x6F,0xC6,0x3F,0x8E,0x5F,0x9F,0x07,0x80,0xEB,0xFB,0x7F,0x99,0x00,0xBD,0x09,0x73,0x75,0x95,0x9F,0x1F,0x8D,0x05,0xB6,0xFC,0xAB,0xF1,0xA3,0xFB,0x9F,0x0B,0xC7,0x7D,0xEE,0x0F,0x18,0x5F,0x60,0x00,0xE4,0x17,0xBE,0x3F,0x45,0x42,0x52,0xC6,0x23,0xB3,0xF7,0x8B,0xF3,0x8F,0xF3,0xF8,0xF2,0x35,0x94,0x70,0x7B,0xFF,0x03,0x8C,0x37,0x9E,0xAE,0x5F,0x1A,0x00,0x8F,0x1F,0xAE,0x5F,0xCB,0xE7,0x94,0x95,0x76,0x46,0xE4,0x77,0x4C,0x90,0x94,0xAB,0xF3,0xBF,0xD4,0xCC,0x3F,0xAA,0x06,0x1C,0x86,0x81,0x8B,0xE7,0xF5,0xF2,0xC5,0x82,0x88,0xBC,0x48,0x13,0xEC,0x85,0x03,0x80,0x91,0x90,0xA3,0xF2,0xED,0xFE,0x4C,0xB1,0x92,0xC7,0x08,0x1D,0x2B,0x36,0xCC,0x72,0x79,0xCB,0xE1,0xAE,0x6F,0xFF,0xE1,0xC4,0x95,0x08,0xF1,0xB0,0xF5,0xFD,0xB9,0xD0,0xF6,0xDB,0x8A,0x9F,0x06,0x43,0xEF,0x38,0xF3,0xDE,0x18,0x7A,0x3E,0xB2,0x9E,0x6F,0xB0,0xDF,0xCA,0x9F,0x67,0x3A,0x79,0xD9,0x50,0xF0,0x11,0xB2,0x5E,0x6D,0x4D,0x38,0xDA,0x99,0x91,0xA4,0x1F,0x45,0x8F,0xFC,0xF8,0xEA,0xDD,0x92,0x84,0x15,0x6C,0xE7,0xC7,0xE9,0x77,0xC2,0xB2,0x1C,0x0C,0xC2,0x15,0x26,0x70,0xEE,0xAD,0x37,0x37,0xE0,0xD3,0x6F,0xA6,0x4F,0xFB,0x46,0x26,0xFC,0xD3,0x1B,0xBC,0x7D,0xF9,0xF8,0x0C,0xD6,0xF9,0x4F,0xF4,0x93,0x17,0xCE,0x9F,0xD5,0x16,0x70,0xAC,0xFD,0x2B,0xFB,0x61,0x33,0xA0,0xDE,0x0C,0xBE,0xF8,0xDA,0x0C,0x51,0x6F,0x7F,0x3F,0xF6,0x3B,0xDC,0x95,0x51,0x9A,0xD3,0x8F,0x76,0x7E,0x87,0xA2,0xCB,0xFB,0x80,0x71,0xD6,0xD9,0x93,0x49,0xAF,0xA0,0x15,0xED,0x0D,0xE7,0x77,0xF4,0x18,0x36,0x08,0x9C,0xBD,0xF5,0xA0,0xFA,0xFC,0x6E,0xF8,0x5F,0x55,0x74,0x10,0x96,0xFD,0x10,0xE7,0xEA,0xFD,0xEE,0xD6,0x2F,0xFA,0x67,0xF6,0xBC,0x21,0x7E,0x7C,0x01,0x24,0xF6,0x86,0xF4,0xEF,0xCE,0x82,0x86,0xF3,0x6B,0xEB,0x4F,0x59,0xD5,0x03,0xFE,0xA7,0x57,0xF5,0xCF,0xCF,0x62,0x02,0x23,0xFF,0xE1,0x76,0xD4,0xD6,0x64,0x67,0xFC,0xA8,0xFE,0x87,0xF8,0x5F,0x9B,0xE4,0x4D,0x4B,0xC9,0xB8,0x90,0xFF,0x57,0xFE,0xEC,0xF6,0xFF,0x2D,0x3D,0x94,0xE7,0x7D,0xC2,0x56,0xBA,0xDA,0x0C,0x6F,0x00,0x14,0x07,0x8C,0x1B,0x51,0xFD,0xC6,0x7E,0x89,0x03,0x13,0xBE,0xE7,0xE3,0xAD,0x1B,0x1B,0x61,0xD5,0xFF,0xEE,0xF3,0x40,0xDC,0x9D,0xCE,0xE5,0xCA,0x46,0xB4,0x7F,0x33,0xE3,0xB9,0x7A,0x3B,0x2B,0xF5,0x97,0x5C,0x9F,0x7F,0x8C,0xC7,0x3C,0x07,0xCC,0x73,0x01,0x3B,0x02,0x28,0xCD,0x45,0x79,0x01,0x60,0x0C,0x39,0x5F,0xD4,0x01,0xA3,0x5E,0x9B,0xF5,0x23,0x5D,0x3D,0x94,0xA3,0x61,0x5D,0xE0,0x4E,0x63,0xBC,0x56,0xEE,0xD2,0x2D,0xA0,0x2C,0xE3,0xE7,0x98,0xB7,0xAF,0xB0,0xB0,0xA1,0xB8,0x00,0x8B,0xE8,0xD4,0xD6,0xDC,0x79,0xB1,0xF8,0xDB,0xD0,0xFE,0x2C,0xFB,0x7F,0x64,0x25,0x7C,0xAC,0xF1,0x95,0xF5,0xA1,0x5C,0x3F,0x70,0x3E,0xDC,0xF1,0x3F,0xED,0xD4,0xCF,0x0B,0xBB,0xE3,0x1F,0xE6,0x37,0xF9,0x61,0xF9,0x53,0xF1,0x8F,0x37,0x24,0x0C,0x2E,0x3F,0x00,0xA4,0x1A,0xB0,0x39,0x7C,0xD4,0x75,0x5E,0xA4,0x43,0x21,0xE7,0xDA,0x16,0xA8,0x8B,0x9F,0xE4,0x60,0xD9,0x9F,0x3F,0xCF,0x7F,0x7E,0xF6,0x27,0x5C,0x1F,0xFF,0x2E,0x19,0xDE,0x37,0x78,0x87,0x7E,0xC6,0xE7,0xC3,0x1F,0x16,0xB7,0x66,0x1F,0x7A,0x5C,0xC9,0x47,0xF9,0x06,0xAC,0xFB,0xFF,0x28,0x6F,0xF9,0xFD,0x8A,0xB2,0xA5,0x4B,0x1B,0xEF,0xE0,0x12,0x03,0x08,0xDF,0xF0,0x73,0xEB,0xFF,0x1F,0x48,0xF0,0xBF,0x0C,0x19,0x61,0x43,0x73,0xFC,0xD3,0xA9,0xB5,0x78,0x26,0x83,0x76,0xC7,0xBF,0x72,0x40,0xF2,0x86,0x74,0xEB,0x16,0xC8,0xCE,0x37,0xDB,0xF3,0x8F,0x5B,0x8F,0x31,0x46,0xFC,0xE2,0x53,0xFB,0x0B,0x90,0xDF,0xAF,0x46,0x3D,0xC6,0x0B,0xED,0xDF,0xAC,0xDF,0xF4,0x2F,0x3C,0x37,0xBF,0xAF,0xC2,0x00,0xCF,0x15,0x6F,0xB7,0x73,0xE5,0x6B,0xFD,0x21,0x30,0xFF,0xB8,0xFE,0xF9,0x50,0x7C,0x45,0x71,0xFF,0x19,0x3E,0x90,0x9B,0x5C,0x9C,0xFF,0x01,0x62,0xB1,0x4B,0x6E,0x24,0x42,0xF1,0x4F,0x2A,0xD7,0xFB,0x5F,0x44,0xF0,0xA0,0x2C,0xF6,0xEF,0x9F,0xC6,0x00,0x64,0x7C,0x25,0xF0,0xDE,0xF0,0x2D,0x87,0xF2,0xFB,0xC7,0x2A,0xBE,0xD5,0x72,0x31,0x08,0x67,0xCB,0x33,0x79,0xEA,0x9A,0x6D,0xEA,0xD7,0xC3,0x57,0xCD,0xBF,0x72,0x7E,0x66,0xEF,0x6F,0x87,0xF3,0x7C,0x80,0xCF,0xB7,0xE4,0xFF,0xD5,0x22,0xC0,0xFA,0xCF,0x35,0xA0,0x8C,0xF6,0xD0,0xE7,0xD5,0xF1,0x63,0xC2,0xF2,0x3F,0xF4,0x07,0x72,0xF3,0xD7,0xE7,0xFF,0xC1,0x58,0x71,0x2A,0x51,0x14,0x3F,0xAE,0x6D,0xC6,0x85,0xF8,0x31,0xE3,0x05,0xE2,0x31,0x73,0x3D,0xD2,0xF3,0x8F,0xC1,0x05,0x30,0x16,0x58,0x9C,0xFF,0x9C,0xAC,0x14,0x90,0x64,0x54,0x1A,0x80,0x57,0xB6,0x39,0x37,0x34,0x40,0x48,0xCC,0x5D,0x3C,0x65,0x4D,0x99,0xA4,0x04,0x50,0xFD,0xE9,0x88,0xC6,0x47,0x7F,0xFC,0xAC,0xF0,0x99,0x46,0x06,0xE1,0xF3,0xEF,0x2E,0x6F,0xD7,0xFF,0xFC,0xFC,0xB3,0xC6,0x95,0xFE,0x67,0xA5,0x77,0xF3,0xF9,0x17,0x61,0xFA,0x5F,0xAC,0x07,0x8C,0xFF,0xFE,0x1E,0x9D,0xEB,0x0D,0x48,0xAE,0xBF,0x1A,0x57,0xCA,0xBF,0x12,0xFF,0x17,0x24,0x76,0xC4,0xCE,0xD7,0xC4,0xBC,0x61,0x13,0x7A,0xB4,0xF8,0x26,0x83,0x64,0xBF,0x97,0x2E,0x70,0xC9,0xB7,0xFA,0x4D,0xB6,0x89,0x65,0x81,0xD9,0x09,0x6F,0xBE,0xB9,0xB4,0x1F,0x1E,0xAC,0xFF,0x61,0xEE,0x9F,0x1A,0x28,0x0F,0x0F,0x1F,0x67,0xDD,0xFE,0xE6,0x0E,0xFD,0x1E,0xFF,0x62,0x2C,0xE1,0xFB,0x9B,0x91,0x12,0xEF,0x94,0x37,0xD7,0x63,0x3C,0x9F,0xA3,0x1C,0xCD,0xFF,0x94,0xB5,0xF7,0xD3,0x25,0xAE,0x04,0x08,0x41,0x70,0xDB,0xAE,0x58,0xD5,0x1B,0xF8,0x42,0x42,0xE7,0x82,0x92,0xDF,0x8F,0x41,0x7A,0xC7,0x76,0x28,0xE7,0xF5,0xF8,0x72,0xEF,0x6B,0xE9,0x83,0x9F,0x37,0x7A,0x33,0xB8,0x09,0xCB,0x7F,0xDE,0x06,0x02,0xBE,0xBD,0xBC,0x01,0x7A,0x67,0x60,0x36,0xF6,0xF2,0x13,0xF0,0xCE,0x36,0x8C,0x20,0xBA,0xF5,0x47,0xD1,0xBD,0x76,0xD1,0xF9,0xBB,0xF5,0x47,0x35,0x74,0xEB,0xF7,0xC6,0xBB,0x86,0x4E,0xFD,0x19,0xE8,0xB4,0x21,0x63,0xEE,0xEE,0x35,0x88,0xCE,0xDF,0xED,0xFF,0x08,0xBA,0xF5,0x47,0x91,0x61,0x7F,0x74,0xFE,0x28,0x77,0xEA,0xEF,0xD4,0x9E,0xA1,0x3F,0x43,0x43,0xA7,0xFE,0x6E,0x4C,0x1B,0xBA,0xB8,0x5B,0x7F,0xB7,0x0D,0x19,0x7E,0x8C,0xA0,0x5B,0x7F,0xF7,0xFC,0x7F,0x9D,0xA3,0xDF,0xD1,0xAD,0x7F,0x24,0xA0,0xDB,0xFF,0x51,0x44,0x7D,0xD7,0x6D,0x7F,0xA7,0xFE,0x4E,0xDB,0xB3,0xFC,0x1F,0x41,0xB7,0xFE,0x28,0xA2,0xF6,0x67,0xF8,0xA0,0x73,0xFD,0xA2,0xF3,0x77,0x6B,0x8F,0xEA,0xCF,0xD2,0x10,0x41,0xD4,0xFF,0xDD,0x88,0xD8,0xF0,0x04,0xFB,0xA3,0x1A,0xBA,0x6D,0x88,0xFA,0x3F,0x82,0x6E,0xFD,0x4F,0x98,0x3B,0xEA,0xFF,0x0C,0x1D,0x5D,0xFA,0xBB,0xED,0xCF,0x98,0x3F,0x8A,0x6E,0xFF,0x47,0x11,0x9D,0x3F,0xC2,0x4F,0xF0,0xDF,0x5F,0xE6,0x28,0xBA,0xF5,0x1F,0x41,0x74,0xDB,0x9F,0xF5,0x1D,0x5D,0xFA,0x3B,0xB5,0x3F,0x61,0xFE,0x28,0x32,0xFC,0xD8,0x89,0x6E,0x1F,0x74,0xEB,0x8F,0x68,0xCF,0xB0,0x21,0xAA,0x3F,0x8A,0x6E,0xFD,0x19,0xF3,0x47,0x39,0xC3,0x86,0x4E,0xEE,0xD4,0xDE,0xAD,0x3F,0x03,0xDD,0xFE,0x8F,0xA2,0x4B,0x3B,0xB5,0xE1,0x2E,0x77,0xEB,0x8F,0xCE,0xDF,0xAD,0x3F,0x8A,0x6E,0xFD,0x76,0x74,0xAF,0x91,0xA1,0x21,0x8A,0x6E,0x1F,0x46,0xF0,0xCE,0xDA,0x7F,0x03,0xFE,0x01}
                        .Decompress();
            }
        }
        public static byte[] CharGenHigh
        {
            get
            {
                return new byte[]
                    {0xCD,0x59,0x0B,0xB2,0x83,0x20,0x0C,0x24,0xF7,0xBF,0xF4,0x9B,0x57,0x40,0xB3,0xBB,0xC8,0xA7,0x06,0x6D,0x3A,0xCC,0x56,0x41,0xD8,0xC4,0x24,0xA4,0x34,0xA5,0x94,0x2C,0x65,0x29,0x68,0x66,0x1E,0xCD,0xF2,0x97,0x82,0x96,0xE5,0x12,0x79,0xBC,0xCE,0x2F,0x18,0x2B,0x1F,0x2E,0x27,0xAE,0xF3,0x25,0xFD,0x77,0xF3,0xBD,0x69,0xFF,0xF7,0xF9,0xF3,0x7A,0xFD,0xF5,0xFF,0xA9,0x97,0x77,0x53,0x90,0xDF,0x0B,0xF6,0x2B,0x7F,0x99,0xFF,0x36,0x7D,0x73,0x58,0x57,0x2C,0x68,0xF9,0xBB,0x9D,0x58,0x1E,0x3A,0x50,0xFA,0xA1,0xF1,0x7C,0xB2,0xDE,0xEB,0xFC,0xB9,0xE1,0xF8,0xFD,0xFC,0x2B,0xE7,0x13,0x97,0x2E,0x97,0x6F,0x84,0xDB,0xFF,0x26,0x9F,0x55,0x7D,0x37,0xD8,0xBF,0x2B,0x39,0xC9,0x1C,0x58,0x52,0xEB,0x25,0xF2,0xF8,0x27,0xF8,0xE1,0x7B,0xE5,0x36,0xEA,0x9F,0x18,0xEF,0x30,0x3A,0x99,0xD6,0x45,0x80,0x9C,0x04,0x31,0x20,0xC7,0x30,0x11,0x1C,0x60,0xBC,0xD0,0x0A,0xCA,0x1F,0x79,0x36,0x14,0x00,0x05,0xF9,0xF9,0xFD,0x1A,0xA8,0x02,0x1E,0xC5,0xBE,0xBC,0xDF,0x62,0xFF,0x84,0xC2,0xB1,0x62,0xE4,0x43,0x8B,0xFA,0xB4,0xF6,0x53,0x1C,0xF2,0x28,0xFD,0xB2,0xF1,0x1C,0xD8,0xF4,0x27,0xF4,0x8F,0x75,0x8C,0xD6,0x00,0x50,0xDD,0x59,0xF2,0x0B,0x20,0x35,0x89,0xF7,0xCD,0xEC,0x59,0xBE,0xB1,0x69,0xAF,0x45,0xD7,0x6B,0x63,0xBA,0x8B,0xD9,0x93,0xFA,0x1B,0x2E,0x08,0xEA,0xEC,0x56,0x60,0xFD,0x05,0x74,0xD3,0x2F,0x87,0x4C,0xB8,0xCC,0x86,0xE9,0x25,0x5A,0x2D,0x2A,0x0C,0x8C,0xFC,0x4C,0xEC,0x8E,0x85,0x8B,0x9C,0x2F,0x3C,0x0C,0x31,0x9E,0x21,0x22,0xFF,0x7E,0xE4,0xE5,0xFB,0xBB,0x43,0x33,0x5E,0x71,0xCC,0xE6,0xFD,0x78,0xCD,0x9F,0xC5,0xBF,0xF9,0xDE,0x03,0x05,0x50,0x57,0xF8,0xF7,0x7B,0xAA,0x6E,0xAE,0x99,0x67,0x0E,0xF7,0x13,0x06,0x9C,0x89,0x5F,0xC0,0x3A,0xCD,0x05,0x3E,0x2D,0x62,0xFF,0xBE,0x3A,0x6F,0xBB,0x8B,0xC8,0x80,0x7F,0xBA,0x8F,0xF1,0xE2,0x56,0x98,0x48,0x9F,0x6F,0xBF,0x90,0x51,0xFE,0xC4,0x80,0x1D,0xA1,0xE6,0xCF,0x57,0x23,0xA0,0xD6,0x98,0xFE,0x70,0x88,0xF2,0x09,0xEB,0x8F,0xFD,0xFE,0xE5,0x6D,0x78,0x05,0xD5,0xA5,0xCD,0x7F,0xBD,0x67,0xDF,0xDF,0xCA,0x40,0x86,0xAD,0x91,0xD3,0xAD,0x87,0x9F,0xA3,0xB8,0x62,0xFB,0x4D,0x3F,0xC0,0xB4,0x5E,0xE8,0xF3,0x45,0xF4,0xDC,0x0E,0x3F,0x71,0xCF,0x73,0xFF,0x0E,0xFE,0x06,0x58,0xEF,0x4F,0xA1,0x46,0x03,0xA7,0x9B,0xC7,0xDD,0xA7,0xBF,0xA0,0x9C,0x3F,0x2C,0x3E,0x1F,0x2C,0xF0,0x37,0xC4,0x91,0x63,0xFC,0xEA,0x7A,0x03,0x2D,0x2C,0xE9,0x07,0x2F,0x79,0xFE,0xDD,0x42,0x1B,0x96,0x4B,0x9D,0xED,0xE5,0x57,0xC7,0x3F,0x2F,0x13,0xF9,0xFD,0x6C,0xFC,0x7F,0xCC,0x2B,0x04,0x7B,0x97,0x63,0x07,0x5B,0x9B,0x2E,0x44,0xAE,0xD7,0x68,0xD8,0x13,0x06,0x4B,0xFF,0x13,0x74,0x7B,0xDC,0x47,0x37,0xBE,0x39,0xFF,0xE4,0x1B,0x91,0x42,0x09,0xA2,0x75,0x78,0x53,0x69,0x5E,0x3A,0x84,0x1F,0xE0,0x9E,0x6D,0xFE,0xFF,0xB5,0x43,0x01,0x8F,0x1C,0x8F,0x85,0xE3,0x25,0xB6,0xFC,0xA7,0xD3,0xF6,0xEF,0xC7,0xA2,0x1E,0xAC,0x69,0x62,0x61,0xC4,0xFD,0xF5,0xCE,0x0C,0x67,0x44,0x7F,0xC9,0xEE,0xF4,0xFA,0xE9,0x0F,0xD7,0x3F,0x1A,0x7D,0x5D,0xFF,0x92,0x7E,0x26,0xCD,0xE5,0x55,0x38,0x7D,0x6C,0x46,0x9F,0x23,0x08,0x5D,0x30,0x82,0xC5,0xA9,0xBF,0xF1,0x3C,0xE9,0x1B,0xCD,0xBF,0x61,0x7E,0x70,0x0E,0xAB,0x9E,0x9F,0xB1,0x0C,0xBE,0x44,0x1C,0xAF,0xF9,0x27,0xF8,0x7D,0xE8,0xFC,0x9C,0x2F,0x07,0xE7,0x41,0x8B,0xE7,0x75,0xE1,0xD2,0x3A,0x1F,0xE9,0x60,0x31,0xEB,0x89,0xCD,0xA4,0xBA,0x84,0xB7,0x35,0x40,0x9C,0x38,0x7F,0x60,0x16,0x18,0x1F,0xCF,0x9E,0x3F,0xB0,0xFF,0x17,0xBB,0x1E,0x9B,0x71,0x36,0x7C,0x07,0xB3,0xAF,0x9F,0x98,0x3C,0x96,0x48,0x38,0x5B,0xBC,0xFF,0x1F,0x75,0x83,0xD5,0xC8,0xCB,0xD3,0x3B,0xE4,0x3D,0xE9,0xE0,0x92,0xB8,0xFC,0x4F,0x75,0x92,0x13,0x69,0x3E,0x5A,0xEF,0x2E,0x7D,0x92,0xB2,0x46,0x02,0x74,0x24,0xA8,0x5A,0xA2,0x81,0x96,0x9A,0xFD,0x0E,0xA5,0xFA,0x0B,0xE1,0xBF,0xC8,0xE7,0x97,0x84,0xDD,0xD1,0x46,0x4D,0xC7,0xB7,0x4A,0x56,0xDF,0x20,0x5C,0xE2,0xF9,0x67,0x16,0x95,0x55,0x2A,0x97,0x1E,0x7D,0xFA,0xE6,0x1D,0xCB,0x3D,0x5B,0x63,0x02,0xB4,0xA1,0x14,0x0C,0xCF,0x06,0xA9,0xA3,0x09,0x0F,0x11,0xB4,0xD1,0x6A,0xA8,0x8B,0x12,0xBF,0xF1,0x32,0xA8,0xCF,0x46,0x6D,0x98,0xEF,0xB7,0xEF,0x07,0xBC,0x40,0x23,0x6D,0x20,0x6A,0xC1,0xF9,0x9A,0x70,0xFE,0xC4,0xEC,0x56,0x92,0x38,0x34,0x9F,0x8D,0xAC,0xEE,0x19,0x80,0x32,0x61,0xA7,0x3F,0x44,0x07,0x44,0x29,0x4F,0xFA,0xFE,0x20,0xF5,0xC3,0x60,0x3E,0xF1,0xBF,0x5F,0xE3,0xCF,0x7C,0xE9,0x9D,0xEA,0xFC,0x7B,0xF9,0xAF,0xC6,0xB3,0xD4,0x7B,0x5A,0x7B,0x04,0xDA,0xFF,0x0F}
                        .Decompress();
            }
        }
        public static byte[] CharGenKanji
        {
            get
            {
                return new byte[]
                    {0xCD,0x59,0x8B,0x6E,0xC4,0x20,0x0C,0x83,0xFF,0xFF,0xE9,0x3D,0x74,0x74,0xD8,0xC9,0x08,0x29,0x09,0x10,0xA9,0xB3,0xDA,0xDE,0xA9,0x0E,0xD8,0x86,0xDE,0x4A,0xA9,0xA5,0xC0,0xF1,0xFD,0xE7,0x17,0x1E,0x6C,0xD0,0x2E,0xFF,0x54,0x87,0xDE,0xFB,0xB7,0x15,0xB1,0x33,0xBA,0x4F,0x78,0x3E,0x8D,0x17,0x3F,0xCF,0x8B,0x17,0xD6,0x4A,0x4B,0x52,0x4E,0x67,0x4B,0x0C,0xF7,0x8B,0x0B,0x47,0xEB,0x2E,0x36,0x76,0xB5,0x79,0xEF,0xE6,0x1F,0x50,0xDE,0x17,0x8E,0x46,0xDC,0x5C,0x9A,0x80,0x39,0x31,0x0B,0x22,0x7E,0xEA,0xFC,0x84,0x8D,0x09,0x11,0x7D,0x11,0xA0,0xC7,0x1B,0x18,0xAF,0x4F,0x62,0xFD,0x93,0x78,0xBA,0x01,0xAC,0x67,0x59,0xFD,0x47,0x2F,0xE6,0x7A,0xBC,0xBB,0x24,0x9F,0x1E,0xAF,0xD7,0x8F,0x90,0x3B,0x8D,0x67,0x7D,0xF6,0x4D,0x0F,0x6A,0xDF,0xBB,0x44,0x3D,0x8A,0x7E,0xC6,0x8C,0x4F,0xEB,0xC7,0xCC,0x4F,0x63,0x81,0x38,0xCE,0xFF,0xA3,0xE4,0xFF,0x51,0xE4,0xCF,0xCD,0xF1,0x53,0x3F,0xE3,0x58,0x4F,0x8D,0xE7,0x0C,0x1F,0xD4,0x07,0x05,0x8A,0xB1,0xDC,0x9E,0x18,0x7D,0x63,0x81,0xA5,0x53,0x6F,0x5E,0x66,0x77,0xE0,0x5B,0x5F,0xDD,0x7A,0x4F,0xA6,0x6F,0xBF,0xAF,0xAE,0x61,0x7E,0xFE,0xC8,0xB8,0x46,0x3F,0xB8,0xF4,0xC3,0xAB,0x99,0xFC,0x7E,0x2A,0x7D,0x85,0xBF,0xB2,0xBE,0x8E,0x90,0x8E,0xFA,0x59,0xE8,0x1A,0xA6,0x37,0x60,0xED,0xCF,0xD6,0xF5,0x16,0x5B,0x4E,0xBF,0xF2,0x90,0x2B,0x04,0x37,0xFB,0xD7,0x42,0xD1,0x9F,0x53,0xEF,0x1B,0x86,0x1F,0xFD,0x1A,0x9A,0x40,0xE9,0xEB,0x35,0xDB,0x8F,0x9F,0x67,0xD9,0x56,0xD2,0xDE,0xAC,0x1F,0xB1,0x1D,0xE6,0xF1,0x03,0x54,0x29,0xF5,0x28,0xFA,0xE3,0xFD,0x46,0x38,0x7D,0x53,0x3F,0xC6,0x29,0xA2,0x12,0xA7,0xEC,0xF7,0xE0,0x0E,0x00,0x67,0xF2,0x1F,0x0C,0xAC,0x8A,0x1E,0x50,0x99,0xE0,0x60,0xF6,0xFD,0xF8,0xF0,0xA1,0x08,0xDE,0x37,0x3D,0x78,0x1A,0x5D,0x3C,0xDE,0x43,0xAF,0xF2,0xC0,0xDF,0xD0,0x00,0xF1,0x51,0xB6,0x5B,0x8A,0xC0,0xE0,0x03,0x86,0xAB,0x73,0xF9,0x5B,0xF9,0xBC,0xEC,0xEF,0xDC,0xF8,0x29,0xA6,0xBF,0x56,0xC7,0x3B,0x5B,0x3E,0x66,0xA6,0x53,0x7B,0x9A,0x27,0x84,0xE7,0x07,0x18,0x5F,0x8B,0xFA,0x3E,0x6E,0xDF,0xD4,0x7C,0xCE,0x7E,0xFF,0xF2,0xEF,0xDF,0xEC,0xF8,0x84,0xFB,0x9A,0xB6,0x62,0x0B,0xD9,0xBD,0xC8,0x1B,0xC4,0xDA,0x88,0xFF,0xFD,0xCE,0x55,0x3A,0x4C,0x28,0x11,0x71,0x2E,0x45,0x1F,0x96,0xBF,0xF2,0x88,0xB1,0x20,0x2C,0xA4,0x80,0x4A,0xD6,0xCF,0x44,0x7C,0xCA,0xFD,0x85,0xF5,0x3D,0xC8,0xD6,0xB6,0x0D,0x4C,0xDA,0xBF,0xB9,0xFD,0x7B,0x9F,0x80,0xC6,0xF5,0x22,0x5E,0xF6,0x72,0xF6,0xAD,0x5F,0xF6,0xEF,0xE9,0x88,0xC9,0xDD,0xC4,0xE7,0xFF,0xCC,0x85,0xB8,0x92,0xCF,0x42,0xBF,0x59,0x7E,0x9C,0xF2,0x6B,0xB2,0x9E,0x16,0xED,0x29,0x5B,0xE8,0x8F,0x5A,0x9F,0xF7,0x8A,0x34,0x3F,0xF4,0x9C,0x84,0x21,0x5F,0xEC,0x17,0xE0,0x2E,0x62,0x74,0x49,0xFD,0x33,0x01,0xD6,0xC3,0x84,0x49,0x60,0x46,0xB2,0xDF,0x60,0x94,0xF8,0xE1,0x7E,0x08,0x71,0x3E,0xA6,0x4C,0x5F,0xD2,0x66,0x40,0xF1,0x9B,0x13,0x87,0xA7,0x6A,0xBE,0x05,0x96,0x3B,0x3F,0xB5,0xFD,0xFC,0x48,0x4A,0xC9,0xFC,0x27,0xD6,0x21,0xF2,0xB3,0x44,0xD7,0x69,0x38,0xFD,0xA2,0x86,0xA0,0x07,0xA9,0xBD,0xCD,0xFC,0xD9,0x8D,0x13,0x58,0xC7,0x48,0xD3,0xD8,0x5C,0xBF,0x23,0x7E,0xE6,0xD0,0x38,0x70,0x8E,0x36,0xBC,0x5E,0xF7,0x3E,0x83,0x67,0x07,0xE0,0xE6,0xFC,0xB1,0xF8,0x14,0x05,0x8F,0xFA,0xD7,0xFB,0xFF,0x09,0x83,0xE1,0x66,0xF9,0x08,0x32,0xFC,0x7C,0xF5,0x02,0xE0,0xE1,0x12,0x63,0x89,0x79,0x73,0x1B,0x5D,0xAA,0x2F}
                        .Decompress();
            }
        }
    }
}